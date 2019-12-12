/*
 * Copyright 2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Net;

namespace AWSSDK.Runtime.Internal.Util
{
    internal static class ExceptionUtils
    {
        internal static HttpStatusCode? DetermineHttpStatusCode(Exception e)
        {
            var response = (e as WebException)?.Response as HttpWebResponse;
            if (response != null)
            {
                return response.StatusCode;                
            }

#if !BCL35 && !UNITY
            var requestException = e as System.Net.Http.HttpRequestException;            
            if (requestException?.Data?.Contains("StatusCode") == true)
            {
                return (HttpStatusCode)requestException.Data["StatusCode"];
            }            
#endif

            if (e?.InnerException != null)
            {
                return DetermineHttpStatusCode(e.InnerException);
            }

            return null;
        }
    }
}
