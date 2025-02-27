﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.AspNetCore.Mvc.Analyzers
{
    [ApiConventionType(typeof(object))]
    [ApiController]
    [ApiConventionType(typeof(string))]
    public class GetAttributes_BaseTypeWithAttributesBase
    {
    }

    [ApiConventionType(typeof(int))]
    public class GetAttributes_BaseTypeWithAttributesDerived : GetAttributes_BaseTypeWithAttributesBase
    {
    }
}
