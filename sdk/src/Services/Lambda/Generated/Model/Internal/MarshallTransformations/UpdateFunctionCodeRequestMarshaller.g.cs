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

using Amazon.Lambda.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateFunctionCode Request Marshaller
    /// </summary>
    public partial class UpdateFunctionCodeRequestMarshaller : IMarshaller<IRequest, UpdateFunctionCodeRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateFunctionCodeRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateFunctionCodeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lambda");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-03-31";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetFunctionName())
            {
                throw new AmazonLambdaException("Request object does not have required field FunctionName set");
            }
            request.AddPathResource("{FunctionName}", StringUtils.FromString(publicRequest.FunctionName));

            request.ResourcePath = "/2015-03-31/functions/{FunctionName}/code";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetArchitectures())
            {
                context.Writer.WritePropertyName("Architectures");
                context.Writer.WriteStartArray();
                foreach (var publicRequestArchitecturesListValue in publicRequest.Architectures)
                {
                    context.Writer.WriteStringValue(publicRequestArchitecturesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetDryRun())
            {
                context.Writer.WritePropertyName("DryRun");
                context.Writer.WriteBooleanValue(publicRequest.DryRun.Value);
            }
            if (publicRequest.IsSetImageUri())
            {
                context.Writer.WritePropertyName("ImageUri");
                context.Writer.WriteStringValue(publicRequest.ImageUri);
            }
            if (publicRequest.IsSetPublish())
            {
                context.Writer.WritePropertyName("Publish");
                context.Writer.WriteBooleanValue(publicRequest.Publish.Value);
            }
            if (publicRequest.IsSetPublishTo())
            {
                context.Writer.WritePropertyName("PublishTo");
                context.Writer.WriteStringValue(publicRequest.PublishTo);
            }
            if (publicRequest.IsSetRevisionId())
            {
                context.Writer.WritePropertyName("RevisionId");
                context.Writer.WriteStringValue(publicRequest.RevisionId);
            }
            if (publicRequest.IsSetS3Bucket())
            {
                context.Writer.WritePropertyName("S3Bucket");
                context.Writer.WriteStringValue(publicRequest.S3Bucket);
            }
            if (publicRequest.IsSetS3Key())
            {
                context.Writer.WritePropertyName("S3Key");
                context.Writer.WriteStringValue(publicRequest.S3Key);
            }
            if (publicRequest.IsSetS3ObjectStorageMode())
            {
                context.Writer.WritePropertyName("S3ObjectStorageMode");
                context.Writer.WriteStringValue(publicRequest.S3ObjectStorageMode);
            }
            if (publicRequest.IsSetS3ObjectVersion())
            {
                context.Writer.WritePropertyName("S3ObjectVersion");
                context.Writer.WriteStringValue(publicRequest.S3ObjectVersion);
            }
            if (publicRequest.IsSetSourceKMSKeyArn())
            {
                context.Writer.WritePropertyName("SourceKMSKeyArn");
                context.Writer.WriteStringValue(publicRequest.SourceKMSKeyArn);
            }
            if (publicRequest.IsSetZipFile())
            {
                context.Writer.WritePropertyName("ZipFile");
                StringUtils.WriteBase64StringValue(context.Writer, publicRequest.ZipFile);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateFunctionCodeRequestMarshaller _instance = new();

        internal static UpdateFunctionCodeRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateFunctionCodeRequestMarshaller Instance => _instance;
    }
}
