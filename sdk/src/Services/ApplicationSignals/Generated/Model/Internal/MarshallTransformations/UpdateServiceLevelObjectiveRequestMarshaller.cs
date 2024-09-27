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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationSignals.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ApplicationSignals.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateServiceLevelObjective Request Marshaller
    /// </summary>       
    public class UpdateServiceLevelObjectiveRequestMarshaller : IMarshaller<IRequest, UpdateServiceLevelObjectiveRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateServiceLevelObjectiveRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateServiceLevelObjectiveRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApplicationSignals");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-04-15";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetId())
                throw new AmazonApplicationSignalsException("Request object does not have required field Id set");
            request.AddPathResource("{Id}", StringUtils.FromString(publicRequest.Id));
            request.ResourcePath = "/slo/{Id}";
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (StreamWriter streamWriter = new InvariantCultureStreamWriter(memoryStream))
                {
                    JsonWriter writer = new JsonWriter(streamWriter);
                    writer.Validate = false;
                    writer.WriteObjectStart();
                    var context = new JsonMarshallerContext(request, writer);
                    if(publicRequest.IsSetDescription())
                    {
                        context.Writer.WritePropertyName("Description");
                        context.Writer.Write(publicRequest.Description);
                    }

                    if(publicRequest.IsSetGoal())
                    {
                        context.Writer.WritePropertyName("Goal");
                        context.Writer.WriteObjectStart();

                        var marshaller = GoalMarshaller.Instance;
                        marshaller.Marshall(publicRequest.Goal, context);

                        context.Writer.WriteObjectEnd();
                    }

                    if(publicRequest.IsSetSliConfig())
                    {
                        context.Writer.WritePropertyName("SliConfig");
                        context.Writer.WriteObjectStart();

                        var marshaller = ServiceLevelIndicatorConfigMarshaller.Instance;
                        marshaller.Marshall(publicRequest.SliConfig, context);

                        context.Writer.WriteObjectEnd();
                    }

                    writer.WriteObjectEnd();
                }

<<<<<<< HEAD
                request.Content = memoryStream.ToArray();
||||||| Commit version number update changes
                if(publicRequest.IsSetGoal())
                {
                    context.Writer.WritePropertyName("Goal");
                    context.Writer.WriteObjectStart();

                    var marshaller = GoalMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Goal, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSliConfig())
                {
                    context.Writer.WritePropertyName("SliConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = ServiceLevelIndicatorConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SliConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
=======
                if(publicRequest.IsSetGoal())
                {
                    context.Writer.WritePropertyName("Goal");
                    context.Writer.WriteObjectStart();

                    var marshaller = GoalMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Goal, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRequestBasedSliConfig())
                {
                    context.Writer.WritePropertyName("RequestBasedSliConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = RequestBasedServiceLevelIndicatorConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RequestBasedSliConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSliConfig())
                {
                    context.Writer.WritePropertyName("SliConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = ServiceLevelIndicatorConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SliConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
>>>>>>> d837e1d9b57336394b2832b28a2a9052473dd618
            }


            return request;
        }
        private static UpdateServiceLevelObjectiveRequestMarshaller _instance = new UpdateServiceLevelObjectiveRequestMarshaller();        

        internal static UpdateServiceLevelObjectiveRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateServiceLevelObjectiveRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}