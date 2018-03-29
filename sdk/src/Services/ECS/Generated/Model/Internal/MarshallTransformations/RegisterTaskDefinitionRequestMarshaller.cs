/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RegisterTaskDefinition Request Marshaller
    /// </summary>       
    public class RegisterTaskDefinitionRequestMarshaller : IMarshaller<IRequest, RegisterTaskDefinitionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RegisterTaskDefinitionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RegisterTaskDefinitionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ECS");
            string target = "AmazonEC2ContainerServiceV20141113.RegisterTaskDefinition";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetContainerDefinitions())
                {
                    context.Writer.WritePropertyName("containerDefinitions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestContainerDefinitionsListValue in publicRequest.ContainerDefinitions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ContainerDefinitionMarshaller.Instance;
                        marshaller.Marshall(publicRequestContainerDefinitionsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetCpu())
                {
                    context.Writer.WritePropertyName("cpu");
                    context.Writer.Write(publicRequest.Cpu);
                }

                if(publicRequest.IsSetExecutionRoleArn())
                {
                    context.Writer.WritePropertyName("executionRoleArn");
                    context.Writer.Write(publicRequest.ExecutionRoleArn);
                }

                if(publicRequest.IsSetFamily())
                {
                    context.Writer.WritePropertyName("family");
                    context.Writer.Write(publicRequest.Family);
                }

                if(publicRequest.IsSetMemory())
                {
                    context.Writer.WritePropertyName("memory");
                    context.Writer.Write(publicRequest.Memory);
                }

                if(publicRequest.IsSetNetworkMode())
                {
                    context.Writer.WritePropertyName("networkMode");
                    context.Writer.Write(publicRequest.NetworkMode);
                }

                if(publicRequest.IsSetPlacementConstraints())
                {
                    context.Writer.WritePropertyName("placementConstraints");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPlacementConstraintsListValue in publicRequest.PlacementConstraints)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TaskDefinitionPlacementConstraintMarshaller.Instance;
                        marshaller.Marshall(publicRequestPlacementConstraintsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRequiresCompatibilities())
                {
                    context.Writer.WritePropertyName("requiresCompatibilities");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRequiresCompatibilitiesListValue in publicRequest.RequiresCompatibilities)
                    {
                            context.Writer.Write(publicRequestRequiresCompatibilitiesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTaskRoleArn())
                {
                    context.Writer.WritePropertyName("taskRoleArn");
                    context.Writer.Write(publicRequest.TaskRoleArn);
                }

                if(publicRequest.IsSetVolumes())
                {
                    context.Writer.WritePropertyName("volumes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestVolumesListValue in publicRequest.Volumes)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = VolumeMarshaller.Instance;
                        marshaller.Marshall(publicRequestVolumesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static RegisterTaskDefinitionRequestMarshaller _instance = new RegisterTaskDefinitionRequestMarshaller();        

        internal static RegisterTaskDefinitionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RegisterTaskDefinitionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}