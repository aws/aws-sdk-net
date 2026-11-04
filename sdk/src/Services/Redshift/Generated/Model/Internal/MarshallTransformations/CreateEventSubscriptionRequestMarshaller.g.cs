/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.Redshift.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateEventSubscription Request Marshaller
    /// </summary>
    public partial class CreateEventSubscriptionRequestMarshaller : IMarshaller<IRequest, CreateEventSubscriptionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateEventSubscriptionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateEventSubscriptionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateEventSubscription");
            request.Parameters.Add("Version", "2012-12-01");

            if (publicRequest.IsSetEnabled())
            {
                request.Parameters.Add("Enabled", StringUtils.FromBool(publicRequest.Enabled.Value));
            }
            if (publicRequest.IsSetEventCategories())
            {
                if (publicRequest.EventCategories.Count == 0)
                {
                    request.Parameters.Add("EventCategories", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.EventCategories)
                    {
                        request.Parameters.Add("EventCategories" + ".EventCategory" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetSeverity())
            {
                request.Parameters.Add("Severity", StringUtils.FromString(publicRequest.Severity));
            }
            if (publicRequest.IsSetSnsTopicArn())
            {
                request.Parameters.Add("SnsTopicArn", StringUtils.FromString(publicRequest.SnsTopicArn));
            }
            if (publicRequest.IsSetSourceIds())
            {
                if (publicRequest.SourceIds.Count == 0)
                {
                    request.Parameters.Add("SourceIds", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.SourceIds)
                    {
                        request.Parameters.Add("SourceIds" + ".SourceId" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetSourceType())
            {
                request.Parameters.Add("SourceType", StringUtils.FromString(publicRequest.SourceType));
            }
            if (publicRequest.IsSetSubscriptionName())
            {
                request.Parameters.Add("SubscriptionName", StringUtils.FromString(publicRequest.SubscriptionName));
            }
            if (publicRequest.IsSetTags())
            {
                if (publicRequest.Tags.Count == 0)
                {
                    request.Parameters.Add("Tags", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Tags)
                    {
                        if (item0.IsSetKey())
                        {
                            request.Parameters.Add("Tags" + ".Tag" + "." + index0 + ".Key", StringUtils.FromString(item0.Key));
                        }
                        if (item0.IsSetValue())
                        {
                            request.Parameters.Add("Tags" + ".Tag" + "." + index0 + ".Value", StringUtils.FromString(item0.Value));
                        }
                        index0++;
                    }
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateEventSubscriptionRequestMarshaller _instance = new();

        internal static CreateEventSubscriptionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateEventSubscriptionRequestMarshaller Instance => _instance;
    }
}
