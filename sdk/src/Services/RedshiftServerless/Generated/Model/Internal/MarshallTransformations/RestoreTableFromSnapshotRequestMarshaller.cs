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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RedshiftServerless.Model;
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
namespace Amazon.RedshiftServerless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RestoreTableFromSnapshot Request Marshaller
    /// </summary>       
    public class RestoreTableFromSnapshotRequestMarshaller : IMarshaller<IRequest, RestoreTableFromSnapshotRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RestoreTableFromSnapshotRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RestoreTableFromSnapshotRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RedshiftServerless");
            string target = "RedshiftServerless.RestoreTableFromSnapshot";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-04-21";
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
            if(publicRequest.IsSetActivateCaseSensitiveIdentifier())
            {
                context.Writer.WritePropertyName("activateCaseSensitiveIdentifier");
                context.Writer.WriteBooleanValue(publicRequest.ActivateCaseSensitiveIdentifier.Value);
            }

            if(publicRequest.IsSetNamespaceName())
            {
                context.Writer.WritePropertyName("namespaceName");
                context.Writer.WriteStringValue(publicRequest.NamespaceName);
            }

            if(publicRequest.IsSetNewTableName())
            {
                context.Writer.WritePropertyName("newTableName");
                context.Writer.WriteStringValue(publicRequest.NewTableName);
            }

            if(publicRequest.IsSetSnapshotName())
            {
                context.Writer.WritePropertyName("snapshotName");
                context.Writer.WriteStringValue(publicRequest.SnapshotName);
            }

            if(publicRequest.IsSetSourceDatabaseName())
            {
                context.Writer.WritePropertyName("sourceDatabaseName");
                context.Writer.WriteStringValue(publicRequest.SourceDatabaseName);
            }

            if(publicRequest.IsSetSourceSchemaName())
            {
                context.Writer.WritePropertyName("sourceSchemaName");
                context.Writer.WriteStringValue(publicRequest.SourceSchemaName);
            }

            if(publicRequest.IsSetSourceTableName())
            {
                context.Writer.WritePropertyName("sourceTableName");
                context.Writer.WriteStringValue(publicRequest.SourceTableName);
            }

            if(publicRequest.IsSetTargetDatabaseName())
            {
                context.Writer.WritePropertyName("targetDatabaseName");
                context.Writer.WriteStringValue(publicRequest.TargetDatabaseName);
            }

            if(publicRequest.IsSetTargetSchemaName())
            {
                context.Writer.WritePropertyName("targetSchemaName");
                context.Writer.WriteStringValue(publicRequest.TargetSchemaName);
            }

            if(publicRequest.IsSetWorkgroupName())
            {
                context.Writer.WritePropertyName("workgroupName");
                context.Writer.WriteStringValue(publicRequest.WorkgroupName);
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
        private static RestoreTableFromSnapshotRequestMarshaller _instance = new RestoreTableFromSnapshotRequestMarshaller();        

        internal static RestoreTableFromSnapshotRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RestoreTableFromSnapshotRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}