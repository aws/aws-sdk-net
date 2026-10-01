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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.QConnect.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.QConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteAssistantAssociation Request Marshaller
    /// </summary>
    public partial class DeleteAssistantAssociationRequestMarshaller : IMarshaller<IRequest, DeleteAssistantAssociationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteAssistantAssociationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteAssistantAssociationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QConnect");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-10-19";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetAssistantAssociationId())
            {
                throw new AmazonQConnectException("Request object does not have required field AssistantAssociationId set");
            }
            request.AddPathResource("{assistantAssociationId}", StringUtils.FromString(publicRequest.AssistantAssociationId));

            if (!publicRequest.IsSetAssistantId())
            {
                throw new AmazonQConnectException("Request object does not have required field AssistantId set");
            }
            request.AddPathResource("{assistantId}", StringUtils.FromString(publicRequest.AssistantId));

            request.ResourcePath = "/assistants/{assistantId}/associations/{assistantAssociationId}";

            return request;
        }

        private static readonly DeleteAssistantAssociationRequestMarshaller _instance = new();

        internal static DeleteAssistantAssociationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteAssistantAssociationRequestMarshaller Instance => _instance;
    }
}
