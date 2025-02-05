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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServerMigrationService.Model;
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
namespace Amazon.ServerMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutAppValidationConfiguration Request Marshaller
    /// </summary>       
    public class PutAppValidationConfigurationRequestMarshaller : IMarshaller<IRequest, PutAppValidationConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutAppValidationConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutAppValidationConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ServerMigrationService");
            string target = "AWSServerMigrationService_V2016_10_24.PutAppValidationConfiguration";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-10-24";
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
            if(publicRequest.IsSetAppId())
            {
                context.Writer.WritePropertyName("appId");
                context.Writer.WriteStringValue(publicRequest.AppId);
            }

            if(publicRequest.IsSetAppValidationConfigurations())
            {
                context.Writer.WritePropertyName("appValidationConfigurations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAppValidationConfigurationsListValue in publicRequest.AppValidationConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AppValidationConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestAppValidationConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetServerGroupValidationConfigurations())
            {
                context.Writer.WritePropertyName("serverGroupValidationConfigurations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestServerGroupValidationConfigurationsListValue in publicRequest.ServerGroupValidationConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ServerGroupValidationConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestServerGroupValidationConfigurationsListValue, context);

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
        private static PutAppValidationConfigurationRequestMarshaller _instance = new PutAppValidationConfigurationRequestMarshaller();        

        internal static PutAppValidationConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutAppValidationConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}