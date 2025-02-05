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
 * Do not modify this file. This file is generated from the ssm-sap-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SsmSap.Model;
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
namespace Amazon.SsmSap.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateApplicationSettings Request Marshaller
    /// </summary>       
    public class UpdateApplicationSettingsRequestMarshaller : IMarshaller<IRequest, UpdateApplicationSettingsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateApplicationSettingsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateApplicationSettingsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SsmSap");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/update-application-settings";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetApplicationId())
            {
                context.Writer.WritePropertyName("ApplicationId");
                context.Writer.WriteStringValue(publicRequest.ApplicationId);
            }

            if(publicRequest.IsSetBackint())
            {
                context.Writer.WritePropertyName("Backint");
                context.Writer.WriteStartObject();

                var marshaller = BackintConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.Backint, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCredentialsToAddOrUpdate())
            {
                context.Writer.WritePropertyName("CredentialsToAddOrUpdate");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCredentialsToAddOrUpdateListValue in publicRequest.CredentialsToAddOrUpdate)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ApplicationCredentialMarshaller.Instance;
                    marshaller.Marshall(publicRequestCredentialsToAddOrUpdateListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetCredentialsToRemove())
            {
                context.Writer.WritePropertyName("CredentialsToRemove");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCredentialsToRemoveListValue in publicRequest.CredentialsToRemove)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ApplicationCredentialMarshaller.Instance;
                    marshaller.Marshall(publicRequestCredentialsToRemoveListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDatabaseArn())
            {
                context.Writer.WritePropertyName("DatabaseArn");
                context.Writer.WriteStringValue(publicRequest.DatabaseArn);
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
        private static UpdateApplicationSettingsRequestMarshaller _instance = new UpdateApplicationSettingsRequestMarshaller();        

        internal static UpdateApplicationSettingsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateApplicationSettingsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}