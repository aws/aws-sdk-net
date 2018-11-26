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
    /// CreateSimulationApplication Request Marshaller
    /// </summary>       
    public class CreateSimulationApplicationRequestMarshaller : IMarshaller<IRequest, CreateSimulationApplicationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateSimulationApplicationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateSimulationApplicationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RoboMaker");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/createSimulationApplication";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetRenderingEngine())
                {
                    context.Writer.WritePropertyName("renderingEngine");
                    context.Writer.WriteObjectStart();

                    var marshaller = RenderingEngineMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RenderingEngine, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRobotSoftwareSuite())
                {
                    context.Writer.WritePropertyName("robotSoftwareSuite");
                    context.Writer.WriteObjectStart();

                    var marshaller = RobotSoftwareSuiteMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RobotSoftwareSuite, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSimulationSoftwareSuite())
                {
                    context.Writer.WritePropertyName("simulationSoftwareSuite");
                    context.Writer.WriteObjectStart();

                    var marshaller = SimulationSoftwareSuiteMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SimulationSoftwareSuite, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSources())
                {
                    context.Writer.WritePropertyName("sources");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSourcesListValue in publicRequest.Sources)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SourceConfigMarshaller.Instance;
                        marshaller.Marshall(publicRequestSourcesListValue, context);

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
        private static CreateSimulationApplicationRequestMarshaller _instance = new CreateSimulationApplicationRequestMarshaller();        

        internal static CreateSimulationApplicationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateSimulationApplicationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}