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
    /// UpdateNodegroupConfig Request Marshaller
    /// </summary>       
    public class UpdateNodegroupConfigRequestMarshaller : IMarshaller<IRequest, UpdateNodegroupConfigRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateNodegroupConfigRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateNodegroupConfigRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EKS");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetClusterName())
                throw new AmazonEKSException("Request object does not have required field ClusterName set");
            request.AddPathResource("{name}", StringUtils.FromString(publicRequest.ClusterName));
            if (!publicRequest.IsSetNodegroupName())
                throw new AmazonEKSException("Request object does not have required field NodegroupName set");
            request.AddPathResource("{nodegroupName}", StringUtils.FromString(publicRequest.NodegroupName));
            request.ResourcePath = "/clusters/{name}/node-groups/{nodegroupName}/update-config";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
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
            if(publicRequest.IsSetLabels())
            {
                context.Writer.WritePropertyName("labels");
                context.Writer.WriteStartObject();

                var marshaller = UpdateLabelsPayloadMarshaller.Instance;
                marshaller.Marshall(publicRequest.Labels, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetNodeRepairConfig())
            {
                context.Writer.WritePropertyName("nodeRepairConfig");
                context.Writer.WriteStartObject();

                var marshaller = NodeRepairConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.NodeRepairConfig, context);

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

            if(publicRequest.IsSetTaints())
            {
                context.Writer.WritePropertyName("taints");
                context.Writer.WriteStartObject();

                var marshaller = UpdateTaintsPayloadMarshaller.Instance;
                marshaller.Marshall(publicRequest.Taints, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetUpdateConfig())
            {
                context.Writer.WritePropertyName("updateConfig");
                context.Writer.WriteStartObject();

                var marshaller = NodegroupUpdateConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.UpdateConfig, context);

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
        private static UpdateNodegroupConfigRequestMarshaller _instance = new UpdateNodegroupConfigRequestMarshaller();        

        internal static UpdateNodegroupConfigRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateNodegroupConfigRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}