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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchRUM.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchRUM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchGetRumMetricDefinitions Request Marshaller
    /// </summary>       
    public class BatchGetRumMetricDefinitionsRequestMarshaller : IMarshaller<IRequest, BatchGetRumMetricDefinitionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchGetRumMetricDefinitionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchGetRumMetricDefinitionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchRUM");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetAppMonitorName())
                throw new AmazonCloudWatchRUMException("Request object does not have required field AppMonitorName set");
            request.AddPathResource("{AppMonitorName}", StringUtils.FromString(publicRequest.AppMonitorName));
            
            if (publicRequest.IsSetDestination())
                request.Parameters.Add("destination", StringUtils.FromString(publicRequest.Destination));
            
            if (publicRequest.IsSetDestinationArn())
                request.Parameters.Add("destinationArn", StringUtils.FromString(publicRequest.DestinationArn));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            request.ResourcePath = "/rummetrics/{AppMonitorName}/metrics";
            request.UseQueryString = true;

            return request;
        }
        private static BatchGetRumMetricDefinitionsRequestMarshaller _instance = new BatchGetRumMetricDefinitionsRequestMarshaller();        

        internal static BatchGetRumMetricDefinitionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchGetRumMetricDefinitionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}