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
    /// Put Metric Data Request Marshaller
    /// </summary>       
    public class PutMetricDataRequestMarshaller : IMarshaller<IRequest, PutMetricDataRequest>
    {
        public IRequest Marshall(PutMetricDataRequest putMetricDataRequest)
        {
            IRequest request = new DefaultRequest(putMetricDataRequest, "AmazonCloudWatch");
            request.Parameters.Add("Action", "PutMetricData");
            request.Parameters.Add("Version", "2010-08-01");
            if (putMetricDataRequest != null && putMetricDataRequest.IsSetNamespace())
            {
                request.Parameters.Add("Namespace", StringUtils.FromString(putMetricDataRequest.Namespace));
            }

            if (putMetricDataRequest != null)
            {
                List<MetricDatum> metricDataList = putMetricDataRequest.MetricData;
                int metricDataListIndex = 1;
                foreach (MetricDatum metricDataListValue in metricDataList)
                {
                    if (metricDataListValue != null && metricDataListValue.IsSetMetricName())
                    {
                        request.Parameters.Add("MetricData.member." + metricDataListIndex + ".MetricName", StringUtils.FromString(metricDataListValue.MetricName));
                    }

                    if (metricDataListValue != null)
                    {
                        List<Dimension> dimensionsList = metricDataListValue.Dimensions;
                        int dimensionsListIndex = 1;
                        foreach (Dimension dimensionsListValue in dimensionsList)
                        {
                            if (dimensionsListValue != null && dimensionsListValue.IsSetName())
                            {
                                request.Parameters.Add("MetricData.member." + metricDataListIndex + ".Dimensions.member." + dimensionsListIndex + ".Name", StringUtils.FromString(dimensionsListValue.Name));
                            }
                            if (dimensionsListValue != null && dimensionsListValue.IsSetValue())
                            {
                                request.Parameters.Add("MetricData.member." + metricDataListIndex + ".Dimensions.member." + dimensionsListIndex + ".Value", StringUtils.FromString(dimensionsListValue.Value));
                            }

                            dimensionsListIndex++;
                        }
                    }
                    if (metricDataListValue != null && metricDataListValue.IsSetTimestamp())
                    {
                        request.Parameters.Add("MetricData.member." + metricDataListIndex + ".Timestamp", StringUtils.FromDateTime(metricDataListValue.Timestamp));
                    }
                    if (metricDataListValue != null && metricDataListValue.IsSetValue())
                    {
                        request.Parameters.Add("MetricData.member." + metricDataListIndex + ".Value", StringUtils.FromDouble(metricDataListValue.Value));
                    }
                    if (metricDataListValue != null)
                    {
                        StatisticSet statisticValues = metricDataListValue.StatisticValues;
                        if (statisticValues != null && statisticValues.IsSetSampleCount())
                        {
                            request.Parameters.Add("MetricData.member." + metricDataListIndex + ".StatisticValues.SampleCount", StringUtils.FromDouble(statisticValues.SampleCount));
                        }
                        if (statisticValues != null && statisticValues.IsSetSum())
                        {
                            request.Parameters.Add("MetricData.member." + metricDataListIndex + ".StatisticValues.Sum", StringUtils.FromDouble(statisticValues.Sum));
                        }
                        if (statisticValues != null && statisticValues.IsSetMinimum())
                        {
                            request.Parameters.Add("MetricData.member." + metricDataListIndex + ".StatisticValues.Minimum", StringUtils.FromDouble(statisticValues.Minimum));
                        }
                        if (statisticValues != null && statisticValues.IsSetMaximum())
                        {
                            request.Parameters.Add("MetricData.member." + metricDataListIndex + ".StatisticValues.Maximum", StringUtils.FromDouble(statisticValues.Maximum));
                        }
                    }
                    if (metricDataListValue != null && metricDataListValue.IsSetUnit())
                    {
                        request.Parameters.Add("MetricData.member." + metricDataListIndex + ".Unit", StringUtils.FromString(metricDataListValue.Unit));
                    }

                    metricDataListIndex++;
                }
            }

            return request;
        }
    }
}
