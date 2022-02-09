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
 * Do not modify this file. This file is generated from the wisdom-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectWisdomService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ConnectWisdomService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteAssistantAssociation Request Marshaller
    /// </summary>       
    public class DeleteAssistantAssociationRequestMarshaller : IMarshaller<IRequest, DeleteAssistantAssociationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteAssistantAssociationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteAssistantAssociationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ConnectWisdomService");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-10-19";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetAssistantAssociationId())
                throw new AmazonConnectWisdomServiceException("Request object does not have required field AssistantAssociationId set");
            request.AddPathResource("{assistantAssociationId}", StringUtils.FromString(publicRequest.AssistantAssociationId));
            if (!publicRequest.IsSetAssistantId())
                throw new AmazonConnectWisdomServiceException("Request object does not have required field AssistantId set");
            request.AddPathResource("{assistantId}", StringUtils.FromString(publicRequest.AssistantId));
            request.ResourcePath = "/assistants/{assistantId}/associations/{assistantAssociationId}";

            return request;
        }
        private static DeleteAssistantAssociationRequestMarshaller _instance = new DeleteAssistantAssociationRequestMarshaller();        

        internal static DeleteAssistantAssociationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteAssistantAssociationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}