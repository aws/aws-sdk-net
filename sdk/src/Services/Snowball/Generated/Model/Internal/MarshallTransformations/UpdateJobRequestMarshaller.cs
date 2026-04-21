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
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

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
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/AWSIESnowballJobManagementService/operation/UpdateJob";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-06-30";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAddressId())
                {
                    context.Writer.WriteTextString("AddressId");
                    context.Writer.WriteTextString(publicRequest.AddressId);
                }
                if (publicRequest.IsSetDescription())
                {
                    context.Writer.WriteTextString("Description");
                    context.Writer.WriteTextString(publicRequest.Description);
                }
                if (publicRequest.IsSetForwardingAddressId())
                {
                    context.Writer.WriteTextString("ForwardingAddressId");
                    context.Writer.WriteTextString(publicRequest.ForwardingAddressId);
                }
                if (publicRequest.IsSetJobId())
                {
                    context.Writer.WriteTextString("JobId");
                    context.Writer.WriteTextString(publicRequest.JobId);
                }
                if (publicRequest.IsSetNotification())
                {
                    context.Writer.WriteTextString("Notification");
                    context.Writer.WriteStartMap(null);

                    var marshaller = NotificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Notification, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetOnDeviceServiceConfiguration())
                {
                    context.Writer.WriteTextString("OnDeviceServiceConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = OnDeviceServiceConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OnDeviceServiceConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetPickupDetails())
                {
                    context.Writer.WriteTextString("PickupDetails");
                    context.Writer.WriteStartMap(null);

                    var marshaller = PickupDetailsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PickupDetails, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetResources())
                {
                    context.Writer.WriteTextString("Resources");
                    context.Writer.WriteStartMap(null);

                    var marshaller = JobResourceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Resources, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetRoleARN())
                {
                    context.Writer.WriteTextString("RoleARN");
                    context.Writer.WriteTextString(publicRequest.RoleARN);
                }
                if (publicRequest.IsSetShippingOption())
                {
                    context.Writer.WriteTextString("ShippingOption");
                    context.Writer.WriteTextString(publicRequest.ShippingOption);
                }
                if (publicRequest.IsSetSnowballCapacityPreference())
                {
                    context.Writer.WriteTextString("SnowballCapacityPreference");
                    context.Writer.WriteTextString(publicRequest.SnowballCapacityPreference);
                }
                writer.WriteEndMap();
                request.Content = writer.Encode();
            }
            finally
            {
                CborWriterPool.Return(writer);
            }
            
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