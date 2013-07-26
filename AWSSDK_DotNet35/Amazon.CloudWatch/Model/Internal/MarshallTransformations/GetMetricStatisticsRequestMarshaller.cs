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
    /// Get Metric Statistics Request Marshaller
    /// </summary>       
    public class GetMetricStatisticsRequestMarshaller : IMarshaller<IRequest, GetMetricStatisticsRequest>
    {
        public IRequest Marshall(GetMetricStatisticsRequest getMetricStatisticsRequest)
        {
            IRequest request = new DefaultRequest(getMetricStatisticsRequest, "AmazonCloudWatch");
            request.Parameters.Add("Action", "GetMetricStatistics");
            request.Parameters.Add("Version", "2010-08-01");
            if (getMetricStatisticsRequest != null && getMetricStatisticsRequest.IsSetNamespace())
            {
                request.Parameters.Add("Namespace", StringUtils.FromString(getMetricStatisticsRequest.Namespace));
            }
            if (getMetricStatisticsRequest != null && getMetricStatisticsRequest.IsSetMetricName())
            {
                request.Parameters.Add("MetricName", StringUtils.FromString(getMetricStatisticsRequest.MetricName));
            }

            if (getMetricStatisticsRequest != null)
            {
                List<Dimension> dimensionsList = getMetricStatisticsRequest.Dimensions;
                int dimensionsListIndex = 1;
                foreach (Dimension dimensionsListValue in dimensionsList)
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
            if (getMetricStatisticsRequest != null && getMetricStatisticsRequest.IsSetStartTime())
            {
                request.Parameters.Add("StartTime", StringUtils.FromDateTime(getMetricStatisticsRequest.StartTime));
            }
            if (getMetricStatisticsRequest != null && getMetricStatisticsRequest.IsSetEndTime())
            {
                request.Parameters.Add("EndTime", StringUtils.FromDateTime(getMetricStatisticsRequest.EndTime));
            }
            if (getMetricStatisticsRequest != null && getMetricStatisticsRequest.IsSetPeriod())
            {
                request.Parameters.Add("Period", StringUtils.FromInt(getMetricStatisticsRequest.Period));
            }
            if (getMetricStatisticsRequest != null)
            {
                List<string> statisticsList = getMetricStatisticsRequest.Statistics;

                int statisticsListIndex = 1;
                foreach (string statisticsListValue in statisticsList)
                { 
                    request.Parameters.Add("Statistics.member." + statisticsListIndex, StringUtils.FromString(statisticsListValue));
                    statisticsListIndex++;
                }
            }
            if (getMetricStatisticsRequest != null && getMetricStatisticsRequest.IsSetUnit())
            {
                request.Parameters.Add("Unit", StringUtils.FromString(getMetricStatisticsRequest.Unit));
            }

            return request;
        }
    }
}
