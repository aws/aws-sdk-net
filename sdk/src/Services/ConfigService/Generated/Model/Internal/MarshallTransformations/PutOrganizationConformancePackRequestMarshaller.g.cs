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

using Amazon.ConfigService.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutOrganizationConformancePack Request Marshaller
    /// </summary>
    public partial class PutOrganizationConformancePackRequestMarshaller : IMarshaller<IRequest, PutOrganizationConformancePackRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutOrganizationConformancePackRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(PutOrganizationConformancePackRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ConfigService");
            string target = "StarlingDoveService.PutOrganizationConformancePack";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-11-12";
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
            if (publicRequest.IsSetConformancePackInputParameters())
            {
                context.Writer.WritePropertyName("ConformancePackInputParameters");
                context.Writer.WriteStartArray();
                foreach (var publicRequestConformancePackInputParametersListValue in publicRequest.ConformancePackInputParameters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ConformancePackInputParameterMarshaller.Instance;
                    marshaller.Marshall(publicRequestConformancePackInputParametersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetDeliveryS3Bucket())
            {
                context.Writer.WritePropertyName("DeliveryS3Bucket");
                context.Writer.WriteStringValue(publicRequest.DeliveryS3Bucket);
            }
            if (publicRequest.IsSetDeliveryS3KeyPrefix())
            {
                context.Writer.WritePropertyName("DeliveryS3KeyPrefix");
                context.Writer.WriteStringValue(publicRequest.DeliveryS3KeyPrefix);
            }
            if (publicRequest.IsSetExcludedAccounts())
            {
                context.Writer.WritePropertyName("ExcludedAccounts");
                context.Writer.WriteStartArray();
                foreach (var publicRequestExcludedAccountsListValue in publicRequest.ExcludedAccounts)
                {
                    context.Writer.WriteStringValue(publicRequestExcludedAccountsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetOrganizationConformancePackName())
            {
                context.Writer.WritePropertyName("OrganizationConformancePackName");
                context.Writer.WriteStringValue(publicRequest.OrganizationConformancePackName);
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
            if (publicRequest.IsSetTemplateBody())
            {
                context.Writer.WritePropertyName("TemplateBody");
                context.Writer.WriteStringValue(publicRequest.TemplateBody);
            }
            if (publicRequest.IsSetTemplateS3Uri())
            {
                context.Writer.WritePropertyName("TemplateS3Uri");
                context.Writer.WriteStringValue(publicRequest.TemplateS3Uri);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly PutOrganizationConformancePackRequestMarshaller _instance = new();

        internal static PutOrganizationConformancePackRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PutOrganizationConformancePackRequestMarshaller Instance => _instance;
    }
}
