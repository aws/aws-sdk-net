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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EventBridgeV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.EventBridgeV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PartnerEventsSourceConfiguration Object
    /// </summary>  
    public class PartnerEventsSourceConfigurationUnmarshaller : ICborUnmarshaller<PartnerEventsSourceConfiguration, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public PartnerEventsSourceConfiguration Unmarshall(CborUnmarshallerContext context)
        {
            PartnerEventsSourceConfiguration unmarshalledObject = new PartnerEventsSourceConfiguration();
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
                    case "OnFailureConfiguration":
                        {
                            context.AddPathSegment("OnFailureConfiguration");
                            var unmarshaller = OnFailureConfigurationUnmarshaller.Instance;
                            unmarshalledObject.OnFailureConfiguration = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PartnerBusKmsKeyIdentifier":
                        {
                            context.AddPathSegment("PartnerBusKmsKeyIdentifier");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PartnerBusKmsKeyIdentifier = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PartnerEventSourceArn":
                        {
                            context.AddPathSegment("PartnerEventSourceArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PartnerEventSourceArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Pattern":
                        {
                            context.AddPathSegment("Pattern");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Pattern = unmarshaller.Unmarshall(context);
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


        private static PartnerEventsSourceConfigurationUnmarshaller _instance = new PartnerEventsSourceConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PartnerEventsSourceConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}