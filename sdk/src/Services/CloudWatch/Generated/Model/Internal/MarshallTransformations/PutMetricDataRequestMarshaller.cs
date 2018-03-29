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
    /// PutMetricData Request Marshaller
    /// </summary>       
    public class PutMetricDataRequestMarshaller : IMarshaller<IRequest, PutMetricDataRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutMetricDataRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutMetricDataRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatch");
            request.Parameters.Add("Action", "PutMetricData");
            request.Parameters.Add("Version", "2010-08-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetMetricData())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.MetricData)
                    {
                        if(publicRequestlistValue.IsSetDimensions())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Dimensions)
                            {
                                if(publicRequestlistValuelistValue.IsSetName())
                                {
                                    request.Parameters.Add("MetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Dimensions" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "Name", StringUtils.FromString(publicRequestlistValuelistValue.Name));
                                }
                                if(publicRequestlistValuelistValue.IsSetValue())
                                {
                                    request.Parameters.Add("MetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Dimensions" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValuelistValue.Value));
                                }
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
                        if(publicRequestlistValue.IsSetMetricName())
                        {
                            request.Parameters.Add("MetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricName", StringUtils.FromString(publicRequestlistValue.MetricName));
                        }
                        if(publicRequestlistValue.IsSetStatisticValues())
                        {
                            if(publicRequestlistValue.StatisticValues.IsSetMaximum())
                            {
                                request.Parameters.Add("MetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "StatisticValues" + "." + "Maximum", StringUtils.FromDouble(publicRequestlistValue.StatisticValues.Maximum));
                            }
                            if(publicRequestlistValue.StatisticValues.IsSetMinimum())
                            {
                                request.Parameters.Add("MetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "StatisticValues" + "." + "Minimum", StringUtils.FromDouble(publicRequestlistValue.StatisticValues.Minimum));
                            }
                            if(publicRequestlistValue.StatisticValues.IsSetSampleCount())
                            {
                                request.Parameters.Add("MetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "StatisticValues" + "." + "SampleCount", StringUtils.FromDouble(publicRequestlistValue.StatisticValues.SampleCount));
                            }
                            if(publicRequestlistValue.StatisticValues.IsSetSum())
                            {
                                request.Parameters.Add("MetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "StatisticValues" + "." + "Sum", StringUtils.FromDouble(publicRequestlistValue.StatisticValues.Sum));
                            }
                        }
                        if(publicRequestlistValue.IsSetStorageResolution())
                        {
                            request.Parameters.Add("MetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "StorageResolution", StringUtils.FromInt(publicRequestlistValue.StorageResolution));
                        }
                        if(publicRequestlistValue.IsSetTimestamp())
                        {
                            request.Parameters.Add("MetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Timestamp", StringUtils.FromDateTime(publicRequestlistValue.Timestamp));
                        }
                        if(publicRequestlistValue.IsSetUnit())
                        {
                            request.Parameters.Add("MetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Unit", StringUtils.FromString(publicRequestlistValue.Unit));
                        }
                        if(publicRequestlistValue.IsSetValue())
                        {
                            request.Parameters.Add("MetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromDouble(publicRequestlistValue.Value));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetNamespace())
                {
                    request.Parameters.Add("Namespace", StringUtils.FromString(publicRequest.Namespace));
                }
            }
            return request;
        }
                    private static PutMetricDataRequestMarshaller _instance = new PutMetricDataRequestMarshaller();        

        internal static PutMetricDataRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutMetricDataRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}