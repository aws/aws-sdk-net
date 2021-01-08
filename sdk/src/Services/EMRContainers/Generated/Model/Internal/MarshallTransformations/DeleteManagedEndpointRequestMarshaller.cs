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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EMRContainers.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.EMRContainers.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteManagedEndpoint Request Marshaller
    /// </summary>       
    public class DeleteManagedEndpointRequestMarshaller : IMarshaller<IRequest, DeleteManagedEndpointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteManagedEndpointRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteManagedEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EMRContainers");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-10-01";            
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetId())
                throw new AmazonEMRContainersException("Request object does not have required field Id set");
            request.AddPathResource("{endpointId}", StringUtils.FromString(publicRequest.Id));
            if (!publicRequest.IsSetVirtualClusterId())
                throw new AmazonEMRContainersException("Request object does not have required field VirtualClusterId set");
            request.AddPathResource("{virtualClusterId}", StringUtils.FromString(publicRequest.VirtualClusterId));
            request.ResourcePath = "/virtualclusters/{virtualClusterId}/endpoints/{endpointId}";
            request.MarshallerVersion = 2;

            return request;
        }
        private static DeleteManagedEndpointRequestMarshaller _instance = new DeleteManagedEndpointRequestMarshaller();        

        internal static DeleteManagedEndpointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteManagedEndpointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}