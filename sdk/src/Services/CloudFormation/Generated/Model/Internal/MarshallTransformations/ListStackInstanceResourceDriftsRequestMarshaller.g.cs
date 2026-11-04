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

using Amazon.CloudFormation.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListStackInstanceResourceDrifts Request Marshaller
    /// </summary>
    public partial class ListStackInstanceResourceDriftsRequestMarshaller : IMarshaller<IRequest, ListStackInstanceResourceDriftsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListStackInstanceResourceDriftsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListStackInstanceResourceDriftsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFormation");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ListStackInstanceResourceDrifts");
            request.Parameters.Add("Version", "2010-05-15");

            if (publicRequest.IsSetCallAs())
            {
                request.Parameters.Add("CallAs", StringUtils.FromString(publicRequest.CallAs));
            }
            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }
            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            }
            if (publicRequest.IsSetOperationId())
            {
                request.Parameters.Add("OperationId", StringUtils.FromString(publicRequest.OperationId));
            }
            if (publicRequest.IsSetStackInstanceAccount())
            {
                request.Parameters.Add("StackInstanceAccount", StringUtils.FromString(publicRequest.StackInstanceAccount));
            }
            if (publicRequest.IsSetStackInstanceRegion())
            {
                request.Parameters.Add("StackInstanceRegion", StringUtils.FromString(publicRequest.StackInstanceRegion));
            }
            if (publicRequest.IsSetStackInstanceResourceDriftStatuses())
            {
                if (publicRequest.StackInstanceResourceDriftStatuses.Count == 0)
                {
                    request.Parameters.Add("StackInstanceResourceDriftStatuses", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.StackInstanceResourceDriftStatuses)
                    {
                        request.Parameters.Add("StackInstanceResourceDriftStatuses" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetStackSetName())
            {
                request.Parameters.Add("StackSetName", StringUtils.FromString(publicRequest.StackSetName));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ListStackInstanceResourceDriftsRequestMarshaller _instance = new();

        internal static ListStackInstanceResourceDriftsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListStackInstanceResourceDriftsRequestMarshaller Instance => _instance;
    }
}
