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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CleanRoomsML.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CleanRoomsML.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetConfiguredModelAlgorithmAssociation Request Marshaller
    /// </summary>       
    public class GetConfiguredModelAlgorithmAssociationRequestMarshaller : IMarshaller<IRequest, GetConfiguredModelAlgorithmAssociationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetConfiguredModelAlgorithmAssociationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetConfiguredModelAlgorithmAssociationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CleanRoomsML");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-09-06";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetConfiguredModelAlgorithmAssociationArn())
                throw new AmazonCleanRoomsMLException("Request object does not have required field ConfiguredModelAlgorithmAssociationArn set");
            request.AddPathResource("{configuredModelAlgorithmAssociationArn}", StringUtils.FromString(publicRequest.ConfiguredModelAlgorithmAssociationArn));
            if (!publicRequest.IsSetMembershipIdentifier())
                throw new AmazonCleanRoomsMLException("Request object does not have required field MembershipIdentifier set");
            request.AddPathResource("{membershipIdentifier}", StringUtils.FromString(publicRequest.MembershipIdentifier));
            request.ResourcePath = "/memberships/{membershipIdentifier}/configured-model-algorithm-associations/{configuredModelAlgorithmAssociationArn}";

            return request;
        }
        private static GetConfiguredModelAlgorithmAssociationRequestMarshaller _instance = new GetConfiguredModelAlgorithmAssociationRequestMarshaller();        

        internal static GetConfiguredModelAlgorithmAssociationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetConfiguredModelAlgorithmAssociationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}