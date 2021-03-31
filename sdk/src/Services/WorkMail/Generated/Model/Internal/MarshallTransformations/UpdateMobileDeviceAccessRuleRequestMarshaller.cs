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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkMail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WorkMail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateMobileDeviceAccessRule Request Marshaller
    /// </summary>       
    public class UpdateMobileDeviceAccessRuleRequestMarshaller : IMarshaller<IRequest, UpdateMobileDeviceAccessRuleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateMobileDeviceAccessRuleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateMobileDeviceAccessRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkMail");
            string target = "WorkMailService.UpdateMobileDeviceAccessRule";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-01";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDeviceModels())
                {
                    context.Writer.WritePropertyName("DeviceModels");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDeviceModelsListValue in publicRequest.DeviceModels)
                    {
                            context.Writer.Write(publicRequestDeviceModelsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDeviceOperatingSystems())
                {
                    context.Writer.WritePropertyName("DeviceOperatingSystems");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDeviceOperatingSystemsListValue in publicRequest.DeviceOperatingSystems)
                    {
                            context.Writer.Write(publicRequestDeviceOperatingSystemsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDeviceTypes())
                {
                    context.Writer.WritePropertyName("DeviceTypes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDeviceTypesListValue in publicRequest.DeviceTypes)
                    {
                            context.Writer.Write(publicRequestDeviceTypesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDeviceUserAgents())
                {
                    context.Writer.WritePropertyName("DeviceUserAgents");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDeviceUserAgentsListValue in publicRequest.DeviceUserAgents)
                    {
                            context.Writer.Write(publicRequestDeviceUserAgentsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetEffect())
                {
                    context.Writer.WritePropertyName("Effect");
                    context.Writer.Write(publicRequest.Effect);
                }

                if(publicRequest.IsSetMobileDeviceAccessRuleId())
                {
                    context.Writer.WritePropertyName("MobileDeviceAccessRuleId");
                    context.Writer.Write(publicRequest.MobileDeviceAccessRuleId);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetNotDeviceModels())
                {
                    context.Writer.WritePropertyName("NotDeviceModels");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestNotDeviceModelsListValue in publicRequest.NotDeviceModels)
                    {
                            context.Writer.Write(publicRequestNotDeviceModelsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetNotDeviceOperatingSystems())
                {
                    context.Writer.WritePropertyName("NotDeviceOperatingSystems");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestNotDeviceOperatingSystemsListValue in publicRequest.NotDeviceOperatingSystems)
                    {
                            context.Writer.Write(publicRequestNotDeviceOperatingSystemsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetNotDeviceTypes())
                {
                    context.Writer.WritePropertyName("NotDeviceTypes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestNotDeviceTypesListValue in publicRequest.NotDeviceTypes)
                    {
                            context.Writer.Write(publicRequestNotDeviceTypesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetNotDeviceUserAgents())
                {
                    context.Writer.WritePropertyName("NotDeviceUserAgents");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestNotDeviceUserAgentsListValue in publicRequest.NotDeviceUserAgents)
                    {
                            context.Writer.Write(publicRequestNotDeviceUserAgentsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetOrganizationId())
                {
                    context.Writer.WritePropertyName("OrganizationId");
                    context.Writer.Write(publicRequest.OrganizationId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateMobileDeviceAccessRuleRequestMarshaller _instance = new UpdateMobileDeviceAccessRuleRequestMarshaller();        

        internal static UpdateMobileDeviceAccessRuleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateMobileDeviceAccessRuleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}