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
 * Do not modify this file. This file is generated from the serverlessrepo-2017-09-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServerlessApplicationRepository.Model;
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
namespace Amazon.ServerlessApplicationRepository.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListApplicationDependencies Request Marshaller
    /// </summary>       
    public class ListApplicationDependenciesRequestMarshaller : IMarshaller<IRequest, ListApplicationDependenciesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListApplicationDependenciesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListApplicationDependenciesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ServerlessApplicationRepository");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-09-08";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetApplicationId())
                throw new AmazonServerlessApplicationRepositoryException("Request object does not have required field ApplicationId set");
            request.AddPathResource("{applicationId}", StringUtils.FromString(publicRequest.ApplicationId));
            
            if (publicRequest.IsSetMaxItems())
                request.Parameters.Add("maxItems", StringUtils.FromInt(publicRequest.MaxItems));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetSemanticVersion())
                request.Parameters.Add("semanticVersion", StringUtils.FromString(publicRequest.SemanticVersion));
            request.ResourcePath = "/applications/{applicationId}/dependencies";
            request.UseQueryString = true;

            return request;
        }
        private static ListApplicationDependenciesRequestMarshaller _instance = new ListApplicationDependenciesRequestMarshaller();        

        internal static ListApplicationDependenciesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListApplicationDependenciesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}