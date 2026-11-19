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

using Amazon.EC2.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeScheduledInstances Request Marshaller
    /// </summary>
    public partial class DescribeScheduledInstancesRequestMarshaller : IMarshaller<IRequest, DescribeScheduledInstancesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeScheduledInstancesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribeScheduledInstancesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "DescribeScheduledInstances");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetFilters())
            {
                if (publicRequest.Filters.Count == 0)
                {
                    request.Parameters.Add("Filter", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Filters)
                    {
                        if (item0.IsSetName())
                        {
                            request.Parameters.Add("Filter" + "." + index0 + ".Name", StringUtils.FromString(item0.Name));
                        }
                        if (item0.IsSetValues())
                        {
                            if (item0.Values.Count == 0)
                            {
                                request.Parameters.Add("Filter" + "." + index0 + ".Value", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Values)
                                {
                                    request.Parameters.Add("Filter" + "." + index0 + ".Value" + "." + index1, StringUtils.FromString(item1));
                                    index1++;
                                }
                            }
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }
            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            }
            if (publicRequest.IsSetScheduledInstanceIds())
            {
                if (publicRequest.ScheduledInstanceIds.Count == 0)
                {
                    request.Parameters.Add("ScheduledInstanceId", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ScheduledInstanceIds)
                    {
                        request.Parameters.Add("ScheduledInstanceId" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetSlotStartTimeRange())
            {
                if (publicRequest.SlotStartTimeRange.IsSetEarliestTime())
                {
                    request.Parameters.Add("SlotStartTimeRange" + ".EarliestTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.SlotStartTimeRange.EarliestTime.Value));
                }
                if (publicRequest.SlotStartTimeRange.IsSetLatestTime())
                {
                    request.Parameters.Add("SlotStartTimeRange" + ".LatestTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.SlotStartTimeRange.LatestTime.Value));
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly DescribeScheduledInstancesRequestMarshaller _instance = new();

        internal static DescribeScheduledInstancesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeScheduledInstancesRequestMarshaller Instance => _instance;
    }
}
