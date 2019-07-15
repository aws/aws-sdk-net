// /*******************************************************************************
//  *  Copyright 2008-2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
//  *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
//  *  this file except in compliance with the License. A copy of the License is located at
//  *
//  *  http://aws.amazon.com/apache2.0
//  *
//  *  or in the "license" file accompanying this file.
//  *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
//  *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
//  *  specific language governing permissions and limitations under the License.
//  * *****************************************************************************
//  *    __  _    _  ___
//  *   (  )( \/\/ )/ __)
//  *   /__\ \    / \__ \
//  *  (_)(_) \/\/  (___/
//  *
//  *  AWS SDK for .NET
//  /******************************************************************************
//  * The EndianConversionUtility methods were copied from the IPAddress class developed by
//  * Microsoft from the .NET framework under the MIT License (MIT) located in the
//  * https://github.com/Microsoft/referencesource repository.
//  *
//  * The MIT License(MIT)
//  *
//  * Copyright(c) Microsoft Corporation
//  *
//  * Permission is hereby granted, free of charge, to any person obtaining a copy
//  * of this software and associated documentation files (the "Software"), to deal 
//  * in the Software without restriction, including without limitation the rights
//  * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  * copies of the Software, and to permit persons to whom the Software is 
//  * furnished to do so, subject to the following conditions: 
//  *
//  * The above copyright notice and this permission notice shall be included in all
//  * copies or substantial portions of the Software. 
//  *
//  * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
//  * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
//  * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  * SOFTWARE.
//  */


namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// PCL doesn't have IPAddress. These methods are copied from the Microsoft source code.
    /// </summary>
    public static class EndianConversionUtility
    {
        public static long HostToNetworkOrder(long host)
        {
#if BIGENDIAN
            return host;
#else
            unchecked
            {
                return (((long)HostToNetworkOrder((int)host) & 0xFFFFFFFF) << 32)
                     | ((long)HostToNetworkOrder((int)(host >> 32)) & 0xFFFFFFFF);
            }
#endif
        }
        public static int HostToNetworkOrder(int host)
        {
#if BIGENDIAN
            return host;
#else
            unchecked
            {
                return (((int)HostToNetworkOrder((short)host) & 0xFFFF) << 16)
                     | ((int)HostToNetworkOrder((short)(host >> 16)) & 0xFFFF);
            }
#endif
        }
        public static short HostToNetworkOrder(short host)
        {
#if BIGENDIAN
            return host;
#else
            unchecked
            {
                return (short)((((int)host & 0xFF) << 8)
                             | (int)((host >> 8) & 0xFF));
            }
#endif
        }
        public static long NetworkToHostOrder(long network)
        {
            return HostToNetworkOrder(network);
        }
        public static int NetworkToHostOrder(int network)
        {
            return HostToNetworkOrder(network);
        }
        public static short NetworkToHostOrder(short network)
        {
            return HostToNetworkOrder(network);
        }
    }
}