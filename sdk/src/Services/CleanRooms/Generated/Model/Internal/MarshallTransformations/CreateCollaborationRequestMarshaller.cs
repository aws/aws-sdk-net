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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CleanRooms.Model;
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
namespace Amazon.CleanRooms.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCollaboration Request Marshaller
    /// </summary>       
    public class CreateCollaborationRequestMarshaller : IMarshaller<IRequest, CreateCollaborationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCollaborationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCollaborationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CleanRooms");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-02-17";
            request.HttpMethod = "POST";

            request.ResourcePath = "/collaborations";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAnalyticsEngine())
            {
                context.Writer.WritePropertyName("analyticsEngine");
                context.Writer.WriteStringValue(publicRequest.AnalyticsEngine);
            }

            if(publicRequest.IsSetCreatorDisplayName())
            {
                context.Writer.WritePropertyName("creatorDisplayName");
                context.Writer.WriteStringValue(publicRequest.CreatorDisplayName);
            }

            if(publicRequest.IsSetCreatorMemberAbilities())
            {
                context.Writer.WritePropertyName("creatorMemberAbilities");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCreatorMemberAbilitiesListValue in publicRequest.CreatorMemberAbilities)
                {
                        context.Writer.WriteStringValue(publicRequestCreatorMemberAbilitiesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetCreatorMLMemberAbilities())
            {
                context.Writer.WritePropertyName("creatorMLMemberAbilities");
                context.Writer.WriteStartObject();

                var marshaller = MLMemberAbilitiesMarshaller.Instance;
                marshaller.Marshall(publicRequest.CreatorMLMemberAbilities, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCreatorPaymentConfiguration())
            {
                context.Writer.WritePropertyName("creatorPaymentConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = PaymentConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.CreatorPaymentConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDataEncryptionMetadata())
            {
                context.Writer.WritePropertyName("dataEncryptionMetadata");
                context.Writer.WriteStartObject();

                var marshaller = DataEncryptionMetadataMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataEncryptionMetadata, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetJobLogStatus())
            {
                context.Writer.WritePropertyName("jobLogStatus");
                context.Writer.WriteStringValue(publicRequest.JobLogStatus);
            }

            if(publicRequest.IsSetMembers())
            {
                context.Writer.WritePropertyName("members");
                context.Writer.WriteStartArray();
                foreach(var publicRequestMembersListValue in publicRequest.Members)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MemberSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequestMembersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetQueryLogStatus())
            {
                context.Writer.WritePropertyName("queryLogStatus");
                context.Writer.WriteStringValue(publicRequest.QueryLogStatus);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
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
        private static CreateCollaborationRequestMarshaller _instance = new CreateCollaborationRequestMarshaller();        

        internal static CreateCollaborationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCollaborationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}