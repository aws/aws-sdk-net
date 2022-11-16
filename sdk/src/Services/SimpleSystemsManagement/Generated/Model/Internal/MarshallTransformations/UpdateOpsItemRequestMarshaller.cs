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

namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateOpsItem Request Marshaller
    /// </summary>       
    public class UpdateOpsItemRequestMarshaller : IMarshaller<IRequest, UpdateOpsItemRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateOpsItemRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateOpsItemRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleSystemsManagement");
            string target = "AmazonSSM.UpdateOpsItem";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-11-06";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetActualEndTime())
                {
                    context.Writer.WritePropertyName("ActualEndTime");
                    context.Writer.Write(publicRequest.ActualEndTime);
                }

                if(publicRequest.IsSetActualStartTime())
                {
                    context.Writer.WritePropertyName("ActualStartTime");
                    context.Writer.Write(publicRequest.ActualStartTime);
                }

                if(publicRequest.IsSetCategory())
                {
                    context.Writer.WritePropertyName("Category");
                    context.Writer.Write(publicRequest.Category);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetNotifications())
                {
                    context.Writer.WritePropertyName("Notifications");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestNotificationsListValue in publicRequest.Notifications)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = OpsItemNotificationMarshaller.Instance;
                        marshaller.Marshall(publicRequestNotificationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetOperationalData())
                {
                    context.Writer.WritePropertyName("OperationalData");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestOperationalDataKvp in publicRequest.OperationalData)
                    {
                        context.Writer.WritePropertyName(publicRequestOperationalDataKvp.Key);
                        var publicRequestOperationalDataValue = publicRequestOperationalDataKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = OpsItemDataValueMarshaller.Instance;
                        marshaller.Marshall(publicRequestOperationalDataValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOperationalDataToDelete())
                {
                    context.Writer.WritePropertyName("OperationalDataToDelete");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestOperationalDataToDeleteListValue in publicRequest.OperationalDataToDelete)
                    {
                            context.Writer.Write(publicRequestOperationalDataToDeleteListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetOpsItemArn())
                {
                    context.Writer.WritePropertyName("OpsItemArn");
                    context.Writer.Write(publicRequest.OpsItemArn);
                }

                if(publicRequest.IsSetOpsItemId())
                {
                    context.Writer.WritePropertyName("OpsItemId");
                    context.Writer.Write(publicRequest.OpsItemId);
                }

                if(publicRequest.IsSetPlannedEndTime())
                {
                    context.Writer.WritePropertyName("PlannedEndTime");
                    context.Writer.Write(publicRequest.PlannedEndTime);
                }

                if(publicRequest.IsSetPlannedStartTime())
                {
                    context.Writer.WritePropertyName("PlannedStartTime");
                    context.Writer.Write(publicRequest.PlannedStartTime);
                }

                if(publicRequest.IsSetPriority())
                {
                    context.Writer.WritePropertyName("Priority");
                    context.Writer.Write(publicRequest.Priority);
                }

                if(publicRequest.IsSetRelatedOpsItems())
                {
                    context.Writer.WritePropertyName("RelatedOpsItems");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRelatedOpsItemsListValue in publicRequest.RelatedOpsItems)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = RelatedOpsItemMarshaller.Instance;
                        marshaller.Marshall(publicRequestRelatedOpsItemsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSeverity())
                {
                    context.Writer.WritePropertyName("Severity");
                    context.Writer.Write(publicRequest.Severity);
                }

                if(publicRequest.IsSetStatus())
                {
                    context.Writer.WritePropertyName("Status");
                    context.Writer.Write(publicRequest.Status);
                }

                if(publicRequest.IsSetTitle())
                {
                    context.Writer.WritePropertyName("Title");
                    context.Writer.Write(publicRequest.Title);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateOpsItemRequestMarshaller _instance = new UpdateOpsItemRequestMarshaller();        

        internal static UpdateOpsItemRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateOpsItemRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}