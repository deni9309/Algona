﻿namespace Server.Common.Requests.TransportRequest
{
    using System.ComponentModel.DataAnnotations;

    using Server.Common.Constants;

    public class TransportRequest
    {
        [Required]
        [MinLength(EntityValidationConstants.Transport.FromAddressMinLength)]
        [MaxLength(EntityValidationConstants.Transport.FromAddressMaxLength)]
        public string FromAddress { get; set; } = null!;

        [Required]
        [MinLength(EntityValidationConstants.Transport.ToAddressMinLength)]
        [MaxLength(EntityValidationConstants.Transport.ToAddressMaxLength)]
        public string ToAddress { get; set; } = null!;

        [Required]
        [DataType(DataType.Date)]
        public DateTime FromDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ToDate { get; set; }

        [Required]
        [Range(EntityValidationConstants.Transport.NumberOfPalletsMinValue, EntityValidationConstants.Transport.NumberOfPalletsMaxValue)]
        public int NumberOfPallets { get; set; }

        [Required]
        [Range(EntityValidationConstants.Transport.TotalWeightMinValue, EntityValidationConstants.Transport.TotalWeightMaxValue)]
        public int TotalWeight { get; set; }

        [Required]
        [MinLength(EntityValidationConstants.Transport.NameMinLength)]
        [MaxLength(EntityValidationConstants.Transport.NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [Phone]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;
    }
}