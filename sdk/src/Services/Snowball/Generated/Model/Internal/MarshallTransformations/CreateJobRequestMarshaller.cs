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
    /// CreateJob Request Marshaller
    /// </summary>       
    public class CreateJobRequestMarshaller : IMarshaller<IRequest, CreateJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Snowball");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/AWSIESnowballJobManagementService/operation/CreateJob";
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
                if (publicRequest.IsSetClusterId())
                {
                    context.Writer.WriteTextString("ClusterId");
                    context.Writer.WriteTextString(publicRequest.ClusterId);
                }
                if (publicRequest.IsSetDescription())
                {
                    context.Writer.WriteTextString("Description");
                    context.Writer.WriteTextString(publicRequest.Description);
                }
                if (publicRequest.IsSetDeviceConfiguration())
                {
                    context.Writer.WriteTextString("DeviceConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = DeviceConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DeviceConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetForwardingAddressId())
                {
                    context.Writer.WriteTextString("ForwardingAddressId");
                    context.Writer.WriteTextString(publicRequest.ForwardingAddressId);
                }
                if (publicRequest.IsSetImpactLevel())
                {
                    context.Writer.WriteTextString("ImpactLevel");
                    context.Writer.WriteTextString(publicRequest.ImpactLevel);
                }
                if (publicRequest.IsSetJobType())
                {
                    context.Writer.WriteTextString("JobType");
                    context.Writer.WriteTextString(publicRequest.JobType);
                }
                if (publicRequest.IsSetKmsKeyARN())
                {
                    context.Writer.WriteTextString("KmsKeyARN");
                    context.Writer.WriteTextString(publicRequest.KmsKeyARN);
                }
                if (publicRequest.IsSetLongTermPricingId())
                {
                    context.Writer.WriteTextString("LongTermPricingId");
                    context.Writer.WriteTextString(publicRequest.LongTermPricingId);
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
                if (publicRequest.IsSetRemoteManagement())
                {
                    context.Writer.WriteTextString("RemoteManagement");
                    context.Writer.WriteTextString(publicRequest.RemoteManagement);
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
                if (publicRequest.IsSetSnowballType())
                {
                    context.Writer.WriteTextString("SnowballType");
                    context.Writer.WriteTextString(publicRequest.SnowballType);
                }
                if (publicRequest.IsSetTaxDocuments())
                {
                    context.Writer.WriteTextString("TaxDocuments");
                    context.Writer.WriteStartMap(null);

                    var marshaller = TaxDocumentsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TaxDocuments, context);

                    context.Writer.WriteEndMap();
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
        private static CreateJobRequestMarshaller _instance = new CreateJobRequestMarshaller();        

        internal static CreateJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}