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
            CompressionAlgorithmUtils.SetCompressionAlgorithm(request, CompressionEncodingAlgorithm.gzip);
            request.Parameters.Add("Action", "PutMetricData");
            request.Parameters.Add("Version", "2010-08-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetEntityMetricData())
                {
                    if (publicRequest.EntityMetricData.Count == 0)
                        request.Parameters.Add("EntityMetricData", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.EntityMetricData)
                         {
                            if(publicRequestlistValue.IsSetEntity())
                            {
                                if(publicRequestlistValue.Entity.IsSetAttributes())
                                {
                                    int mapIndex = 1;
                                    foreach(var key in publicRequestlistValue.Entity.Attributes.Keys)
                                    {
                                        String value;
                                        bool hasValue = publicRequestlistValue.Entity.Attributes.TryGetValue(key, out value);
                                        request.Parameters.Add("EntityMetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Entity" + "." + "Attributes" + "." + "entry" + "." + mapIndex + "." + "key", StringUtils.FromString(key));
                                        if (hasValue)
                                        {
                                            request.Parameters.Add("EntityMetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Entity" + "." + "Attributes" + "." + "entry" + "." + mapIndex + "." + "value", StringUtils.FromString(value));
                                        }
                                        mapIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Entity.IsSetKeyAttributes())
                                {
                                    int mapIndex = 1;
                                    foreach(var key in publicRequestlistValue.Entity.KeyAttributes.Keys)
                                    {
                                        String value;
                                        bool hasValue = publicRequestlistValue.Entity.KeyAttributes.TryGetValue(key, out value);
                                        request.Parameters.Add("EntityMetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Entity" + "." + "KeyAttributes" + "." + "entry" + "." + mapIndex + "." + "key", StringUtils.FromString(key));
                                        if (hasValue)
                                        {
                                            request.Parameters.Add("EntityMetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Entity" + "." + "KeyAttributes" + "." + "entry" + "." + mapIndex + "." + "value", StringUtils.FromString(value));
                                        }
                                        mapIndex++;
                                    }
                                }
                            }
                            if(publicRequestlistValue.IsSetMetricData())
                            {
                                if (publicRequestlistValue.MetricData.Count == 0)
                                    request.Parameters.Add("EntityMetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricData", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.MetricData)
                                     {
                                        if(publicRequestlistValuelistValue.IsSetCounts())
                                        {
                                            if (publicRequestlistValuelistValue.Counts.Count == 0)
                                                request.Parameters.Add("EntityMetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricData" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "Counts", "");
                                            else
                                            {
                                                 int publicRequestlistValuelistValuelistValueIndex = 1;
                                                 foreach(var publicRequestlistValuelistValuelistValue in publicRequestlistValuelistValue.Counts)
                                                 {
                                                     request.Parameters.Add("EntityMetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricData" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "Counts" + "." + "member" + "." + publicRequestlistValuelistValuelistValueIndex, StringUtils.FromDouble(publicRequestlistValuelistValuelistValue));
                                                     publicRequestlistValuelistValuelistValueIndex++;
                                                 }
                                            }
                                        }
                                        if(publicRequestlistValuelistValue.IsSetDimensions())
                                        {
                                            if (publicRequestlistValuelistValue.Dimensions.Count == 0)
                                                request.Parameters.Add("EntityMetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricData" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "Dimensions", "");
                                            else
                                            {
                                                 int publicRequestlistValuelistValuelistValueIndex = 1;
                                                 foreach(var publicRequestlistValuelistValuelistValue in publicRequestlistValuelistValue.Dimensions)
                                                 {
                                                    if(publicRequestlistValuelistValuelistValue.IsSetName())
                                                    {
                                                        request.Parameters.Add("EntityMetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricData" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "Dimensions" + "." + "member" + "." + publicRequestlistValuelistValuelistValueIndex + "." + "Name", StringUtils.FromString(publicRequestlistValuelistValuelistValue.Name));
                                                    }
                                                    if(publicRequestlistValuelistValuelistValue.IsSetValue())
                                                    {
                                                        request.Parameters.Add("EntityMetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricData" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "Dimensions" + "." + "member" + "." + publicRequestlistValuelistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValuelistValuelistValue.Value));
                                                    }
                                                     publicRequestlistValuelistValuelistValueIndex++;
                                                 }
                                            }
                                        }
                                        if(publicRequestlistValuelistValue.IsSetMetricName())
                                        {
                                            request.Parameters.Add("EntityMetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricData" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "MetricName", StringUtils.FromString(publicRequestlistValuelistValue.MetricName));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetStatisticValues())
                                        {
                                            if(publicRequestlistValuelistValue.StatisticValues.IsSetMaximum())
                                            {
                                                request.Parameters.Add("EntityMetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricData" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "StatisticValues" + "." + "Maximum", StringUtils.FromDouble(publicRequestlistValuelistValue.StatisticValues.Maximum));
                                            }
                                            if(publicRequestlistValuelistValue.StatisticValues.IsSetMinimum())
                                            {
                                                request.Parameters.Add("EntityMetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricData" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "StatisticValues" + "." + "Minimum", StringUtils.FromDouble(publicRequestlistValuelistValue.StatisticValues.Minimum));
                                            }
                                            if(publicRequestlistValuelistValue.StatisticValues.IsSetSampleCount())
                                            {
                                                request.Parameters.Add("EntityMetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricData" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "StatisticValues" + "." + "SampleCount", StringUtils.FromDouble(publicRequestlistValuelistValue.StatisticValues.SampleCount));
                                            }
                                            if(publicRequestlistValuelistValue.StatisticValues.IsSetSum())
                                            {
                                                request.Parameters.Add("EntityMetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricData" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "StatisticValues" + "." + "Sum", StringUtils.FromDouble(publicRequestlistValuelistValue.StatisticValues.Sum));
                                            }
                                        }
                                        if(publicRequestlistValuelistValue.IsSetStorageResolution())
                                        {
                                            request.Parameters.Add("EntityMetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricData" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "StorageResolution", StringUtils.FromInt(publicRequestlistValuelistValue.StorageResolution));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetTimestamp())
                                        {
                                            request.Parameters.Add("EntityMetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricData" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "Timestamp", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequestlistValuelistValue.Timestamp));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetUnit())
                                        {
                                            request.Parameters.Add("EntityMetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricData" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "Unit", StringUtils.FromString(publicRequestlistValuelistValue.Unit));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetValue())
                                        {
                                            request.Parameters.Add("EntityMetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricData" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "Value", StringUtils.FromDouble(publicRequestlistValuelistValue.Value));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetValues())
                                        {
                                            if (publicRequestlistValuelistValue.Values.Count == 0)
                                                request.Parameters.Add("EntityMetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricData" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "Values", "");
                                            else
                                            {
                                                 int publicRequestlistValuelistValuelistValueIndex = 1;
                                                 foreach(var publicRequestlistValuelistValuelistValue in publicRequestlistValuelistValue.Values)
                                                 {
                                                     request.Parameters.Add("EntityMetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricData" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "Values" + "." + "member" + "." + publicRequestlistValuelistValuelistValueIndex, StringUtils.FromDouble(publicRequestlistValuelistValuelistValue));
                                                     publicRequestlistValuelistValuelistValueIndex++;
                                                 }
                                            }
                                        }
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetMetricData())
                {
                    if (publicRequest.MetricData.Count == 0)
                        request.Parameters.Add("MetricData", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.MetricData)
                         {
                            if(publicRequestlistValue.IsSetCounts())
                            {
                                if (publicRequestlistValue.Counts.Count == 0)
                                    request.Parameters.Add("MetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Counts", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Counts)
                                     {
                                         request.Parameters.Add("MetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Counts" + "." + "member" + "." + publicRequestlistValuelistValueIndex, StringUtils.FromDouble(publicRequestlistValuelistValue));
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                            if(publicRequestlistValue.IsSetDimensions())
                            {
                                if (publicRequestlistValue.Dimensions.Count == 0)
                                    request.Parameters.Add("MetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Dimensions", "");
                                else
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
                                request.Parameters.Add("MetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Timestamp", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequestlistValue.Timestamp));
                            }
                            if(publicRequestlistValue.IsSetUnit())
                            {
                                request.Parameters.Add("MetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Unit", StringUtils.FromString(publicRequestlistValue.Unit));
                            }
                            if(publicRequestlistValue.IsSetValue())
                            {
                                request.Parameters.Add("MetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromDouble(publicRequestlistValue.Value));
                            }
                            if(publicRequestlistValue.IsSetValues())
                            {
                                if (publicRequestlistValue.Values.Count == 0)
                                    request.Parameters.Add("MetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Values", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Values)
                                     {
                                         request.Parameters.Add("MetricData" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Values" + "." + "member" + "." + publicRequestlistValuelistValueIndex, StringUtils.FromDouble(publicRequestlistValuelistValue));
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetNamespace())
                {
                    request.Parameters.Add("Namespace", StringUtils.FromString(publicRequest.Namespace));
                }
                if(publicRequest.IsSetStrictEntityValidation())
                {
                    request.Parameters.Add("StrictEntityValidation", StringUtils.FromBool(publicRequest.StrictEntityValidation));
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