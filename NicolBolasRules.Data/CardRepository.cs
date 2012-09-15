using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NicolBolasRules.Model;
using HtmlAgilityPack;

namespace NicolBolasRules.Data
{
    public class CardRepository : ICardRepository
    {
        public IQueryable<IList<Card>> GetCards()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Card> GetRandomCard()
        {
            throw new NotImplementedException();
        }

        public Card GetCard(string cardName)
        {
            
       
        }


    }
}
