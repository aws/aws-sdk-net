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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Chime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Chime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteChannelMembership Request Marshaller
    /// </summary>       
    public class DeleteChannelMembershipRequestMarshaller : IMarshaller<IRequest, DeleteChannelMembershipRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteChannelMembershipRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteChannelMembershipRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Chime");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-01";            
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetChannelArn())
                throw new AmazonChimeException("Request object does not have required field ChannelArn set");
            request.AddPathResource("{channelArn}", StringUtils.FromString(publicRequest.ChannelArn));
            if (!publicRequest.IsSetMemberArn())
                throw new AmazonChimeException("Request object does not have required field MemberArn set");
            request.AddPathResource("{memberArn}", StringUtils.FromString(publicRequest.MemberArn));
            request.ResourcePath = "/channels/{channelArn}/memberships/{memberArn}";
            request.MarshallerVersion = 2;
            
            request.HostPrefix = $"messaging-";

            return request;
        }
        private static DeleteChannelMembershipRequestMarshaller _instance = new DeleteChannelMembershipRequestMarshaller();        

        internal static DeleteChannelMembershipRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteChannelMembershipRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}