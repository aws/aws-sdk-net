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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DevOpsGuru.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DevOpsGuru.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AnomalousLogGroup Object
    /// </summary>  
    public class AnomalousLogGroupUnmarshaller : IUnmarshaller<AnomalousLogGroup, XmlUnmarshallerContext>, IUnmarshaller<AnomalousLogGroup, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AnomalousLogGroup IUnmarshaller<AnomalousLogGroup, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AnomalousLogGroup Unmarshall(JsonUnmarshallerContext context)
        {
            AnomalousLogGroup unmarshalledObject = new AnomalousLogGroup();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ImpactEndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ImpactEndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ImpactStartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ImpactStartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LogAnomalyShowcases", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<LogAnomalyShowcase, LogAnomalyShowcaseUnmarshaller>(LogAnomalyShowcaseUnmarshaller.Instance);
                    unmarshalledObject.LogAnomalyShowcases = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LogGroupName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogGroupName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumberOfLogLinesScanned", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumberOfLogLinesScanned = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AnomalousLogGroupUnmarshaller _instance = new AnomalousLogGroupUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AnomalousLogGroupUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}