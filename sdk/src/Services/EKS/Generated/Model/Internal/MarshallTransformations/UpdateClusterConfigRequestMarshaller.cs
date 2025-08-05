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
    /// UpdateClusterConfig Request Marshaller
    /// </summary>       
    public class UpdateClusterConfigRequestMarshaller : IMarshaller<IRequest, UpdateClusterConfigRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateClusterConfigRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateClusterConfigRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EKS");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetName())
                throw new AmazonEKSException("Request object does not have required field Name set");
            request.AddPathResource("{name}", StringUtils.FromString(publicRequest.Name));
            request.ResourcePath = "/clusters/{name}/update-config";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAccessConfig())
            {
                context.Writer.WritePropertyName("accessConfig");
                context.Writer.WriteStartObject();

                var marshaller = UpdateAccessConfigRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.AccessConfig, context);

                context.Writer.WriteEndObject();
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
            if(publicRequest.IsSetComputeConfig())
            {
                context.Writer.WritePropertyName("computeConfig");
                context.Writer.WriteStartObject();

                var marshaller = ComputeConfigRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.ComputeConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDeletionProtection())
            {
                context.Writer.WritePropertyName("deletionProtection");
                context.Writer.WriteBooleanValue(publicRequest.DeletionProtection.Value);
            }

            if(publicRequest.IsSetKubernetesNetworkConfig())
            {
                context.Writer.WritePropertyName("kubernetesNetworkConfig");
                context.Writer.WriteStartObject();

                var marshaller = KubernetesNetworkConfigRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.KubernetesNetworkConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetLogging())
            {
                context.Writer.WritePropertyName("logging");
                context.Writer.WriteStartObject();

                var marshaller = LoggingMarshaller.Instance;
                marshaller.Marshall(publicRequest.Logging, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRemoteNetworkConfig())
            {
                context.Writer.WritePropertyName("remoteNetworkConfig");
                context.Writer.WriteStartObject();

                var marshaller = RemoteNetworkConfigRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.RemoteNetworkConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetResourcesVpcConfig())
            {
                context.Writer.WritePropertyName("resourcesVpcConfig");
                context.Writer.WriteStartObject();

                var marshaller = VpcConfigRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.ResourcesVpcConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetStorageConfig())
            {
                context.Writer.WritePropertyName("storageConfig");
                context.Writer.WriteStartObject();

                var marshaller = StorageConfigRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.StorageConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetUpgradePolicy())
            {
                context.Writer.WritePropertyName("upgradePolicy");
                context.Writer.WriteStartObject();

                var marshaller = UpgradePolicyRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.UpgradePolicy, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetZonalShiftConfig())
            {
                context.Writer.WritePropertyName("zonalShiftConfig");
                context.Writer.WriteStartObject();

                var marshaller = ZonalShiftConfigRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.ZonalShiftConfig, context);

                context.Writer.WriteEndObject();
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
        private static UpdateClusterConfigRequestMarshaller _instance = new UpdateClusterConfigRequestMarshaller();        

        internal static UpdateClusterConfigRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateClusterConfigRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}