// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using Microsoft.Extensions.Options;

namespace EdFi.Ods.AdminApp.Web.Infrastructure
{
    public class Net48Options<TOptions> : IOptions<TOptions>
        where TOptions : class, new()
    {
        public TOptions Value { get; set; }

        public Net48Options(TOptions value)
        {
            Value = value;
        }
    }
}
