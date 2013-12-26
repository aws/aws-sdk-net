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
    /// Create Platform Application Request Marshaller
    /// </summary>       
    public class CreatePlatformApplicationRequestMarshaller : IMarshaller<IRequest, CreatePlatformApplicationRequest>
    {
        public IRequest Marshall(CreatePlatformApplicationRequest createPlatformApplicationRequest)
        {
            IRequest request = new DefaultRequest(createPlatformApplicationRequest, "AmazonSimpleNotificationService");
            request.Parameters.Add("Action", "CreatePlatformApplication");
            request.Parameters.Add("Version", "2010-03-31");
            if (createPlatformApplicationRequest != null && createPlatformApplicationRequest.IsSetName())
            {
                request.Parameters.Add("Name", StringUtils.FromString(createPlatformApplicationRequest.Name));
            }
            if (createPlatformApplicationRequest != null && createPlatformApplicationRequest.IsSetPlatform())
            {
                request.Parameters.Add("Platform", StringUtils.FromString(createPlatformApplicationRequest.Platform));
            }
            if (createPlatformApplicationRequest != null)
            {
                if (createPlatformApplicationRequest.Attributes != null)
                {
                    int attributesListIndex = 1;
                    foreach (string key in createPlatformApplicationRequest.Attributes.Keys)
                    {
                        string value;
                        bool hasValue = createPlatformApplicationRequest.Attributes.TryGetValue(key, out value);
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
