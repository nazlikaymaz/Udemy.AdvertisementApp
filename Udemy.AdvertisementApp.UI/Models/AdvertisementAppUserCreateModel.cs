using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udemy.AdvertisementApp.Common.Enums;

namespace Udemy.AdvertisementApp.UI.Models
{
    public class AdvertisementAppUserCreateModel
    {
        public int AdvertisementID { get; set; }
        public int AppUserID { get; set; }
        public int AdvertisementAppUserStatusID { get; set; } = (int)AdvertisementAppUserStatusType.Basvurdu;
        public int MilitaryStatusID { get; set; }
        public DateTime? EndDate { get; set; }
        public int WorkExperience { get; set; }
        public IFormFile CvFile { get; set; }
    }
}
