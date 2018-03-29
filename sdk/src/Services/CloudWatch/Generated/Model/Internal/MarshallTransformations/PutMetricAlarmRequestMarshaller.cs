/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.AlarmActions)
                    {
                        request.Parameters.Add("AlarmActions" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
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
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.InsufficientDataActions)
                    {
                        request.Parameters.Add("InsufficientDataActions" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
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
                if(publicRequest.IsSetOKActions())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.OKActions)
                    {
                        request.Parameters.Add("OKActions" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
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
                if(publicRequest.IsSetThreshold())
                {
                    request.Parameters.Add("Threshold", StringUtils.FromDouble(publicRequest.Threshold));
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