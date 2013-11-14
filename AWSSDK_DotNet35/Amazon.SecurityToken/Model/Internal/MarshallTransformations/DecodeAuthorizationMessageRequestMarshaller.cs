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
    /// Decode Authorization Message Request Marshaller
    /// </summary>       
    public class DecodeAuthorizationMessageRequestMarshaller : IMarshaller<IRequest, DecodeAuthorizationMessageRequest>
    {
        public IRequest Marshall(DecodeAuthorizationMessageRequest decodeAuthorizationMessageRequest)
        {
            IRequest request = new DefaultRequest(decodeAuthorizationMessageRequest, "AmazonSecurityTokenService");
            request.Parameters.Add("Action", "DecodeAuthorizationMessage");
            request.Parameters.Add("Version", "2011-06-15");
            if (decodeAuthorizationMessageRequest != null && decodeAuthorizationMessageRequest.IsSetEncodedMessage())
            {
                request.Parameters.Add("EncodedMessage", StringUtils.FromString(decodeAuthorizationMessageRequest.EncodedMessage));
            }

            return request;
        }
    }
}
