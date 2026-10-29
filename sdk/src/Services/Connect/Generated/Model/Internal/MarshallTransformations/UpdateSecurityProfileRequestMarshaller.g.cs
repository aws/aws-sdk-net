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

using Amazon.Connect.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateSecurityProfile Request Marshaller
    /// </summary>
    public partial class UpdateSecurityProfileRequestMarshaller : IMarshaller<IRequest, UpdateSecurityProfileRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateSecurityProfileRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateSecurityProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetInstanceId())
            {
                throw new AmazonConnectException("Request object does not have required field InstanceId set");
            }
            request.AddPathResource("{InstanceId}", StringUtils.FromString(publicRequest.InstanceId));

            if (!publicRequest.IsSetSecurityProfileId())
            {
                throw new AmazonConnectException("Request object does not have required field SecurityProfileId set");
            }
            request.AddPathResource("{SecurityProfileId}", StringUtils.FromString(publicRequest.SecurityProfileId));

            request.ResourcePath = "/security-profiles/{InstanceId}/{SecurityProfileId}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAllowedAIAgents())
            {
                context.Writer.WritePropertyName("AllowedAIAgents");
                context.Writer.WriteStartArray();
                foreach (var publicRequestAllowedAIAgentsListValue in publicRequest.AllowedAIAgents)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AIAgentMarshaller.Instance;
                    marshaller.Marshall(publicRequestAllowedAIAgentsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetAllowedAccessControlHierarchyGroupId())
            {
                context.Writer.WritePropertyName("AllowedAccessControlHierarchyGroupId");
                context.Writer.WriteStringValue(publicRequest.AllowedAccessControlHierarchyGroupId);
            }
            if (publicRequest.IsSetAllowedAccessControlTags())
            {
                context.Writer.WritePropertyName("AllowedAccessControlTags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestAllowedAccessControlTagsKvp in publicRequest.AllowedAccessControlTags)
                {
                    context.Writer.WritePropertyName(publicRequestAllowedAccessControlTagsKvp.Key);
                    var publicRequestAllowedAccessControlTagsValue = publicRequestAllowedAccessControlTagsKvp.Value;
                    context.Writer.WriteStringValue(publicRequestAllowedAccessControlTagsValue);
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetAllowedFlowModules())
            {
                context.Writer.WritePropertyName("AllowedFlowModules");
                context.Writer.WriteStartArray();
                foreach (var publicRequestAllowedFlowModulesListValue in publicRequest.AllowedFlowModules)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FlowModuleMarshaller.Instance;
                    marshaller.Marshall(publicRequestAllowedFlowModulesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetApplications())
            {
                context.Writer.WritePropertyName("Applications");
                context.Writer.WriteStartArray();
                foreach (var publicRequestApplicationsListValue in publicRequest.Applications)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ApplicationMarshaller.Instance;
                    marshaller.Marshall(publicRequestApplicationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }
            if (publicRequest.IsSetGranularAccessControlConfiguration())
            {
                context.Writer.WritePropertyName("GranularAccessControlConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = GranularAccessControlConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.GranularAccessControlConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetHierarchyRestrictedResources())
            {
                context.Writer.WritePropertyName("HierarchyRestrictedResources");
                context.Writer.WriteStartArray();
                foreach (var publicRequestHierarchyRestrictedResourcesListValue in publicRequest.HierarchyRestrictedResources)
                {
                    context.Writer.WriteStringValue(publicRequestHierarchyRestrictedResourcesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetPermissions())
            {
                context.Writer.WritePropertyName("Permissions");
                context.Writer.WriteStartArray();
                foreach (var publicRequestPermissionsListValue in publicRequest.Permissions)
                {
                    context.Writer.WriteStringValue(publicRequestPermissionsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetTagRestrictedResources())
            {
                context.Writer.WritePropertyName("TagRestrictedResources");
                context.Writer.WriteStartArray();
                foreach (var publicRequestTagRestrictedResourcesListValue in publicRequest.TagRestrictedResources)
                {
                    context.Writer.WriteStringValue(publicRequestTagRestrictedResourcesListValue);
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

        private static readonly UpdateSecurityProfileRequestMarshaller _instance = new();

        internal static UpdateSecurityProfileRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateSecurityProfileRequestMarshaller Instance => _instance;
    }
}
