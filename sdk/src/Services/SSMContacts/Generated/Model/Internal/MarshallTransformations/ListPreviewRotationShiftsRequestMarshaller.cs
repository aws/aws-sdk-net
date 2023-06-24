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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSMContacts.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SSMContacts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListPreviewRotationShifts Request Marshaller
    /// </summary>       
    public class ListPreviewRotationShiftsRequestMarshaller : IMarshaller<IRequest, ListPreviewRotationShiftsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListPreviewRotationShiftsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListPreviewRotationShiftsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SSMContacts");
            string target = "SSMContacts.ListPreviewRotationShifts";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-05-03";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetEndTime())
                {
                    context.Writer.WritePropertyName("EndTime");
                    context.Writer.Write(publicRequest.EndTime);
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("MaxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetMembers())
                {
                    context.Writer.WritePropertyName("Members");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestMembersListValue in publicRequest.Members)
                    {
                            context.Writer.Write(publicRequestMembersListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("NextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetOverrides())
                {
                    context.Writer.WritePropertyName("Overrides");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestOverridesListValue in publicRequest.Overrides)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = PreviewOverrideMarshaller.Instance;
                        marshaller.Marshall(publicRequestOverridesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRecurrence())
                {
                    context.Writer.WritePropertyName("Recurrence");
                    context.Writer.WriteObjectStart();

                    var marshaller = RecurrenceSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Recurrence, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRotationStartTime())
                {
                    context.Writer.WritePropertyName("RotationStartTime");
                    context.Writer.Write(publicRequest.RotationStartTime);
                }

                if(publicRequest.IsSetStartTime())
                {
                    context.Writer.WritePropertyName("StartTime");
                    context.Writer.Write(publicRequest.StartTime);
                }

                if(publicRequest.IsSetTimeZoneId())
                {
                    context.Writer.WritePropertyName("TimeZoneId");
                    context.Writer.Write(publicRequest.TimeZoneId);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ListPreviewRotationShiftsRequestMarshaller _instance = new ListPreviewRotationShiftsRequestMarshaller();        

        internal static ListPreviewRotationShiftsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListPreviewRotationShiftsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}