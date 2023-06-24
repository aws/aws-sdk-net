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
 * Do not modify this file. This file is generated from the gamesparks-2021-08-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameSparks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GameSparks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DisconnectPlayer Request Marshaller
    /// </summary>       
    public class DisconnectPlayerRequestMarshaller : IMarshaller<IRequest, DisconnectPlayerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DisconnectPlayerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DisconnectPlayerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameSparks");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-08-17";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetGameName())
                throw new AmazonGameSparksException("Request object does not have required field GameName set");
            request.AddPathResource("{GameName}", StringUtils.FromString(publicRequest.GameName));
            if (!publicRequest.IsSetPlayerId())
                throw new AmazonGameSparksException("Request object does not have required field PlayerId set");
            request.AddPathResource("{PlayerId}", StringUtils.FromString(publicRequest.PlayerId));
            if (!publicRequest.IsSetStageName())
                throw new AmazonGameSparksException("Request object does not have required field StageName set");
            request.AddPathResource("{StageName}", StringUtils.FromString(publicRequest.StageName));
            request.ResourcePath = "/runtime/game/{GameName}/stage/{StageName}/player/{PlayerId}/disconnect";

            return request;
        }
        private static DisconnectPlayerRequestMarshaller _instance = new DisconnectPlayerRequestMarshaller();        

        internal static DisconnectPlayerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DisconnectPlayerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}