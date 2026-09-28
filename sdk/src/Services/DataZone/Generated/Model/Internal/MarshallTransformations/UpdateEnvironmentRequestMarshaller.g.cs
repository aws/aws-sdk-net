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

using Amazon.DataZone.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateEnvironment Request Marshaller
    /// </summary>
    public partial class UpdateEnvironmentRequestMarshaller : IMarshaller<IRequest, UpdateEnvironmentRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateEnvironmentRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateEnvironmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataZone");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetDomainIdentifier())
            {
                throw new AmazonDataZoneException("Request object does not have required field DomainIdentifier set");
            }
            request.AddPathResource("{domainIdentifier}", StringUtils.FromString(publicRequest.DomainIdentifier));

            if (!publicRequest.IsSetIdentifier())
            {
                throw new AmazonDataZoneException("Request object does not have required field Identifier set");
            }
            request.AddPathResource("{identifier}", StringUtils.FromString(publicRequest.Identifier));

            request.ResourcePath = "/v2/domains/{domainIdentifier}/environments/{identifier}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetBlueprintVersion())
            {
                context.Writer.WritePropertyName("blueprintVersion");
                context.Writer.WriteStringValue(publicRequest.BlueprintVersion);
            }
            if (publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }
            if (publicRequest.IsSetEnvironmentConfigurationName())
            {
                context.Writer.WritePropertyName("environmentConfigurationName");
                context.Writer.WriteStringValue(publicRequest.EnvironmentConfigurationName);
            }
            if (publicRequest.IsSetGlossaryTerms())
            {
                context.Writer.WritePropertyName("glossaryTerms");
                context.Writer.WriteStartArray();
                foreach (var publicRequestGlossaryTermsListValue in publicRequest.GlossaryTerms)
                {
                    context.Writer.WriteStringValue(publicRequestGlossaryTermsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }
            if (publicRequest.IsSetUserParameters())
            {
                context.Writer.WritePropertyName("userParameters");
                context.Writer.WriteStartArray();
                foreach (var publicRequestUserParametersListValue in publicRequest.UserParameters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EnvironmentParameterMarshaller.Instance;
                    marshaller.Marshall(publicRequestUserParametersListValue, context);

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

        private static readonly UpdateEnvironmentRequestMarshaller _instance = new();

        internal static UpdateEnvironmentRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateEnvironmentRequestMarshaller Instance => _instance;
    }
}
