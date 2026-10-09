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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.Snowball.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.Snowball.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for JobMetadata Object
    /// </summary>
    public partial class JobMetadataUnmarshaller : ICborUnmarshaller<JobMetadata, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public JobMetadata Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new JobMetadata();
            if (context.IsEmptyResponse) return null;

            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "AddressId":
                        context.AddPathSegment("AddressId");
                        unmarshalledObject.AddressId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ClusterId":
                        context.AddPathSegment("ClusterId");
                        unmarshalledObject.ClusterId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CreationDate":
                        context.AddPathSegment("CreationDate");
                        unmarshalledObject.CreationDate = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DataTransferProgress":
                        context.AddPathSegment("DataTransferProgress");
                        unmarshalledObject.DataTransferProgress = DataTransferUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Description":
                        context.AddPathSegment("Description");
                        unmarshalledObject.Description = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DeviceConfiguration":
                        context.AddPathSegment("DeviceConfiguration");
                        unmarshalledObject.DeviceConfiguration = DeviceConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ForwardingAddressId":
                        context.AddPathSegment("ForwardingAddressId");
                        unmarshalledObject.ForwardingAddressId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ImpactLevel":
                        context.AddPathSegment("ImpactLevel");
                        unmarshalledObject.ImpactLevel = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "JobId":
                        context.AddPathSegment("JobId");
                        unmarshalledObject.JobId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "JobLogInfo":
                        context.AddPathSegment("JobLogInfo");
                        unmarshalledObject.JobLogInfo = JobLogsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "JobState":
                        context.AddPathSegment("JobState");
                        unmarshalledObject.JobState = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "JobType":
                        context.AddPathSegment("JobType");
                        unmarshalledObject.JobType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "KmsKeyARN":
                        context.AddPathSegment("KmsKeyARN");
                        unmarshalledObject.KmsKeyARN = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LongTermPricingId":
                        context.AddPathSegment("LongTermPricingId");
                        unmarshalledObject.LongTermPricingId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Notification":
                        context.AddPathSegment("Notification");
                        unmarshalledObject.Notification = NotificationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "OnDeviceServiceConfiguration":
                        context.AddPathSegment("OnDeviceServiceConfiguration");
                        unmarshalledObject.OnDeviceServiceConfiguration = OnDeviceServiceConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PickupDetails":
                        context.AddPathSegment("PickupDetails");
                        unmarshalledObject.PickupDetails = PickupDetailsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RemoteManagement":
                        context.AddPathSegment("RemoteManagement");
                        unmarshalledObject.RemoteManagement = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Resources":
                        context.AddPathSegment("Resources");
                        unmarshalledObject.Resources = JobResourceUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RoleARN":
                        context.AddPathSegment("RoleARN");
                        unmarshalledObject.RoleARN = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ShippingDetails":
                        context.AddPathSegment("ShippingDetails");
                        unmarshalledObject.ShippingDetails = ShippingDetailsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SnowballCapacityPreference":
                        context.AddPathSegment("SnowballCapacityPreference");
                        unmarshalledObject.SnowballCapacityPreference = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SnowballId":
                        context.AddPathSegment("SnowballId");
                        unmarshalledObject.SnowballId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SnowballType":
                        context.AddPathSegment("SnowballType");
                        unmarshalledObject.SnowballType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TaxDocuments":
                        context.AddPathSegment("TaxDocuments");
                        unmarshalledObject.TaxDocuments = TaxDocumentsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            return unmarshalledObject;
        }

        private static JobMetadataUnmarshaller _instance = new JobMetadataUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static JobMetadataUnmarshaller Instance => _instance;
    }
}
