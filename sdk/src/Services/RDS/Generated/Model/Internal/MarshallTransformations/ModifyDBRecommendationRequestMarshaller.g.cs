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
    /// ModifyDBRecommendation Request Marshaller
    /// </summary>
    public partial class ModifyDBRecommendationRequestMarshaller : IMarshaller<IRequest, ModifyDBRecommendationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyDBRecommendationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyDBRecommendationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyDBRecommendation");
            request.Parameters.Add("Version", "2014-10-31");

            if (publicRequest.IsSetLocale())
            {
                request.Parameters.Add("Locale", StringUtils.FromString(publicRequest.Locale));
            }
            if (publicRequest.IsSetRecommendationId())
            {
                request.Parameters.Add("RecommendationId", StringUtils.FromString(publicRequest.RecommendationId));
            }
            if (publicRequest.IsSetRecommendedActionUpdates())
            {
                if (publicRequest.RecommendedActionUpdates.Count == 0)
                {
                    request.Parameters.Add("RecommendedActionUpdates", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.RecommendedActionUpdates)
                    {
                        if (item0.IsSetActionId())
                        {
                            request.Parameters.Add("RecommendedActionUpdates" + ".member" + "." + index0 + ".ActionId", StringUtils.FromString(item0.ActionId));
                        }
                        if (item0.IsSetStatus())
                        {
                            request.Parameters.Add("RecommendedActionUpdates" + ".member" + "." + index0 + ".Status", StringUtils.FromString(item0.Status));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetStatus())
            {
                request.Parameters.Add("Status", StringUtils.FromString(publicRequest.Status));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifyDBRecommendationRequestMarshaller _instance = new();

        internal static ModifyDBRecommendationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyDBRecommendationRequestMarshaller Instance => _instance;
    }
}
