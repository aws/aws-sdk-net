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
    /// PutAnomalyDetector Request Marshaller
    /// </summary>       
    public class PutAnomalyDetectorRequestMarshaller : IMarshaller<IRequest, PutAnomalyDetectorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutAnomalyDetectorRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutAnomalyDetectorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatch");
            request.Parameters.Add("Action", "PutAnomalyDetector");
            request.Parameters.Add("Version", "2010-08-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetConfiguration())
                {
                    if(publicRequest.Configuration.IsSetExcludedTimeRanges())
                    {
                        if (publicRequest.Configuration.ExcludedTimeRanges.Count == 0)
                            request.Parameters.Add("Configuration" + "." + "ExcludedTimeRanges", "");
                        else
                        {
                             int publicRequestConfigurationlistValueIndex = 1;
                             foreach(var publicRequestConfigurationlistValue in publicRequest.Configuration.ExcludedTimeRanges)
                             {
                                if(publicRequestConfigurationlistValue.IsSetEndTime())
                                {
                                    request.Parameters.Add("Configuration" + "." + "ExcludedTimeRanges" + "." + "member" + "." + publicRequestConfigurationlistValueIndex + "." + "EndTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequestConfigurationlistValue.EndTime));
                                }
                                if(publicRequestConfigurationlistValue.IsSetStartTime())
                                {
                                    request.Parameters.Add("Configuration" + "." + "ExcludedTimeRanges" + "." + "member" + "." + publicRequestConfigurationlistValueIndex + "." + "StartTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequestConfigurationlistValue.StartTime));
                                }
                                 publicRequestConfigurationlistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.Configuration.IsSetMetricTimezone())
                    {
                        request.Parameters.Add("Configuration" + "." + "MetricTimezone", StringUtils.FromString(publicRequest.Configuration.MetricTimezone));
                    }
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
                if(publicRequest.IsSetMetricCharacteristics())
                {
                    if(publicRequest.MetricCharacteristics.IsSetPeriodicSpikes())
                    {
                        request.Parameters.Add("MetricCharacteristics" + "." + "PeriodicSpikes", StringUtils.FromBool(publicRequest.MetricCharacteristics.PeriodicSpikes));
                    }
                }
                if(publicRequest.IsSetMetricMathAnomalyDetector())
                {
                    if(publicRequest.MetricMathAnomalyDetector.IsSetMetricDataQueries())
                    {
                        if (publicRequest.MetricMathAnomalyDetector.MetricDataQueries.Count == 0)
                            request.Parameters.Add("MetricMathAnomalyDetector" + "." + "MetricDataQueries", "");
                        else
                        {
                             int publicRequestMetricMathAnomalyDetectorlistValueIndex = 1;
                             foreach(var publicRequestMetricMathAnomalyDetectorlistValue in publicRequest.MetricMathAnomalyDetector.MetricDataQueries)
                             {
                                if(publicRequestMetricMathAnomalyDetectorlistValue.IsSetAccountId())
                                {
                                    request.Parameters.Add("MetricMathAnomalyDetector" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueIndex + "." + "AccountId", StringUtils.FromString(publicRequestMetricMathAnomalyDetectorlistValue.AccountId));
                                }
                                if(publicRequestMetricMathAnomalyDetectorlistValue.IsSetExpression())
                                {
                                    request.Parameters.Add("MetricMathAnomalyDetector" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueIndex + "." + "Expression", StringUtils.FromString(publicRequestMetricMathAnomalyDetectorlistValue.Expression));
                                }
                                if(publicRequestMetricMathAnomalyDetectorlistValue.IsSetId())
                                {
                                    request.Parameters.Add("MetricMathAnomalyDetector" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueIndex + "." + "Id", StringUtils.FromString(publicRequestMetricMathAnomalyDetectorlistValue.Id));
                                }
                                if(publicRequestMetricMathAnomalyDetectorlistValue.IsSetLabel())
                                {
                                    request.Parameters.Add("MetricMathAnomalyDetector" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueIndex + "." + "Label", StringUtils.FromString(publicRequestMetricMathAnomalyDetectorlistValue.Label));
                                }
                                if(publicRequestMetricMathAnomalyDetectorlistValue.IsSetMetricStat())
                                {
                                    if(publicRequestMetricMathAnomalyDetectorlistValue.MetricStat.IsSetMetric())
                                    {
                                        if(publicRequestMetricMathAnomalyDetectorlistValue.MetricStat.Metric.IsSetDimensions())
                                        {
                                            if (publicRequestMetricMathAnomalyDetectorlistValue.MetricStat.Metric.Dimensions.Count == 0)
                                                request.Parameters.Add("MetricMathAnomalyDetector" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "Dimensions", "");
                                            else
                                            {
                                                 int publicRequestMetricMathAnomalyDetectorlistValueMetricStatMetriclistValueIndex = 1;
                                                 foreach(var publicRequestMetricMathAnomalyDetectorlistValueMetricStatMetriclistValue in publicRequestMetricMathAnomalyDetectorlistValue.MetricStat.Metric.Dimensions)
                                                 {
                                                    if(publicRequestMetricMathAnomalyDetectorlistValueMetricStatMetriclistValue.IsSetName())
                                                    {
                                                        request.Parameters.Add("MetricMathAnomalyDetector" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "Dimensions" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueMetricStatMetriclistValueIndex + "." + "Name", StringUtils.FromString(publicRequestMetricMathAnomalyDetectorlistValueMetricStatMetriclistValue.Name));
                                                    }
                                                    if(publicRequestMetricMathAnomalyDetectorlistValueMetricStatMetriclistValue.IsSetValue())
                                                    {
                                                        request.Parameters.Add("MetricMathAnomalyDetector" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "Dimensions" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueMetricStatMetriclistValueIndex + "." + "Value", StringUtils.FromString(publicRequestMetricMathAnomalyDetectorlistValueMetricStatMetriclistValue.Value));
                                                    }
                                                     publicRequestMetricMathAnomalyDetectorlistValueMetricStatMetriclistValueIndex++;
                                                 }
                                            }
                                        }
                                        if(publicRequestMetricMathAnomalyDetectorlistValue.MetricStat.Metric.IsSetMetricName())
                                        {
                                            request.Parameters.Add("MetricMathAnomalyDetector" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "MetricName", StringUtils.FromString(publicRequestMetricMathAnomalyDetectorlistValue.MetricStat.Metric.MetricName));
                                        }
                                        if(publicRequestMetricMathAnomalyDetectorlistValue.MetricStat.Metric.IsSetNamespace())
                                        {
                                            request.Parameters.Add("MetricMathAnomalyDetector" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "Namespace", StringUtils.FromString(publicRequestMetricMathAnomalyDetectorlistValue.MetricStat.Metric.Namespace));
                                        }
                                    }
                                    if(publicRequestMetricMathAnomalyDetectorlistValue.MetricStat.IsSetPeriod())
                                    {
                                        request.Parameters.Add("MetricMathAnomalyDetector" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueIndex + "." + "MetricStat" + "." + "Period", StringUtils.FromInt(publicRequestMetricMathAnomalyDetectorlistValue.MetricStat.Period));
                                    }
                                    if(publicRequestMetricMathAnomalyDetectorlistValue.MetricStat.IsSetStat())
                                    {
                                        request.Parameters.Add("MetricMathAnomalyDetector" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueIndex + "." + "MetricStat" + "." + "Stat", StringUtils.FromString(publicRequestMetricMathAnomalyDetectorlistValue.MetricStat.Stat));
                                    }
                                    if(publicRequestMetricMathAnomalyDetectorlistValue.MetricStat.IsSetUnit())
                                    {
                                        request.Parameters.Add("MetricMathAnomalyDetector" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueIndex + "." + "MetricStat" + "." + "Unit", StringUtils.FromString(publicRequestMetricMathAnomalyDetectorlistValue.MetricStat.Unit));
                                    }
                                }
                                if(publicRequestMetricMathAnomalyDetectorlistValue.IsSetPeriod())
                                {
                                    request.Parameters.Add("MetricMathAnomalyDetector" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueIndex + "." + "Period", StringUtils.FromInt(publicRequestMetricMathAnomalyDetectorlistValue.Period));
                                }
                                if(publicRequestMetricMathAnomalyDetectorlistValue.IsSetReturnData())
                                {
                                    request.Parameters.Add("MetricMathAnomalyDetector" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestMetricMathAnomalyDetectorlistValueIndex + "." + "ReturnData", StringUtils.FromBool(publicRequestMetricMathAnomalyDetectorlistValue.ReturnData));
                                }
                                 publicRequestMetricMathAnomalyDetectorlistValueIndex++;
                             }
                        }
                    }
                }
                if(publicRequest.IsSetMetricName())
                {
                    request.Parameters.Add("MetricName", StringUtils.FromString(publicRequest.MetricName));
                }
                if(publicRequest.IsSetNamespace())
                {
                    request.Parameters.Add("Namespace", StringUtils.FromString(publicRequest.Namespace));
                }
                if(publicRequest.IsSetSingleMetricAnomalyDetector())
                {
                    if(publicRequest.SingleMetricAnomalyDetector.IsSetAccountId())
                    {
                        request.Parameters.Add("SingleMetricAnomalyDetector" + "." + "AccountId", StringUtils.FromString(publicRequest.SingleMetricAnomalyDetector.AccountId));
                    }
                    if(publicRequest.SingleMetricAnomalyDetector.IsSetDimensions())
                    {
                        if (publicRequest.SingleMetricAnomalyDetector.Dimensions.Count == 0)
                            request.Parameters.Add("SingleMetricAnomalyDetector" + "." + "Dimensions", "");
                        else
                        {
                             int publicRequestSingleMetricAnomalyDetectorlistValueIndex = 1;
                             foreach(var publicRequestSingleMetricAnomalyDetectorlistValue in publicRequest.SingleMetricAnomalyDetector.Dimensions)
                             {
                                if(publicRequestSingleMetricAnomalyDetectorlistValue.IsSetName())
                                {
                                    request.Parameters.Add("SingleMetricAnomalyDetector" + "." + "Dimensions" + "." + "member" + "." + publicRequestSingleMetricAnomalyDetectorlistValueIndex + "." + "Name", StringUtils.FromString(publicRequestSingleMetricAnomalyDetectorlistValue.Name));
                                }
                                if(publicRequestSingleMetricAnomalyDetectorlistValue.IsSetValue())
                                {
                                    request.Parameters.Add("SingleMetricAnomalyDetector" + "." + "Dimensions" + "." + "member" + "." + publicRequestSingleMetricAnomalyDetectorlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestSingleMetricAnomalyDetectorlistValue.Value));
                                }
                                 publicRequestSingleMetricAnomalyDetectorlistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.SingleMetricAnomalyDetector.IsSetMetricName())
                    {
                        request.Parameters.Add("SingleMetricAnomalyDetector" + "." + "MetricName", StringUtils.FromString(publicRequest.SingleMetricAnomalyDetector.MetricName));
                    }
                    if(publicRequest.SingleMetricAnomalyDetector.IsSetNamespace())
                    {
                        request.Parameters.Add("SingleMetricAnomalyDetector" + "." + "Namespace", StringUtils.FromString(publicRequest.SingleMetricAnomalyDetector.Namespace));
                    }
                    if(publicRequest.SingleMetricAnomalyDetector.IsSetStat())
                    {
                        request.Parameters.Add("SingleMetricAnomalyDetector" + "." + "Stat", StringUtils.FromString(publicRequest.SingleMetricAnomalyDetector.Stat));
                    }
                }
                if(publicRequest.IsSetStat())
                {
                    request.Parameters.Add("Stat", StringUtils.FromString(publicRequest.Stat));
                }
            }
            return request;
        }
                    private static PutAnomalyDetectorRequestMarshaller _instance = new PutAnomalyDetectorRequestMarshaller();        

        internal static PutAnomalyDetectorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutAnomalyDetectorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}