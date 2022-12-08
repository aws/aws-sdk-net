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
    /// GetSyncJob Request Marshaller
    /// </summary>       
    public class GetSyncJobRequestMarshaller : IMarshaller<IRequest, GetSyncJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetSyncJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetSyncJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTTwinMaker");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-11-29";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetSyncSource())
                throw new AmazonIoTTwinMakerException("Request object does not have required field SyncSource set");
            request.AddPathResource("{syncSource}", StringUtils.FromString(publicRequest.SyncSource));
            
            if (publicRequest.IsSetWorkspaceId())
                request.Parameters.Add("workspace", StringUtils.FromString(publicRequest.WorkspaceId));
            request.ResourcePath = "/sync-jobs/{syncSource}";
            request.UseQueryString = true;
            
            request.HostPrefix = $"api.";

            return request;
        }
        private static GetSyncJobRequestMarshaller _instance = new GetSyncJobRequestMarshaller();        

        internal static GetSyncJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetSyncJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}