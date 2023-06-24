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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MigrationHubStrategyRecommendations.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MigrationHubStrategyRecommendations.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Collector Object
    /// </summary>  
    public class CollectorUnmarshaller : IUnmarshaller<Collector, XmlUnmarshallerContext>, IUnmarshaller<Collector, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Collector IUnmarshaller<Collector, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Collector Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Collector unmarshalledObject = new Collector();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("collectorHealth", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CollectorHealth = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("collectorId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CollectorId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("collectorVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CollectorVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("configurationSummary", targetDepth))
                {
                    var unmarshaller = ConfigurationSummaryUnmarshaller.Instance;
                    unmarshalledObject.ConfigurationSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("hostName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HostName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ipAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IpAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastActivityTimeStamp", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastActivityTimeStamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("registeredTimeStamp", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RegisteredTimeStamp = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CollectorUnmarshaller _instance = new CollectorUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CollectorUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}