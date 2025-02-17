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
    /// CreateServiceLevelObjective Request Marshaller
    /// </summary>       
    public class CreateServiceLevelObjectiveRequestMarshaller : IMarshaller<IRequest, CreateServiceLevelObjectiveRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateServiceLevelObjectiveRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateServiceLevelObjectiveRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApplicationSignals");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-04-15";
            request.HttpMethod = "POST";

            request.ResourcePath = "/slo";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBurnRateConfigurations())
                {
                    context.Writer.WritePropertyName("BurnRateConfigurations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestBurnRateConfigurationsListValue in publicRequest.BurnRateConfigurations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = BurnRateConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestBurnRateConfigurationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

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

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
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

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

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
        private static CreateServiceLevelObjectiveRequestMarshaller _instance = new CreateServiceLevelObjectiveRequestMarshaller();        

        internal static CreateServiceLevelObjectiveRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateServiceLevelObjectiveRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}