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
    /// Publish Request Marshaller
    /// </summary>       
    public class PublishRequestMarshaller : IMarshaller<IRequest, PublishRequest>
    {
        public IRequest Marshall(PublishRequest publishRequest)
        {
            IRequest request = new DefaultRequest(publishRequest, "AmazonSimpleNotificationService");
            request.Parameters.Add("Action", "Publish");
            request.Parameters.Add("Version", "2010-03-31");
            if (publishRequest != null && publishRequest.IsSetTopicArn())
            {
                request.Parameters.Add("TopicArn", StringUtils.FromString(publishRequest.TopicArn));
            }
            if (publishRequest != null && publishRequest.IsSetTargetArn())
            {
                request.Parameters.Add("TargetArn", StringUtils.FromString(publishRequest.TargetArn));
            }
            if (publishRequest != null && publishRequest.IsSetMessage())
            {
                request.Parameters.Add("Message", StringUtils.FromString(publishRequest.Message));
            }
            if (publishRequest != null && publishRequest.IsSetSubject())
            {
                request.Parameters.Add("Subject", StringUtils.FromString(publishRequest.Subject));
            }
            if (publishRequest != null && publishRequest.IsSetMessageStructure())
            {
                request.Parameters.Add("MessageStructure", StringUtils.FromString(publishRequest.MessageStructure));
            }

            return request;
        }
    }
}
