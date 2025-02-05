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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IVS.Model;
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
namespace Amazon.IVS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdatePlaybackRestrictionPolicy Request Marshaller
    /// </summary>       
    public class UpdatePlaybackRestrictionPolicyRequestMarshaller : IMarshaller<IRequest, UpdatePlaybackRestrictionPolicyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdatePlaybackRestrictionPolicyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdatePlaybackRestrictionPolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IVS");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-14";
            request.HttpMethod = "POST";

            request.ResourcePath = "/UpdatePlaybackRestrictionPolicy";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAllowedCountries())
            {
                context.Writer.WritePropertyName("allowedCountries");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAllowedCountriesListValue in publicRequest.AllowedCountries)
                {
                        context.Writer.WriteStringValue(publicRequestAllowedCountriesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAllowedOrigins())
            {
                context.Writer.WritePropertyName("allowedOrigins");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAllowedOriginsListValue in publicRequest.AllowedOrigins)
                {
                        context.Writer.WriteStringValue(publicRequestAllowedOriginsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetArn())
            {
                context.Writer.WritePropertyName("arn");
                context.Writer.WriteStringValue(publicRequest.Arn);
            }

            if(publicRequest.IsSetEnableStrictOriginEnforcement())
            {
                context.Writer.WritePropertyName("enableStrictOriginEnforcement");
                context.Writer.WriteBooleanValue(publicRequest.EnableStrictOriginEnforcement.Value);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
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
        private static UpdatePlaybackRestrictionPolicyRequestMarshaller _instance = new UpdatePlaybackRestrictionPolicyRequestMarshaller();        

        internal static UpdatePlaybackRestrictionPolicyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdatePlaybackRestrictionPolicyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}