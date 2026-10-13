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
    /// CreateToken Request Marshaller
    /// </summary>
    public partial class CreateTokenRequestMarshaller : IMarshaller<IRequest, CreateTokenRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTokenRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateTokenRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LicenseManager");
            string target = "AWSLicenseManager.CreateToken";
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
            if (publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }
            if (publicRequest.IsSetExpirationInDays())
            {
                context.Writer.WritePropertyName("ExpirationInDays");
                context.Writer.WriteNumberValue(publicRequest.ExpirationInDays.Value);
            }
            if (publicRequest.IsSetLicenseArn())
            {
                context.Writer.WritePropertyName("LicenseArn");
                context.Writer.WriteStringValue(publicRequest.LicenseArn);
            }
            if (publicRequest.IsSetRoleArns())
            {
                context.Writer.WritePropertyName("RoleArns");
                context.Writer.WriteStartArray();
                foreach (var publicRequestRoleArnsListValue in publicRequest.RoleArns)
                {
                    context.Writer.WriteStringValue(publicRequestRoleArnsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetTokenProperties())
            {
                context.Writer.WritePropertyName("TokenProperties");
                context.Writer.WriteStartArray();
                foreach (var publicRequestTokenPropertiesListValue in publicRequest.TokenProperties)
                {
                    context.Writer.WriteStringValue(publicRequestTokenPropertiesListValue);
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

        private static readonly CreateTokenRequestMarshaller _instance = new();

        internal static CreateTokenRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateTokenRequestMarshaller Instance => _instance;
    }
}
