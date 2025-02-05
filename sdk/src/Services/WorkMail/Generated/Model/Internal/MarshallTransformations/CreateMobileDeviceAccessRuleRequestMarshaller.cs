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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.WorkMail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateMobileDeviceAccessRule Request Marshaller
    /// </summary>       
    public class CreateMobileDeviceAccessRuleRequestMarshaller : IMarshaller<IRequest, CreateMobileDeviceAccessRuleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMobileDeviceAccessRuleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateMobileDeviceAccessRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkMail");
            string target = "WorkMailService.CreateMobileDeviceAccessRule";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetDeviceModels())
            {
                context.Writer.WritePropertyName("DeviceModels");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDeviceModelsListValue in publicRequest.DeviceModels)
                {
                        context.Writer.WriteStringValue(publicRequestDeviceModelsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDeviceOperatingSystems())
            {
                context.Writer.WritePropertyName("DeviceOperatingSystems");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDeviceOperatingSystemsListValue in publicRequest.DeviceOperatingSystems)
                {
                        context.Writer.WriteStringValue(publicRequestDeviceOperatingSystemsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDeviceTypes())
            {
                context.Writer.WritePropertyName("DeviceTypes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDeviceTypesListValue in publicRequest.DeviceTypes)
                {
                        context.Writer.WriteStringValue(publicRequestDeviceTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDeviceUserAgents())
            {
                context.Writer.WritePropertyName("DeviceUserAgents");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDeviceUserAgentsListValue in publicRequest.DeviceUserAgents)
                {
                        context.Writer.WriteStringValue(publicRequestDeviceUserAgentsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetEffect())
            {
                context.Writer.WritePropertyName("Effect");
                context.Writer.WriteStringValue(publicRequest.Effect);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetNotDeviceModels())
            {
                context.Writer.WritePropertyName("NotDeviceModels");
                context.Writer.WriteStartArray();
                foreach(var publicRequestNotDeviceModelsListValue in publicRequest.NotDeviceModels)
                {
                        context.Writer.WriteStringValue(publicRequestNotDeviceModelsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetNotDeviceOperatingSystems())
            {
                context.Writer.WritePropertyName("NotDeviceOperatingSystems");
                context.Writer.WriteStartArray();
                foreach(var publicRequestNotDeviceOperatingSystemsListValue in publicRequest.NotDeviceOperatingSystems)
                {
                        context.Writer.WriteStringValue(publicRequestNotDeviceOperatingSystemsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetNotDeviceTypes())
            {
                context.Writer.WritePropertyName("NotDeviceTypes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestNotDeviceTypesListValue in publicRequest.NotDeviceTypes)
                {
                        context.Writer.WriteStringValue(publicRequestNotDeviceTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetNotDeviceUserAgents())
            {
                context.Writer.WritePropertyName("NotDeviceUserAgents");
                context.Writer.WriteStartArray();
                foreach(var publicRequestNotDeviceUserAgentsListValue in publicRequest.NotDeviceUserAgents)
                {
                        context.Writer.WriteStringValue(publicRequestNotDeviceUserAgentsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetOrganizationId())
            {
                context.Writer.WritePropertyName("OrganizationId");
                context.Writer.WriteStringValue(publicRequest.OrganizationId);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateMobileDeviceAccessRuleRequestMarshaller _instance = new CreateMobileDeviceAccessRuleRequestMarshaller();        

        internal static CreateMobileDeviceAccessRuleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateMobileDeviceAccessRuleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}