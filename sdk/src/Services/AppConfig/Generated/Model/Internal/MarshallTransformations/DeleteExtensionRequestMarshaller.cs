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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppConfig.Model;
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
namespace Amazon.AppConfig.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteExtension Request Marshaller
    /// </summary>       
    public class DeleteExtensionRequestMarshaller : IMarshaller<IRequest, DeleteExtensionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteExtensionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteExtensionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppConfig");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-10-09";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetExtensionIdentifier())
                throw new AmazonAppConfigException("Request object does not have required field ExtensionIdentifier set");
            request.AddPathResource("{ExtensionIdentifier}", StringUtils.FromString(publicRequest.ExtensionIdentifier));
            
            if (publicRequest.IsSetVersionNumber())
                request.Parameters.Add("version", StringUtils.FromInt(publicRequest.VersionNumber));
            request.ResourcePath = "/extensions/{ExtensionIdentifier}";
            request.UseQueryString = true;

            return request;
        }
        private static DeleteExtensionRequestMarshaller _instance = new DeleteExtensionRequestMarshaller();        

        internal static DeleteExtensionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteExtensionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}