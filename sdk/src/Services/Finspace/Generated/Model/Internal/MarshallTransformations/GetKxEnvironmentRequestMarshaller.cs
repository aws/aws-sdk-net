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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Finspace.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Finspace.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetKxEnvironment Request Marshaller
    /// </summary>       
    public class GetKxEnvironmentRequestMarshaller : IMarshaller<IRequest, GetKxEnvironmentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetKxEnvironmentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetKxEnvironmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Finspace");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-03-12";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetEnvironmentId())
                throw new AmazonFinspaceException("Request object does not have required field EnvironmentId set");
            request.AddPathResource("{environmentId}", StringUtils.FromString(publicRequest.EnvironmentId));
            request.ResourcePath = "/kx/environments/{environmentId}";

            return request;
        }
        private static GetKxEnvironmentRequestMarshaller _instance = new GetKxEnvironmentRequestMarshaller();        

        internal static GetKxEnvironmentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetKxEnvironmentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}