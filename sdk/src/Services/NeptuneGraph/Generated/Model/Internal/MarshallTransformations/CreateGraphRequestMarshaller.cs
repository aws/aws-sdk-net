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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NeptuneGraph.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.NeptuneGraph.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateGraph Request Marshaller
    /// </summary>       
    public class CreateGraphRequestMarshaller : IMarshaller<IRequest, CreateGraphRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateGraphRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateGraphRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NeptuneGraph");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-11-29";
            request.HttpMethod = "POST";

            request.ResourcePath = "/graphs";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDeletionProtection())
                {
                    context.Writer.WritePropertyName("deletionProtection");
                    context.Writer.Write(publicRequest.DeletionProtection);
                }

                if(publicRequest.IsSetGraphName())
                {
                    context.Writer.WritePropertyName("graphName");
                    context.Writer.Write(publicRequest.GraphName);
                }

                if(publicRequest.IsSetKmsKeyIdentifier())
                {
                    context.Writer.WritePropertyName("kmsKeyIdentifier");
                    context.Writer.Write(publicRequest.KmsKeyIdentifier);
                }

                if(publicRequest.IsSetProvisionedMemory())
                {
                    context.Writer.WritePropertyName("provisionedMemory");
                    context.Writer.Write(publicRequest.ProvisionedMemory);
                }

                if(publicRequest.IsSetPublicConnectivity())
                {
                    context.Writer.WritePropertyName("publicConnectivity");
                    context.Writer.Write(publicRequest.PublicConnectivity);
                }

                if(publicRequest.IsSetReplicaCount())
                {
                    context.Writer.WritePropertyName("replicaCount");
                    context.Writer.Write(publicRequest.ReplicaCount);
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

                if(publicRequest.IsSetVectorSearchConfiguration())
                {
                    context.Writer.WritePropertyName("vectorSearchConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = VectorSearchConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VectorSearchConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateGraphRequestMarshaller _instance = new CreateGraphRequestMarshaller();        

        internal static CreateGraphRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateGraphRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618