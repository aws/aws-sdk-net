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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
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
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCrawler Request Marshaller
    /// </summary>       
    public class CreateCrawlerRequestMarshaller : IMarshaller<IRequest, CreateCrawlerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCrawlerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCrawlerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Glue");
            string target = "AWSGlue.CreateCrawler";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-03-31";
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
            if(publicRequest.IsSetClassifiers())
            {
                context.Writer.WritePropertyName("Classifiers");
                context.Writer.WriteStartArray();
                foreach(var publicRequestClassifiersListValue in publicRequest.Classifiers)
                {
                        context.Writer.WriteStringValue(publicRequestClassifiersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetConfiguration())
            {
                context.Writer.WritePropertyName("Configuration");
                context.Writer.WriteStringValue(publicRequest.Configuration);
            }

            if(publicRequest.IsSetCrawlerSecurityConfiguration())
            {
                context.Writer.WritePropertyName("CrawlerSecurityConfiguration");
                context.Writer.WriteStringValue(publicRequest.CrawlerSecurityConfiguration);
            }

            if(publicRequest.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("DatabaseName");
                context.Writer.WriteStringValue(publicRequest.DatabaseName);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetLakeFormationConfiguration())
            {
                context.Writer.WritePropertyName("LakeFormationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = LakeFormationConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.LakeFormationConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetLineageConfiguration())
            {
                context.Writer.WritePropertyName("LineageConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = LineageConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.LineageConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetRecrawlPolicy())
            {
                context.Writer.WritePropertyName("RecrawlPolicy");
                context.Writer.WriteStartObject();

                var marshaller = RecrawlPolicyMarshaller.Instance;
                marshaller.Marshall(publicRequest.RecrawlPolicy, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRole())
            {
                context.Writer.WritePropertyName("Role");
                context.Writer.WriteStringValue(publicRequest.Role);
            }

            if(publicRequest.IsSetSchedule())
            {
                context.Writer.WritePropertyName("Schedule");
                context.Writer.WriteStringValue(publicRequest.Schedule);
            }

            if(publicRequest.IsSetSchemaChangePolicy())
            {
                context.Writer.WritePropertyName("SchemaChangePolicy");
                context.Writer.WriteStartObject();

                var marshaller = SchemaChangePolicyMarshaller.Instance;
                marshaller.Marshall(publicRequest.SchemaChangePolicy, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTablePrefix())
            {
                context.Writer.WritePropertyName("TablePrefix");
                context.Writer.WriteStringValue(publicRequest.TablePrefix);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTargets())
            {
                context.Writer.WritePropertyName("Targets");
                context.Writer.WriteStartObject();

                var marshaller = CrawlerTargetsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Targets, context);

                context.Writer.WriteEndObject();
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
        private static CreateCrawlerRequestMarshaller _instance = new CreateCrawlerRequestMarshaller();        

        internal static CreateCrawlerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCrawlerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}