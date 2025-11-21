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
using ThirdParty.Json.LitJson;

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
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccessConfig())
                {
                    context.Writer.WritePropertyName("accessConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = UpdateAccessConfigRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AccessConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetClientRequestToken())
                {
                    context.Writer.WritePropertyName("clientRequestToken");
                    context.Writer.Write(publicRequest.ClientRequestToken);
                }

                else if(!(publicRequest.IsSetClientRequestToken()))
                {
                    context.Writer.WritePropertyName("clientRequestToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetComputeConfig())
                {
                    context.Writer.WritePropertyName("computeConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = ComputeConfigRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ComputeConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetControlPlaneScalingConfig())
                {
                    context.Writer.WritePropertyName("controlPlaneScalingConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = ControlPlaneScalingConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ControlPlaneScalingConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDeletionProtection())
                {
                    context.Writer.WritePropertyName("deletionProtection");
                    context.Writer.Write(publicRequest.DeletionProtection);
                }

                if(publicRequest.IsSetKubernetesNetworkConfig())
                {
                    context.Writer.WritePropertyName("kubernetesNetworkConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = KubernetesNetworkConfigRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.KubernetesNetworkConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetLogging())
                {
                    context.Writer.WritePropertyName("logging");
                    context.Writer.WriteObjectStart();

                    var marshaller = LoggingMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Logging, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRemoteNetworkConfig())
                {
                    context.Writer.WritePropertyName("remoteNetworkConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = RemoteNetworkConfigRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RemoteNetworkConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetResourcesVpcConfig())
                {
                    context.Writer.WritePropertyName("resourcesVpcConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = VpcConfigRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ResourcesVpcConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetStorageConfig())
                {
                    context.Writer.WritePropertyName("storageConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = StorageConfigRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.StorageConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetUpgradePolicy())
                {
                    context.Writer.WritePropertyName("upgradePolicy");
                    context.Writer.WriteObjectStart();

                    var marshaller = UpgradePolicyRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.UpgradePolicy, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetZonalShiftConfig())
                {
                    context.Writer.WritePropertyName("zonalShiftConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = ZonalShiftConfigRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ZonalShiftConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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