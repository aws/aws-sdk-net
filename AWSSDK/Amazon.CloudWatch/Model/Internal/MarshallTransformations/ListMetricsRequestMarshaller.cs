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

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// List Metrics Request Marshaller
    /// </summary>       
    public class ListMetricsRequestMarshaller : IMarshaller<IRequest, ListMetricsRequest>
    {
        public IRequest Marshall(ListMetricsRequest listMetricsRequest)
        {
            IRequest request = new DefaultRequest(listMetricsRequest, "AmazonCloudWatch");
            request.Parameters.Add("Action", "ListMetrics");
            request.Parameters.Add("Version", "2010-08-01");
            if (listMetricsRequest != null && listMetricsRequest.IsSetNamespace())
            {
                request.Parameters.Add("Namespace", StringUtils.FromString(listMetricsRequest.Namespace));
            }
            if (listMetricsRequest != null && listMetricsRequest.IsSetMetricName())
            {
                request.Parameters.Add("MetricName", StringUtils.FromString(listMetricsRequest.MetricName));
            }

            if (listMetricsRequest != null)
            {
                List<DimensionFilter> dimensionsList = listMetricsRequest.Dimensions;
                int dimensionsListIndex = 1;
                foreach (DimensionFilter dimensionsListValue in dimensionsList)
                {
                    if (dimensionsListValue != null && dimensionsListValue.IsSetName())
                    {
                        request.Parameters.Add("Dimensions.member." + dimensionsListIndex + ".Name", StringUtils.FromString(dimensionsListValue.Name));
                    }
                    if (dimensionsListValue != null && dimensionsListValue.IsSetValue())
                    {
                        request.Parameters.Add("Dimensions.member." + dimensionsListIndex + ".Value", StringUtils.FromString(dimensionsListValue.Value));
                    }

                    dimensionsListIndex++;
                }
            }
            if (listMetricsRequest != null && listMetricsRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(listMetricsRequest.NextToken));
            }

            return request;
        }
    }
}
