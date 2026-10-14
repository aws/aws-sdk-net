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

using Amazon.PCS.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.PCS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateComputeNodeGroup Request Marshaller
    /// </summary>
    public partial class CreateComputeNodeGroupRequestMarshaller : IMarshaller<IRequest, CreateComputeNodeGroupRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateComputeNodeGroupRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateComputeNodeGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PCS");
            string target = "AWSParallelComputingService.CreateComputeNodeGroup";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-02-10";
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
            if (publicRequest.IsSetAmiId())
            {
                context.Writer.WritePropertyName("amiId");
                context.Writer.WriteStringValue(publicRequest.AmiId);
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
            if (publicRequest.IsSetClusterIdentifier())
            {
                context.Writer.WritePropertyName("clusterIdentifier");
                context.Writer.WriteStringValue(publicRequest.ClusterIdentifier);
            }
            if (publicRequest.IsSetComputeNodeGroupName())
            {
                context.Writer.WritePropertyName("computeNodeGroupName");
                context.Writer.WriteStringValue(publicRequest.ComputeNodeGroupName);
            }
            if (publicRequest.IsSetCustomLaunchTemplate())
            {
                context.Writer.WritePropertyName("customLaunchTemplate");
                context.Writer.WriteStartObject();

                var marshaller = CustomLaunchTemplateMarshaller.Instance;
                marshaller.Marshall(publicRequest.CustomLaunchTemplate, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetIamInstanceProfileArn())
            {
                context.Writer.WritePropertyName("iamInstanceProfileArn");
                context.Writer.WriteStringValue(publicRequest.IamInstanceProfileArn);
            }
            if (publicRequest.IsSetInstanceConfigs())
            {
                context.Writer.WritePropertyName("instanceConfigs");
                context.Writer.WriteStartArray();
                foreach (var publicRequestInstanceConfigsListValue in publicRequest.InstanceConfigs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InstanceConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequestInstanceConfigsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetNodeLifecycleActions())
            {
                context.Writer.WritePropertyName("nodeLifecycleActions");
                context.Writer.WriteStartObject();

                var marshaller = NodeLifecycleActionsRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.NodeLifecycleActions, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetPurchaseOption())
            {
                context.Writer.WritePropertyName("purchaseOption");
                context.Writer.WriteStringValue(publicRequest.PurchaseOption);
            }
            if (publicRequest.IsSetScalingConfiguration())
            {
                context.Writer.WritePropertyName("scalingConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ScalingConfigurationRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.ScalingConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetSlurmConfiguration())
            {
                context.Writer.WritePropertyName("slurmConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ComputeNodeGroupSlurmConfigurationRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.SlurmConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetSpotOptions())
            {
                context.Writer.WritePropertyName("spotOptions");
                context.Writer.WriteStartObject();

                var marshaller = SpotOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.SpotOptions, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetSubnetIds())
            {
                context.Writer.WritePropertyName("subnetIds");
                context.Writer.WriteStartArray();
                foreach (var publicRequestSubnetIdsListValue in publicRequest.SubnetIds)
                {
                    context.Writer.WriteStringValue(publicRequestSubnetIdsListValue);
                }
                context.Writer.WriteEndArray();
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

        private static readonly CreateComputeNodeGroupRequestMarshaller _instance = new();

        internal static CreateComputeNodeGroupRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateComputeNodeGroupRequestMarshaller Instance => _instance;
    }
}
