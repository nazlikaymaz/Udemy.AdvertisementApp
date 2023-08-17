using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.AdvertisementApp.Dtos.Interfaces;

namespace Udemy.AdvertisementApp.Dtos
{
    public class AdvertisementAppUserCreateDto : IDto
    {
        public int AdvertisementID { get; set; }
        public int AppUserID { get; set; }
        public int AdvertisementAppUserStatusID { get; set; }
        public int MilitaryStatusID { get; set; }
        public DateTime? EndDate { get; set; }
        public int WorkExperience { get; set; }
        public string CvPath { get; set; }
    }
}
