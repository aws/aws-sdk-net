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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QBusiness.Model;
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
namespace Amazon.QBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateApplication Request Marshaller
    /// </summary>       
    public class UpdateApplicationRequestMarshaller : IMarshaller<IRequest, UpdateApplicationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateApplicationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateApplicationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QBusiness");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-11-27";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetApplicationId())
                throw new AmazonQBusinessException("Request object does not have required field ApplicationId set");
            request.AddPathResource("{applicationId}", StringUtils.FromString(publicRequest.ApplicationId));
            request.ResourcePath = "/applications/{applicationId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAttachmentsConfiguration())
            {
                context.Writer.WritePropertyName("attachmentsConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AttachmentsConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.AttachmentsConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAutoSubscriptionConfiguration())
            {
                context.Writer.WritePropertyName("autoSubscriptionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AutoSubscriptionConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.AutoSubscriptionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetDisplayName())
            {
                context.Writer.WritePropertyName("displayName");
                context.Writer.WriteStringValue(publicRequest.DisplayName);
            }

            if(publicRequest.IsSetIdentityCenterInstanceArn())
            {
                context.Writer.WritePropertyName("identityCenterInstanceArn");
                context.Writer.WriteStringValue(publicRequest.IdentityCenterInstanceArn);
            }

            if(publicRequest.IsSetPersonalizationConfiguration())
            {
                context.Writer.WritePropertyName("personalizationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = PersonalizationConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.PersonalizationConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetQAppsConfiguration())
            {
                context.Writer.WritePropertyName("qAppsConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = QAppsConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.QAppsConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
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
        private static UpdateApplicationRequestMarshaller _instance = new UpdateApplicationRequestMarshaller();        

        internal static UpdateApplicationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateApplicationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}