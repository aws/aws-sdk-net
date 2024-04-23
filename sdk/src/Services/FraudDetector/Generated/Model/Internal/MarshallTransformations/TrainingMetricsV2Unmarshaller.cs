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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.FraudDetector.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.FraudDetector.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TrainingMetricsV2 Object
    /// </summary>  
    public class TrainingMetricsV2Unmarshaller : IUnmarshaller<TrainingMetricsV2, XmlUnmarshallerContext>, IUnmarshaller<TrainingMetricsV2, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TrainingMetricsV2 IUnmarshaller<TrainingMetricsV2, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public TrainingMetricsV2 Unmarshall(JsonUnmarshallerContext context)
        {
            TrainingMetricsV2 unmarshalledObject = new TrainingMetricsV2();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ati", targetDepth))
                {
                    var unmarshaller = ATITrainingMetricsValueUnmarshaller.Instance;
                    unmarshalledObject.Ati = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ofi", targetDepth))
                {
                    var unmarshaller = OFITrainingMetricsValueUnmarshaller.Instance;
                    unmarshalledObject.Ofi = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tfi", targetDepth))
                {
                    var unmarshaller = TFITrainingMetricsValueUnmarshaller.Instance;
                    unmarshalledObject.Tfi = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TrainingMetricsV2Unmarshaller _instance = new TrainingMetricsV2Unmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TrainingMetricsV2Unmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618