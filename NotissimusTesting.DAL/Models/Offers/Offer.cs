﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace NotissimusTesting.DAL.Models.Offers
{
    public class Offer
    {
        [Key]
        public int Id { get; set; }
        List<OfferElement> elements = new List<OfferElement>();



    }
}
