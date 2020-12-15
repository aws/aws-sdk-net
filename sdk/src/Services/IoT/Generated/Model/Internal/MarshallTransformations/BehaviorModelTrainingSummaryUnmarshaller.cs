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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BehaviorModelTrainingSummary Object
    /// </summary>  
    public class BehaviorModelTrainingSummaryUnmarshaller : IUnmarshaller<BehaviorModelTrainingSummary, XmlUnmarshallerContext>, IUnmarshaller<BehaviorModelTrainingSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        BehaviorModelTrainingSummary IUnmarshaller<BehaviorModelTrainingSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public BehaviorModelTrainingSummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            BehaviorModelTrainingSummary unmarshalledObject = new BehaviorModelTrainingSummary();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("behaviorName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BehaviorName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("datapointsCollectionPercentage", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.DatapointsCollectionPercentage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastModelRefreshDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastModelRefreshDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("modelStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ModelStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("securityProfileName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecurityProfileName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("trainingDataCollectionStartDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.TrainingDataCollectionStartDate = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static BehaviorModelTrainingSummaryUnmarshaller _instance = new BehaviorModelTrainingSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BehaviorModelTrainingSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}