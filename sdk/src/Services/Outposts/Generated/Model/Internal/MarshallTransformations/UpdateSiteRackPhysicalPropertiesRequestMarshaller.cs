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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Outposts.Model;
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
namespace Amazon.Outposts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateSiteRackPhysicalProperties Request Marshaller
    /// </summary>       
    public class UpdateSiteRackPhysicalPropertiesRequestMarshaller : IMarshaller<IRequest, UpdateSiteRackPhysicalPropertiesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateSiteRackPhysicalPropertiesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateSiteRackPhysicalPropertiesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Outposts");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-03";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetSiteId())
                throw new AmazonOutpostsException("Request object does not have required field SiteId set");
            request.AddPathResource("{SiteId}", StringUtils.FromString(publicRequest.SiteId));
            request.ResourcePath = "/sites/{SiteId}/rackPhysicalProperties";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetFiberOpticCableType())
            {
                context.Writer.WritePropertyName("FiberOpticCableType");
                context.Writer.WriteStringValue(publicRequest.FiberOpticCableType);
            }

            if(publicRequest.IsSetMaximumSupportedWeightLbs())
            {
                context.Writer.WritePropertyName("MaximumSupportedWeightLbs");
                context.Writer.WriteStringValue(publicRequest.MaximumSupportedWeightLbs);
            }

            if(publicRequest.IsSetOpticalStandard())
            {
                context.Writer.WritePropertyName("OpticalStandard");
                context.Writer.WriteStringValue(publicRequest.OpticalStandard);
            }

            if(publicRequest.IsSetPowerConnector())
            {
                context.Writer.WritePropertyName("PowerConnector");
                context.Writer.WriteStringValue(publicRequest.PowerConnector);
            }

            if(publicRequest.IsSetPowerDrawKva())
            {
                context.Writer.WritePropertyName("PowerDrawKva");
                context.Writer.WriteStringValue(publicRequest.PowerDrawKva);
            }

            if(publicRequest.IsSetPowerFeedDrop())
            {
                context.Writer.WritePropertyName("PowerFeedDrop");
                context.Writer.WriteStringValue(publicRequest.PowerFeedDrop);
            }

            if(publicRequest.IsSetPowerPhase())
            {
                context.Writer.WritePropertyName("PowerPhase");
                context.Writer.WriteStringValue(publicRequest.PowerPhase);
            }

            if(publicRequest.IsSetUplinkCount())
            {
                context.Writer.WritePropertyName("UplinkCount");
                context.Writer.WriteStringValue(publicRequest.UplinkCount);
            }

            if(publicRequest.IsSetUplinkGbps())
            {
                context.Writer.WritePropertyName("UplinkGbps");
                context.Writer.WriteStringValue(publicRequest.UplinkGbps);
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
        private static UpdateSiteRackPhysicalPropertiesRequestMarshaller _instance = new UpdateSiteRackPhysicalPropertiesRequestMarshaller();        

        internal static UpdateSiteRackPhysicalPropertiesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateSiteRackPhysicalPropertiesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}