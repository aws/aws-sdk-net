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
    /// Create Topic Request Marshaller
    /// </summary>       
    public class CreateTopicRequestMarshaller : IMarshaller<IRequest, CreateTopicRequest>
    {
        public IRequest Marshall(CreateTopicRequest createTopicRequest)
        {
            IRequest request = new DefaultRequest(createTopicRequest, "AmazonSimpleNotificationService");
            request.Parameters.Add("Action", "CreateTopic");
            request.Parameters.Add("Version", "2010-03-31");
            if (createTopicRequest != null && createTopicRequest.IsSetName())
            {
                request.Parameters.Add("Name", StringUtils.FromString(createTopicRequest.Name));
            }

            return request;
        }
    }
}
