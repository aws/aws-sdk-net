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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Snowball.Model;
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
namespace Amazon.Snowball.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateJob Request Marshaller
    /// </summary>       
    public class UpdateJobRequestMarshaller : IMarshaller<IRequest, UpdateJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Snowball");
            string target = "AWSIESnowballJobManagementService.UpdateJob";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-06-30";
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
            if(publicRequest.IsSetAddressId())
            {
                context.Writer.WritePropertyName("AddressId");
                context.Writer.WriteStringValue(publicRequest.AddressId);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetForwardingAddressId())
            {
                context.Writer.WritePropertyName("ForwardingAddressId");
                context.Writer.WriteStringValue(publicRequest.ForwardingAddressId);
            }

            if(publicRequest.IsSetJobId())
            {
                context.Writer.WritePropertyName("JobId");
                context.Writer.WriteStringValue(publicRequest.JobId);
            }

            if(publicRequest.IsSetNotification())
            {
                context.Writer.WritePropertyName("Notification");
                context.Writer.WriteStartObject();

                var marshaller = NotificationMarshaller.Instance;
                marshaller.Marshall(publicRequest.Notification, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOnDeviceServiceConfiguration())
            {
                context.Writer.WritePropertyName("OnDeviceServiceConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = OnDeviceServiceConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.OnDeviceServiceConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPickupDetails())
            {
                context.Writer.WritePropertyName("PickupDetails");
                context.Writer.WriteStartObject();

                var marshaller = PickupDetailsMarshaller.Instance;
                marshaller.Marshall(publicRequest.PickupDetails, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetResources())
            {
                context.Writer.WritePropertyName("Resources");
                context.Writer.WriteStartObject();

                var marshaller = JobResourceMarshaller.Instance;
                marshaller.Marshall(publicRequest.Resources, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRoleARN())
            {
                context.Writer.WritePropertyName("RoleARN");
                context.Writer.WriteStringValue(publicRequest.RoleARN);
            }

            if(publicRequest.IsSetShippingOption())
            {
                context.Writer.WritePropertyName("ShippingOption");
                context.Writer.WriteStringValue(publicRequest.ShippingOption);
            }

            if(publicRequest.IsSetSnowballCapacityPreference())
            {
                context.Writer.WritePropertyName("SnowballCapacityPreference");
                context.Writer.WriteStringValue(publicRequest.SnowballCapacityPreference);
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
        private static UpdateJobRequestMarshaller _instance = new UpdateJobRequestMarshaller();        

        internal static UpdateJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}