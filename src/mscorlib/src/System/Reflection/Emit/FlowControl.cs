// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
/*============================================================
**
** 
** 
**
**Purpose: Exposes FlowControl Attribute of IL .
**
** THIS FILE IS AUTOMATICALLY GENERATED. DO NOT EDIT BY HAND!
** See clrsrcincopcodegen.pl for more information.**
============================================================*/
namespace System.Reflection.Emit {

using System;

[Serializable]
[System.Runtime.InteropServices.ComVisible(true)]
public enum FlowControl
{

    Branch       = 0,
    Break        = 1,
    Call         = 2,
    Cond_Branch  = 3,
    Meta         = 4,
    Next         = 5,
#if !FEATURE_CORECLR
    /// <internalonly/>
    [Obsolete("This API has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
    Phi          = 6,
#endif
    Return       = 7,
    Throw        = 8,
}
}
