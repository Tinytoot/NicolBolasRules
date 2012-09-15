using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NicolBolasRules.Model;
using NicolBolasRules.Data;

namespace NicolBolasRules.Business
{
    public class MagicCards: ICardRepository
    {

        public Card GetCard(string cardName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Card> GetRandomCard()
        {
            var dbWorker = new CardRepository();
            return dbWorker.GetRandomCard();
        }

        public IQueryable<IList<Card>> GetCards()
        {
            throw new NotImplementedException();
        }
    }
}
