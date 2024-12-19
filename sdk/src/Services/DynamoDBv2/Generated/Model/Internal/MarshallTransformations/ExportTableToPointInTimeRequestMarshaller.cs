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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#pragma warning disable CS0612,CS0618
namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ExportTableToPointInTime Request Marshaller
    /// </summary>       
    public class ExportTableToPointInTimeRequestMarshaller : IMarshaller<IRequest, ExportTableToPointInTimeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ExportTableToPointInTimeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ExportTableToPointInTimeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DynamoDBv2");
            string target = "DynamoDB_20120810.ExportTableToPointInTime";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2012-08-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if NETCOREAPP3_1_OR_GREATER
            ArrayBufferWriter<byte> arrayBufferWriter = new ArrayBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetExportFormat())
            {
                context.Writer.WritePropertyName("ExportFormat");
                context.Writer.WriteStringValue(publicRequest.ExportFormat);
            }

            if(publicRequest.IsSetExportTime())
            {
                context.Writer.WritePropertyName("ExportTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.ExportTime.Value)));
            }

            if(publicRequest.IsSetExportType())
            {
                context.Writer.WritePropertyName("ExportType");
                context.Writer.WriteStringValue(publicRequest.ExportType);
            }

            if(publicRequest.IsSetIncrementalExportSpecification())
            {
                context.Writer.WritePropertyName("IncrementalExportSpecification");
                context.Writer.WriteStartObject();

                var marshaller = IncrementalExportSpecificationMarshaller.Instance;
                marshaller.Marshall(publicRequest.IncrementalExportSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetS3Bucket())
            {
                context.Writer.WritePropertyName("S3Bucket");
                context.Writer.WriteStringValue(publicRequest.S3Bucket);
            }

            if(publicRequest.IsSetS3BucketOwner())
            {
                context.Writer.WritePropertyName("S3BucketOwner");
                context.Writer.WriteStringValue(publicRequest.S3BucketOwner);
            }

            if(publicRequest.IsSetS3Prefix())
            {
                context.Writer.WritePropertyName("S3Prefix");
                context.Writer.WriteStringValue(publicRequest.S3Prefix);
            }

            if(publicRequest.IsSetS3SseAlgorithm())
            {
                context.Writer.WritePropertyName("S3SseAlgorithm");
                context.Writer.WriteStringValue(publicRequest.S3SseAlgorithm);
            }

            if(publicRequest.IsSetS3SseKmsKeyId())
            {
                context.Writer.WritePropertyName("S3SseKmsKeyId");
                context.Writer.WriteStringValue(publicRequest.S3SseKmsKeyId);
            }

            if(publicRequest.IsSetTableArn())
            {
                context.Writer.WritePropertyName("TableArn");
                context.Writer.WriteStringValue(publicRequest.TableArn);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETCOREAPP3_1_OR_GREATER
            request.Content = arrayBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static ExportTableToPointInTimeRequestMarshaller _instance = new ExportTableToPointInTimeRequestMarshaller();        

        internal static ExportTableToPointInTimeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ExportTableToPointInTimeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}