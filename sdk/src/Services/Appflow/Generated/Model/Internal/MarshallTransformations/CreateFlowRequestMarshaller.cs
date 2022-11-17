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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Appflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Appflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateFlow Request Marshaller
    /// </summary>       
    public class CreateFlowRequestMarshaller : IMarshaller<IRequest, CreateFlowRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFlowRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateFlowRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Appflow");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-23";
            request.HttpMethod = "POST";

            request.ResourcePath = "/create-flow";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDestinationFlowConfigList())
                {
                    context.Writer.WritePropertyName("destinationFlowConfigList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDestinationFlowConfigListListValue in publicRequest.DestinationFlowConfigList)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = DestinationFlowConfigMarshaller.Instance;
                        marshaller.Marshall(publicRequestDestinationFlowConfigListListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetFlowName())
                {
                    context.Writer.WritePropertyName("flowName");
                    context.Writer.Write(publicRequest.FlowName);
                }

                if(publicRequest.IsSetKmsArn())
                {
                    context.Writer.WritePropertyName("kmsArn");
                    context.Writer.Write(publicRequest.KmsArn);
                }

                if(publicRequest.IsSetMetadataCatalogConfig())
                {
                    context.Writer.WritePropertyName("metadataCatalogConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = MetadataCatalogConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MetadataCatalogConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSourceFlowConfig())
                {
                    context.Writer.WritePropertyName("sourceFlowConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = SourceFlowConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SourceFlowConfig, context);

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

                if(publicRequest.IsSetTasks())
                {
                    context.Writer.WritePropertyName("tasks");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTasksListValue in publicRequest.Tasks)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TaskMarshaller.Instance;
                        marshaller.Marshall(publicRequestTasksListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTriggerConfig())
                {
                    context.Writer.WritePropertyName("triggerConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = TriggerConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TriggerConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateFlowRequestMarshaller _instance = new CreateFlowRequestMarshaller();        

        internal static CreateFlowRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateFlowRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}