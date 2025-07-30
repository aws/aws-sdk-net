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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTWireless.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTWireless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LoRaWANGetServiceProfileInfo Object
    /// </summary>  
    public class LoRaWANGetServiceProfileInfoUnmarshaller : IUnmarshaller<LoRaWANGetServiceProfileInfo, XmlUnmarshallerContext>, IUnmarshaller<LoRaWANGetServiceProfileInfo, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        LoRaWANGetServiceProfileInfo IUnmarshaller<LoRaWANGetServiceProfileInfo, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public LoRaWANGetServiceProfileInfo Unmarshall(JsonUnmarshallerContext context)
        {
            LoRaWANGetServiceProfileInfo unmarshalledObject = new LoRaWANGetServiceProfileInfo();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AddGwMetadata", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AddGwMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ChannelMask", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ChannelMask = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DevStatusReqFreq", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DevStatusReqFreq = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DlBucketSize", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DlBucketSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DlRate", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DlRate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DlRatePolicy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DlRatePolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DrMax", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DrMax = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DrMin", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DrMin = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HrAllowed", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.HrAllowed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MinGwDiversity", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinGwDiversity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NbTransMax", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NbTransMax = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NbTransMin", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NbTransMin = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NwkGeoLoc", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.NwkGeoLoc = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PrAllowed", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.PrAllowed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RaAllowed", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.RaAllowed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReportDevStatusBattery", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ReportDevStatusBattery = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReportDevStatusMargin", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ReportDevStatusMargin = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetPer", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TargetPer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TxPowerIndexMax", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TxPowerIndexMax = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TxPowerIndexMin", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TxPowerIndexMin = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UlBucketSize", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.UlBucketSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UlRate", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.UlRate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UlRatePolicy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UlRatePolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static LoRaWANGetServiceProfileInfoUnmarshaller _instance = new LoRaWANGetServiceProfileInfoUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LoRaWANGetServiceProfileInfoUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}