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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lambda.Model;
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
namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListDurableExecutionsByFunction Request Marshaller
    /// </summary>       
    public class ListDurableExecutionsByFunctionRequestMarshaller : IMarshaller<IRequest, ListDurableExecutionsByFunctionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListDurableExecutionsByFunctionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListDurableExecutionsByFunctionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lambda");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-03-31";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetFunctionName())
                throw new AmazonLambdaException("Request object does not have required field FunctionName set");
            request.AddPathResource("{FunctionName}", StringUtils.FromString(publicRequest.FunctionName));
            
            if (publicRequest.IsSetDurableExecutionName())
                request.Parameters.Add("DurableExecutionName", StringUtils.FromString(publicRequest.DurableExecutionName));
            
            if (publicRequest.IsSetMarker())
                request.Parameters.Add("Marker", StringUtils.FromString(publicRequest.Marker));
            
            if (publicRequest.IsSetMaxItems())
                request.Parameters.Add("MaxItems", StringUtils.FromInt(publicRequest.MaxItems));
            
            if (publicRequest.IsSetQualifier())
                request.Parameters.Add("Qualifier", StringUtils.FromString(publicRequest.Qualifier));
            
            if (publicRequest.IsSetReverseOrder())
                request.Parameters.Add("ReverseOrder", StringUtils.FromBool(publicRequest.ReverseOrder));
            
            if (publicRequest.IsSetStartedAfter())
                request.Parameters.Add("StartedAfter", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartedAfter));
            
            if (publicRequest.IsSetStartedBefore())
                request.Parameters.Add("StartedBefore", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartedBefore));
            
            if (publicRequest.IsSetStatuses())
                request.ParameterCollection.Add("Statuses", publicRequest.Statuses);
            request.ResourcePath = "/2025-12-01/functions/{FunctionName}/durable-executions";
            request.UseQueryString = true;

            return request;
        }
        private static ListDurableExecutionsByFunctionRequestMarshaller _instance = new ListDurableExecutionsByFunctionRequestMarshaller();        

        internal static ListDurableExecutionsByFunctionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListDurableExecutionsByFunctionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}