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

using Amazon.AppStream.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AdminAppLicenseUsageRecord Object
    /// </summary>
    public partial class AdminAppLicenseUsageRecordUnmarshaller : ICborUnmarshaller<AdminAppLicenseUsageRecord, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public AdminAppLicenseUsageRecord Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new AdminAppLicenseUsageRecord();
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
                    case "BillingPeriod":
                        context.AddPathSegment("BillingPeriod");
                        unmarshalledObject.BillingPeriod = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LicenseType":
                        context.AddPathSegment("LicenseType");
                        unmarshalledObject.LicenseType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "OwnerAWSAccountId":
                        context.AddPathSegment("OwnerAWSAccountId");
                        unmarshalledObject.OwnerAWSAccountId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SubscriptionFirstUsedDate":
                        context.AddPathSegment("SubscriptionFirstUsedDate");
                        unmarshalledObject.SubscriptionFirstUsedDate = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SubscriptionLastUsedDate":
                        context.AddPathSegment("SubscriptionLastUsedDate");
                        unmarshalledObject.SubscriptionLastUsedDate = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "UserArn":
                        context.AddPathSegment("UserArn");
                        unmarshalledObject.UserArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "UserId":
                        context.AddPathSegment("UserId");
                        unmarshalledObject.UserId = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static AdminAppLicenseUsageRecordUnmarshaller _instance = new AdminAppLicenseUsageRecordUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AdminAppLicenseUsageRecordUnmarshaller Instance => _instance;
    }
}
