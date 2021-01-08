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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PrometheusService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.PrometheusService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeWorkspace Request Marshaller
    /// </summary>       
    public class DescribeWorkspaceRequestMarshaller : IMarshaller<IRequest, DescribeWorkspaceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeWorkspaceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeWorkspaceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PrometheusService");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-01";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetWorkspaceId())
                throw new AmazonPrometheusServiceException("Request object does not have required field WorkspaceId set");
            request.AddPathResource("{workspaceId}", StringUtils.FromString(publicRequest.WorkspaceId));
            request.ResourcePath = "/workspaces/{workspaceId}";
            request.MarshallerVersion = 2;

            return request;
        }
        private static DescribeWorkspaceRequestMarshaller _instance = new DescribeWorkspaceRequestMarshaller();        

        internal static DescribeWorkspaceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeWorkspaceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}