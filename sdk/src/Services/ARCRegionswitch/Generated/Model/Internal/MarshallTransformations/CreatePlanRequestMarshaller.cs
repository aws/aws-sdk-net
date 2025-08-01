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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ARCRegionswitch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ARCRegionswitch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreatePlan Request Marshaller
    /// </summary>       
    public class CreatePlanRequestMarshaller : IMarshaller<IRequest, CreatePlanRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreatePlanRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreatePlanRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ARCRegionswitch");
            string target = "ArcRegionSwitch.CreatePlan";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-07-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAssociatedAlarms())
                {
                    context.Writer.WritePropertyName("associatedAlarms");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestAssociatedAlarmsKvp in publicRequest.AssociatedAlarms)
                    {
                        context.Writer.WritePropertyName(publicRequestAssociatedAlarmsKvp.Key);
                        var publicRequestAssociatedAlarmsValue = publicRequestAssociatedAlarmsKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = AssociatedAlarmMarshaller.Instance;
                        marshaller.Marshall(publicRequestAssociatedAlarmsValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetExecutionRole())
                {
                    context.Writer.WritePropertyName("executionRole");
                    context.Writer.Write(publicRequest.ExecutionRole);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetPrimaryRegion())
                {
                    context.Writer.WritePropertyName("primaryRegion");
                    context.Writer.Write(publicRequest.PrimaryRegion);
                }

                if(publicRequest.IsSetRecoveryApproach())
                {
                    context.Writer.WritePropertyName("recoveryApproach");
                    context.Writer.Write(publicRequest.RecoveryApproach);
                }

                if(publicRequest.IsSetRecoveryTimeObjectiveMinutes())
                {
                    context.Writer.WritePropertyName("recoveryTimeObjectiveMinutes");
                    context.Writer.Write(publicRequest.RecoveryTimeObjectiveMinutes);
                }

                if(publicRequest.IsSetRegions())
                {
                    context.Writer.WritePropertyName("regions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRegionsListValue in publicRequest.Regions)
                    {
                            context.Writer.Write(publicRequestRegionsListValue);
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

                if(publicRequest.IsSetTriggers())
                {
                    context.Writer.WritePropertyName("triggers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTriggersListValue in publicRequest.Triggers)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TriggerMarshaller.Instance;
                        marshaller.Marshall(publicRequestTriggersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetWorkflows())
                {
                    context.Writer.WritePropertyName("workflows");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestWorkflowsListValue in publicRequest.Workflows)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = WorkflowMarshaller.Instance;
                        marshaller.Marshall(publicRequestWorkflowsListValue, context);

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
        private static CreatePlanRequestMarshaller _instance = new CreatePlanRequestMarshaller();        

        internal static CreatePlanRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreatePlanRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}