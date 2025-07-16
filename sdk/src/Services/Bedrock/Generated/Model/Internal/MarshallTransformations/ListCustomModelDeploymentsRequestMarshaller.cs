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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Bedrock.Model;
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
namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListCustomModelDeployments Request Marshaller
    /// </summary>       
    public class ListCustomModelDeploymentsRequestMarshaller : IMarshaller<IRequest, ListCustomModelDeploymentsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListCustomModelDeploymentsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListCustomModelDeploymentsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Bedrock");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-04-20";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetCreatedAfter())
                request.Parameters.Add("createdAfter", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.CreatedAfter));
            
            if (publicRequest.IsSetCreatedBefore())
                request.Parameters.Add("createdBefore", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.CreatedBefore));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetModelArnEquals())
                request.Parameters.Add("modelArnEquals", StringUtils.FromString(publicRequest.ModelArnEquals));
            
            if (publicRequest.IsSetNameContains())
                request.Parameters.Add("nameContains", StringUtils.FromString(publicRequest.NameContains));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetSortBy())
                request.Parameters.Add("sortBy", StringUtils.FromString(publicRequest.SortBy));
            
            if (publicRequest.IsSetSortOrder())
                request.Parameters.Add("sortOrder", StringUtils.FromString(publicRequest.SortOrder));
            
            if (publicRequest.IsSetStatusEquals())
                request.Parameters.Add("statusEquals", StringUtils.FromString(publicRequest.StatusEquals));
            request.ResourcePath = "/model-customization/custom-model-deployments";
            request.UseQueryString = true;

            return request;
        }
        private static ListCustomModelDeploymentsRequestMarshaller _instance = new ListCustomModelDeploymentsRequestMarshaller();        

        internal static ListCustomModelDeploymentsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListCustomModelDeploymentsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}