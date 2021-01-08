﻿/*
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

using Amazon.Util;
using System;
using System.Globalization;

namespace Amazon.EC2.Internal
{
    /// <summary>
    /// Custom type serializers for EC2
    /// </summary>
    public static class CustomMarshallTransformations
    {
        [Obsolete("This method doesn't handle correctly non-UTC DateTimes. Use ConvertDateTimeISOWithoutMillisecondsUtc instead.", false)]
        public static String ConvertDateTimeISOWithoutMilliseconds(DateTime dateTime)
        {
            return dateTime.ToString(AWSSDKUtils.ISO8601DateFormatNoMS, DateTimeFormatInfo.InvariantInfo);
        }

        /// <summary>
        /// Custom DateTime serializer for EC2.
        /// </summary>
        /// <param name="dateTime">The DateTime to serialize</param>
        /// <returns>ISO formatted string with no miliseconds</returns>
        public static String ConvertDateTimeISOWithoutMillisecondsUtc(DateTime dateTime)
        {
            return dateTime.ToUniversalTime().ToString(AWSSDKUtils.ISO8601DateFormatNoMS, DateTimeFormatInfo.InvariantInfo);
        }
    }
}
