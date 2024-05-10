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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NeptuneGraph.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.NeptuneGraph.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeletePrivateGraphEndpoint Request Marshaller
    /// </summary>       
    public class DeletePrivateGraphEndpointRequestMarshaller : IMarshaller<IRequest, DeletePrivateGraphEndpointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeletePrivateGraphEndpointRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeletePrivateGraphEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NeptuneGraph");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-11-29";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetGraphIdentifier())
                throw new AmazonNeptuneGraphException("Request object does not have required field GraphIdentifier set");
            request.AddPathResource("{graphIdentifier}", StringUtils.FromString(publicRequest.GraphIdentifier));
            if (!publicRequest.IsSetVpcId())
                throw new AmazonNeptuneGraphException("Request object does not have required field VpcId set");
            request.AddPathResource("{vpcId}", StringUtils.FromString(publicRequest.VpcId));
            request.ResourcePath = "/graphs/{graphIdentifier}/endpoints/{vpcId}";

            return request;
        }
        private static DeletePrivateGraphEndpointRequestMarshaller _instance = new DeletePrivateGraphEndpointRequestMarshaller();        

        internal static DeletePrivateGraphEndpointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeletePrivateGraphEndpointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}