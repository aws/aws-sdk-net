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

using Amazon.SimpleNotificationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.SimpleNotificationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Create Platform Endpoint Request Marshaller
    /// </summary>       
    public class CreatePlatformEndpointRequestMarshaller : IMarshaller<IRequest, CreatePlatformEndpointRequest>
    {
        public IRequest Marshall(CreatePlatformEndpointRequest createPlatformEndpointRequest)
        {
            IRequest request = new DefaultRequest(createPlatformEndpointRequest, "AmazonSimpleNotificationService");
            request.Parameters.Add("Action", "CreatePlatformEndpoint");
            request.Parameters.Add("Version", "2010-03-31");
            if (createPlatformEndpointRequest != null && createPlatformEndpointRequest.IsSetPlatformApplicationArn())
            {
                request.Parameters.Add("PlatformApplicationArn", StringUtils.FromString(createPlatformEndpointRequest.PlatformApplicationArn));
            }
            if (createPlatformEndpointRequest != null && createPlatformEndpointRequest.IsSetToken())
            {
                request.Parameters.Add("Token", StringUtils.FromString(createPlatformEndpointRequest.Token));
            }
            if (createPlatformEndpointRequest != null && createPlatformEndpointRequest.IsSetCustomUserData())
            {
                request.Parameters.Add("CustomUserData", StringUtils.FromString(createPlatformEndpointRequest.CustomUserData));
            }
            if (createPlatformEndpointRequest != null)
            {
                if (createPlatformEndpointRequest.Attributes != null)
                {
                    int attributesListIndex = 1;
                    foreach (string key in createPlatformEndpointRequest.Attributes.Keys)
                    {
                        string value;
                        bool hasValue = createPlatformEndpointRequest.Attributes.TryGetValue(key, out value);
                                    request.Parameters.Add("Attributes.entry." + attributesListIndex + ".key", StringUtils.FromString(key));
                        if (hasValue) 
                        {
                            request.Parameters.Add("Attributes.entry." + attributesListIndex + ".value", StringUtils.FromString(value));
                        }
                        ++attributesListIndex;
                    }
                }
            }

            return request;
        }
    }
}
