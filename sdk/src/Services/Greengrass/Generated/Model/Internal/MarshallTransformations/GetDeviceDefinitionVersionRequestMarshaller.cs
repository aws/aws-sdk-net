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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Greengrass.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Greengrass.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetDeviceDefinitionVersion Request Marshaller
    /// </summary>       
    public class GetDeviceDefinitionVersionRequestMarshaller : IMarshaller<IRequest, GetDeviceDefinitionVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetDeviceDefinitionVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetDeviceDefinitionVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Greengrass");
            request.HttpMethod = "GET";

            string uriResourcePath = "/greengrass/definition/devices/{DeviceDefinitionId}/versions/{DeviceDefinitionVersionId}";
            if (!publicRequest.IsSetDeviceDefinitionId())
                throw new AmazonGreengrassException("Request object does not have required field DeviceDefinitionId set");
            uriResourcePath = uriResourcePath.Replace("{DeviceDefinitionId}", StringUtils.FromString(publicRequest.DeviceDefinitionId));
            if (!publicRequest.IsSetDeviceDefinitionVersionId())
                throw new AmazonGreengrassException("Request object does not have required field DeviceDefinitionVersionId set");
            uriResourcePath = uriResourcePath.Replace("{DeviceDefinitionVersionId}", StringUtils.FromString(publicRequest.DeviceDefinitionVersionId));
            request.ResourcePath = uriResourcePath;

            return request;
        }
        private static GetDeviceDefinitionVersionRequestMarshaller _instance = new GetDeviceDefinitionVersionRequestMarshaller();        

        internal static GetDeviceDefinitionVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetDeviceDefinitionVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}