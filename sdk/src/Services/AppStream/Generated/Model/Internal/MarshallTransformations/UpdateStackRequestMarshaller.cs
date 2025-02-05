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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppStream.Model;
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
namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateStack Request Marshaller
    /// </summary>       
    public class UpdateStackRequestMarshaller : IMarshaller<IRequest, UpdateStackRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateStackRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateStackRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppStream");
            string target = "PhotonAdminProxyService.UpdateStack";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-12-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAccessEndpoints())
            {
                context.Writer.WritePropertyName("AccessEndpoints");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAccessEndpointsListValue in publicRequest.AccessEndpoints)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AccessEndpointMarshaller.Instance;
                    marshaller.Marshall(publicRequestAccessEndpointsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetApplicationSettings())
            {
                context.Writer.WritePropertyName("ApplicationSettings");
                context.Writer.WriteStartObject();

                var marshaller = ApplicationSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.ApplicationSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAttributesToDelete())
            {
                context.Writer.WritePropertyName("AttributesToDelete");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAttributesToDeleteListValue in publicRequest.AttributesToDelete)
                {
                        context.Writer.WriteStringValue(publicRequestAttributesToDeleteListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDeleteStorageConnectors())
            {
                context.Writer.WritePropertyName("DeleteStorageConnectors");
                context.Writer.WriteBooleanValue(publicRequest.DeleteStorageConnectors.Value);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetDisplayName())
            {
                context.Writer.WritePropertyName("DisplayName");
                context.Writer.WriteStringValue(publicRequest.DisplayName);
            }

            if(publicRequest.IsSetEmbedHostDomains())
            {
                context.Writer.WritePropertyName("EmbedHostDomains");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEmbedHostDomainsListValue in publicRequest.EmbedHostDomains)
                {
                        context.Writer.WriteStringValue(publicRequestEmbedHostDomainsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetFeedbackURL())
            {
                context.Writer.WritePropertyName("FeedbackURL");
                context.Writer.WriteStringValue(publicRequest.FeedbackURL);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetRedirectURL())
            {
                context.Writer.WritePropertyName("RedirectURL");
                context.Writer.WriteStringValue(publicRequest.RedirectURL);
            }

            if(publicRequest.IsSetStorageConnectors())
            {
                context.Writer.WritePropertyName("StorageConnectors");
                context.Writer.WriteStartArray();
                foreach(var publicRequestStorageConnectorsListValue in publicRequest.StorageConnectors)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StorageConnectorMarshaller.Instance;
                    marshaller.Marshall(publicRequestStorageConnectorsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetStreamingExperienceSettings())
            {
                context.Writer.WritePropertyName("StreamingExperienceSettings");
                context.Writer.WriteStartObject();

                var marshaller = StreamingExperienceSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.StreamingExperienceSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetUserSettings())
            {
                context.Writer.WritePropertyName("UserSettings");
                context.Writer.WriteStartArray();
                foreach(var publicRequestUserSettingsListValue in publicRequest.UserSettings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = UserSettingMarshaller.Instance;
                    marshaller.Marshall(publicRequestUserSettingsListValue, context);

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
        private static UpdateStackRequestMarshaller _instance = new UpdateStackRequestMarshaller();        

        internal static UpdateStackRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateStackRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}