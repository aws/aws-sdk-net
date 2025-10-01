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
    /// CreateQueue Request Marshaller
    /// </summary>       
    public class CreateQueueRequestMarshaller : IMarshaller<IRequest, CreateQueueRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateQueueRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateQueueRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PCS");
            string target = "AWSParallelComputingService.CreateQueue";
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

                if(publicRequest.IsSetComputeNodeGroupConfigurations())
                {
                    context.Writer.WritePropertyName("computeNodeGroupConfigurations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestComputeNodeGroupConfigurationsListValue in publicRequest.ComputeNodeGroupConfigurations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ComputeNodeGroupConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestComputeNodeGroupConfigurationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetQueueName())
                {
                    context.Writer.WritePropertyName("queueName");
                    context.Writer.Write(publicRequest.QueueName);
                }

                if(publicRequest.IsSetSlurmConfiguration())
                {
                    context.Writer.WritePropertyName("slurmConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = QueueSlurmConfigurationRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SlurmConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateQueueRequestMarshaller _instance = new CreateQueueRequestMarshaller();        

        internal static CreateQueueRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateQueueRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}