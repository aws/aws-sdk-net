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

using Amazon.WellArchitected.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.WellArchitected.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SendAgentOrganizationalReportDataToS3 Request Marshaller
    /// </summary>
    public partial class SendAgentOrganizationalReportDataToS3RequestMarshaller : IMarshaller<IRequest, SendAgentOrganizationalReportDataToS3Request>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendAgentOrganizationalReportDataToS3Request)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(SendAgentOrganizationalReportDataToS3Request publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WellArchitected");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-03-31";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetReportId())
            {
                throw new AmazonWellArchitectedException("Request object does not have required field ReportId set");
            }
            request.AddPathResource("{reportId}", StringUtils.FromString(publicRequest.ReportId));

            request.ResourcePath = "/api/v1/agent-organizational-reports/{reportId}/send-to-s3";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetBucketArn())
            {
                context.Writer.WritePropertyName("bucketArn");
                context.Writer.WriteStringValue(publicRequest.BucketArn);
            }
            if (publicRequest.IsSetFormat())
            {
                context.Writer.WritePropertyName("format");
                context.Writer.WriteStringValue(publicRequest.Format);
            }
            if (publicRequest.IsSetObjectKey())
            {
                context.Writer.WritePropertyName("objectKey");
                context.Writer.WriteStringValue(publicRequest.ObjectKey);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly SendAgentOrganizationalReportDataToS3RequestMarshaller _instance = new();

        internal static SendAgentOrganizationalReportDataToS3RequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SendAgentOrganizationalReportDataToS3RequestMarshaller Instance => _instance;
    }
}
