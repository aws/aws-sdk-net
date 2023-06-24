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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetAwsNetworkPerformanceData Request Marshaller
    /// </summary>       
    public class GetAwsNetworkPerformanceDataRequestMarshaller : IMarshaller<IRequest, GetAwsNetworkPerformanceDataRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetAwsNetworkPerformanceDataRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetAwsNetworkPerformanceDataRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "GetAwsNetworkPerformanceData");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDataQueries())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.DataQueries)
                    {
                        if(publicRequestlistValue.IsSetDestination())
                        {
                            request.Parameters.Add("DataQuery" + "." + publicRequestlistValueIndex + "." + "Destination", StringUtils.FromString(publicRequestlistValue.Destination));
                        }
                        if(publicRequestlistValue.IsSetId())
                        {
                            request.Parameters.Add("DataQuery" + "." + publicRequestlistValueIndex + "." + "Id", StringUtils.FromString(publicRequestlistValue.Id));
                        }
                        if(publicRequestlistValue.IsSetMetric())
                        {
                            request.Parameters.Add("DataQuery" + "." + publicRequestlistValueIndex + "." + "Metric", StringUtils.FromString(publicRequestlistValue.Metric));
                        }
                        if(publicRequestlistValue.IsSetPeriod())
                        {
                            request.Parameters.Add("DataQuery" + "." + publicRequestlistValueIndex + "." + "Period", StringUtils.FromString(publicRequestlistValue.Period));
                        }
                        if(publicRequestlistValue.IsSetSource())
                        {
                            request.Parameters.Add("DataQuery" + "." + publicRequestlistValueIndex + "." + "Source", StringUtils.FromString(publicRequestlistValue.Source));
                        }
                        if(publicRequestlistValue.IsSetStatistic())
                        {
                            request.Parameters.Add("DataQuery" + "." + publicRequestlistValueIndex + "." + "Statistic", StringUtils.FromString(publicRequestlistValue.Statistic));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetEndTime())
                {
                    request.Parameters.Add("EndTime", StringUtils.FromDateTimeToISO8601(publicRequest.EndTime));
                }
                if(publicRequest.IsSetMaxResults())
                {
                    request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults));
                }
                if(publicRequest.IsSetNextToken())
                {
                    request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
                }
                if(publicRequest.IsSetStartTime())
                {
                    request.Parameters.Add("StartTime", StringUtils.FromDateTimeToISO8601(publicRequest.StartTime));
                }
            }
            return request;
        }
                    private static GetAwsNetworkPerformanceDataRequestMarshaller _instance = new GetAwsNetworkPerformanceDataRequestMarshaller();        

        internal static GetAwsNetworkPerformanceDataRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetAwsNetworkPerformanceDataRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}