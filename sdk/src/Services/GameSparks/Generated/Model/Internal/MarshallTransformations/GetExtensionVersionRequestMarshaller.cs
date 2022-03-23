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
 * Do not modify this file. This file is generated from the gamesparks-2021-08-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameSparks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GameSparks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetExtensionVersion Request Marshaller
    /// </summary>       
    public class GetExtensionVersionRequestMarshaller : IMarshaller<IRequest, GetExtensionVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetExtensionVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetExtensionVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameSparks");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-08-17";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetExtensionVersion())
                throw new AmazonGameSparksException("Request object does not have required field ExtensionVersion set");
            request.AddPathResource("{ExtensionVersion}", StringUtils.FromString(publicRequest.ExtensionVersion));
            if (!publicRequest.IsSetName())
                throw new AmazonGameSparksException("Request object does not have required field Name set");
            request.AddPathResource("{Name}", StringUtils.FromString(publicRequest.Name));
            if (!publicRequest.IsSetNamespace())
                throw new AmazonGameSparksException("Request object does not have required field Namespace set");
            request.AddPathResource("{Namespace}", StringUtils.FromString(publicRequest.Namespace));
            request.ResourcePath = "/extension/{Namespace}/{Name}/version/{ExtensionVersion}";

            return request;
        }
        private static GetExtensionVersionRequestMarshaller _instance = new GetExtensionVersionRequestMarshaller();        

        internal static GetExtensionVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetExtensionVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}