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
 * Do not modify this file. This file is generated from the runtime.lex-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lex.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.Lex.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteSession Request Marshaller
    /// </summary>       
    public class DeleteSessionRequestMarshaller : IMarshaller<IRequest, DeleteSessionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteSessionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteSessionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lex");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-11-28";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetBotAlias())
                throw new AmazonLexException("Request object does not have required field BotAlias set");
            request.AddPathResource("{botAlias}", StringUtils.FromString(publicRequest.BotAlias));
            if (!publicRequest.IsSetBotName())
                throw new AmazonLexException("Request object does not have required field BotName set");
            request.AddPathResource("{botName}", StringUtils.FromString(publicRequest.BotName));
            if (!publicRequest.IsSetUserId())
                throw new AmazonLexException("Request object does not have required field UserId set");
            request.AddPathResource("{userId}", StringUtils.FromString(publicRequest.UserId));
            request.ResourcePath = "/bot/{botName}/alias/{botAlias}/user/{userId}/session";

            return request;
        }
        private static DeleteSessionRequestMarshaller _instance = new DeleteSessionRequestMarshaller();        

        internal static DeleteSessionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteSessionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}