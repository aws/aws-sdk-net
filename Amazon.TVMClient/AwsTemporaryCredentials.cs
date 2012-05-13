/*
 * Author: David Iffland, Heavy Code LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 * http://aws.amazon.com/apache2.0
 */

using System;

namespace AWSSDK.Amazon.TVMClient
{
    /// <summary>
    /// Used to contain a set of temporary credentials for Amazon AWS.
    /// </summary>
    public class AwsTemporaryCredentials
    {
        public string AccessKey { get; set; }
        public string SecretKey { get; set; }
        public string SecurityToken { get; set; }
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Handles converting milliseconds since 01-01-1970 into a useable DateTime.
        /// </summary>
        /// <param name="milliseconds">The number of milliseconds since 01-01-1970 as a string</param>
        /// <returns>A DateTime that is 01-01-1970 plus the number of milliseconds</returns>
        public static DateTime GetExpirationTimeFromMilliseconds(string milliseconds)
        {
            long longMillseconds;
            Int64.TryParse(milliseconds, out longMillseconds);

            return GetExpirationTimeFromMilliseconds(longMillseconds);
            
        }

        /// <summary>
        /// Handles converting milliseconds since 01-01-1970 into a useable DateTime.
        /// </summary>
        /// <param name="milliseconds">The number of milliseconds since 01-01-1970</param>
        /// <returns>A DateTime that is 01-01-1970 plus the number of milliseconds</returns>
        public static DateTime GetExpirationTimeFromMilliseconds(long milliseconds)
        {
            var ticks = milliseconds*TimeSpan.TicksPerMillisecond;
            var correctedDate = new DateTime(1970, 1, 1).Add(new TimeSpan(ticks));
            return correctedDate;
        }

    }
}
