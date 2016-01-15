// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNet.Mvc.ModelBinding.Validation;

namespace Microsoft.AspNet.Mvc.DataAnnotations.Internal
{
    public class ModelClientValidationRequiredRule : ModelClientValidationRule
    {
        private const string RequiredValidationType = "required";

        public ModelClientValidationRequiredRule(string errorMessage) :
            base(RequiredValidationType, errorMessage)
        {
        }
    }
}