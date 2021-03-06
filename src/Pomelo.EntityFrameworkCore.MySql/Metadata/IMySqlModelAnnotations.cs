﻿// Copyright (c) Pomelo Foundation. All rights reserved.
// Licensed under the MIT. See LICENSE in the project root for license information.

using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace Microsoft.EntityFrameworkCore.Metadata
{
    public interface IMySqlModelAnnotations : IRelationalModelAnnotations
    {
        IReadOnlyList<IMySqlExtension> MySqlExtensions { get; }
        string DatabaseTemplate { get; }
    }
}
