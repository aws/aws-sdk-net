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

using Amazon.AppConfig.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.AppConfig.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartDeployment Request Marshaller
    /// </summary>
    public partial class StartDeploymentRequestMarshaller : IMarshaller<IRequest, StartDeploymentRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartDeploymentRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(StartDeploymentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppConfig");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-10-09";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetApplicationId())
            {
                throw new AmazonAppConfigException("Request object does not have required field ApplicationId set");
            }
            request.AddPathResource("{ApplicationId}", StringUtils.FromString(publicRequest.ApplicationId));

            if (!publicRequest.IsSetEnvironmentId())
            {
                throw new AmazonAppConfigException("Request object does not have required field EnvironmentId set");
            }
            request.AddPathResource("{EnvironmentId}", StringUtils.FromString(publicRequest.EnvironmentId));

            request.ResourcePath = "/applications/{ApplicationId}/environments/{EnvironmentId}/deployments";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetConfigurationProfileId())
            {
                context.Writer.WritePropertyName("ConfigurationProfileId");
                context.Writer.WriteStringValue(publicRequest.ConfigurationProfileId);
            }
            if (publicRequest.IsSetConfigurationVersion())
            {
                context.Writer.WritePropertyName("ConfigurationVersion");
                context.Writer.WriteStringValue(publicRequest.ConfigurationVersion);
            }
            if (publicRequest.IsSetDeploymentStrategyId())
            {
                context.Writer.WritePropertyName("DeploymentStrategyId");
                context.Writer.WriteStringValue(publicRequest.DeploymentStrategyId);
            }
            if (publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }
            if (publicRequest.IsSetDynamicExtensionParameters())
            {
                context.Writer.WritePropertyName("DynamicExtensionParameters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestDynamicExtensionParametersKvp in publicRequest.DynamicExtensionParameters)
                {
                    context.Writer.WritePropertyName(publicRequestDynamicExtensionParametersKvp.Key);
                    var publicRequestDynamicExtensionParametersValue = publicRequestDynamicExtensionParametersKvp.Value;
                    context.Writer.WriteStringValue(publicRequestDynamicExtensionParametersValue);
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetKmsKeyIdentifier())
            {
                context.Writer.WritePropertyName("KmsKeyIdentifier");
                context.Writer.WriteStringValue(publicRequest.KmsKeyIdentifier);
            }
            if (publicRequest.IsSetLatestDeploymentNumber())
            {
                context.Writer.WritePropertyName("LatestDeploymentNumber");
                context.Writer.WriteNumberValue(publicRequest.LatestDeploymentNumber.Value);
            }
            if (publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;
                    context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly StartDeploymentRequestMarshaller _instance = new();

        internal static StartDeploymentRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static StartDeploymentRequestMarshaller Instance => _instance;
    }
}
