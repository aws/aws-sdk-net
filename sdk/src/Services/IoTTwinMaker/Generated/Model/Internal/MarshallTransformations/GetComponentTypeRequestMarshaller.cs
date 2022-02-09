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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTTwinMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTTwinMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetComponentType Request Marshaller
    /// </summary>       
    public class GetComponentTypeRequestMarshaller : IMarshaller<IRequest, GetComponentTypeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetComponentTypeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetComponentTypeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTTwinMaker");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-11-29";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetComponentTypeId())
                throw new AmazonIoTTwinMakerException("Request object does not have required field ComponentTypeId set");
            request.AddPathResource("{componentTypeId}", StringUtils.FromString(publicRequest.ComponentTypeId));
            if (!publicRequest.IsSetWorkspaceId())
                throw new AmazonIoTTwinMakerException("Request object does not have required field WorkspaceId set");
            request.AddPathResource("{workspaceId}", StringUtils.FromString(publicRequest.WorkspaceId));
            request.ResourcePath = "/workspaces/{workspaceId}/component-types/{componentTypeId}";
            
            request.HostPrefix = $"api.";

            return request;
        }
        private static GetComponentTypeRequestMarshaller _instance = new GetComponentTypeRequestMarshaller();        

        internal static GetComponentTypeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetComponentTypeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}