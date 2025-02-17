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
    /// CreateGraphUsingImportTask Request Marshaller
    /// </summary>       
    public class CreateGraphUsingImportTaskRequestMarshaller : IMarshaller<IRequest, CreateGraphUsingImportTaskRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateGraphUsingImportTaskRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateGraphUsingImportTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NeptuneGraph");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-11-29";
            request.HttpMethod = "POST";

            request.ResourcePath = "/importtasks";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBlankNodeHandling())
                {
                    context.Writer.WritePropertyName("blankNodeHandling");
                    context.Writer.Write(publicRequest.BlankNodeHandling);
                }

                if(publicRequest.IsSetDeletionProtection())
                {
                    context.Writer.WritePropertyName("deletionProtection");
                    context.Writer.Write(publicRequest.DeletionProtection);
                }

                if(publicRequest.IsSetFailOnError())
                {
                    context.Writer.WritePropertyName("failOnError");
                    context.Writer.Write(publicRequest.FailOnError);
                }

                if(publicRequest.IsSetFormat())
                {
                    context.Writer.WritePropertyName("format");
                    context.Writer.Write(publicRequest.Format);
                }

                if(publicRequest.IsSetGraphName())
                {
                    context.Writer.WritePropertyName("graphName");
                    context.Writer.Write(publicRequest.GraphName);
                }

                if(publicRequest.IsSetImportOptions())
                {
                    context.Writer.WritePropertyName("importOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = ImportOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ImportOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetKmsKeyIdentifier())
                {
                    context.Writer.WritePropertyName("kmsKeyIdentifier");
                    context.Writer.Write(publicRequest.KmsKeyIdentifier);
                }

                if(publicRequest.IsSetMaxProvisionedMemory())
                {
                    context.Writer.WritePropertyName("maxProvisionedMemory");
                    context.Writer.Write(publicRequest.MaxProvisionedMemory);
                }

                if(publicRequest.IsSetMinProvisionedMemory())
                {
                    context.Writer.WritePropertyName("minProvisionedMemory");
                    context.Writer.Write(publicRequest.MinProvisionedMemory);
                }

                if(publicRequest.IsSetParquetType())
                {
                    context.Writer.WritePropertyName("parquetType");
                    context.Writer.Write(publicRequest.ParquetType);
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

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("roleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetSource())
                {
                    context.Writer.WritePropertyName("source");
                    context.Writer.Write(publicRequest.Source);
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
        private static CreateGraphUsingImportTaskRequestMarshaller _instance = new CreateGraphUsingImportTaskRequestMarshaller();        

        internal static CreateGraphUsingImportTaskRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateGraphUsingImportTaskRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}