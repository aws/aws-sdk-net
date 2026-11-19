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
    /// GetCapacityManagerMetricDimensions Request Marshaller
    /// </summary>
    public partial class GetCapacityManagerMetricDimensionsRequestMarshaller : IMarshaller<IRequest, GetCapacityManagerMetricDimensionsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetCapacityManagerMetricDimensionsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetCapacityManagerMetricDimensionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "GetCapacityManagerMetricDimensions");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetEndTime())
            {
                request.Parameters.Add("EndTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndTime.Value));
            }
            if (publicRequest.IsSetFilterBy())
            {
                if (publicRequest.FilterBy.Count == 0)
                {
                    request.Parameters.Add("FilterBy", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.FilterBy)
                    {
                        if (item0.IsSetDimensionCondition())
                        {
                            if (item0.DimensionCondition.IsSetComparison())
                            {
                                request.Parameters.Add("FilterBy" + "." + index0 + ".DimensionCondition" + ".Comparison", StringUtils.FromString(item0.DimensionCondition.Comparison));
                            }
                            if (item0.DimensionCondition.IsSetDimension())
                            {
                                request.Parameters.Add("FilterBy" + "." + index0 + ".DimensionCondition" + ".Dimension", StringUtils.FromString(item0.DimensionCondition.Dimension));
                            }
                            if (item0.DimensionCondition.IsSetValues())
                            {
                                if (item0.DimensionCondition.Values.Count == 0)
                                {
                                    request.Parameters.Add("FilterBy" + "." + index0 + ".DimensionCondition" + ".Value", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item0.DimensionCondition.Values)
                                    {
                                        request.Parameters.Add("FilterBy" + "." + index0 + ".DimensionCondition" + ".Value" + "." + index2, StringUtils.FromString(item2));
                                        index2++;
                                    }
                                }
                            }
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetGroupBy())
            {
                if (publicRequest.GroupBy.Count == 0)
                {
                    request.Parameters.Add("GroupBy", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.GroupBy)
                    {
                        request.Parameters.Add("GroupBy" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }
            if (publicRequest.IsSetMetricNames())
            {
                if (publicRequest.MetricNames.Count == 0)
                {
                    request.Parameters.Add("MetricName", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.MetricNames)
                    {
                        request.Parameters.Add("MetricName" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            }
            if (publicRequest.IsSetStartTime())
            {
                request.Parameters.Add("StartTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartTime.Value));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly GetCapacityManagerMetricDimensionsRequestMarshaller _instance = new();

        internal static GetCapacityManagerMetricDimensionsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetCapacityManagerMetricDimensionsRequestMarshaller Instance => _instance;
    }
}
