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

using Amazon.CognitoIdentity.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MergeDeveloperIdentities Request Marshaller
    /// </summary>
    public partial class MergeDeveloperIdentitiesRequestMarshaller : IMarshaller<IRequest, MergeDeveloperIdentitiesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((MergeDeveloperIdentitiesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(MergeDeveloperIdentitiesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoIdentity");
            string target = "AWSCognitoIdentityService.MergeDeveloperIdentities";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-06-30";
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
            if (publicRequest.IsSetDestinationUserIdentifier())
            {
                context.Writer.WritePropertyName("DestinationUserIdentifier");
                context.Writer.WriteStringValue(publicRequest.DestinationUserIdentifier);
            }
            if (publicRequest.IsSetDeveloperProviderName())
            {
                context.Writer.WritePropertyName("DeveloperProviderName");
                context.Writer.WriteStringValue(publicRequest.DeveloperProviderName);
            }
            if (publicRequest.IsSetIdentityPoolId())
            {
                context.Writer.WritePropertyName("IdentityPoolId");
                context.Writer.WriteStringValue(publicRequest.IdentityPoolId);
            }
            if (publicRequest.IsSetSourceUserIdentifier())
            {
                context.Writer.WritePropertyName("SourceUserIdentifier");
                context.Writer.WriteStringValue(publicRequest.SourceUserIdentifier);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly MergeDeveloperIdentitiesRequestMarshaller _instance = new();

        internal static MergeDeveloperIdentitiesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static MergeDeveloperIdentitiesRequestMarshaller Instance => _instance;
    }
}
