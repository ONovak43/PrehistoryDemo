using Blazored.Modal;
using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using PrehistoryMethodApp.Data;
using PrehistoryMethodApp.Pages;
using PrehistoryMethodApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrehistoryMethodApp.Components
{
    public partial class Dropzone
    {
        [Parameter]
        public List<Card> Cards { get; set; }
        [Parameter]
        public State DefaultState { get; set; }
        [Parameter]
        public State SuccessfulState { get; set; }
        [Parameter]
        public State FailState { get; set; }
        [Parameter]
        public string RightColor { get; set; }
        [Parameter]
        public string LeftColor { get; set; }
        [Parameter]
        public int? Max_Mistakes { get; set; }
        [CascadingParameter] public IModalService Modal { get; set; }
        public State State;

        private CardDeck TwoCardDecks;
        private Card activeItem;
        private Card lastActiveItem;
        private List<Card> hiddenItems = new();
        private readonly Dictionary<Card, string> cardColors = new();
        private readonly List<Card> RightAnswers = new();
        private int currentMistakes = 0;

        protected override void OnInitialized()
        {
            TwoCardDecks = new CardDeck
            {
                FirstCardDeck = Cards,
                SecondCardDeck = Cards.ToList().OrderBy(x => Guid.NewGuid()).ToList()
            };
            DragDrop.Items = TwoCardDecks.FirstCardDeck;
            DragDrop.SuccessfulEnd = false;
            State = DefaultState;
            if (Max_Mistakes == null) Max_Mistakes = 0;
        }

        public void OnDragStart(Card card, DragEventArgs dragEventArgs)
        {
            DragDrop.LastActiveItem = DragDrop.ActiveItem = lastActiveItem = activeItem = card;
            dragEventArgs.DataTransfer.EffectAllowed = "move";
        }

        public void OnDragEnd(Card card)
        {
            if (card is null)
            {
                throw new ArgumentNullException(nameof(card));
            }

            lastActiveItem = activeItem;
            DragDrop.LastActiveItem = activeItem;
            DragDrop.ActiveItem = activeItem = default(Card);
        }

        public void OnDrop(Card card)
        {
            var param = new ModalParameters();
            if (card.Equals(lastActiveItem))
            {
                ChangeColor(card);
                RightAnswers.Add(card);
                if (RightAnswers.Count == TwoCardDecks.FirstCardDeck.Count)
                {
                    HideAll();
                    DragDrop.SuccessfulEnd = true;
                    State = SuccessfulState;
                }
                return;
            }
            else if (Max_Mistakes <= currentMistakes)
            {
                HideAll();
                param.Add(nameof(card.Advices), lastActiveItem.WrongAnswer);

                Modal.Show<Advice>("Konec!", param);
                DragDrop.ForcedEnd = true;
                State = FailState;
                return;
            }
            currentMistakes++;
            param.Add(nameof(card.Advices), lastActiveItem.Advices);

            Modal.Show<Advice>("Chyba!", param);
        }

        private string GetItemClasses(Card card)
        {
            var output = "";
            output += CheckIfItemIsActive(card) ? "card-dragging " : "";
            output += CheckIfItemIsHidden(card) ? "card-hidden " : "";
            return output;
        }

        private string GetDropItemClasses(Card card)
        {
            var output = "";
            output += CheckIfItemIsHidden(card) ? "card-hidden " : "";
            return output;
        }

        private string GetBgColor(Card card, bool isRight = true) => CheckIfItemHasColor(card) ? cardColors[card] : isRight ? RightColor : LeftColor;
        private string GetWidth(Card card) => card.IsImage ? "45%" : "auto";
        private bool CheckIfItemIsActive(Card card) => card.Equals(activeItem);

        private bool CheckIfItemIsHidden(Card card) => hiddenItems.Contains(card);
        private bool CheckIfItemHasColor(Card card) => cardColors.ContainsKey(card);

        private void ChangeColor(Card card)
        {
            var random = new Random();
            var color = String.Format("#{0:X6}", random.Next(0x1000000));
            cardColors.Add(card, color);
            HideItem(card);
        }

        private void HideItem(Card card)
        {
            hiddenItems.Add(card);
        }

        private void HideAll()
        {
            hiddenItems = TwoCardDecks.FirstCardDeck;
        }

        public void Dispose()
        {

        }
    }
}