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

using Amazon.RDS.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyEventSubscription Request Marshaller
    /// </summary>
    public partial class ModifyEventSubscriptionRequestMarshaller : IMarshaller<IRequest, ModifyEventSubscriptionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyEventSubscriptionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyEventSubscriptionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyEventSubscription");
            request.Parameters.Add("Version", "2014-10-31");

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
            if (publicRequest.IsSetSnsTopicArn())
            {
                request.Parameters.Add("SnsTopicArn", StringUtils.FromString(publicRequest.SnsTopicArn));
            }
            if (publicRequest.IsSetSourceType())
            {
                request.Parameters.Add("SourceType", StringUtils.FromString(publicRequest.SourceType));
            }
            if (publicRequest.IsSetSubscriptionName())
            {
                request.Parameters.Add("SubscriptionName", StringUtils.FromString(publicRequest.SubscriptionName));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifyEventSubscriptionRequestMarshaller _instance = new();

        internal static ModifyEventSubscriptionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyEventSubscriptionRequestMarshaller Instance => _instance;
    }
}
