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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.FSx.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.FSx.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDataRepositoryAssociation Request Marshaller
    /// </summary>
    public partial class CreateDataRepositoryAssociationRequestMarshaller : IMarshaller<IRequest, CreateDataRepositoryAssociationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDataRepositoryAssociationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateDataRepositoryAssociationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.FSx");
            string target = "AWSSimbaAPIService_v20180301.CreateDataRepositoryAssociation";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-03-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetBatchImportMetaDataOnCreate())
            {
                context.Writer.WritePropertyName("BatchImportMetaDataOnCreate");
                context.Writer.WriteBooleanValue(publicRequest.BatchImportMetaDataOnCreate.Value);
            }
            if (publicRequest.IsSetClientRequestToken())
            {
                context.Writer.WritePropertyName("ClientRequestToken");
                context.Writer.WriteStringValue(publicRequest.ClientRequestToken);
            }
            else
            {
                context.Writer.WritePropertyName("ClientRequestToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if (publicRequest.IsSetDataRepositoryPath())
            {
                context.Writer.WritePropertyName("DataRepositoryPath");
                context.Writer.WriteStringValue(publicRequest.DataRepositoryPath);
            }
            if (publicRequest.IsSetFileSystemId())
            {
                context.Writer.WritePropertyName("FileSystemId");
                context.Writer.WriteStringValue(publicRequest.FileSystemId);
            }
            if (publicRequest.IsSetFileSystemPath())
            {
                context.Writer.WritePropertyName("FileSystemPath");
                context.Writer.WriteStringValue(publicRequest.FileSystemPath);
            }
            if (publicRequest.IsSetImportedFileChunkSize())
            {
                context.Writer.WritePropertyName("ImportedFileChunkSize");
                context.Writer.WriteNumberValue(publicRequest.ImportedFileChunkSize.Value);
            }
            if (publicRequest.IsSetS3())
            {
                context.Writer.WritePropertyName("S3");
                context.Writer.WriteStartObject();

                var marshaller = S3DataRepositoryConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.S3, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach (var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateDataRepositoryAssociationRequestMarshaller _instance = new();

        internal static CreateDataRepositoryAssociationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateDataRepositoryAssociationRequestMarshaller Instance => _instance;
    }
}
