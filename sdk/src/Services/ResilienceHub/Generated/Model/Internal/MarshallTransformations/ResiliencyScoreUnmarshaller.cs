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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ResilienceHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ResilienceHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ResiliencyScore Object
    /// </summary>  
    public class ResiliencyScoreUnmarshaller : IUnmarshaller<ResiliencyScore, XmlUnmarshallerContext>, IUnmarshaller<ResiliencyScore, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ResiliencyScore IUnmarshaller<ResiliencyScore, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ResiliencyScore Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ResiliencyScore unmarshalledObject = new ResiliencyScore();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("disruptionScore", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, double, StringUnmarshaller, DoubleUnmarshaller>(StringUnmarshaller.Instance, DoubleUnmarshaller.Instance);
                    unmarshalledObject.DisruptionScore = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("score", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Score = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ResiliencyScoreUnmarshaller _instance = new ResiliencyScoreUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResiliencyScoreUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}