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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GroundStation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GroundStation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAgentStatus Request Marshaller
    /// </summary>       
    public class UpdateAgentStatusRequestMarshaller : IMarshaller<IRequest, UpdateAgentStatusRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAgentStatusRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAgentStatusRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GroundStation");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-05-23";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetAgentId())
                throw new AmazonGroundStationException("Request object does not have required field AgentId set");
            request.AddPathResource("{agentId}", StringUtils.FromString(publicRequest.AgentId));
            request.ResourcePath = "/agent/{agentId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAggregateStatus())
                {
                    context.Writer.WritePropertyName("aggregateStatus");
                    context.Writer.WriteObjectStart();

                    var marshaller = AggregateStatusMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AggregateStatus, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetComponentStatuses())
                {
                    context.Writer.WritePropertyName("componentStatuses");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestComponentStatusesListValue in publicRequest.ComponentStatuses)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ComponentStatusDataMarshaller.Instance;
                        marshaller.Marshall(publicRequestComponentStatusesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTaskId())
                {
                    context.Writer.WritePropertyName("taskId");
                    context.Writer.Write(publicRequest.TaskId);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateAgentStatusRequestMarshaller _instance = new UpdateAgentStatusRequestMarshaller();        

        internal static UpdateAgentStatusRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAgentStatusRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}