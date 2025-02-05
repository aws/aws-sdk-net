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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DatabaseMigrationService.Model;
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
namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDataMigration Request Marshaller
    /// </summary>       
    public class CreateDataMigrationRequestMarshaller : IMarshaller<IRequest, CreateDataMigrationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDataMigrationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDataMigrationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DatabaseMigrationService");
            string target = "AmazonDMSv20160101.CreateDataMigration";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-01-01";
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
            if(publicRequest.IsSetDataMigrationName())
            {
                context.Writer.WritePropertyName("DataMigrationName");
                context.Writer.WriteStringValue(publicRequest.DataMigrationName);
            }

            if(publicRequest.IsSetDataMigrationType())
            {
                context.Writer.WritePropertyName("DataMigrationType");
                context.Writer.WriteStringValue(publicRequest.DataMigrationType);
            }

            if(publicRequest.IsSetEnableCloudwatchLogs())
            {
                context.Writer.WritePropertyName("EnableCloudwatchLogs");
                context.Writer.WriteBooleanValue(publicRequest.EnableCloudwatchLogs.Value);
            }

            if(publicRequest.IsSetMigrationProjectIdentifier())
            {
                context.Writer.WritePropertyName("MigrationProjectIdentifier");
                context.Writer.WriteStringValue(publicRequest.MigrationProjectIdentifier);
            }

            if(publicRequest.IsSetNumberOfJobs())
            {
                context.Writer.WritePropertyName("NumberOfJobs");
                context.Writer.WriteNumberValue(publicRequest.NumberOfJobs.Value);
            }

            if(publicRequest.IsSetSelectionRules())
            {
                context.Writer.WritePropertyName("SelectionRules");
                context.Writer.WriteStringValue(publicRequest.SelectionRules);
            }

            if(publicRequest.IsSetServiceAccessRoleArn())
            {
                context.Writer.WritePropertyName("ServiceAccessRoleArn");
                context.Writer.WriteStringValue(publicRequest.ServiceAccessRoleArn);
            }

            if(publicRequest.IsSetSourceDataSettings())
            {
                context.Writer.WritePropertyName("SourceDataSettings");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSourceDataSettingsListValue in publicRequest.SourceDataSettings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SourceDataSettingMarshaller.Instance;
                    marshaller.Marshall(publicRequestSourceDataSettingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTargetDataSettings())
            {
                context.Writer.WritePropertyName("TargetDataSettings");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTargetDataSettingsListValue in publicRequest.TargetDataSettings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TargetDataSettingMarshaller.Instance;
                    marshaller.Marshall(publicRequestTargetDataSettingsListValue, context);

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
        private static CreateDataMigrationRequestMarshaller _instance = new CreateDataMigrationRequestMarshaller();        

        internal static CreateDataMigrationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDataMigrationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}