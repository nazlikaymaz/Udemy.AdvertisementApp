﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.AdvertisementApp.Entities
{
    public class AppUserRole : BaseEntity
    {
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }
        public int AppRoleID { get; set; }
        public AppRole AppRole { get; set; }
    }
}
