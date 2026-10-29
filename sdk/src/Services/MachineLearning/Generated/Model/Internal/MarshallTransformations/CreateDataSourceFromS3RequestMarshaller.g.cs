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

using Amazon.MachineLearning.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.MachineLearning.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDataSourceFromS3 Request Marshaller
    /// </summary>
    public partial class CreateDataSourceFromS3RequestMarshaller : IMarshaller<IRequest, CreateDataSourceFromS3Request>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDataSourceFromS3Request)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateDataSourceFromS3Request publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MachineLearning");
            string target = "AmazonML_20141212.CreateDataSourceFromS3";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-12-12";
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
            if (publicRequest.IsSetComputeStatistics())
            {
                context.Writer.WritePropertyName("ComputeStatistics");
                context.Writer.WriteBooleanValue(publicRequest.ComputeStatistics.Value);
            }
            if (publicRequest.IsSetDataSourceId())
            {
                context.Writer.WritePropertyName("DataSourceId");
                context.Writer.WriteStringValue(publicRequest.DataSourceId);
            }
            if (publicRequest.IsSetDataSourceName())
            {
                context.Writer.WritePropertyName("DataSourceName");
                context.Writer.WriteStringValue(publicRequest.DataSourceName);
            }
            if (publicRequest.IsSetDataSpec())
            {
                context.Writer.WritePropertyName("DataSpec");
                context.Writer.WriteStartObject();

                var marshaller = S3DataSpecMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataSpec, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateDataSourceFromS3RequestMarshaller _instance = new();

        internal static CreateDataSourceFromS3RequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateDataSourceFromS3RequestMarshaller Instance => _instance;
    }
}
