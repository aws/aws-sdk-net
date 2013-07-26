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
    /// Confirm Subscription Request Marshaller
    /// </summary>       
    public class ConfirmSubscriptionRequestMarshaller : IMarshaller<IRequest, ConfirmSubscriptionRequest>
    {
        public IRequest Marshall(ConfirmSubscriptionRequest confirmSubscriptionRequest)
        {
            IRequest request = new DefaultRequest(confirmSubscriptionRequest, "AmazonSimpleNotificationService");
            request.Parameters.Add("Action", "ConfirmSubscription");
            request.Parameters.Add("Version", "2010-03-31");
            if (confirmSubscriptionRequest != null && confirmSubscriptionRequest.IsSetTopicArn())
            {
                request.Parameters.Add("TopicArn", StringUtils.FromString(confirmSubscriptionRequest.TopicArn));
            }
            if (confirmSubscriptionRequest != null && confirmSubscriptionRequest.IsSetToken())
            {
                request.Parameters.Add("Token", StringUtils.FromString(confirmSubscriptionRequest.Token));
            }
            if (confirmSubscriptionRequest != null && confirmSubscriptionRequest.IsSetAuthenticateOnUnsubscribe())
            {
                request.Parameters.Add("AuthenticateOnUnsubscribe", StringUtils.FromString(confirmSubscriptionRequest.AuthenticateOnUnsubscribe));
            }

            return request;
        }
    }
}
