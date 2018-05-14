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
 * Do not modify this file. This file is generated from the iot1click-projects-2018-05-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT1ClickProjects.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT1ClickProjects.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AssociateDeviceWithPlacement Request Marshaller
    /// </summary>       
    public class AssociateDeviceWithPlacementRequestMarshaller : IMarshaller<IRequest, AssociateDeviceWithPlacementRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AssociateDeviceWithPlacementRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AssociateDeviceWithPlacementRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT1ClickProjects");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "PUT";

            string uriResourcePath = "/projects/{projectName}/placements/{placementName}/devices/{deviceTemplateName}";
            if (!publicRequest.IsSetDeviceTemplateName())
                throw new AmazonIoT1ClickProjectsException("Request object does not have required field DeviceTemplateName set");
            uriResourcePath = uriResourcePath.Replace("{deviceTemplateName}", StringUtils.FromString(publicRequest.DeviceTemplateName));
            if (!publicRequest.IsSetPlacementName())
                throw new AmazonIoT1ClickProjectsException("Request object does not have required field PlacementName set");
            uriResourcePath = uriResourcePath.Replace("{placementName}", StringUtils.FromString(publicRequest.PlacementName));
            if (!publicRequest.IsSetProjectName())
                throw new AmazonIoT1ClickProjectsException("Request object does not have required field ProjectName set");
            uriResourcePath = uriResourcePath.Replace("{projectName}", StringUtils.FromString(publicRequest.ProjectName));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDeviceId())
                {
                    context.Writer.WritePropertyName("deviceId");
                    context.Writer.Write(publicRequest.DeviceId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static AssociateDeviceWithPlacementRequestMarshaller _instance = new AssociateDeviceWithPlacementRequestMarshaller();        

        internal static AssociateDeviceWithPlacementRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssociateDeviceWithPlacementRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}