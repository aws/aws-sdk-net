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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutMetricAlarm Request Marshaller
    /// </summary>       
    public class PutMetricAlarmRequestMarshaller : IMarshaller<IRequest, PutMetricAlarmRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutMetricAlarmRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutMetricAlarmRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatch");
            request.Parameters.Add("Action", "PutMetricAlarm");
            request.Parameters.Add("Version", "2010-08-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetActionsEnabled())
                {
                    request.Parameters.Add("ActionsEnabled", StringUtils.FromBool(publicRequest.ActionsEnabled));
                }
                if(publicRequest.IsSetAlarmActions())
                {
                    if (publicRequest.AlarmActions.Count == 0)
                        request.Parameters.Add("AlarmActions", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.AlarmActions)
                         {
                             request.Parameters.Add("AlarmActions" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetAlarmDescription())
                {
                    request.Parameters.Add("AlarmDescription", StringUtils.FromString(publicRequest.AlarmDescription));
                }
                if(publicRequest.IsSetAlarmName())
                {
                    request.Parameters.Add("AlarmName", StringUtils.FromString(publicRequest.AlarmName));
                }
                if(publicRequest.IsSetComparisonOperator())
                {
                    request.Parameters.Add("ComparisonOperator", StringUtils.FromString(publicRequest.ComparisonOperator));
                }
                if(publicRequest.IsSetDatapointsToAlarm())
                {
                    request.Parameters.Add("DatapointsToAlarm", StringUtils.FromInt(publicRequest.DatapointsToAlarm));
                }
                if(publicRequest.IsSetDimensions())
                {
                    if (publicRequest.Dimensions.Count == 0)
                        request.Parameters.Add("Dimensions", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Dimensions)
                         {
                            if(publicRequestlistValue.IsSetName())
                            {
                                request.Parameters.Add("Dimensions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Name", StringUtils.FromString(publicRequestlistValue.Name));
                            }
                            if(publicRequestlistValue.IsSetValue())
                            {
                                request.Parameters.Add("Dimensions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetEvaluateLowSampleCountPercentile())
                {
                    request.Parameters.Add("EvaluateLowSampleCountPercentile", StringUtils.FromString(publicRequest.EvaluateLowSampleCountPercentile));
                }
                if(publicRequest.IsSetEvaluationPeriods())
                {
                    request.Parameters.Add("EvaluationPeriods", StringUtils.FromInt(publicRequest.EvaluationPeriods));
                }
                if(publicRequest.IsSetExtendedStatistic())
                {
                    request.Parameters.Add("ExtendedStatistic", StringUtils.FromString(publicRequest.ExtendedStatistic));
                }
                if(publicRequest.IsSetInsufficientDataActions())
                {
                    if (publicRequest.InsufficientDataActions.Count == 0)
                        request.Parameters.Add("InsufficientDataActions", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.InsufficientDataActions)
                         {
                             request.Parameters.Add("InsufficientDataActions" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetMetricName())
                {
                    request.Parameters.Add("MetricName", StringUtils.FromString(publicRequest.MetricName));
                }
                if(publicRequest.IsSetMetrics())
                {
                    if (publicRequest.Metrics.Count == 0)
                        request.Parameters.Add("Metrics", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Metrics)
                         {
                            if(publicRequestlistValue.IsSetAccountId())
                            {
                                request.Parameters.Add("Metrics" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AccountId", StringUtils.FromString(publicRequestlistValue.AccountId));
                            }
                            if(publicRequestlistValue.IsSetExpression())
                            {
                                request.Parameters.Add("Metrics" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Expression", StringUtils.FromString(publicRequestlistValue.Expression));
                            }
                            if(publicRequestlistValue.IsSetId())
                            {
                                request.Parameters.Add("Metrics" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Id", StringUtils.FromString(publicRequestlistValue.Id));
                            }
                            if(publicRequestlistValue.IsSetLabel())
                            {
                                request.Parameters.Add("Metrics" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Label", StringUtils.FromString(publicRequestlistValue.Label));
                            }
                            if(publicRequestlistValue.IsSetMetricStat())
                            {
                                if(publicRequestlistValue.MetricStat.IsSetMetric())
                                {
                                    if(publicRequestlistValue.MetricStat.Metric.IsSetDimensions())
                                    {
                                        if (publicRequestlistValue.MetricStat.Metric.Dimensions.Count == 0)
                                            request.Parameters.Add("Metrics" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "Dimensions", "");
                                        else
                                        {
                                             int publicRequestlistValueMetricStatMetriclistValueIndex = 1;
                                             foreach(var publicRequestlistValueMetricStatMetriclistValue in publicRequestlistValue.MetricStat.Metric.Dimensions)
                                             {
                                                if(publicRequestlistValueMetricStatMetriclistValue.IsSetName())
                                                {
                                                    request.Parameters.Add("Metrics" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "Dimensions" + "." + "member" + "." + publicRequestlistValueMetricStatMetriclistValueIndex + "." + "Name", StringUtils.FromString(publicRequestlistValueMetricStatMetriclistValue.Name));
                                                }
                                                if(publicRequestlistValueMetricStatMetriclistValue.IsSetValue())
                                                {
                                                    request.Parameters.Add("Metrics" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "Dimensions" + "." + "member" + "." + publicRequestlistValueMetricStatMetriclistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValueMetricStatMetriclistValue.Value));
                                                }
                                                 publicRequestlistValueMetricStatMetriclistValueIndex++;
                                             }
                                        }
                                    }
                                    if(publicRequestlistValue.MetricStat.Metric.IsSetMetricName())
                                    {
                                        request.Parameters.Add("Metrics" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "MetricName", StringUtils.FromString(publicRequestlistValue.MetricStat.Metric.MetricName));
                                    }
                                    if(publicRequestlistValue.MetricStat.Metric.IsSetNamespace())
                                    {
                                        request.Parameters.Add("Metrics" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "Namespace", StringUtils.FromString(publicRequestlistValue.MetricStat.Metric.Namespace));
                                    }
                                }
                                if(publicRequestlistValue.MetricStat.IsSetPeriod())
                                {
                                    request.Parameters.Add("Metrics" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricStat" + "." + "Period", StringUtils.FromInt(publicRequestlistValue.MetricStat.Period));
                                }
                                if(publicRequestlistValue.MetricStat.IsSetStat())
                                {
                                    request.Parameters.Add("Metrics" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricStat" + "." + "Stat", StringUtils.FromString(publicRequestlistValue.MetricStat.Stat));
                                }
                                if(publicRequestlistValue.MetricStat.IsSetUnit())
                                {
                                    request.Parameters.Add("Metrics" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricStat" + "." + "Unit", StringUtils.FromString(publicRequestlistValue.MetricStat.Unit));
                                }
                            }
                            if(publicRequestlistValue.IsSetPeriod())
                            {
                                request.Parameters.Add("Metrics" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Period", StringUtils.FromInt(publicRequestlistValue.Period));
                            }
                            if(publicRequestlistValue.IsSetReturnData())
                            {
                                request.Parameters.Add("Metrics" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ReturnData", StringUtils.FromBool(publicRequestlistValue.ReturnData));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetNamespace())
                {
                    request.Parameters.Add("Namespace", StringUtils.FromString(publicRequest.Namespace));
                }
                if(publicRequest.IsSetOKActions())
                {
                    if (publicRequest.OKActions.Count == 0)
                        request.Parameters.Add("OKActions", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.OKActions)
                         {
                             request.Parameters.Add("OKActions" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetPeriod())
                {
                    request.Parameters.Add("Period", StringUtils.FromInt(publicRequest.Period));
                }
                if(publicRequest.IsSetStatistic())
                {
                    request.Parameters.Add("Statistic", StringUtils.FromString(publicRequest.Statistic));
                }
                if(publicRequest.IsSetTags())
                {
                    if (publicRequest.Tags.Count == 0)
                        request.Parameters.Add("Tags", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Tags)
                         {
                            if(publicRequestlistValue.IsSetKey())
                            {
                                request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValue.Key));
                            }
                            if(publicRequestlistValue.IsSetValue())
                            {
                                request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetThreshold())
                {
                    request.Parameters.Add("Threshold", StringUtils.FromDouble(publicRequest.Threshold));
                }
                if(publicRequest.IsSetThresholdMetricId())
                {
                    request.Parameters.Add("ThresholdMetricId", StringUtils.FromString(publicRequest.ThresholdMetricId));
                }
                if(publicRequest.IsSetTreatMissingData())
                {
                    request.Parameters.Add("TreatMissingData", StringUtils.FromString(publicRequest.TreatMissingData));
                }
                if(publicRequest.IsSetUnit())
                {
                    request.Parameters.Add("Unit", StringUtils.FromString(publicRequest.Unit));
                }
            }
            return request;
        }
                    private static PutMetricAlarmRequestMarshaller _instance = new PutMetricAlarmRequestMarshaller();        

        internal static PutMetricAlarmRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutMetricAlarmRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}