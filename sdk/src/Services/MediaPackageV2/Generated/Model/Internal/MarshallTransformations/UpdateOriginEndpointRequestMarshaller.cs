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

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaPackageV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateOriginEndpoint Request Marshaller
    /// </summary>       
    public class UpdateOriginEndpointRequestMarshaller : IMarshaller<IRequest, UpdateOriginEndpointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateOriginEndpointRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateOriginEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaPackageV2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-12-25";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetChannelGroupName())
                throw new AmazonMediaPackageV2Exception("Request object does not have required field ChannelGroupName set");
            request.AddPathResource("{ChannelGroupName}", StringUtils.FromString(publicRequest.ChannelGroupName));
            if (!publicRequest.IsSetChannelName())
                throw new AmazonMediaPackageV2Exception("Request object does not have required field ChannelName set");
            request.AddPathResource("{ChannelName}", StringUtils.FromString(publicRequest.ChannelName));
            if (!publicRequest.IsSetOriginEndpointName())
                throw new AmazonMediaPackageV2Exception("Request object does not have required field OriginEndpointName set");
            request.AddPathResource("{OriginEndpointName}", StringUtils.FromString(publicRequest.OriginEndpointName));
            request.ResourcePath = "/channelGroup/{ChannelGroupName}/channel/{ChannelName}/originEndpoint/{OriginEndpointName}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetContainerType())
                {
                    context.Writer.WritePropertyName("ContainerType");
                    context.Writer.Write(publicRequest.ContainerType);
                }

                if(publicRequest.IsSetDashManifests())
                {
                    context.Writer.WritePropertyName("DashManifests");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDashManifestsListValue in publicRequest.DashManifests)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CreateDashManifestConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestDashManifestsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
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

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

        
            if (publicRequest.IsSetETag()) 
            {
                request.Headers["x-amzn-update-if-match"] = publicRequest.ETag;
            }

            return request;
        }
        private static UpdateOriginEndpointRequestMarshaller _instance = new UpdateOriginEndpointRequestMarshaller();        

        internal static UpdateOriginEndpointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateOriginEndpointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618