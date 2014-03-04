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

using Amazon.SimpleEmail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.SimpleEmail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Set Identity Notification Topic Request Marshaller
    /// </summary>       
    public class SetIdentityNotificationTopicRequestMarshaller : IMarshaller<IRequest, SetIdentityNotificationTopicRequest>
    {
        public IRequest Marshall(SetIdentityNotificationTopicRequest setIdentityNotificationTopicRequest)
        {
            IRequest request = new DefaultRequest(setIdentityNotificationTopicRequest, "AmazonSimpleEmailService");
            request.Parameters.Add("Action", "SetIdentityNotificationTopic");
            request.Parameters.Add("Version", "2010-12-01");
            if (setIdentityNotificationTopicRequest != null && setIdentityNotificationTopicRequest.IsSetIdentity())
            {
                request.Parameters.Add("Identity", StringUtils.FromString(setIdentityNotificationTopicRequest.Identity));
            }
            if (setIdentityNotificationTopicRequest != null && setIdentityNotificationTopicRequest.IsSetNotificationType())
            {
                request.Parameters.Add("NotificationType", StringUtils.FromString(setIdentityNotificationTopicRequest.NotificationType));
            }
            if (setIdentityNotificationTopicRequest != null && setIdentityNotificationTopicRequest.IsSetSnsTopic())
            {
                request.Parameters.Add("SnsTopic", StringUtils.FromString(setIdentityNotificationTopicRequest.SnsTopic));
            }

            return request;
        }
    }
}
