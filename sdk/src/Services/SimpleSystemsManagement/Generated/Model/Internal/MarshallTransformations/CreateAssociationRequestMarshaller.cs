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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAssociation Request Marshaller
    /// </summary>       
    public class CreateAssociationRequestMarshaller : IMarshaller<IRequest, CreateAssociationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAssociationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAssociationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleSystemsManagement");
            string target = "AmazonSSM.CreateAssociation";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-11-06";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAlarmConfiguration())
                {
                    context.Writer.WritePropertyName("AlarmConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = AlarmConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AlarmConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetApplyOnlyAtCronInterval())
                {
                    context.Writer.WritePropertyName("ApplyOnlyAtCronInterval");
                    context.Writer.Write(publicRequest.ApplyOnlyAtCronInterval);
                }

                if(publicRequest.IsSetAssociationName())
                {
                    context.Writer.WritePropertyName("AssociationName");
                    context.Writer.Write(publicRequest.AssociationName);
                }

                if(publicRequest.IsSetAutomationTargetParameterName())
                {
                    context.Writer.WritePropertyName("AutomationTargetParameterName");
                    context.Writer.Write(publicRequest.AutomationTargetParameterName);
                }

                if(publicRequest.IsSetCalendarNames())
                {
                    context.Writer.WritePropertyName("CalendarNames");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCalendarNamesListValue in publicRequest.CalendarNames)
                    {
                            context.Writer.Write(publicRequestCalendarNamesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetComplianceSeverity())
                {
                    context.Writer.WritePropertyName("ComplianceSeverity");
                    context.Writer.Write(publicRequest.ComplianceSeverity);
                }

                if(publicRequest.IsSetDocumentVersion())
                {
                    context.Writer.WritePropertyName("DocumentVersion");
                    context.Writer.Write(publicRequest.DocumentVersion);
                }

                if(publicRequest.IsSetDuration())
                {
                    context.Writer.WritePropertyName("Duration");
                    context.Writer.Write(publicRequest.Duration);
                }

                if(publicRequest.IsSetInstanceId())
                {
                    context.Writer.WritePropertyName("InstanceId");
                    context.Writer.Write(publicRequest.InstanceId);
                }

                if(publicRequest.IsSetMaxConcurrency())
                {
                    context.Writer.WritePropertyName("MaxConcurrency");
                    context.Writer.Write(publicRequest.MaxConcurrency);
                }

                if(publicRequest.IsSetMaxErrors())
                {
                    context.Writer.WritePropertyName("MaxErrors");
                    context.Writer.Write(publicRequest.MaxErrors);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetOutputLocation())
                {
                    context.Writer.WritePropertyName("OutputLocation");
                    context.Writer.WriteObjectStart();

                    var marshaller = InstanceAssociationOutputLocationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OutputLocation, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetParameters())
                {
                    context.Writer.WritePropertyName("Parameters");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestParametersKvp in publicRequest.Parameters)
                    {
                        context.Writer.WritePropertyName(publicRequestParametersKvp.Key);
                        var publicRequestParametersValue = publicRequestParametersKvp.Value;

                        context.Writer.WriteArrayStart();
                        foreach(var publicRequestParametersValueListValue in publicRequestParametersValue)
                        {
                                context.Writer.Write(publicRequestParametersValueListValue);
                        }
                        context.Writer.WriteArrayEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetScheduleExpression())
                {
                    context.Writer.WritePropertyName("ScheduleExpression");
                    context.Writer.Write(publicRequest.ScheduleExpression);
                }

                if(publicRequest.IsSetScheduleOffset())
                {
                    context.Writer.WritePropertyName("ScheduleOffset");
                    context.Writer.Write(publicRequest.ScheduleOffset);
                }

                if(publicRequest.IsSetSyncCompliance())
                {
                    context.Writer.WritePropertyName("SyncCompliance");
                    context.Writer.Write(publicRequest.SyncCompliance);
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

                if(publicRequest.IsSetTargetLocations())
                {
                    context.Writer.WritePropertyName("TargetLocations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTargetLocationsListValue in publicRequest.TargetLocations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TargetLocationMarshaller.Instance;
                        marshaller.Marshall(publicRequestTargetLocationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTargetMaps())
                {
                    context.Writer.WritePropertyName("TargetMaps");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTargetMapsListValue in publicRequest.TargetMaps)
                    {
                        context.Writer.WriteObjectStart();
                        foreach (var publicRequestTargetMapsListValueKvp in publicRequestTargetMapsListValue)
                        {
                            context.Writer.WritePropertyName(publicRequestTargetMapsListValueKvp.Key);
                            var publicRequestTargetMapsListValueValue = publicRequestTargetMapsListValueKvp.Value;

                            context.Writer.WriteArrayStart();
                            foreach(var publicRequestTargetMapsListValueValueListValue in publicRequestTargetMapsListValueValue)
                            {
                                    context.Writer.Write(publicRequestTargetMapsListValueValueListValue);
                            }
                            context.Writer.WriteArrayEnd();
                        }
                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTargets())
                {
                    context.Writer.WritePropertyName("Targets");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTargetsListValue in publicRequest.Targets)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TargetMarshaller.Instance;
                        marshaller.Marshall(publicRequestTargetsListValue, context);

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
        private static CreateAssociationRequestMarshaller _instance = new CreateAssociationRequestMarshaller();        

        internal static CreateAssociationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAssociationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618