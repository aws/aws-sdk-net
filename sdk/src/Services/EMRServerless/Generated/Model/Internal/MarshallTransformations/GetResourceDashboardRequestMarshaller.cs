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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EMRServerless.Model;
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
namespace Amazon.EMRServerless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetResourceDashboard Request Marshaller
    /// </summary>       
    public class GetResourceDashboardRequestMarshaller : IMarshaller<IRequest, GetResourceDashboardRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetResourceDashboardRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetResourceDashboardRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EMRServerless");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-07-13";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetApplicationId())
                throw new AmazonEMRServerlessException("Request object does not have required field ApplicationId set");
            request.AddPathResource("{applicationId}", StringUtils.FromString(publicRequest.ApplicationId));
            if (string.IsNullOrEmpty(publicRequest.ResourceId))
                throw new AmazonEMRServerlessException("Request object does not have required field ResourceId set");
            
            if (publicRequest.IsSetResourceId())
                request.Parameters.Add("resourceId", StringUtils.FromString(publicRequest.ResourceId));
            if (string.IsNullOrEmpty(publicRequest.ResourceType))
                throw new AmazonEMRServerlessException("Request object does not have required field ResourceType set");
            
            if (publicRequest.IsSetResourceType())
                request.Parameters.Add("resourceType", StringUtils.FromString(publicRequest.ResourceType));
            request.ResourcePath = "/applications/{applicationId}/dashboard";
            request.UseQueryString = true;

            return request;
        }
        private static GetResourceDashboardRequestMarshaller _instance = new GetResourceDashboardRequestMarshaller();        

        internal static GetResourceDashboardRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetResourceDashboardRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}