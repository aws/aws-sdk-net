/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Transfer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Transfer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateServer Request Marshaller
    /// </summary>       
    public class UpdateServerRequestMarshaller : IMarshaller<IRequest, UpdateServerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateServerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateServerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Transfer");
            string target = "TransferService.UpdateServer";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetIdentityProviderDetails())
                {
                    context.Writer.WritePropertyName("IdentityProviderDetails");
                    context.Writer.WriteObjectStart();

                    var marshaller = IdentityProviderDetailsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.IdentityProviderDetails, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetLoggingRole())
                {
                    context.Writer.WritePropertyName("LoggingRole");
                    context.Writer.Write(publicRequest.LoggingRole);
                }

                if(publicRequest.IsSetServerId())
                {
                    context.Writer.WritePropertyName("ServerId");
                    context.Writer.Write(publicRequest.ServerId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateServerRequestMarshaller _instance = new UpdateServerRequestMarshaller();        

        internal static UpdateServerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateServerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}