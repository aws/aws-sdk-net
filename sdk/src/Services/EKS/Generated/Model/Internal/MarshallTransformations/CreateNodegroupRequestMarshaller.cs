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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EKS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.EKS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateNodegroup Request Marshaller
    /// </summary>       
    public class CreateNodegroupRequestMarshaller : IMarshaller<IRequest, CreateNodegroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateNodegroupRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateNodegroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EKS");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetClusterName())
                throw new AmazonEKSException("Request object does not have required field ClusterName set");
            request.AddPathResource("{name}", StringUtils.FromString(publicRequest.ClusterName));
            request.ResourcePath = "/clusters/{name}/node-groups";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAmiType())
            {
                context.Writer.WritePropertyName("amiType");
                context.Writer.WriteStringValue(publicRequest.AmiType);
            }

            if(publicRequest.IsSetCapacityType())
            {
                context.Writer.WritePropertyName("capacityType");
                context.Writer.WriteStringValue(publicRequest.CapacityType);
            }

            if(publicRequest.IsSetClientRequestToken())
            {
                context.Writer.WritePropertyName("clientRequestToken");
                context.Writer.WriteStringValue(publicRequest.ClientRequestToken);
            }

            else if(!(publicRequest.IsSetClientRequestToken()))
            {
                context.Writer.WritePropertyName("clientRequestToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetDiskSize())
            {
                context.Writer.WritePropertyName("diskSize");
                context.Writer.WriteNumberValue(publicRequest.DiskSize.Value);
            }

            if(publicRequest.IsSetInstanceTypes())
            {
                context.Writer.WritePropertyName("instanceTypes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestInstanceTypesListValue in publicRequest.InstanceTypes)
                {
                        context.Writer.WriteStringValue(publicRequestInstanceTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetLabels())
            {
                context.Writer.WritePropertyName("labels");
                context.Writer.WriteStartObject();
                foreach (var publicRequestLabelsKvp in publicRequest.Labels)
                {
                    context.Writer.WritePropertyName(publicRequestLabelsKvp.Key);
                    var publicRequestLabelsValue = publicRequestLabelsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestLabelsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetLaunchTemplate())
            {
                context.Writer.WritePropertyName("launchTemplate");
                context.Writer.WriteStartObject();

                var marshaller = LaunchTemplateSpecificationMarshaller.Instance;
                marshaller.Marshall(publicRequest.LaunchTemplate, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetNodegroupName())
            {
                context.Writer.WritePropertyName("nodegroupName");
                context.Writer.WriteStringValue(publicRequest.NodegroupName);
            }

            if(publicRequest.IsSetNodeRepairConfig())
            {
                context.Writer.WritePropertyName("nodeRepairConfig");
                context.Writer.WriteStartObject();

                var marshaller = NodeRepairConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.NodeRepairConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetNodeRole())
            {
                context.Writer.WritePropertyName("nodeRole");
                context.Writer.WriteStringValue(publicRequest.NodeRole);
            }

            if(publicRequest.IsSetReleaseVersion())
            {
                context.Writer.WritePropertyName("releaseVersion");
                context.Writer.WriteStringValue(publicRequest.ReleaseVersion);
            }

            if(publicRequest.IsSetRemoteAccess())
            {
                context.Writer.WritePropertyName("remoteAccess");
                context.Writer.WriteStartObject();

                var marshaller = RemoteAccessConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.RemoteAccess, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetScalingConfig())
            {
                context.Writer.WritePropertyName("scalingConfig");
                context.Writer.WriteStartObject();

                var marshaller = NodegroupScalingConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ScalingConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSubnets())
            {
                context.Writer.WritePropertyName("subnets");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSubnetsListValue in publicRequest.Subnets)
                {
                        context.Writer.WriteStringValue(publicRequestSubnetsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTags())
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

            if(publicRequest.IsSetTaints())
            {
                context.Writer.WritePropertyName("taints");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTaintsListValue in publicRequest.Taints)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TaintMarshaller.Instance;
                    marshaller.Marshall(publicRequestTaintsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetUpdateConfig())
            {
                context.Writer.WritePropertyName("updateConfig");
                context.Writer.WriteStartObject();

                var marshaller = NodegroupUpdateConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.UpdateConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetVersion())
            {
                context.Writer.WritePropertyName("version");
                context.Writer.WriteStringValue(publicRequest.Version);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateNodegroupRequestMarshaller _instance = new CreateNodegroupRequestMarshaller();        

        internal static CreateNodegroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateNodegroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}