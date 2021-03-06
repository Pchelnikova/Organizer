﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model_Classes
{
    public class User 
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password_ { get; set; }

        public virtual Rang_of_User Rang_of_User { get; set; }

        public virtual ICollection<Wish> Wish_List { get; set; } 
        public virtual ICollection<Diary> Dairy { get; set; }
        public virtual ICollection<Profit> Profit { get; set; }
        public virtual ICollection<Expence> Expance { get; set; }
        public virtual ICollection<Plan> Budjet_Plan { get; set; }
    }
}
