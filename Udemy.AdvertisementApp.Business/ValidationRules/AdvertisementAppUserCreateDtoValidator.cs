using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.AdvertisementApp.Common.Enums;
using Udemy.AdvertisementApp.Dtos;

namespace Udemy.AdvertisementApp.Business.ValidationRules
{
    public class AdvertisementAppUserCreateDtoValidator : AbstractValidator<AdvertisementAppUserCreateDto>
    {
        public AdvertisementAppUserCreateDtoValidator()
        {
            this.RuleFor(x => x.AdvertisementAppUserStatusID).NotEmpty();
            this.RuleFor(x => x.AdvertisementID).NotEmpty();
            this.RuleFor(x => x.AppUserID).NotEmpty();
            this.RuleFor(x => x.CvPath).NotEmpty().WithMessage("Bir cv dosyası seçiniz.");
            this.RuleFor(x => x.EndDate).NotEmpty().When(x => x.MilitaryStatusID == (int)MilitaryStatusType.Tecilli).WithMessage("Tecil tarihi boş bırakılamaz");
        }
    }
}
