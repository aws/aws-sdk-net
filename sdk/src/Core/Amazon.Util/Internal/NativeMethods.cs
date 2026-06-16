/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Amazon.Util.Internal
{
#if !NET8_0_OR_GREATER
    /// <summary>
    /// Native method declarations for Unix/macOS platform interop.
    /// </summary>
    [SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass", Justification = "NativeMethods is the class name")]
    public static class NativeMethods
    {
#pragma warning disable PC003 // Native API not available in UWP - chmod is only called on Unix/macOS platforms
#pragma warning disable CA1401 // P/Invoke method is made public so test projects can reuse it without duplicating the declaration
        [DllImport("libc", EntryPoint = "chmod", SetLastError = true, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        [SuppressMessage("Microsoft.Globalization", "CA2101:SpecifyMarshalingForPInvokeStringArguments", Justification = "Ansi marshaling is appropriate for Unix file paths")]
        public static extern int Chmod(string path, int mode);
#pragma warning restore CA1401
#pragma warning restore PC003
    }
#endif
}
