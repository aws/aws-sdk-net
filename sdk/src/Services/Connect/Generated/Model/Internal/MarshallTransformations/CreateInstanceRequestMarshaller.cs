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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateInstance Request Marshaller
    /// </summary>       
    public class CreateInstanceRequestMarshaller : IMarshaller<IRequest, CreateInstanceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateInstanceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateInstanceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";            
            request.HttpMethod = "PUT";

            request.ResourcePath = "/instance";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                if(publicRequest.IsSetDirectoryId())
                {
                    context.Writer.WritePropertyName("DirectoryId");
                    context.Writer.Write(publicRequest.DirectoryId);
                }

                if(publicRequest.IsSetIdentityManagementType())
                {
                    context.Writer.WritePropertyName("IdentityManagementType");
                    context.Writer.Write(publicRequest.IdentityManagementType);
                }

                if(publicRequest.IsSetInboundCallsEnabled())
                {
                    context.Writer.WritePropertyName("InboundCallsEnabled");
                    context.Writer.Write(publicRequest.InboundCallsEnabled);
                }

                if(publicRequest.IsSetInstanceAlias())
                {
                    context.Writer.WritePropertyName("InstanceAlias");
                    context.Writer.Write(publicRequest.InstanceAlias);
                }

                if(publicRequest.IsSetOutboundCallsEnabled())
                {
                    context.Writer.WritePropertyName("OutboundCallsEnabled");
                    context.Writer.Write(publicRequest.OutboundCallsEnabled);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateInstanceRequestMarshaller _instance = new CreateInstanceRequestMarshaller();        

        internal static CreateInstanceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateInstanceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}