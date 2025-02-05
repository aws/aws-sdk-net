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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Amplify.Model;
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
namespace Amazon.Amplify.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteBackendEnvironment Request Marshaller
    /// </summary>       
    public class DeleteBackendEnvironmentRequestMarshaller : IMarshaller<IRequest, DeleteBackendEnvironmentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteBackendEnvironmentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteBackendEnvironmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Amplify");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetAppId())
                throw new AmazonAmplifyException("Request object does not have required field AppId set");
            request.AddPathResource("{appId}", StringUtils.FromString(publicRequest.AppId));
            if (!publicRequest.IsSetEnvironmentName())
                throw new AmazonAmplifyException("Request object does not have required field EnvironmentName set");
            request.AddPathResource("{environmentName}", StringUtils.FromString(publicRequest.EnvironmentName));
            request.ResourcePath = "/apps/{appId}/backendenvironments/{environmentName}";

            return request;
        }
        private static DeleteBackendEnvironmentRequestMarshaller _instance = new DeleteBackendEnvironmentRequestMarshaller();        

        internal static DeleteBackendEnvironmentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteBackendEnvironmentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}