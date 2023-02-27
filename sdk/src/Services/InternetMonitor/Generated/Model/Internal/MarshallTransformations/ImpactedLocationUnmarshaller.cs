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
 * Do not modify this file. This file is generated from the internetmonitor-2021-06-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.InternetMonitor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.InternetMonitor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ImpactedLocation Object
    /// </summary>  
    public class ImpactedLocationUnmarshaller : IUnmarshaller<ImpactedLocation, XmlUnmarshallerContext>, IUnmarshaller<ImpactedLocation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ImpactedLocation IUnmarshaller<ImpactedLocation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ImpactedLocation Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ImpactedLocation unmarshalledObject = new ImpactedLocation();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ASName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ASName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ASNumber", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ASNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CausedBy", targetDepth))
                {
                    var unmarshaller = NetworkImpairmentUnmarshaller.Instance;
                    unmarshalledObject.CausedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("City", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.City = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Country", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Country = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CountryCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CountryCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InternetHealth", targetDepth))
                {
                    var unmarshaller = InternetHealthUnmarshaller.Instance;
                    unmarshalledObject.InternetHealth = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Latitude", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Latitude = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Longitude", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Longitude = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Metro", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Metro = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceLocation", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceLocation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Subdivision", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Subdivision = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubdivisionCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SubdivisionCode = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ImpactedLocationUnmarshaller _instance = new ImpactedLocationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ImpactedLocationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}