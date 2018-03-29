/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.APIGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.APIGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteBasePathMapping Request Marshaller
    /// </summary>       
    public class DeleteBasePathMappingRequestMarshaller : IMarshaller<IRequest, DeleteBasePathMappingRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteBasePathMappingRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteBasePathMappingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.APIGateway");
            request.HttpMethod = "DELETE";

            string uriResourcePath = "/domainnames/{domain_name}/basepathmappings/{base_path}";
            if (!publicRequest.IsSetBasePath())
                throw new AmazonAPIGatewayException("Request object does not have required field BasePath set");
            uriResourcePath = uriResourcePath.Replace("{base_path}", StringUtils.FromString(publicRequest.BasePath));
            if (!publicRequest.IsSetDomainName())
                throw new AmazonAPIGatewayException("Request object does not have required field DomainName set");
            uriResourcePath = uriResourcePath.Replace("{domain_name}", StringUtils.FromString(publicRequest.DomainName));
            request.ResourcePath = uriResourcePath;

            return request;
        }
        private static DeleteBasePathMappingRequestMarshaller _instance = new DeleteBasePathMappingRequestMarshaller();        

        internal static DeleteBasePathMappingRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteBasePathMappingRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}