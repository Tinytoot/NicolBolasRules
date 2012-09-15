using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicolBolasRules.Model
{
    public interface ICardRepository
    {
        Card GetCard(string cardName);
        IEnumerable<Card> GetRandomCard();
        IQueryable<IList<Card>> GetCards();


    }
}
