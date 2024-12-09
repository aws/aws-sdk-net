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
    /// GetMetricData Request Marshaller
    /// </summary>       
    public class GetMetricDataRequestMarshaller : IMarshaller<IRequest, GetMetricDataRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetMetricDataRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetMetricDataRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatch");
            request.Parameters.Add("Action", "GetMetricData");
            request.Parameters.Add("Version", "2010-08-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetEndTime())
                {
                    request.Parameters.Add("EndTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndTime));
                }
                if(publicRequest.IsSetLabelOptions())
                {
                    if(publicRequest.LabelOptions.IsSetTimezone())
                    {
                        request.Parameters.Add("LabelOptions" + "." + "Timezone", StringUtils.FromString(publicRequest.LabelOptions.Timezone));
                    }
                }
                if(publicRequest.IsSetMaxDatapoints())
                {
                    request.Parameters.Add("MaxDatapoints", StringUtils.FromInt(publicRequest.MaxDatapoints));
                }
                if(publicRequest.IsSetMetricDataQueries())
                {
                    if (publicRequest.MetricDataQueries.Count == 0)
                        request.Parameters.Add("MetricDataQueries", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.MetricDataQueries)
                         {
                            if(publicRequestlistValue.IsSetAccountId())
                            {
                                request.Parameters.Add("MetricDataQueries" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AccountId", StringUtils.FromString(publicRequestlistValue.AccountId));
                            }
                            if(publicRequestlistValue.IsSetExpression())
                            {
                                request.Parameters.Add("MetricDataQueries" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Expression", StringUtils.FromString(publicRequestlistValue.Expression));
                            }
                            if(publicRequestlistValue.IsSetId())
                            {
                                request.Parameters.Add("MetricDataQueries" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Id", StringUtils.FromString(publicRequestlistValue.Id));
                            }
                            if(publicRequestlistValue.IsSetLabel())
                            {
                                request.Parameters.Add("MetricDataQueries" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Label", StringUtils.FromString(publicRequestlistValue.Label));
                            }
                            if(publicRequestlistValue.IsSetMetricStat())
                            {
                                if(publicRequestlistValue.MetricStat.IsSetMetric())
                                {
                                    if(publicRequestlistValue.MetricStat.Metric.IsSetDimensions())
                                    {
                                        if (publicRequestlistValue.MetricStat.Metric.Dimensions.Count == 0)
                                            request.Parameters.Add("MetricDataQueries" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "Dimensions", "");
                                        else
                                        {
                                             int publicRequestlistValueMetricStatMetriclistValueIndex = 1;
                                             foreach(var publicRequestlistValueMetricStatMetriclistValue in publicRequestlistValue.MetricStat.Metric.Dimensions)
                                             {
                                                if(publicRequestlistValueMetricStatMetriclistValue.IsSetName())
                                                {
                                                    request.Parameters.Add("MetricDataQueries" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "Dimensions" + "." + "member" + "." + publicRequestlistValueMetricStatMetriclistValueIndex + "." + "Name", StringUtils.FromString(publicRequestlistValueMetricStatMetriclistValue.Name));
                                                }
                                                if(publicRequestlistValueMetricStatMetriclistValue.IsSetValue())
                                                {
                                                    request.Parameters.Add("MetricDataQueries" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "Dimensions" + "." + "member" + "." + publicRequestlistValueMetricStatMetriclistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValueMetricStatMetriclistValue.Value));
                                                }
                                                 publicRequestlistValueMetricStatMetriclistValueIndex++;
                                             }
                                        }
                                    }
                                    if(publicRequestlistValue.MetricStat.Metric.IsSetMetricName())
                                    {
                                        request.Parameters.Add("MetricDataQueries" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "MetricName", StringUtils.FromString(publicRequestlistValue.MetricStat.Metric.MetricName));
                                    }
                                    if(publicRequestlistValue.MetricStat.Metric.IsSetNamespace())
                                    {
                                        request.Parameters.Add("MetricDataQueries" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "Namespace", StringUtils.FromString(publicRequestlistValue.MetricStat.Metric.Namespace));
                                    }
                                }
                                if(publicRequestlistValue.MetricStat.IsSetPeriod())
                                {
                                    request.Parameters.Add("MetricDataQueries" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricStat" + "." + "Period", StringUtils.FromInt(publicRequestlistValue.MetricStat.Period));
                                }
                                if(publicRequestlistValue.MetricStat.IsSetStat())
                                {
                                    request.Parameters.Add("MetricDataQueries" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricStat" + "." + "Stat", StringUtils.FromString(publicRequestlistValue.MetricStat.Stat));
                                }
                                if(publicRequestlistValue.MetricStat.IsSetUnit())
                                {
                                    request.Parameters.Add("MetricDataQueries" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricStat" + "." + "Unit", StringUtils.FromString(publicRequestlistValue.MetricStat.Unit));
                                }
                            }
                            if(publicRequestlistValue.IsSetPeriod())
                            {
                                request.Parameters.Add("MetricDataQueries" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Period", StringUtils.FromInt(publicRequestlistValue.Period));
                            }
                            if(publicRequestlistValue.IsSetReturnData())
                            {
                                request.Parameters.Add("MetricDataQueries" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ReturnData", StringUtils.FromBool(publicRequestlistValue.ReturnData));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetNextToken())
                {
                    request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
                }
                if(publicRequest.IsSetScanBy())
                {
                    request.Parameters.Add("ScanBy", StringUtils.FromString(publicRequest.ScanBy));
                }
                if(publicRequest.IsSetStartTime())
                {
                    request.Parameters.Add("StartTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartTime));
                }
            }
            return request;
        }
                    private static GetMetricDataRequestMarshaller _instance = new GetMetricDataRequestMarshaller();        

        internal static GetMetricDataRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetMetricDataRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}