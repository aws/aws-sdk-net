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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetContactAttributes Request Marshaller
    /// </summary>       
    public class GetContactAttributesRequestMarshaller : IMarshaller<IRequest, GetContactAttributesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetContactAttributesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetContactAttributesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.HttpMethod = "GET";

            string uriResourcePath = "/contact/attributes/{InstanceId}/{InitialContactId}";
            if (!publicRequest.IsSetInitialContactId())
                throw new AmazonConnectException("Request object does not have required field InitialContactId set");
            uriResourcePath = uriResourcePath.Replace("{InitialContactId}", StringUtils.FromStringWithSlashEncoding(publicRequest.InitialContactId));
            if (!publicRequest.IsSetInstanceId())
                throw new AmazonConnectException("Request object does not have required field InstanceId set");
            uriResourcePath = uriResourcePath.Replace("{InstanceId}", StringUtils.FromStringWithSlashEncoding(publicRequest.InstanceId));
            request.ResourcePath = uriResourcePath;

            return request;
        }
        private static GetContactAttributesRequestMarshaller _instance = new GetContactAttributesRequestMarshaller();        

        internal static GetContactAttributesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetContactAttributesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}