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

using Amazon.BedrockAgentCoreControl.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.BedrockAgentCoreControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateConfigurationBundle Request Marshaller
    /// </summary>
    public partial class CreateConfigurationBundleRequestMarshaller : IMarshaller<IRequest, CreateConfigurationBundleRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateConfigurationBundleRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateConfigurationBundleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCoreControl");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-06-05";
            request.HttpMethod = "POST";

            request.ResourcePath = "/configuration-bundles/create";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetBranchName())
            {
                context.Writer.WritePropertyName("branchName");
                context.Writer.WriteStringValue(publicRequest.BranchName);
            }
            if (publicRequest.IsSetBundleName())
            {
                context.Writer.WritePropertyName("bundleName");
                context.Writer.WriteStringValue(publicRequest.BundleName);
            }
            if (publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }
            else
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if (publicRequest.IsSetCommitMessage())
            {
                context.Writer.WritePropertyName("commitMessage");
                context.Writer.WriteStringValue(publicRequest.CommitMessage);
            }
            if (publicRequest.IsSetComponents())
            {
                context.Writer.WritePropertyName("components");
                context.Writer.WriteStartObject();
                foreach (var publicRequestComponentsKvp in publicRequest.Components)
                {
                    context.Writer.WritePropertyName(publicRequestComponentsKvp.Key);
                    var publicRequestComponentsValue = publicRequestComponentsKvp.Value;
                    context.Writer.WriteStartObject();

                    var marshaller = ComponentConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestComponentsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetCreatedBy())
            {
                context.Writer.WritePropertyName("createdBy");
                context.Writer.WriteStartObject();

                var marshaller = VersionCreatedBySourceMarshaller.Instance;
                marshaller.Marshall(publicRequest.CreatedBy, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }
            if (publicRequest.IsSetKmsKeyArn())
            {
                context.Writer.WritePropertyName("kmsKeyArn");
                context.Writer.WriteStringValue(publicRequest.KmsKeyArn);
            }
            if (publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
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

        private static readonly CreateConfigurationBundleRequestMarshaller _instance = new();

        internal static CreateConfigurationBundleRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateConfigurationBundleRequestMarshaller Instance => _instance;
    }
}
