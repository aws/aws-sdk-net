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

using Amazon.LicenseManagerUserSubscriptions.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.LicenseManagerUserSubscriptions.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeregisterIdentityProvider Request Marshaller
    /// </summary>
    public partial class DeregisterIdentityProviderRequestMarshaller : IMarshaller<IRequest, DeregisterIdentityProviderRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeregisterIdentityProviderRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeregisterIdentityProviderRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LicenseManagerUserSubscriptions");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/identity-provider/DeregisterIdentityProvider";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetIdentityProvider())
            {
                context.Writer.WritePropertyName("IdentityProvider");
                context.Writer.WriteStartObject();

                var marshaller = IdentityProviderMarshaller.Instance;
                marshaller.Marshall(publicRequest.IdentityProvider, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetIdentityProviderArn())
            {
                context.Writer.WritePropertyName("IdentityProviderArn");
                context.Writer.WriteStringValue(publicRequest.IdentityProviderArn);
            }
            if (publicRequest.IsSetProduct())
            {
                context.Writer.WritePropertyName("Product");
                context.Writer.WriteStringValue(publicRequest.Product);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly DeregisterIdentityProviderRequestMarshaller _instance = new();

        internal static DeregisterIdentityProviderRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeregisterIdentityProviderRequestMarshaller Instance => _instance;
    }
}
