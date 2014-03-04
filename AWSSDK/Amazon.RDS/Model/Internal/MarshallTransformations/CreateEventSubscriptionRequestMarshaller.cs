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
    /// Create Event Subscription Request Marshaller
    /// </summary>       
    public class CreateEventSubscriptionRequestMarshaller : IMarshaller<IRequest, CreateEventSubscriptionRequest>
    {
        public IRequest Marshall(CreateEventSubscriptionRequest createEventSubscriptionRequest)
        {
            IRequest request = new DefaultRequest(createEventSubscriptionRequest, "AmazonRDS");
            request.Parameters.Add("Action", "CreateEventSubscription");
            request.Parameters.Add("Version", "2013-09-09");
            if (createEventSubscriptionRequest != null && createEventSubscriptionRequest.IsSetSubscriptionName())
            {
                request.Parameters.Add("SubscriptionName", StringUtils.FromString(createEventSubscriptionRequest.SubscriptionName));
            }
            if (createEventSubscriptionRequest != null && createEventSubscriptionRequest.IsSetSnsTopicArn())
            {
                request.Parameters.Add("SnsTopicArn", StringUtils.FromString(createEventSubscriptionRequest.SnsTopicArn));
            }
            if (createEventSubscriptionRequest != null && createEventSubscriptionRequest.IsSetSourceType())
            {
                request.Parameters.Add("SourceType", StringUtils.FromString(createEventSubscriptionRequest.SourceType));
            }
            if (createEventSubscriptionRequest != null)
            {
                List<string> eventCategoriesList = createEventSubscriptionRequest.EventCategories;

                int eventCategoriesListIndex = 1;
                foreach (string eventCategoriesListValue in eventCategoriesList)
                { 
                    request.Parameters.Add("EventCategories.member." + eventCategoriesListIndex, StringUtils.FromString(eventCategoriesListValue));
                    eventCategoriesListIndex++;
                }
            }
            if (createEventSubscriptionRequest != null)
            {
                List<string> sourceIdsList = createEventSubscriptionRequest.SourceIds;

                int sourceIdsListIndex = 1;
                foreach (string sourceIdsListValue in sourceIdsList)
                { 
                    request.Parameters.Add("SourceIds.member." + sourceIdsListIndex, StringUtils.FromString(sourceIdsListValue));
                    sourceIdsListIndex++;
                }
            }
            if (createEventSubscriptionRequest != null && createEventSubscriptionRequest.IsSetEnabled())
            {
                request.Parameters.Add("Enabled", StringUtils.FromBool(createEventSubscriptionRequest.Enabled));
            }

            if (createEventSubscriptionRequest != null)
            {
                List<Tag> tagsList = createEventSubscriptionRequest.Tags;
                int tagsListIndex = 1;
                foreach (Tag tagsListValue in tagsList)
                {
                    if (tagsListValue != null && tagsListValue.IsSetKey())
                    {
                        request.Parameters.Add("Tags.member." + tagsListIndex + ".Key", StringUtils.FromString(tagsListValue.Key));
                    }
                    if (tagsListValue != null && tagsListValue.IsSetValue())
                    {
                        request.Parameters.Add("Tags.member." + tagsListIndex + ".Value", StringUtils.FromString(tagsListValue.Value));
                    }

                    tagsListIndex++;
                }
            }

            return request;
        }
    }
}
