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
 * Do not modify this file. This file is generated from the appconfigdata-2021-11-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppConfigData.Model;
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
namespace Amazon.AppConfigData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartConfigurationSession Request Marshaller
    /// </summary>       
    public class StartConfigurationSessionRequestMarshaller : IMarshaller<IRequest, StartConfigurationSessionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartConfigurationSessionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartConfigurationSessionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppConfigData");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-11-11";
            request.HttpMethod = "POST";

            request.ResourcePath = "/configurationsessions";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetApplicationIdentifier())
            {
                context.Writer.WritePropertyName("ApplicationIdentifier");
                context.Writer.WriteStringValue(publicRequest.ApplicationIdentifier);
            }

            if(publicRequest.IsSetConfigurationProfileIdentifier())
            {
                context.Writer.WritePropertyName("ConfigurationProfileIdentifier");
                context.Writer.WriteStringValue(publicRequest.ConfigurationProfileIdentifier);
            }

            if(publicRequest.IsSetEnvironmentIdentifier())
            {
                context.Writer.WritePropertyName("EnvironmentIdentifier");
                context.Writer.WriteStringValue(publicRequest.EnvironmentIdentifier);
            }

            if(publicRequest.IsSetRequiredMinimumPollIntervalInSeconds())
            {
                context.Writer.WritePropertyName("RequiredMinimumPollIntervalInSeconds");
                context.Writer.WriteNumberValue(publicRequest.RequiredMinimumPollIntervalInSeconds.Value);
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
        private static StartConfigurationSessionRequestMarshaller _instance = new StartConfigurationSessionRequestMarshaller();        

        internal static StartConfigurationSessionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartConfigurationSessionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}