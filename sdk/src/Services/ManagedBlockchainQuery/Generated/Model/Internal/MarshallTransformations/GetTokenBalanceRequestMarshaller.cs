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
 * Do not modify this file. This file is generated from the managedblockchain-query-2023-05-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ManagedBlockchainQuery.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ManagedBlockchainQuery.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetTokenBalance Request Marshaller
    /// </summary>       
    public class GetTokenBalanceRequestMarshaller : IMarshaller<IRequest, GetTokenBalanceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetTokenBalanceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetTokenBalanceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ManagedBlockchainQuery");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-05-04";
            request.HttpMethod = "POST";

            request.ResourcePath = "/get-token-balance";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAtBlockchainInstant())
                {
                    context.Writer.WritePropertyName("atBlockchainInstant");
                    context.Writer.WriteObjectStart();

                    var marshaller = BlockchainInstantMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AtBlockchainInstant, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOwnerIdentifier())
                {
                    context.Writer.WritePropertyName("ownerIdentifier");
                    context.Writer.WriteObjectStart();

                    var marshaller = OwnerIdentifierMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OwnerIdentifier, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTokenIdentifier())
                {
                    context.Writer.WritePropertyName("tokenIdentifier");
                    context.Writer.WriteObjectStart();

                    var marshaller = TokenIdentifierMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TokenIdentifier, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GetTokenBalanceRequestMarshaller _instance = new GetTokenBalanceRequestMarshaller();        

        internal static GetTokenBalanceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetTokenBalanceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}