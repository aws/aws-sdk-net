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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Snowball.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
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
    public class JobMetadataUnmarshaller : ICborUnmarshaller<JobMetadata, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public JobMetadata Unmarshall(CborUnmarshallerContext context)
        {
            JobMetadata unmarshalledObject = new JobMetadata();
            if (context.IsEmptyResponse)
                return null;
            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "AddressId":
                        {
                            context.AddPathSegment("AddressId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AddressId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ClusterId":
                        {
                            context.AddPathSegment("ClusterId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ClusterId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CreationDate":
                        {
                            context.AddPathSegment("CreationDate");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.CreationDate = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DataTransferProgress":
                        {
                            context.AddPathSegment("DataTransferProgress");
                            var unmarshaller = DataTransferUnmarshaller.Instance;
                            unmarshalledObject.DataTransferProgress = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Description":
                        {
                            context.AddPathSegment("Description");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DeviceConfiguration":
                        {
                            context.AddPathSegment("DeviceConfiguration");
                            var unmarshaller = DeviceConfigurationUnmarshaller.Instance;
                            unmarshalledObject.DeviceConfiguration = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ForwardingAddressId":
                        {
                            context.AddPathSegment("ForwardingAddressId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ForwardingAddressId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ImpactLevel":
                        {
                            context.AddPathSegment("ImpactLevel");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ImpactLevel = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "JobId":
                        {
                            context.AddPathSegment("JobId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.JobId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "JobLogInfo":
                        {
                            context.AddPathSegment("JobLogInfo");
                            var unmarshaller = JobLogsUnmarshaller.Instance;
                            unmarshalledObject.JobLogInfo = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "JobState":
                        {
                            context.AddPathSegment("JobState");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.JobState = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "JobType":
                        {
                            context.AddPathSegment("JobType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.JobType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "KmsKeyARN":
                        {
                            context.AddPathSegment("KmsKeyARN");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.KmsKeyARN = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LongTermPricingId":
                        {
                            context.AddPathSegment("LongTermPricingId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.LongTermPricingId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Notification":
                        {
                            context.AddPathSegment("Notification");
                            var unmarshaller = NotificationUnmarshaller.Instance;
                            unmarshalledObject.Notification = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "OnDeviceServiceConfiguration":
                        {
                            context.AddPathSegment("OnDeviceServiceConfiguration");
                            var unmarshaller = OnDeviceServiceConfigurationUnmarshaller.Instance;
                            unmarshalledObject.OnDeviceServiceConfiguration = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PickupDetails":
                        {
                            context.AddPathSegment("PickupDetails");
                            var unmarshaller = PickupDetailsUnmarshaller.Instance;
                            unmarshalledObject.PickupDetails = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "RemoteManagement":
                        {
                            context.AddPathSegment("RemoteManagement");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.RemoteManagement = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Resources":
                        {
                            context.AddPathSegment("Resources");
                            var unmarshaller = JobResourceUnmarshaller.Instance;
                            unmarshalledObject.Resources = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "RoleARN":
                        {
                            context.AddPathSegment("RoleARN");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.RoleARN = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ShippingDetails":
                        {
                            context.AddPathSegment("ShippingDetails");
                            var unmarshaller = ShippingDetailsUnmarshaller.Instance;
                            unmarshalledObject.ShippingDetails = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SnowballCapacityPreference":
                        {
                            context.AddPathSegment("SnowballCapacityPreference");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SnowballCapacityPreference = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SnowballId":
                        {
                            context.AddPathSegment("SnowballId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SnowballId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SnowballType":
                        {
                            context.AddPathSegment("SnowballType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SnowballType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "TaxDocuments":
                        {
                            context.AddPathSegment("TaxDocuments");
                            var unmarshaller = TaxDocumentsUnmarshaller.Instance;
                            unmarshalledObject.TaxDocuments = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
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
        public static JobMetadataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}