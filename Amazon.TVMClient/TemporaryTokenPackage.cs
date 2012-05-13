/*
 * Author: David Iffland, Heavy Code LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 * http://aws.amazon.com/apache2.0
 */

using System.Net;

namespace AWSSDK.Amazon.TVMClient
{
    /// <summary>
    /// Package used to combine necessary information for async callback data manipulation.
    /// </summary>
    public class TemporaryTokenPackage
    {
        public HttpWebRequest Request { get; set; }
        public string DeviceId { get; set; }
    }
}