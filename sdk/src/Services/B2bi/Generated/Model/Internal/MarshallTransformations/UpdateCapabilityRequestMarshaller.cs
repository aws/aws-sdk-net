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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.B2bi.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.B2bi.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateCapability Request Marshaller
    /// </summary>       
    public class UpdateCapabilityRequestMarshaller : IMarshaller<IRequest, UpdateCapabilityRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateCapabilityRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateCapabilityRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.B2bi");
            string target = "B2BI.UpdateCapability";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-06-23";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCapabilityId())
                {
                    context.Writer.WritePropertyName("capabilityId");
                    context.Writer.Write(publicRequest.CapabilityId);
                }

                if(publicRequest.IsSetConfiguration())
                {
                    context.Writer.WritePropertyName("configuration");
                    context.Writer.WriteObjectStart();

                    var marshaller = CapabilityConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Configuration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetInstructionsDocuments())
                {
                    context.Writer.WritePropertyName("instructionsDocuments");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestInstructionsDocumentsListValue in publicRequest.InstructionsDocuments)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = S3LocationMarshaller.Instance;
                        marshaller.Marshall(publicRequestInstructionsDocumentsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateCapabilityRequestMarshaller _instance = new UpdateCapabilityRequestMarshaller();        

        internal static UpdateCapabilityRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateCapabilityRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}