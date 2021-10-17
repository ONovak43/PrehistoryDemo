using Blazored.Modal;
using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using PrehistoryMethodApp.Data;
using PrehistoryMethodApp.Pages;
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
        [CascadingParameter] public IModalService Modal { get; set; }
        public State State;

        private List<Card> CardsTwo = new List<Card>();
        private Card activeItem;
        private Card lastActiveItem;
        private List<Card> hiddenItems = new List<Card>();
        private Dictionary<Card, string> cardColors = new Dictionary<Card, string>();
        private List<Card> RightAnswers = new List<Card>();
        private bool mistake = false;
        private bool instructionHidden = false;

        protected override void OnInitialized()
        {
            CardsTwo = Cards.ToList().OrderBy(x => Guid.NewGuid()).ToList();
            DragDrop.Items = Cards;
            DragDrop.SuccessfulEnd = false;
            State = DefaultState;
        }

        public void OnDragStart(Card card, DragEventArgs dragEventArgs)
        {
            DragDrop.LastActiveItem = DragDrop.ActiveItem = lastActiveItem = activeItem = card;
            dragEventArgs.DataTransfer.EffectAllowed = "move";
        }

        public void OnDragEnd(Card card)
        {
            lastActiveItem = activeItem;
            DragDrop.LastActiveItem = activeItem;
            DragDrop.ActiveItem = activeItem = default(Card);
        }

        public void OnDrop(Card card)
        {
            if (card.Equals(lastActiveItem))
            {
                ChangeColor(card);
                RightAnswers.Add(card);
                if (RightAnswers.Count == Cards.Count)
                {
                    HideAll();
                    DragDrop.SuccessfulEnd = true;
                    State = SuccessfulState;
                }
            }
            else if (mistake)
            {
                HideAll();
                instructionHidden = true;
                var parameteres = new ModalParameters();
                parameteres.Add(nameof(card.Advices), lastActiveItem.WrongAnswer);

                Modal.Show<Advice>("Konec!", parameteres);
                DragDrop.ForcedEnd = true;
                State = FailState;
            }
            else
            {
                mistake = true;
                var parameteres = new ModalParameters();
                parameteres.Add(nameof(card.Advices), lastActiveItem.Advices);

                Modal.Show<Advice>("Chyba!", parameteres);
            }
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

        private string GetInstructionClass() => instructionHidden ? "card-hidden" : "";

        private string GetWrongAnswerClass() => instructionHidden ? "" : "card-hidden";

        private string GetBgColor(Card card, bool isRight = true) => CheckIfItemHasColor(card) ? cardColors[card] : isRight ? RightColor : LeftColor;
        public string GetHeight(Card card) => card.IsImage ? "15rem" : "auto";
        private string GetWidth(Card card) => card.IsImage ? "25rem" : "auto";
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
            hiddenItems = Cards;
        }

        public void Dispose()
        {

        }
    }
}