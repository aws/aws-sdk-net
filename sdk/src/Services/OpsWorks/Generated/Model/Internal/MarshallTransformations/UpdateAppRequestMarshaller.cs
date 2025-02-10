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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorks.Model;
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
namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateApp Request Marshaller
    /// </summary>       
    public class UpdateAppRequestMarshaller : IMarshaller<IRequest, UpdateAppRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAppRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAppRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpsWorks");
            string target = "OpsWorks_20130218.UpdateApp";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2013-02-18";
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
                context.Writer.WritePropertyName("AppId");
                context.Writer.WriteStringValue(publicRequest.AppId);
            }

            if(publicRequest.IsSetAppSource())
            {
                context.Writer.WritePropertyName("AppSource");
                context.Writer.WriteStartObject();

                var marshaller = SourceMarshaller.Instance;
                marshaller.Marshall(publicRequest.AppSource, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAttributes())
            {
                context.Writer.WritePropertyName("Attributes");
                context.Writer.WriteStartObject();
                foreach (var publicRequestAttributesKvp in publicRequest.Attributes)
                {
                    context.Writer.WritePropertyName(publicRequestAttributesKvp.Key);
                    var publicRequestAttributesValue = publicRequestAttributesKvp.Value;

                        context.Writer.WriteStringValue(publicRequestAttributesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDataSources())
            {
                context.Writer.WritePropertyName("DataSources");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDataSourcesListValue in publicRequest.DataSources)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequestDataSourcesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetDomains())
            {
                context.Writer.WritePropertyName("Domains");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDomainsListValue in publicRequest.Domains)
                {
                        context.Writer.WriteStringValue(publicRequestDomainsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetEnableSsl())
            {
                context.Writer.WritePropertyName("EnableSsl");
                context.Writer.WriteBooleanValue(publicRequest.EnableSsl.Value);
            }

            if(publicRequest.IsSetEnvironment())
            {
                context.Writer.WritePropertyName("Environment");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEnvironmentListValue in publicRequest.Environment)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EnvironmentVariableMarshaller.Instance;
                    marshaller.Marshall(publicRequestEnvironmentListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetSslConfiguration())
            {
                context.Writer.WritePropertyName("SslConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SslConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.SslConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteStringValue(publicRequest.Type);
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
        private static UpdateAppRequestMarshaller _instance = new UpdateAppRequestMarshaller();        

        internal static UpdateAppRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAppRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}