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
    /// DeletePlacement Request Marshaller
    /// </summary>       
    public class DeletePlacementRequestMarshaller : IMarshaller<IRequest, DeletePlacementRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeletePlacementRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeletePlacementRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT1ClickProjects");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-14";            
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetPlacementName())
                throw new AmazonIoT1ClickProjectsException("Request object does not have required field PlacementName set");
            request.AddPathResource("{placementName}", StringUtils.FromString(publicRequest.PlacementName));
            if (!publicRequest.IsSetProjectName())
                throw new AmazonIoT1ClickProjectsException("Request object does not have required field ProjectName set");
            request.AddPathResource("{projectName}", StringUtils.FromString(publicRequest.ProjectName));
            request.ResourcePath = "/projects/{projectName}/placements/{placementName}";
            request.MarshallerVersion = 2;

            return request;
        }
        private static DeletePlacementRequestMarshaller _instance = new DeletePlacementRequestMarshaller();        

        internal static DeletePlacementRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeletePlacementRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}