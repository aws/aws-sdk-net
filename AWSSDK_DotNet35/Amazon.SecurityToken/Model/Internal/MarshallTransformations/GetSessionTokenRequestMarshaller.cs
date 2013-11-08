/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Xml.Serialization;
using System.Text;

using Amazon.SecurityToken.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Get Session Token Request Marshaller
    /// </summary>       
    public class GetSessionTokenRequestMarshaller : IMarshaller<IRequest, GetSessionTokenRequest>
    {
        public IRequest Marshall(GetSessionTokenRequest getSessionTokenRequest)
        {
            IRequest request = new DefaultRequest(getSessionTokenRequest, "AmazonSecurityTokenService");
            request.Parameters.Add("Action", "GetSessionToken");
            request.Parameters.Add("Version", "2011-06-15");
            if (getSessionTokenRequest != null && getSessionTokenRequest.IsSetDurationSeconds())
            {
                request.Parameters.Add("DurationSeconds", StringUtils.FromInt(getSessionTokenRequest.DurationSeconds));
            }
            if (getSessionTokenRequest != null && getSessionTokenRequest.IsSetSerialNumber())
            {
                request.Parameters.Add("SerialNumber", StringUtils.FromString(getSessionTokenRequest.SerialNumber));
            }
            if (getSessionTokenRequest != null && getSessionTokenRequest.IsSetTokenCode())
            {
                request.Parameters.Add("TokenCode", StringUtils.FromString(getSessionTokenRequest.TokenCode));
            }

            return request;
        }
    }
}
