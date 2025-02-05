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
 * Do not modify this file. This file is generated from the appfabric-2023-05-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppFabric.Model;
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
namespace Amazon.AppFabric.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListAppAuthorizations Request Marshaller
    /// </summary>       
    public class ListAppAuthorizationsRequestMarshaller : IMarshaller<IRequest, ListAppAuthorizationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListAppAuthorizationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListAppAuthorizationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppFabric");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-05-19";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetAppBundleIdentifier())
                throw new AmazonAppFabricException("Request object does not have required field AppBundleIdentifier set");
            request.AddPathResource("{appBundleIdentifier}", StringUtils.FromString(publicRequest.AppBundleIdentifier));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            request.ResourcePath = "/appbundles/{appBundleIdentifier}/appauthorizations";
            request.UseQueryString = true;

            return request;
        }
        private static ListAppAuthorizationsRequestMarshaller _instance = new ListAppAuthorizationsRequestMarshaller();        

        internal static ListAppAuthorizationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListAppAuthorizationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}