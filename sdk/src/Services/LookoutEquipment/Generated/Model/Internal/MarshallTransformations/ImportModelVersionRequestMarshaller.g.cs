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

using Amazon.LookoutEquipment.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.LookoutEquipment.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImportModelVersion Request Marshaller
    /// </summary>
    public partial class ImportModelVersionRequestMarshaller : IMarshaller<IRequest, ImportModelVersionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ImportModelVersionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ImportModelVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LookoutEquipment");
            string target = "AWSLookoutEquipmentFrontendService.ImportModelVersion";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-12-15";
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
            if (publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }
            else
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if (publicRequest.IsSetDatasetName())
            {
                context.Writer.WritePropertyName("DatasetName");
                context.Writer.WriteStringValue(publicRequest.DatasetName);
            }
            if (publicRequest.IsSetInferenceDataImportStrategy())
            {
                context.Writer.WritePropertyName("InferenceDataImportStrategy");
                context.Writer.WriteStringValue(publicRequest.InferenceDataImportStrategy);
            }
            if (publicRequest.IsSetLabelsInputConfiguration())
            {
                context.Writer.WritePropertyName("LabelsInputConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = LabelsInputConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.LabelsInputConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetModelName())
            {
                context.Writer.WritePropertyName("ModelName");
                context.Writer.WriteStringValue(publicRequest.ModelName);
            }
            if (publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }
            if (publicRequest.IsSetServerSideKmsKeyId())
            {
                context.Writer.WritePropertyName("ServerSideKmsKeyId");
                context.Writer.WriteStringValue(publicRequest.ServerSideKmsKeyId);
            }
            if (publicRequest.IsSetSourceModelVersionArn())
            {
                context.Writer.WritePropertyName("SourceModelVersionArn");
                context.Writer.WriteStringValue(publicRequest.SourceModelVersionArn);
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

        private static readonly ImportModelVersionRequestMarshaller _instance = new();

        internal static ImportModelVersionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ImportModelVersionRequestMarshaller Instance => _instance;
    }
}
