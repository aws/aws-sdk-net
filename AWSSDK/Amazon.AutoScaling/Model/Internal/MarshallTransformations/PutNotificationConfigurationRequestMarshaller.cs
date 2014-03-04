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

using Amazon.AutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Put Notification Configuration Request Marshaller
    /// </summary>       
    public class PutNotificationConfigurationRequestMarshaller : IMarshaller<IRequest, PutNotificationConfigurationRequest>
    {
        public IRequest Marshall(PutNotificationConfigurationRequest putNotificationConfigurationRequest)
        {
            IRequest request = new DefaultRequest(putNotificationConfigurationRequest, "AmazonAutoScaling");
            request.Parameters.Add("Action", "PutNotificationConfiguration");
            request.Parameters.Add("Version", "2011-01-01");
            if (putNotificationConfigurationRequest != null && putNotificationConfigurationRequest.IsSetAutoScalingGroupName())
            {
                request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(putNotificationConfigurationRequest.AutoScalingGroupName));
            }
            if (putNotificationConfigurationRequest != null && putNotificationConfigurationRequest.IsSetTopicARN())
            {
                request.Parameters.Add("TopicARN", StringUtils.FromString(putNotificationConfigurationRequest.TopicARN));
            }
            if (putNotificationConfigurationRequest != null)
            {
                List<string> notificationTypesList = putNotificationConfigurationRequest.NotificationTypes;

                int notificationTypesListIndex = 1;
                foreach (string notificationTypesListValue in notificationTypesList)
                { 
                    request.Parameters.Add("NotificationTypes.member." + notificationTypesListIndex, StringUtils.FromString(notificationTypesListValue));
                    notificationTypesListIndex++;
                }
            }

            return request;
        }
    }
}
