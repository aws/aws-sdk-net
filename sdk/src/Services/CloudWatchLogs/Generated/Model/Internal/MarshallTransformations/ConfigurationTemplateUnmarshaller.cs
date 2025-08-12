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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchLogs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConfigurationTemplate Object
    /// </summary>  
    public class ConfigurationTemplateUnmarshaller : ICborUnmarshaller<ConfigurationTemplate, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ConfigurationTemplate Unmarshall(CborUnmarshallerContext context)
        {
            ConfigurationTemplate unmarshalledObject = new ConfigurationTemplate();
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
                    case "allowedActionForAllowVendedLogsDeliveryForResource":
                        {
                            context.AddPathSegment("AllowedActionForAllowVendedLogsDeliveryForResource");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AllowedActionForAllowVendedLogsDeliveryForResource = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "allowedFieldDelimiters":
                        {
                            context.AddPathSegment("AllowedFieldDelimiters");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.AllowedFieldDelimiters = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "allowedFields":
                        {
                            context.AddPathSegment("AllowedFields");
                            var unmarshaller = new CborListUnmarshaller<RecordField, RecordFieldUnmarshaller>(RecordFieldUnmarshaller.Instance);
                            unmarshalledObject.AllowedFields = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "allowedOutputFormats":
                        {
                            context.AddPathSegment("AllowedOutputFormats");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.AllowedOutputFormats = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "allowedSuffixPathFields":
                        {
                            context.AddPathSegment("AllowedSuffixPathFields");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.AllowedSuffixPathFields = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "defaultDeliveryConfigValues":
                        {
                            context.AddPathSegment("DefaultDeliveryConfigValues");
                            var unmarshaller = ConfigurationTemplateDeliveryConfigValuesUnmarshaller.Instance;
                            unmarshalledObject.DefaultDeliveryConfigValues = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "deliveryDestinationType":
                        {
                            context.AddPathSegment("DeliveryDestinationType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.DeliveryDestinationType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "logType":
                        {
                            context.AddPathSegment("LogType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.LogType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "resourceType":
                        {
                            context.AddPathSegment("ResourceType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ResourceType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "service":
                        {
                            context.AddPathSegment("Service");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Service = unmarshaller.Unmarshall(context);
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


        private static ConfigurationTemplateUnmarshaller _instance = new ConfigurationTemplateUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConfigurationTemplateUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}