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
 * Do not modify this file. This file is generated from the appintegrations-2020-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppIntegrationsService.Model;
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
namespace Amazon.AppIntegrationsService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateApplication Request Marshaller
    /// </summary>       
    public class CreateApplicationRequestMarshaller : IMarshaller<IRequest, CreateApplicationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateApplicationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateApplicationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppIntegrationsService");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-29";
            request.HttpMethod = "POST";

            request.ResourcePath = "/applications";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetApplicationConfig())
            {
                context.Writer.WritePropertyName("ApplicationConfig");
                context.Writer.WriteStartObject();

                var marshaller = ApplicationConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ApplicationConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetApplicationSourceConfig())
            {
                context.Writer.WritePropertyName("ApplicationSourceConfig");
                context.Writer.WriteStartObject();

                var marshaller = ApplicationSourceConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ApplicationSourceConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetIframeConfig())
            {
                context.Writer.WritePropertyName("IframeConfig");
                context.Writer.WriteStartObject();

                var marshaller = IframeConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.IframeConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInitializationTimeout())
            {
                context.Writer.WritePropertyName("InitializationTimeout");
                context.Writer.WriteNumberValue(publicRequest.InitializationTimeout.Value);
            }

            if(publicRequest.IsSetIsService())
            {
                context.Writer.WritePropertyName("IsService");
                context.Writer.WriteBooleanValue(publicRequest.IsService.Value);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetNamespace())
            {
                context.Writer.WritePropertyName("Namespace");
                context.Writer.WriteStringValue(publicRequest.Namespace);
            }

            if(publicRequest.IsSetPermissions())
            {
                context.Writer.WritePropertyName("Permissions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPermissionsListValue in publicRequest.Permissions)
                {
                        context.Writer.WriteStringValue(publicRequestPermissionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetPublications())
            {
                context.Writer.WritePropertyName("Publications");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPublicationsListValue in publicRequest.Publications)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PublicationMarshaller.Instance;
                    marshaller.Marshall(publicRequestPublicationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSubscriptions())
            {
                context.Writer.WritePropertyName("Subscriptions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSubscriptionsListValue in publicRequest.Subscriptions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SubscriptionMarshaller.Instance;
                    marshaller.Marshall(publicRequestSubscriptionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
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
        private static CreateApplicationRequestMarshaller _instance = new CreateApplicationRequestMarshaller();        

        internal static CreateApplicationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateApplicationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}