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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutCompositeAlarm Request Marshaller
    /// </summary>       
    public class PutCompositeAlarmRequestMarshaller : IMarshaller<IRequest, PutCompositeAlarmRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutCompositeAlarmRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutCompositeAlarmRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatch");
            string target = "GraniteServiceVersion20100801.PutCompositeAlarm";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2010-08-01";
            request.HttpMethod = "POST";

            request.Headers[Amazon.Util.HeaderKeys.XAmzQueryMode] = "true";
            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetActionsEnabled())
                {
                    context.Writer.WritePropertyName("ActionsEnabled");
                    context.Writer.Write(publicRequest.ActionsEnabled);
                }

                if(publicRequest.IsSetActionsSuppressor())
                {
                    context.Writer.WritePropertyName("ActionsSuppressor");
                    context.Writer.Write(publicRequest.ActionsSuppressor);
                }

                if(publicRequest.IsSetActionsSuppressorExtensionPeriod())
                {
                    context.Writer.WritePropertyName("ActionsSuppressorExtensionPeriod");
                    context.Writer.Write(publicRequest.ActionsSuppressorExtensionPeriod);
                }

                if(publicRequest.IsSetActionsSuppressorWaitPeriod())
                {
                    context.Writer.WritePropertyName("ActionsSuppressorWaitPeriod");
                    context.Writer.Write(publicRequest.ActionsSuppressorWaitPeriod);
                }

                if(publicRequest.IsSetAlarmActions())
                {
                    context.Writer.WritePropertyName("AlarmActions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAlarmActionsListValue in publicRequest.AlarmActions)
                    {
                            context.Writer.Write(publicRequestAlarmActionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAlarmDescription())
                {
                    context.Writer.WritePropertyName("AlarmDescription");
                    context.Writer.Write(publicRequest.AlarmDescription);
                }

                if(publicRequest.IsSetAlarmName())
                {
                    context.Writer.WritePropertyName("AlarmName");
                    context.Writer.Write(publicRequest.AlarmName);
                }

                if(publicRequest.IsSetAlarmRule())
                {
                    context.Writer.WritePropertyName("AlarmRule");
                    context.Writer.Write(publicRequest.AlarmRule);
                }

                if(publicRequest.IsSetInsufficientDataActions())
                {
                    context.Writer.WritePropertyName("InsufficientDataActions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestInsufficientDataActionsListValue in publicRequest.InsufficientDataActions)
                    {
                            context.Writer.Write(publicRequestInsufficientDataActionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetOKActions())
                {
                    context.Writer.WritePropertyName("OKActions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestOKActionsListValue in publicRequest.OKActions)
                    {
                            context.Writer.Write(publicRequestOKActionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
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
        private static PutCompositeAlarmRequestMarshaller _instance = new PutCompositeAlarmRequestMarshaller();        

        internal static PutCompositeAlarmRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutCompositeAlarmRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}