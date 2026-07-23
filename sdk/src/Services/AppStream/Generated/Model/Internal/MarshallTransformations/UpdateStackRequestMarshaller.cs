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
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

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
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/PhotonAdminProxyService/operation/UpdateStack";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-12-01";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAccessEndpoints())
                {
                    context.Writer.WriteTextString("AccessEndpoints");
                    context.Writer.WriteStartArray(publicRequest.AccessEndpoints.Count);
                    foreach(var publicRequestAccessEndpointsListValue in publicRequest.AccessEndpoints)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = AccessEndpointMarshaller.Instance;
                        marshaller.Marshall(publicRequestAccessEndpointsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetAgentAccessConfig())
                {
                    context.Writer.WriteTextString("AgentAccessConfig");
                    context.Writer.WriteStartMap(null);

                    var marshaller = AgentAccessConfigForUpdateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AgentAccessConfig, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetApplicationSettings())
                {
                    context.Writer.WriteTextString("ApplicationSettings");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ApplicationSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ApplicationSettings, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetAttributesToDelete())
                {
                    context.Writer.WriteTextString("AttributesToDelete");
                    context.Writer.WriteStartArray(publicRequest.AttributesToDelete.Count);
                    foreach(var publicRequestAttributesToDeleteListValue in publicRequest.AttributesToDelete)
                    {
                            context.Writer.WriteTextString(publicRequestAttributesToDeleteListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetContentRedirection())
                {
                    context.Writer.WriteTextString("ContentRedirection");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ContentRedirectionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ContentRedirection, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetDeleteStorageConnectors())
                {
                    context.Writer.WriteTextString("DeleteStorageConnectors");
                    context.Writer.WriteBoolean(publicRequest.DeleteStorageConnectors.Value);
                }
                if (publicRequest.IsSetDescription())
                {
                    context.Writer.WriteTextString("Description");
                    context.Writer.WriteTextString(publicRequest.Description);
                }
                if (publicRequest.IsSetDisplayName())
                {
                    context.Writer.WriteTextString("DisplayName");
                    context.Writer.WriteTextString(publicRequest.DisplayName);
                }
                if (publicRequest.IsSetEmbedHostDomains())
                {
                    context.Writer.WriteTextString("EmbedHostDomains");
                    context.Writer.WriteStartArray(publicRequest.EmbedHostDomains.Count);
                    foreach(var publicRequestEmbedHostDomainsListValue in publicRequest.EmbedHostDomains)
                    {
                            context.Writer.WriteTextString(publicRequestEmbedHostDomainsListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetFeedbackURL())
                {
                    context.Writer.WriteTextString("FeedbackURL");
                    context.Writer.WriteTextString(publicRequest.FeedbackURL);
                }
                if (publicRequest.IsSetName())
                {
                    context.Writer.WriteTextString("Name");
                    context.Writer.WriteTextString(publicRequest.Name);
                }
                if (publicRequest.IsSetRedirectURL())
                {
                    context.Writer.WriteTextString("RedirectURL");
                    context.Writer.WriteTextString(publicRequest.RedirectURL);
                }
                if (publicRequest.IsSetStorageConnectors())
                {
                    context.Writer.WriteTextString("StorageConnectors");
                    context.Writer.WriteStartArray(publicRequest.StorageConnectors.Count);
                    foreach(var publicRequestStorageConnectorsListValue in publicRequest.StorageConnectors)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = StorageConnectorMarshaller.Instance;
                        marshaller.Marshall(publicRequestStorageConnectorsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetStreamingExperienceSettings())
                {
                    context.Writer.WriteTextString("StreamingExperienceSettings");
                    context.Writer.WriteStartMap(null);

                    var marshaller = StreamingExperienceSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.StreamingExperienceSettings, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetUserSettings())
                {
                    context.Writer.WriteTextString("UserSettings");
                    context.Writer.WriteStartArray(publicRequest.UserSettings.Count);
                    foreach(var publicRequestUserSettingsListValue in publicRequest.UserSettings)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = UserSettingMarshaller.Instance;
                        marshaller.Marshall(publicRequestUserSettingsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                writer.WriteEndMap();
#if !NETFRAMEWORK
                // Encode directly into a pooled buffer instead of allocating a new byte[] per request.
                // The buffer is pre-sized to writer.BytesWritten so it's rented at the right size up front,
                // avoiding the default-size rent followed by a resize+return.
                var encodedLength = writer.BytesWritten;
                request.ContentStream = new PooledContentStream(encodedLength);
                var bufferWriter = ((PooledContentStream)request.ContentStream).BufferWriter;
                var span = bufferWriter.GetSpan(encodedLength);
                var bytesWritten = writer.Encode(span);
                bufferWriter.Advance(bytesWritten);
#else
                request.Content = writer.Encode();
#endif
            }
            finally
            {
                CborWriterPool.Return(writer);
            }
            
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