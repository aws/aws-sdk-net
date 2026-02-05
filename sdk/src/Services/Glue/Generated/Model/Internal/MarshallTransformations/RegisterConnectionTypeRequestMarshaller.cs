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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RegisterConnectionType Request Marshaller
    /// </summary>       
    public class RegisterConnectionTypeRequestMarshaller : IMarshaller<IRequest, RegisterConnectionTypeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RegisterConnectionTypeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RegisterConnectionTypeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Glue");
            string target = "AWSGlue.RegisterConnectionType";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-03-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetConnectionProperties())
                {
                    context.Writer.WritePropertyName("ConnectionProperties");
                    context.Writer.WriteObjectStart();

                    var marshaller = ConnectionPropertiesConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ConnectionProperties, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetConnectionType())
                {
                    context.Writer.WritePropertyName("ConnectionType");
                    context.Writer.Write(publicRequest.ConnectionType);
                }

                if(publicRequest.IsSetConnectorAuthenticationConfiguration())
                {
                    context.Writer.WritePropertyName("ConnectorAuthenticationConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ConnectorAuthenticationConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ConnectorAuthenticationConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetIntegrationType())
                {
                    context.Writer.WritePropertyName("IntegrationType");
                    context.Writer.Write(publicRequest.IntegrationType);
                }

                if(publicRequest.IsSetRestConfiguration())
                {
                    context.Writer.WritePropertyName("RestConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = RestConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RestConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static RegisterConnectionTypeRequestMarshaller _instance = new RegisterConnectionTypeRequestMarshaller();        

        internal static RegisterConnectionTypeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RegisterConnectionTypeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}