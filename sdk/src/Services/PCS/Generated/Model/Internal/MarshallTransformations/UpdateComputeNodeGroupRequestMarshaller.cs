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
 * Do not modify this file. This file is generated from the pcs-2023-02-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PCS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PCS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateComputeNodeGroup Request Marshaller
    /// </summary>       
    public class UpdateComputeNodeGroupRequestMarshaller : IMarshaller<IRequest, UpdateComputeNodeGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateComputeNodeGroupRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateComputeNodeGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PCS");
            string target = "AWSParallelComputingService.UpdateComputeNodeGroup";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-02-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAmiId())
                {
                    context.Writer.WritePropertyName("amiId");
                    context.Writer.Write(publicRequest.AmiId);
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetClusterIdentifier())
                {
                    context.Writer.WritePropertyName("clusterIdentifier");
                    context.Writer.Write(publicRequest.ClusterIdentifier);
                }

                if(publicRequest.IsSetComputeNodeGroupIdentifier())
                {
                    context.Writer.WritePropertyName("computeNodeGroupIdentifier");
                    context.Writer.Write(publicRequest.ComputeNodeGroupIdentifier);
                }

                if(publicRequest.IsSetCustomLaunchTemplate())
                {
                    context.Writer.WritePropertyName("customLaunchTemplate");
                    context.Writer.WriteObjectStart();

                    var marshaller = CustomLaunchTemplateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CustomLaunchTemplate, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetIamInstanceProfileArn())
                {
                    context.Writer.WritePropertyName("iamInstanceProfileArn");
                    context.Writer.Write(publicRequest.IamInstanceProfileArn);
                }

                if(publicRequest.IsSetPurchaseOption())
                {
                    context.Writer.WritePropertyName("purchaseOption");
                    context.Writer.Write(publicRequest.PurchaseOption);
                }

                if(publicRequest.IsSetScalingConfiguration())
                {
                    context.Writer.WritePropertyName("scalingConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ScalingConfigurationRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ScalingConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSlurmConfiguration())
                {
                    context.Writer.WritePropertyName("slurmConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = UpdateComputeNodeGroupSlurmConfigurationRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SlurmConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSpotOptions())
                {
                    context.Writer.WritePropertyName("spotOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = SpotOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SpotOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSubnetIds())
                {
                    context.Writer.WritePropertyName("subnetIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSubnetIdsListValue in publicRequest.SubnetIds)
                    {
                            context.Writer.Write(publicRequestSubnetIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateComputeNodeGroupRequestMarshaller _instance = new UpdateComputeNodeGroupRequestMarshaller();        

        internal static UpdateComputeNodeGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateComputeNodeGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}