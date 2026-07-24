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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationInsights.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
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
    public class ApplicationInfoUnmarshaller : ICborUnmarshaller<ApplicationInfo, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ApplicationInfo Unmarshall(CborUnmarshallerContext context)
        {
            ApplicationInfo unmarshalledObject = new ApplicationInfo();
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
                    case "AccountId":
                        {
                            context.AddPathSegment("AccountId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AccountId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "AttachMissingPermission":
                        {
                            context.AddPathSegment("AttachMissingPermission");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.AttachMissingPermission = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "AutoConfigEnabled":
                        {
                            context.AddPathSegment("AutoConfigEnabled");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.AutoConfigEnabled = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CWEMonitorEnabled":
                        {
                            context.AddPathSegment("CWEMonitorEnabled");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.CWEMonitorEnabled = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DiscoveryType":
                        {
                            context.AddPathSegment("DiscoveryType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.DiscoveryType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LifeCycle":
                        {
                            context.AddPathSegment("LifeCycle");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.LifeCycle = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "OpsCenterEnabled":
                        {
                            context.AddPathSegment("OpsCenterEnabled");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.OpsCenterEnabled = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "OpsItemSNSTopicArn":
                        {
                            context.AddPathSegment("OpsItemSNSTopicArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.OpsItemSNSTopicArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Remarks":
                        {
                            context.AddPathSegment("Remarks");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Remarks = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ResourceGroupName":
                        {
                            context.AddPathSegment("ResourceGroupName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ResourceGroupName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SNSNotificationArn":
                        {
                            context.AddPathSegment("SNSNotificationArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SNSNotificationArn = unmarshaller.Unmarshall(context);
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


        private static ApplicationInfoUnmarshaller _instance = new ApplicationInfoUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ApplicationInfoUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}