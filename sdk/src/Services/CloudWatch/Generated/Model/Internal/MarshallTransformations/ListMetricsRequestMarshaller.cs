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
    /// ListMetrics Request Marshaller
    /// </summary>       
    public class ListMetricsRequestMarshaller : IMarshaller<IRequest, ListMetricsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListMetricsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListMetricsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatch");
            request.Parameters.Add("Action", "ListMetrics");
            request.Parameters.Add("Version", "2010-08-01");

            if(publicRequest != null)
            {
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
                if(publicRequest.IsSetIncludeLinkedAccounts())
                {
                    request.Parameters.Add("IncludeLinkedAccounts", StringUtils.FromBool(publicRequest.IncludeLinkedAccounts));
                }
                if(publicRequest.IsSetMetricName())
                {
                    request.Parameters.Add("MetricName", StringUtils.FromString(publicRequest.MetricName));
                }
                if(publicRequest.IsSetNamespace())
                {
                    request.Parameters.Add("Namespace", StringUtils.FromString(publicRequest.Namespace));
                }
                if(publicRequest.IsSetNextToken())
                {
                    request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
                }
                if(publicRequest.IsSetOwningAccount())
                {
                    request.Parameters.Add("OwningAccount", StringUtils.FromString(publicRequest.OwningAccount));
                }
                if(publicRequest.IsSetRecentlyActive())
                {
                    request.Parameters.Add("RecentlyActive", StringUtils.FromString(publicRequest.RecentlyActive));
                }
            }
            return request;
        }
                    private static ListMetricsRequestMarshaller _instance = new ListMetricsRequestMarshaller();        

        internal static ListMetricsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListMetricsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}