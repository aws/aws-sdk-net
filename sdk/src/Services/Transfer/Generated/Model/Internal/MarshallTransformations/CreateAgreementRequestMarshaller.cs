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

#pragma warning disable CS0612,CS0618
namespace Amazon.Transfer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAgreement Request Marshaller
    /// </summary>       
    public class CreateAgreementRequestMarshaller : IMarshaller<IRequest, CreateAgreementRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAgreementRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAgreementRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Transfer");
            string target = "TransferService.CreateAgreement";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-05";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccessRole())
                {
                    context.Writer.WritePropertyName("AccessRole");
                    context.Writer.Write(publicRequest.AccessRole);
                }

                if(publicRequest.IsSetBaseDirectory())
                {
                    context.Writer.WritePropertyName("BaseDirectory");
                    context.Writer.Write(publicRequest.BaseDirectory);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEnforceMessageSigning())
                {
                    context.Writer.WritePropertyName("EnforceMessageSigning");
                    context.Writer.Write(publicRequest.EnforceMessageSigning);
                }

                if(publicRequest.IsSetLocalProfileId())
                {
                    context.Writer.WritePropertyName("LocalProfileId");
                    context.Writer.Write(publicRequest.LocalProfileId);
                }

                if(publicRequest.IsSetPartnerProfileId())
                {
                    context.Writer.WritePropertyName("PartnerProfileId");
                    context.Writer.Write(publicRequest.PartnerProfileId);
                }

                if(publicRequest.IsSetPreserveFilename())
                {
                    context.Writer.WritePropertyName("PreserveFilename");
                    context.Writer.Write(publicRequest.PreserveFilename);
                }

                if(publicRequest.IsSetServerId())
                {
                    context.Writer.WritePropertyName("ServerId");
                    context.Writer.Write(publicRequest.ServerId);
                }

                if(publicRequest.IsSetStatus())
                {
                    context.Writer.WritePropertyName("Status");
                    context.Writer.Write(publicRequest.Status);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
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
        private static CreateAgreementRequestMarshaller _instance = new CreateAgreementRequestMarshaller();        

        internal static CreateAgreementRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAgreementRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}