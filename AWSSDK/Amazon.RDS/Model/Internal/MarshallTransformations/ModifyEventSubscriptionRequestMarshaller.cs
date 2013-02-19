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

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Modify Event Subscription Request Marshaller
    /// </summary>       
    public class ModifyEventSubscriptionRequestMarshaller : IMarshaller<IRequest, ModifyEventSubscriptionRequest>
    {
        public IRequest Marshall(ModifyEventSubscriptionRequest modifyEventSubscriptionRequest)
        {
            IRequest request = new DefaultRequest(modifyEventSubscriptionRequest, "AmazonRDS");
            request.Parameters.Add("Action", "ModifyEventSubscription");
            request.Parameters.Add("Version", "2013-01-10");
            if (modifyEventSubscriptionRequest != null && modifyEventSubscriptionRequest.IsSetSubscriptionName())
            {
                request.Parameters.Add("SubscriptionName", StringUtils.FromString(modifyEventSubscriptionRequest.SubscriptionName));
            }
            if (modifyEventSubscriptionRequest != null && modifyEventSubscriptionRequest.IsSetSnsTopicArn())
            {
                request.Parameters.Add("SnsTopicArn", StringUtils.FromString(modifyEventSubscriptionRequest.SnsTopicArn));
            }
            if (modifyEventSubscriptionRequest != null && modifyEventSubscriptionRequest.IsSetSourceType())
            {
                request.Parameters.Add("SourceType", StringUtils.FromString(modifyEventSubscriptionRequest.SourceType));
            }
            if (modifyEventSubscriptionRequest != null)
            {
                List<string> eventCategoriesList = modifyEventSubscriptionRequest.EventCategories;

                int eventCategoriesListIndex = 1;
                foreach (string eventCategoriesListValue in eventCategoriesList)
                { 
                    request.Parameters.Add("EventCategories.member." + eventCategoriesListIndex, StringUtils.FromString(eventCategoriesListValue));
                    eventCategoriesListIndex++;
                }
            }
            if (modifyEventSubscriptionRequest != null && modifyEventSubscriptionRequest.IsSetEnabled())
            {
                request.Parameters.Add("Enabled", StringUtils.FromBool(modifyEventSubscriptionRequest.Enabled));
            }

            return request;
        }
    }
}
