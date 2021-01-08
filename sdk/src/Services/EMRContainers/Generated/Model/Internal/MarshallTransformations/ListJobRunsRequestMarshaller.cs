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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EMRContainers.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.EMRContainers.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListJobRuns Request Marshaller
    /// </summary>       
    public class ListJobRunsRequestMarshaller : IMarshaller<IRequest, ListJobRunsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListJobRunsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListJobRunsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EMRContainers");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-10-01";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetVirtualClusterId())
                throw new AmazonEMRContainersException("Request object does not have required field VirtualClusterId set");
            request.AddPathResource("{virtualClusterId}", StringUtils.FromString(publicRequest.VirtualClusterId));
            
            if (publicRequest.IsSetCreatedAfter())
                request.Parameters.Add("createdAfter", StringUtils.FromDateTimeToISO8601(publicRequest.CreatedAfter));
            
            if (publicRequest.IsSetCreatedBefore())
                request.Parameters.Add("createdBefore", StringUtils.FromDateTimeToISO8601(publicRequest.CreatedBefore));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetName())
                request.Parameters.Add("name", StringUtils.FromString(publicRequest.Name));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetStates())
                request.ParameterCollection.Add("states", publicRequest.States);
            request.ResourcePath = "/virtualclusters/{virtualClusterId}/jobruns";
            request.MarshallerVersion = 2;
            request.UseQueryString = true;

            return request;
        }
        private static ListJobRunsRequestMarshaller _instance = new ListJobRunsRequestMarshaller();        

        internal static ListJobRunsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListJobRunsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}