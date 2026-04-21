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
    /// Response Unmarshaller for OnDeviceServiceConfiguration Object
    /// </summary>  
    public class OnDeviceServiceConfigurationUnmarshaller : ICborUnmarshaller<OnDeviceServiceConfiguration, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public OnDeviceServiceConfiguration Unmarshall(CborUnmarshallerContext context)
        {
            OnDeviceServiceConfiguration unmarshalledObject = new OnDeviceServiceConfiguration();
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
                    case "EKSOnDeviceService":
                        {
                            context.AddPathSegment("EKSOnDeviceService");
                            var unmarshaller = EKSOnDeviceServiceConfigurationUnmarshaller.Instance;
                            unmarshalledObject.EKSOnDeviceService = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "NFSOnDeviceService":
                        {
                            context.AddPathSegment("NFSOnDeviceService");
                            var unmarshaller = NFSOnDeviceServiceConfigurationUnmarshaller.Instance;
                            unmarshalledObject.NFSOnDeviceService = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "S3OnDeviceService":
                        {
                            context.AddPathSegment("S3OnDeviceService");
                            var unmarshaller = S3OnDeviceServiceConfigurationUnmarshaller.Instance;
                            unmarshalledObject.S3OnDeviceService = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "TGWOnDeviceService":
                        {
                            context.AddPathSegment("TGWOnDeviceService");
                            var unmarshaller = TGWOnDeviceServiceConfigurationUnmarshaller.Instance;
                            unmarshalledObject.TGWOnDeviceService = unmarshaller.Unmarshall(context);
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


        private static OnDeviceServiceConfigurationUnmarshaller _instance = new OnDeviceServiceConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OnDeviceServiceConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}