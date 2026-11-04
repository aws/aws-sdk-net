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

using Amazon.AutoScaling.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribePolicies Request Marshaller
    /// </summary>
    public partial class DescribePoliciesRequestMarshaller : IMarshaller<IRequest, DescribePoliciesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribePoliciesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribePoliciesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AutoScaling");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "DescribePolicies");
            request.Parameters.Add("Version", "2011-01-01");

            if (publicRequest.IsSetAutoScalingGroupName())
            {
                request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(publicRequest.AutoScalingGroupName));
            }
            if (publicRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(publicRequest.MaxRecords.Value));
            }
            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            }
            if (publicRequest.IsSetPolicyNames())
            {
                if (publicRequest.PolicyNames.Count == 0)
                {
                    request.Parameters.Add("PolicyNames", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.PolicyNames)
                    {
                        request.Parameters.Add("PolicyNames" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetPolicyTypes())
            {
                if (publicRequest.PolicyTypes.Count == 0)
                {
                    request.Parameters.Add("PolicyTypes", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.PolicyTypes)
                    {
                        request.Parameters.Add("PolicyTypes" + ".member" + "." + index0, StringUtils.FromString(item0));
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

        private static readonly DescribePoliciesRequestMarshaller _instance = new();

        internal static DescribePoliciesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribePoliciesRequestMarshaller Instance => _instance;
    }
}
