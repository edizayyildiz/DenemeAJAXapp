using DenemeAJAXapp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DenemeAJAXapp
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {

        }
        public virtual DbSet<FeedBack> FeedBacks { get; set; }
    }
}