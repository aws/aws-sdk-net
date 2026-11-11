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

using Amazon.SecurityToken.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetFederationToken Request Marshaller
    /// </summary>
    public partial class GetFederationTokenRequestMarshaller : IMarshaller<IRequest, GetFederationTokenRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetFederationTokenRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetFederationTokenRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecurityToken");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "GetFederationToken");
            request.Parameters.Add("Version", "2011-06-15");

            if (publicRequest.IsSetDurationSeconds())
            {
                request.Parameters.Add("DurationSeconds", StringUtils.FromInt(publicRequest.DurationSeconds.Value));
            }
            if (publicRequest.IsSetMinimumSessionTokenSize())
            {
                request.Parameters.Add("MinimumSessionTokenSize", StringUtils.FromInt(publicRequest.MinimumSessionTokenSize.Value));
            }
            if (publicRequest.IsSetName())
            {
                request.Parameters.Add("Name", StringUtils.FromString(publicRequest.Name));
            }
            if (publicRequest.IsSetPolicy())
            {
                request.Parameters.Add("Policy", StringUtils.FromString(publicRequest.Policy));
            }
            if (publicRequest.IsSetPolicyArns())
            {
                if (publicRequest.PolicyArns.Count == 0)
                {
                    request.Parameters.Add("PolicyArns", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.PolicyArns)
                    {
                        if (item0.IsSetArn())
                        {
                            request.Parameters.Add("PolicyArns" + ".member" + "." + index0 + ".arn", StringUtils.FromString(item0.Arn));
                        }
                        index0++;
                    }
                }
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
                            request.Parameters.Add("Tags" + ".member" + "." + index0 + ".Key", StringUtils.FromString(item0.Key));
                        }
                        if (item0.IsSetValue())
                        {
                            request.Parameters.Add("Tags" + ".member" + "." + index0 + ".Value", StringUtils.FromString(item0.Value));
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

        private static readonly GetFederationTokenRequestMarshaller _instance = new();

        internal static GetFederationTokenRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetFederationTokenRequestMarshaller Instance => _instance;
    }
}
