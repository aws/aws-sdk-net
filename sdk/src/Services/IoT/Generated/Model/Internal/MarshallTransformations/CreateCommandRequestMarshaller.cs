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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCommand Request Marshaller
    /// </summary>       
    public class CreateCommandRequestMarshaller : IMarshaller<IRequest, CreateCommandRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCommandRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCommandRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-05-28";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetCommandId())
                throw new AmazonIoTException("Request object does not have required field CommandId set");
            request.AddPathResource("{commandId}", StringUtils.FromString(publicRequest.CommandId));
            request.ResourcePath = "/commands/{commandId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDisplayName())
                {
                    context.Writer.WritePropertyName("displayName");
                    context.Writer.Write(publicRequest.DisplayName);
                }

                if(publicRequest.IsSetMandatoryParameters())
                {
                    context.Writer.WritePropertyName("mandatoryParameters");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestMandatoryParametersListValue in publicRequest.MandatoryParameters)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CommandParameterMarshaller.Instance;
                        marshaller.Marshall(publicRequestMandatoryParametersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetNamespace())
                {
                    context.Writer.WritePropertyName("namespace");
                    context.Writer.Write(publicRequest.Namespace);
                }

                if(publicRequest.IsSetPayload())
                {
                    context.Writer.WritePropertyName("payload");
                    context.Writer.WriteObjectStart();

                    var marshaller = CommandPayloadMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Payload, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPayloadTemplate())
                {
                    context.Writer.WritePropertyName("payloadTemplate");
                    context.Writer.Write(publicRequest.PayloadTemplate);
                }

                if(publicRequest.IsSetPreprocessor())
                {
                    context.Writer.WritePropertyName("preprocessor");
                    context.Writer.WriteObjectStart();

                    var marshaller = CommandPreprocessorMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Preprocessor, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("roleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateCommandRequestMarshaller _instance = new CreateCommandRequestMarshaller();        

        internal static CreateCommandRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCommandRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}