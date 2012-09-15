using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicolBolasRules.Model
{
    public class Card
    {
        public string cardId { get; set; }
        public string cardName { get; set; }
        public string cardImageUrl { get; set; }
        public string manaCost { get; set; }
        public int convertedManaCost { get; set; }
        public string types { get; set; }
        public string cardText { get; set; }
        public string flavorText { get; set; }
        public int power { get; set; }
        public int toughness { get; set; }
        public string expansion { get; set; }
        public string rarity { get; set; }
        public int cardNo { get; set; }
        public string artist { get; set; }
        public IList<CardRuling> cardRulings { get; set; }

    }
}
