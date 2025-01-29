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
    /// CreateRelationalDatabaseFromSnapshot Request Marshaller
    /// </summary>       
    public class CreateRelationalDatabaseFromSnapshotRequestMarshaller : IMarshaller<IRequest, CreateRelationalDatabaseFromSnapshotRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateRelationalDatabaseFromSnapshotRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateRelationalDatabaseFromSnapshotRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lightsail");
            string target = "Lightsail_20161128.CreateRelationalDatabaseFromSnapshot";
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
            if(publicRequest.IsSetAvailabilityZone())
            {
                context.Writer.WritePropertyName("availabilityZone");
                context.Writer.WriteStringValue(publicRequest.AvailabilityZone);
            }

            if(publicRequest.IsSetPubliclyAccessible())
            {
                context.Writer.WritePropertyName("publiclyAccessible");
                context.Writer.WriteBooleanValue(publicRequest.PubliclyAccessible.Value);
            }

            if(publicRequest.IsSetRelationalDatabaseBundleId())
            {
                context.Writer.WritePropertyName("relationalDatabaseBundleId");
                context.Writer.WriteStringValue(publicRequest.RelationalDatabaseBundleId);
            }

            if(publicRequest.IsSetRelationalDatabaseName())
            {
                context.Writer.WritePropertyName("relationalDatabaseName");
                context.Writer.WriteStringValue(publicRequest.RelationalDatabaseName);
            }

            if(publicRequest.IsSetRelationalDatabaseSnapshotName())
            {
                context.Writer.WritePropertyName("relationalDatabaseSnapshotName");
                context.Writer.WriteStringValue(publicRequest.RelationalDatabaseSnapshotName);
            }

            if(publicRequest.IsSetRestoreTime())
            {
                context.Writer.WritePropertyName("restoreTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.RestoreTime.Value)));
            }

            if(publicRequest.IsSetSourceRelationalDatabaseName())
            {
                context.Writer.WritePropertyName("sourceRelationalDatabaseName");
                context.Writer.WriteStringValue(publicRequest.SourceRelationalDatabaseName);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
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

            if(publicRequest.IsSetUseLatestRestorableTime())
            {
                context.Writer.WritePropertyName("useLatestRestorableTime");
                context.Writer.WriteBooleanValue(publicRequest.UseLatestRestorableTime.Value);
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
        private static CreateRelationalDatabaseFromSnapshotRequestMarshaller _instance = new CreateRelationalDatabaseFromSnapshotRequestMarshaller();        

        internal static CreateRelationalDatabaseFromSnapshotRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateRelationalDatabaseFromSnapshotRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}