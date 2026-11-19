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
    /// DescribeAutoScalingGroups Request Marshaller
    /// </summary>
    public partial class DescribeAutoScalingGroupsRequestMarshaller : IMarshaller<IRequest, DescribeAutoScalingGroupsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeAutoScalingGroupsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribeAutoScalingGroupsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AutoScaling");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "DescribeAutoScalingGroups");
            request.Parameters.Add("Version", "2011-01-01");

            if (publicRequest.IsSetAutoScalingGroupNames())
            {
                if (publicRequest.AutoScalingGroupNames.Count == 0)
                {
                    request.Parameters.Add("AutoScalingGroupNames", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.AutoScalingGroupNames)
                    {
                        request.Parameters.Add("AutoScalingGroupNames" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetFilters())
            {
                if (publicRequest.Filters.Count == 0)
                {
                    request.Parameters.Add("Filters", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Filters)
                    {
                        if (item0.IsSetName())
                        {
                            request.Parameters.Add("Filters" + ".member" + "." + index0 + ".Name", StringUtils.FromString(item0.Name));
                        }
                        if (item0.IsSetValues())
                        {
                            if (item0.Values.Count == 0)
                            {
                                request.Parameters.Add("Filters" + ".member" + "." + index0 + ".Values", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Values)
                                {
                                    request.Parameters.Add("Filters" + ".member" + "." + index0 + ".Values" + ".member" + "." + index1, StringUtils.FromString(item1));
                                    index1++;
                                }
                            }
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetIncludeInstances())
            {
                request.Parameters.Add("IncludeInstances", StringUtils.FromBool(publicRequest.IncludeInstances.Value));
            }
            if (publicRequest.IsSetIncludeManagedResources())
            {
                request.Parameters.Add("IncludeManagedResources", StringUtils.FromBool(publicRequest.IncludeManagedResources.Value));
            }
            if (publicRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(publicRequest.MaxRecords.Value));
            }
            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly DescribeAutoScalingGroupsRequestMarshaller _instance = new();

        internal static DescribeAutoScalingGroupsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeAutoScalingGroupsRequestMarshaller Instance => _instance;
    }
}
