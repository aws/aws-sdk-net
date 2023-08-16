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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AWSSDK.Benchmarks
{
    public static class Constants
    {
        public static readonly DateTime DefaultDate = new DateTime(1997, 8, 12, 19, 54, 44, 0, DateTimeKind.Utc);
        public const string SdkTestPrefix = "aws-net-sdk";
        public static readonly Byte[] DefaultBlob = UTF8Encoding.UTF8.GetBytes("Cyberdyne Systems");
        public static readonly string DefaultBlobEncoded = Convert.ToBase64String(DefaultBlob);
        public static readonly decimal DefaultDecimal = 10.1111222412323m;
        public static readonly int MegSize = (int)Math.Pow(2, 20);
        public static readonly int KiloSize = (int)Math.Pow(2, 10);

    }
}
