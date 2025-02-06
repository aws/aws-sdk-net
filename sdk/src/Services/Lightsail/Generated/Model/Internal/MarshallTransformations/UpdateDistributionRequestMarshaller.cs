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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lightsail.Model;
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
namespace Amazon.Lightsail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDistribution Request Marshaller
    /// </summary>       
    public class UpdateDistributionRequestMarshaller : IMarshaller<IRequest, UpdateDistributionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDistributionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDistributionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lightsail");
            string target = "Lightsail_20161128.UpdateDistribution";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-11-28";
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
            if(publicRequest.IsSetCacheBehaviors())
            {
                context.Writer.WritePropertyName("cacheBehaviors");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCacheBehaviorsListValue in publicRequest.CacheBehaviors)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CacheBehaviorPerPathMarshaller.Instance;
                    marshaller.Marshall(publicRequestCacheBehaviorsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetCacheBehaviorSettings())
            {
                context.Writer.WritePropertyName("cacheBehaviorSettings");
                context.Writer.WriteStartObject();

                var marshaller = CacheSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.CacheBehaviorSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCertificateName())
            {
                context.Writer.WritePropertyName("certificateName");
                context.Writer.WriteStringValue(publicRequest.CertificateName);
            }

            if(publicRequest.IsSetDefaultCacheBehavior())
            {
                context.Writer.WritePropertyName("defaultCacheBehavior");
                context.Writer.WriteStartObject();

                var marshaller = CacheBehaviorMarshaller.Instance;
                marshaller.Marshall(publicRequest.DefaultCacheBehavior, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDistributionName())
            {
                context.Writer.WritePropertyName("distributionName");
                context.Writer.WriteStringValue(publicRequest.DistributionName);
            }

            if(publicRequest.IsSetIsEnabled())
            {
                context.Writer.WritePropertyName("isEnabled");
                context.Writer.WriteBooleanValue(publicRequest.IsEnabled.Value);
            }

            if(publicRequest.IsSetOrigin())
            {
                context.Writer.WritePropertyName("origin");
                context.Writer.WriteStartObject();

                var marshaller = InputOriginMarshaller.Instance;
                marshaller.Marshall(publicRequest.Origin, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetUseDefaultCertificate())
            {
                context.Writer.WritePropertyName("useDefaultCertificate");
                context.Writer.WriteBooleanValue(publicRequest.UseDefaultCertificate.Value);
            }

            if(publicRequest.IsSetViewerMinimumTlsProtocolVersion())
            {
                context.Writer.WritePropertyName("viewerMinimumTlsProtocolVersion");
                context.Writer.WriteStringValue(publicRequest.ViewerMinimumTlsProtocolVersion);
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
        private static UpdateDistributionRequestMarshaller _instance = new UpdateDistributionRequestMarshaller();        

        internal static UpdateDistributionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDistributionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}