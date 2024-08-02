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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GuardDuty.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ScanDetections Object
    /// </summary>  
    public class ScanDetectionsUnmarshaller : IUnmarshaller<ScanDetections, XmlUnmarshallerContext>, IUnmarshaller<ScanDetections, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ScanDetections IUnmarshaller<ScanDetections, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ScanDetections Unmarshall(JsonUnmarshallerContext context)
        {
            ScanDetections unmarshalledObject = new ScanDetections();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("highestSeverityThreatDetails", targetDepth))
                {
                    var unmarshaller = HighestSeverityThreatDetailsUnmarshaller.Instance;
                    unmarshalledObject.HighestSeverityThreatDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scannedItemCount", targetDepth))
                {
                    var unmarshaller = ScannedItemCountUnmarshaller.Instance;
                    unmarshalledObject.ScannedItemCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("threatDetectedByName", targetDepth))
                {
                    var unmarshaller = ThreatDetectedByNameUnmarshaller.Instance;
                    unmarshalledObject.ThreatDetectedByName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("threatsDetectedItemCount", targetDepth))
                {
                    var unmarshaller = ThreatsDetectedItemCountUnmarshaller.Instance;
                    unmarshalledObject.ThreatsDetectedItemCount = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ScanDetectionsUnmarshaller _instance = new ScanDetectionsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ScanDetectionsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}