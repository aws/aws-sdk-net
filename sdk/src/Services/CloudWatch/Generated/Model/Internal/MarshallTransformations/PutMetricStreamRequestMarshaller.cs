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
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutMetricStream Request Marshaller
    /// </summary>       
    public class PutMetricStreamRequestMarshaller : IMarshaller<IRequest, PutMetricStreamRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutMetricStreamRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutMetricStreamRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatch");
            request.Parameters.Add("Action", "PutMetricStream");
            request.Parameters.Add("Version", "2010-08-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetExcludeFilters())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.ExcludeFilters)
                    {
                        if(publicRequestlistValue.IsSetNamespace())
                        {
                            request.Parameters.Add("ExcludeFilters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Namespace", StringUtils.FromString(publicRequestlistValue.Namespace));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetFirehoseArn())
                {
                    request.Parameters.Add("FirehoseArn", StringUtils.FromString(publicRequest.FirehoseArn));
                }
                if(publicRequest.IsSetIncludeFilters())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.IncludeFilters)
                    {
                        if(publicRequestlistValue.IsSetNamespace())
                        {
                            request.Parameters.Add("IncludeFilters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Namespace", StringUtils.FromString(publicRequestlistValue.Namespace));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetIncludeLinkedAccountsMetrics())
                {
                    request.Parameters.Add("IncludeLinkedAccountsMetrics", StringUtils.FromBool(publicRequest.IncludeLinkedAccountsMetrics));
                }
                if(publicRequest.IsSetName())
                {
                    request.Parameters.Add("Name", StringUtils.FromString(publicRequest.Name));
                }
                if(publicRequest.IsSetOutputFormat())
                {
                    request.Parameters.Add("OutputFormat", StringUtils.FromString(publicRequest.OutputFormat));
                }
                if(publicRequest.IsSetRoleArn())
                {
                    request.Parameters.Add("RoleArn", StringUtils.FromString(publicRequest.RoleArn));
                }
                if(publicRequest.IsSetStatisticsConfigurations())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.StatisticsConfigurations)
                    {
                        if(publicRequestlistValue.IsSetAdditionalStatistics())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.AdditionalStatistics)
                            {
                                request.Parameters.Add("StatisticsConfigurations" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AdditionalStatistics" + "." + "member" + "." + publicRequestlistValuelistValueIndex, StringUtils.FromString(publicRequestlistValuelistValue));
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
                        if(publicRequestlistValue.IsSetIncludeMetrics())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.IncludeMetrics)
                            {
                                if(publicRequestlistValuelistValue.IsSetMetricName())
                                {
                                    request.Parameters.Add("StatisticsConfigurations" + "." + "member" + "." + publicRequestlistValueIndex + "." + "IncludeMetrics" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "MetricName", StringUtils.FromString(publicRequestlistValuelistValue.MetricName));
                                }
                                if(publicRequestlistValuelistValue.IsSetNamespace())
                                {
                                    request.Parameters.Add("StatisticsConfigurations" + "." + "member" + "." + publicRequestlistValueIndex + "." + "IncludeMetrics" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "Namespace", StringUtils.FromString(publicRequestlistValuelistValue.Namespace));
                                }
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetTags())
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
            return request;
        }
                    private static PutMetricStreamRequestMarshaller _instance = new PutMetricStreamRequestMarshaller();        

        internal static PutMetricStreamRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutMetricStreamRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}