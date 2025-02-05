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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTTwinMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetScene Request Marshaller
    /// </summary>       
    public class GetSceneRequestMarshaller : IMarshaller<IRequest, GetSceneRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetSceneRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetSceneRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTTwinMaker");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-11-29";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetSceneId())
                throw new AmazonIoTTwinMakerException("Request object does not have required field SceneId set");
            request.AddPathResource("{sceneId}", StringUtils.FromString(publicRequest.SceneId));
            if (!publicRequest.IsSetWorkspaceId())
                throw new AmazonIoTTwinMakerException("Request object does not have required field WorkspaceId set");
            request.AddPathResource("{workspaceId}", StringUtils.FromString(publicRequest.WorkspaceId));
            request.ResourcePath = "/workspaces/{workspaceId}/scenes/{sceneId}";
            
            request.HostPrefix = $"api.";

            return request;
        }
        private static GetSceneRequestMarshaller _instance = new GetSceneRequestMarshaller();        

        internal static GetSceneRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetSceneRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}