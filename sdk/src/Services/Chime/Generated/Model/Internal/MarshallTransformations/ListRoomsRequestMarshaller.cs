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
    /// ListRooms Request Marshaller
    /// </summary>       
    public class ListRoomsRequestMarshaller : IMarshaller<IRequest, ListRoomsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListRoomsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListRoomsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Chime");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-01";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetAccountId())
                throw new AmazonChimeException("Request object does not have required field AccountId set");
            request.AddPathResource("{accountId}", StringUtils.FromString(publicRequest.AccountId));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("max-results", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetMemberId())
                request.Parameters.Add("member-id", StringUtils.FromString(publicRequest.MemberId));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("next-token", StringUtils.FromString(publicRequest.NextToken));
            request.ResourcePath = "/accounts/{accountId}/rooms";
            request.MarshallerVersion = 2;
            request.UseQueryString = true;

            return request;
        }
        private static ListRoomsRequestMarshaller _instance = new ListRoomsRequestMarshaller();        

        internal static ListRoomsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListRoomsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}