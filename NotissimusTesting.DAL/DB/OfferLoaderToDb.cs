using NotissimusTesting.DAL.Models.Offers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotissimusTesting.DAL.DB
{
    public class OfferLoaderToDb
    {
        private WebAppContext context;

        public OfferLoaderToDb() 
        {
            context = new WebAppContext();
        }

        private bool OfferExist(int id)
        {
            return context.offers.Where(x=> x.Id == id).Count() > 0;
        }
        
        public async void Create(Offer offer)
        {
            if (!OfferExist(offer.Id))
            {
                await context.offers.AddAsync(offer);
                foreach(OfferElement element in offer.Elements)
                {
                    await context.offerElements.AddAsync(element);
                }
                context.SaveChanges();
            }

        }


    }
}
