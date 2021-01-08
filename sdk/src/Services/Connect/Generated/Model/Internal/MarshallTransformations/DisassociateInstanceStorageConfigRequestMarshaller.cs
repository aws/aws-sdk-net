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
    /// DisassociateInstanceStorageConfig Request Marshaller
    /// </summary>       
    public class DisassociateInstanceStorageConfigRequestMarshaller : IMarshaller<IRequest, DisassociateInstanceStorageConfigRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DisassociateInstanceStorageConfigRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DisassociateInstanceStorageConfigRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";            
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetAssociationId())
                throw new AmazonConnectException("Request object does not have required field AssociationId set");
            request.AddPathResource("{AssociationId}", StringUtils.FromString(publicRequest.AssociationId));
            if (!publicRequest.IsSetInstanceId())
                throw new AmazonConnectException("Request object does not have required field InstanceId set");
            request.AddPathResource("{InstanceId}", StringUtils.FromString(publicRequest.InstanceId));
            
            if (publicRequest.IsSetResourceType())
                request.Parameters.Add("resourceType", StringUtils.FromString(publicRequest.ResourceType));
            request.ResourcePath = "/instance/{InstanceId}/storage-config/{AssociationId}";
            request.MarshallerVersion = 2;
            request.UseQueryString = true;

            return request;
        }
        private static DisassociateInstanceStorageConfigRequestMarshaller _instance = new DisassociateInstanceStorageConfigRequestMarshaller();        

        internal static DisassociateInstanceStorageConfigRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DisassociateInstanceStorageConfigRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}