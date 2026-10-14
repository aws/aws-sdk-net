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

using Amazon.LicenseManager.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.LicenseManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateGrantVersion Request Marshaller
    /// </summary>
    public partial class CreateGrantVersionRequestMarshaller : IMarshaller<IRequest, CreateGrantVersionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateGrantVersionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateGrantVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LicenseManager");
            string target = "AWSLicenseManager.CreateGrantVersion";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-08-01";
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
            if (publicRequest.IsSetAllowedOperations())
            {
                context.Writer.WritePropertyName("AllowedOperations");
                context.Writer.WriteStartArray();
                foreach (var publicRequestAllowedOperationsListValue in publicRequest.AllowedOperations)
                {
                    context.Writer.WriteStringValue(publicRequestAllowedOperationsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }
            if (publicRequest.IsSetGrantArn())
            {
                context.Writer.WritePropertyName("GrantArn");
                context.Writer.WriteStringValue(publicRequest.GrantArn);
            }
            if (publicRequest.IsSetGrantName())
            {
                context.Writer.WritePropertyName("GrantName");
                context.Writer.WriteStringValue(publicRequest.GrantName);
            }
            if (publicRequest.IsSetOptions())
            {
                context.Writer.WritePropertyName("Options");
                context.Writer.WriteStartObject();

                var marshaller = OptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Options, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetSourceVersion())
            {
                context.Writer.WritePropertyName("SourceVersion");
                context.Writer.WriteStringValue(publicRequest.SourceVersion);
            }
            if (publicRequest.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStringValue(publicRequest.Status);
            }
            if (publicRequest.IsSetStatusReason())
            {
                context.Writer.WritePropertyName("StatusReason");
                context.Writer.WriteStringValue(publicRequest.StatusReason);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateGrantVersionRequestMarshaller _instance = new();

        internal static CreateGrantVersionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateGrantVersionRequestMarshaller Instance => _instance;
    }
}
