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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RoboMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.RoboMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateSimulationJob Request Marshaller
    /// </summary>       
    public class CreateSimulationJobRequestMarshaller : IMarshaller<IRequest, CreateSimulationJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateSimulationJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateSimulationJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RoboMaker");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-06-29";            
            request.HttpMethod = "POST";

            string uriResourcePath = "/createSimulationJob";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
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
                if(publicRequest.IsSetFailureBehavior())
                {
                    context.Writer.WritePropertyName("failureBehavior");
                    context.Writer.Write(publicRequest.FailureBehavior);
                }

                if(publicRequest.IsSetIamRole())
                {
                    context.Writer.WritePropertyName("iamRole");
                    context.Writer.Write(publicRequest.IamRole);
                }

                if(publicRequest.IsSetMaxJobDurationInSeconds())
                {
                    context.Writer.WritePropertyName("maxJobDurationInSeconds");
                    context.Writer.Write(publicRequest.MaxJobDurationInSeconds);
                }

                if(publicRequest.IsSetOutputLocation())
                {
                    context.Writer.WritePropertyName("outputLocation");
                    context.Writer.WriteObjectStart();

                    var marshaller = OutputLocationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OutputLocation, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRobotApplications())
                {
                    context.Writer.WritePropertyName("robotApplications");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRobotApplicationsListValue in publicRequest.RobotApplications)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = RobotApplicationConfigMarshaller.Instance;
                        marshaller.Marshall(publicRequestRobotApplicationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSimulationApplications())
                {
                    context.Writer.WritePropertyName("simulationApplications");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSimulationApplicationsListValue in publicRequest.SimulationApplications)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SimulationApplicationConfigMarshaller.Instance;
                        marshaller.Marshall(publicRequestSimulationApplicationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
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

                if(publicRequest.IsSetVpcConfig())
                {
                    context.Writer.WritePropertyName("vpcConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = VPCConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VpcConfig, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateSimulationJobRequestMarshaller _instance = new CreateSimulationJobRequestMarshaller();        

        internal static CreateSimulationJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateSimulationJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}