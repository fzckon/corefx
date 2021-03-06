// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//------------------------------------------------------------

//------------------------------------------------------------

using System;

namespace System.Runtime.Serialization
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false)]
    public sealed class OnDeserializedAttribute : Attribute
    {
    }
}
