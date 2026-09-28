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
    /// CreateProjectProfile Request Marshaller
    /// </summary>
    public partial class CreateProjectProfileRequestMarshaller : IMarshaller<IRequest, CreateProjectProfileRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateProjectProfileRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateProjectProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataZone");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDomainIdentifier())
            {
                throw new AmazonDataZoneException("Request object does not have required field DomainIdentifier set");
            }
            request.AddPathResource("{domainIdentifier}", StringUtils.FromString(publicRequest.DomainIdentifier));

            request.ResourcePath = "/v2/domains/{domainIdentifier}/project-profiles";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAllowCustomProjectResourceTags())
            {
                context.Writer.WritePropertyName("allowCustomProjectResourceTags");
                context.Writer.WriteBooleanValue(publicRequest.AllowCustomProjectResourceTags.Value);
            }
            if (publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }
            if (publicRequest.IsSetDomainUnitIdentifier())
            {
                context.Writer.WritePropertyName("domainUnitIdentifier");
                context.Writer.WriteStringValue(publicRequest.DomainUnitIdentifier);
            }
            if (publicRequest.IsSetEnvironmentConfigurations())
            {
                context.Writer.WritePropertyName("environmentConfigurations");
                context.Writer.WriteStartArray();
                foreach (var publicRequestEnvironmentConfigurationsListValue in publicRequest.EnvironmentConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EnvironmentConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestEnvironmentConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }
            if (publicRequest.IsSetProjectResourceTags())
            {
                context.Writer.WritePropertyName("projectResourceTags");
                context.Writer.WriteStartArray();
                foreach (var publicRequestProjectResourceTagsListValue in publicRequest.ProjectResourceTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ResourceTagParameterMarshaller.Instance;
                    marshaller.Marshall(publicRequestProjectResourceTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetProjectResourceTagsDescription())
            {
                context.Writer.WritePropertyName("projectResourceTagsDescription");
                context.Writer.WriteStringValue(publicRequest.ProjectResourceTagsDescription);
            }
            if (publicRequest.IsSetStatus())
            {
                context.Writer.WritePropertyName("status");
                context.Writer.WriteStringValue(publicRequest.Status);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateProjectProfileRequestMarshaller _instance = new();

        internal static CreateProjectProfileRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateProjectProfileRequestMarshaller Instance => _instance;
    }
}
