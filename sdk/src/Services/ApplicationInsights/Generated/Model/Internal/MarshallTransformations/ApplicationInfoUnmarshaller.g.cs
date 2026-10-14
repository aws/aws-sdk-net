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

using Amazon.ApplicationInsights.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.ApplicationInsights.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ApplicationInfo Object
    /// </summary>
    public partial class ApplicationInfoUnmarshaller : ICborUnmarshaller<ApplicationInfo, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ApplicationInfo Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new ApplicationInfo();
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
                    case "AccountId":
                        context.AddPathSegment("AccountId");
                        unmarshalledObject.AccountId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AttachMissingPermission":
                        context.AddPathSegment("AttachMissingPermission");
                        unmarshalledObject.AttachMissingPermission = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AutoConfigEnabled":
                        context.AddPathSegment("AutoConfigEnabled");
                        unmarshalledObject.AutoConfigEnabled = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CWEMonitorEnabled":
                        context.AddPathSegment("CWEMonitorEnabled");
                        unmarshalledObject.CWEMonitorEnabled = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DiscoveryType":
                        context.AddPathSegment("DiscoveryType");
                        unmarshalledObject.DiscoveryType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LifeCycle":
                        context.AddPathSegment("LifeCycle");
                        unmarshalledObject.LifeCycle = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "OpsCenterEnabled":
                        context.AddPathSegment("OpsCenterEnabled");
                        unmarshalledObject.OpsCenterEnabled = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "OpsItemSNSTopicArn":
                        context.AddPathSegment("OpsItemSNSTopicArn");
                        unmarshalledObject.OpsItemSNSTopicArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Remarks":
                        context.AddPathSegment("Remarks");
                        unmarshalledObject.Remarks = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ResourceGroupName":
                        context.AddPathSegment("ResourceGroupName");
                        unmarshalledObject.ResourceGroupName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SNSNotificationArn":
                        context.AddPathSegment("SNSNotificationArn");
                        unmarshalledObject.SNSNotificationArn = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static ApplicationInfoUnmarshaller _instance = new ApplicationInfoUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ApplicationInfoUnmarshaller Instance => _instance;
    }
}
