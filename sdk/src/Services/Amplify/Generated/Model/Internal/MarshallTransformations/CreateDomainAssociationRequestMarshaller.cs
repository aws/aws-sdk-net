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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Amplify.Model;
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
namespace Amazon.Amplify.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDomainAssociation Request Marshaller
    /// </summary>       
    public class CreateDomainAssociationRequestMarshaller : IMarshaller<IRequest, CreateDomainAssociationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDomainAssociationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDomainAssociationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Amplify");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAppId())
                throw new AmazonAmplifyException("Request object does not have required field AppId set");
            request.AddPathResource("{appId}", StringUtils.FromString(publicRequest.AppId));
            request.ResourcePath = "/apps/{appId}/domains";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAutoSubDomainCreationPatterns())
            {
                context.Writer.WritePropertyName("autoSubDomainCreationPatterns");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAutoSubDomainCreationPatternsListValue in publicRequest.AutoSubDomainCreationPatterns)
                {
                        context.Writer.WriteStringValue(publicRequestAutoSubDomainCreationPatternsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAutoSubDomainIAMRole())
            {
                context.Writer.WritePropertyName("autoSubDomainIAMRole");
                context.Writer.WriteStringValue(publicRequest.AutoSubDomainIAMRole);
            }

            if(publicRequest.IsSetCertificateSettings())
            {
                context.Writer.WritePropertyName("certificateSettings");
                context.Writer.WriteStartObject();

                var marshaller = CertificateSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.CertificateSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDomainName())
            {
                context.Writer.WritePropertyName("domainName");
                context.Writer.WriteStringValue(publicRequest.DomainName);
            }

            if(publicRequest.IsSetEnableAutoSubDomain())
            {
                context.Writer.WritePropertyName("enableAutoSubDomain");
                context.Writer.WriteBooleanValue(publicRequest.EnableAutoSubDomain.Value);
            }

            if(publicRequest.IsSetSubDomainSettings())
            {
                context.Writer.WritePropertyName("subDomainSettings");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSubDomainSettingsListValue in publicRequest.SubDomainSettings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SubDomainSettingMarshaller.Instance;
                    marshaller.Marshall(publicRequestSubDomainSettingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateDomainAssociationRequestMarshaller _instance = new CreateDomainAssociationRequestMarshaller();        

        internal static CreateDomainAssociationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDomainAssociationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}