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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GroundStation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GroundStation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteDataflowEndpointGroup Request Marshaller
    /// </summary>       
    public class DeleteDataflowEndpointGroupRequestMarshaller : IMarshaller<IRequest, DeleteDataflowEndpointGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteDataflowEndpointGroupRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteDataflowEndpointGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GroundStation");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-05-23";            
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetDataflowEndpointGroupId())
                throw new AmazonGroundStationException("Request object does not have required field DataflowEndpointGroupId set");
            request.AddPathResource("{dataflowEndpointGroupId}", StringUtils.FromString(publicRequest.DataflowEndpointGroupId));
            request.ResourcePath = "/dataflowEndpointGroup/{dataflowEndpointGroupId}";
            request.MarshallerVersion = 2;

            return request;
        }
        private static DeleteDataflowEndpointGroupRequestMarshaller _instance = new DeleteDataflowEndpointGroupRequestMarshaller();        

        internal static DeleteDataflowEndpointGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteDataflowEndpointGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}