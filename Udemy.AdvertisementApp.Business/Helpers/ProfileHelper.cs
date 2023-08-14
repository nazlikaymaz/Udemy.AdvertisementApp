﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.AdvertisementApp.Business.Mappings.AutoMapper;

namespace Udemy.AdvertisementApp.Business.Helpers
{
    public static class ProfileHelper
    {
        public static List<Profile> GetProfiles()
        {
            return new List<Profile>
            {
                new ProvidedServicesProfile(),
            new AdvertisementProfile(),
            new AppUserProfile(),
            new GenderProfile(),
            };
        }
    }
}
