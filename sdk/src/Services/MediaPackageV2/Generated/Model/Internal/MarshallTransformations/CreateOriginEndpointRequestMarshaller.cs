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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaPackageV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaPackageV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateOriginEndpoint Request Marshaller
    /// </summary>       
    public class CreateOriginEndpointRequestMarshaller : IMarshaller<IRequest, CreateOriginEndpointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateOriginEndpointRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateOriginEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaPackageV2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-12-25";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetChannelGroupName())
                throw new AmazonMediaPackageV2Exception("Request object does not have required field ChannelGroupName set");
            request.AddPathResource("{ChannelGroupName}", StringUtils.FromString(publicRequest.ChannelGroupName));
            if (!publicRequest.IsSetChannelName())
                throw new AmazonMediaPackageV2Exception("Request object does not have required field ChannelName set");
            request.AddPathResource("{ChannelName}", StringUtils.FromString(publicRequest.ChannelName));
            request.ResourcePath = "/channelGroup/{ChannelGroupName}/channel/{ChannelName}/originEndpoint";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetContainerType())
                {
                    context.Writer.WritePropertyName("ContainerType");
                    context.Writer.Write(publicRequest.ContainerType);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetHlsManifests())
                {
                    context.Writer.WritePropertyName("HlsManifests");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestHlsManifestsListValue in publicRequest.HlsManifests)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CreateHlsManifestConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestHlsManifestsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetLowLatencyHlsManifests())
                {
                    context.Writer.WritePropertyName("LowLatencyHlsManifests");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLowLatencyHlsManifestsListValue in publicRequest.LowLatencyHlsManifests)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CreateLowLatencyHlsManifestConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestLowLatencyHlsManifestsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetOriginEndpointName())
                {
                    context.Writer.WritePropertyName("OriginEndpointName");
                    context.Writer.Write(publicRequest.OriginEndpointName);
                }

                if(publicRequest.IsSetSegment())
                {
                    context.Writer.WritePropertyName("Segment");
                    context.Writer.WriteObjectStart();

                    var marshaller = SegmentMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Segment, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetStartoverWindowSeconds())
                {
                    context.Writer.WritePropertyName("StartoverWindowSeconds");
                    context.Writer.Write(publicRequest.StartoverWindowSeconds);
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

        
            if (publicRequest.IsSetClientToken()) 
            {
                request.Headers["x-amzn-client-token"] = publicRequest.ClientToken;
            }

            return request;
        }
        private static CreateOriginEndpointRequestMarshaller _instance = new CreateOriginEndpointRequestMarshaller();        

        internal static CreateOriginEndpointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateOriginEndpointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}