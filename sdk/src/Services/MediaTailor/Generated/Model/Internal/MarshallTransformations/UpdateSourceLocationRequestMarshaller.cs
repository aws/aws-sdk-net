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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaTailor.Model;
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
namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateSourceLocation Request Marshaller
    /// </summary>       
    public class UpdateSourceLocationRequestMarshaller : IMarshaller<IRequest, UpdateSourceLocationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateSourceLocationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateSourceLocationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaTailor");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-23";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetSourceLocationName())
                throw new AmazonMediaTailorException("Request object does not have required field SourceLocationName set");
            request.AddPathResource("{SourceLocationName}", StringUtils.FromString(publicRequest.SourceLocationName));
            request.ResourcePath = "/sourceLocation/{SourceLocationName}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAccessConfiguration())
            {
                context.Writer.WritePropertyName("AccessConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AccessConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.AccessConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDefaultSegmentDeliveryConfiguration())
            {
                context.Writer.WritePropertyName("DefaultSegmentDeliveryConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DefaultSegmentDeliveryConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.DefaultSegmentDeliveryConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetHttpConfiguration())
            {
                context.Writer.WritePropertyName("HttpConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = HttpConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.HttpConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSegmentDeliveryConfigurations())
            {
                context.Writer.WritePropertyName("SegmentDeliveryConfigurations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSegmentDeliveryConfigurationsListValue in publicRequest.SegmentDeliveryConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SegmentDeliveryConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestSegmentDeliveryConfigurationsListValue, context);

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
        private static UpdateSourceLocationRequestMarshaller _instance = new UpdateSourceLocationRequestMarshaller();        

        internal static UpdateSourceLocationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateSourceLocationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}