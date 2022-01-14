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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NimbleStudio.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.NimbleStudio.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutStudioMembers Request Marshaller
    /// </summary>       
    public class PutStudioMembersRequestMarshaller : IMarshaller<IRequest, PutStudioMembersRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutStudioMembersRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutStudioMembersRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NimbleStudio");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetStudioId())
                throw new AmazonNimbleStudioException("Request object does not have required field StudioId set");
            request.AddPathResource("{studioId}", StringUtils.FromString(publicRequest.StudioId));
            request.ResourcePath = "/2020-08-01/studios/{studioId}/membership";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetIdentityStoreId())
                {
                    context.Writer.WritePropertyName("identityStoreId");
                    context.Writer.Write(publicRequest.IdentityStoreId);
                }

                if(publicRequest.IsSetMembers())
                {
                    context.Writer.WritePropertyName("members");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestMembersListValue in publicRequest.Members)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = NewStudioMemberMarshaller.Instance;
                        marshaller.Marshall(publicRequestMembersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

        
            if (publicRequest.IsSetClientToken()) 
            {
                request.Headers["X-Amz-Client-Token"] = publicRequest.ClientToken;
            }

            return request;
        }
        private static PutStudioMembersRequestMarshaller _instance = new PutStudioMembersRequestMarshaller();        

        internal static PutStudioMembersRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutStudioMembersRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}