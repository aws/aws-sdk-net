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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationInsights.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ApplicationInsights.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateApplication Request Marshaller
    /// </summary>       
    public class CreateApplicationRequestMarshaller : IMarshaller<IRequest, CreateApplicationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateApplicationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateApplicationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApplicationInsights");
            string target = "EC2WindowsBarleyService.CreateApplication";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-25";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAttachMissingPermission())
                {
                    context.Writer.WritePropertyName("AttachMissingPermission");
                    context.Writer.Write(publicRequest.AttachMissingPermission);
                }

                if(publicRequest.IsSetAutoConfigEnabled())
                {
                    context.Writer.WritePropertyName("AutoConfigEnabled");
                    context.Writer.Write(publicRequest.AutoConfigEnabled);
                }

                if(publicRequest.IsSetAutoCreate())
                {
                    context.Writer.WritePropertyName("AutoCreate");
                    context.Writer.Write(publicRequest.AutoCreate);
                }

                if(publicRequest.IsSetCWEMonitorEnabled())
                {
                    context.Writer.WritePropertyName("CWEMonitorEnabled");
                    context.Writer.Write(publicRequest.CWEMonitorEnabled);
                }

                if(publicRequest.IsSetGroupingType())
                {
                    context.Writer.WritePropertyName("GroupingType");
                    context.Writer.Write(publicRequest.GroupingType);
                }

                if(publicRequest.IsSetOpsCenterEnabled())
                {
                    context.Writer.WritePropertyName("OpsCenterEnabled");
                    context.Writer.Write(publicRequest.OpsCenterEnabled);
                }

                if(publicRequest.IsSetOpsItemSNSTopicArn())
                {
                    context.Writer.WritePropertyName("OpsItemSNSTopicArn");
                    context.Writer.Write(publicRequest.OpsItemSNSTopicArn);
                }

                if(publicRequest.IsSetResourceGroupName())
                {
                    context.Writer.WritePropertyName("ResourceGroupName");
                    context.Writer.Write(publicRequest.ResourceGroupName);
                }

                if(publicRequest.IsSetSNSNotificationArn())
                {
                    context.Writer.WritePropertyName("SNSNotificationArn");
                    context.Writer.Write(publicRequest.SNSNotificationArn);
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
        private static CreateApplicationRequestMarshaller _instance = new CreateApplicationRequestMarshaller();        

        internal static CreateApplicationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateApplicationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}