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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EventBridge.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.EventBridge.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateConnection Request Marshaller
    /// </summary>       
    public class UpdateConnectionRequestMarshaller : IMarshaller<IRequest, UpdateConnectionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateConnectionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateConnectionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EventBridge");
            string target = "AWSEvents.UpdateConnection";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-10-07";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAuthorizationType())
                {
                    context.Writer.WritePropertyName("AuthorizationType");
                    context.Writer.Write(publicRequest.AuthorizationType);
                }

                if(publicRequest.IsSetAuthParameters())
                {
                    context.Writer.WritePropertyName("AuthParameters");
                    context.Writer.WriteObjectStart();

                    var marshaller = UpdateConnectionAuthRequestParametersMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AuthParameters, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetInvocationConnectivityParameters())
                {
                    context.Writer.WritePropertyName("InvocationConnectivityParameters");
                    context.Writer.WriteObjectStart();

                    var marshaller = ConnectivityResourceParametersMarshaller.Instance;
                    marshaller.Marshall(publicRequest.InvocationConnectivityParameters, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetKmsKeyIdentifier())
                {
                    context.Writer.WritePropertyName("KmsKeyIdentifier");
                    context.Writer.Write(publicRequest.KmsKeyIdentifier);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateConnectionRequestMarshaller _instance = new UpdateConnectionRequestMarshaller();        

        internal static UpdateConnectionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateConnectionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}