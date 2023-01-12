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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CleanRooms.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CleanRooms.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteConfiguredTableAssociation Request Marshaller
    /// </summary>       
    public class DeleteConfiguredTableAssociationRequestMarshaller : IMarshaller<IRequest, DeleteConfiguredTableAssociationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteConfiguredTableAssociationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteConfiguredTableAssociationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CleanRooms");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-02-17";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetConfiguredTableAssociationIdentifier())
                throw new AmazonCleanRoomsException("Request object does not have required field ConfiguredTableAssociationIdentifier set");
            request.AddPathResource("{configuredTableAssociationIdentifier}", StringUtils.FromString(publicRequest.ConfiguredTableAssociationIdentifier));
            if (!publicRequest.IsSetMembershipIdentifier())
                throw new AmazonCleanRoomsException("Request object does not have required field MembershipIdentifier set");
            request.AddPathResource("{membershipIdentifier}", StringUtils.FromString(publicRequest.MembershipIdentifier));
            request.ResourcePath = "/memberships/{membershipIdentifier}/configuredTableAssociations/{configuredTableAssociationIdentifier}";

            return request;
        }
        private static DeleteConfiguredTableAssociationRequestMarshaller _instance = new DeleteConfiguredTableAssociationRequestMarshaller();        

        internal static DeleteConfiguredTableAssociationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteConfiguredTableAssociationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}