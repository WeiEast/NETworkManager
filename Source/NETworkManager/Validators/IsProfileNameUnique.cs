﻿using System;
using System.Globalization;
using System.Linq;
using System.Windows.Controls;
using NETworkManager.Models.Settings;

namespace NETworkManager.Validators
{
    public class IsProfileNameUnique : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            return ProfileManager.Profiles.Any(x => string.Equals(x.Name, value as string, StringComparison.OrdinalIgnoreCase)) ? new ValidationResult(false, Resources.Localization.Strings.ProfileWithThisNameAlreadyExists) : ValidationResult.ValidResult;
        }
    }
}
