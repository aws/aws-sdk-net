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
 * Do not modify this file. This file is generated from the managedblockchain-2018-09-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ManagedBlockchain.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ManagedBlockchain.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteMember Request Marshaller
    /// </summary>       
    public class DeleteMemberRequestMarshaller : IMarshaller<IRequest, DeleteMemberRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteMemberRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteMemberRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ManagedBlockchain");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-09-24";            
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetMemberId())
                throw new AmazonManagedBlockchainException("Request object does not have required field MemberId set");
            request.AddPathResource("{memberId}", StringUtils.FromString(publicRequest.MemberId));
            if (!publicRequest.IsSetNetworkId())
                throw new AmazonManagedBlockchainException("Request object does not have required field NetworkId set");
            request.AddPathResource("{networkId}", StringUtils.FromString(publicRequest.NetworkId));
            request.ResourcePath = "/networks/{networkId}/members/{memberId}";
            request.MarshallerVersion = 2;

            return request;
        }
        private static DeleteMemberRequestMarshaller _instance = new DeleteMemberRequestMarshaller();        

        internal static DeleteMemberRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteMemberRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}