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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.PrometheusService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PrometheusService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RandomCutForestConfiguration Object
    /// </summary>  
    public class RandomCutForestConfigurationUnmarshaller : IUnmarshaller<RandomCutForestConfiguration, XmlUnmarshallerContext>, IUnmarshaller<RandomCutForestConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RandomCutForestConfiguration IUnmarshaller<RandomCutForestConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RandomCutForestConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            RandomCutForestConfiguration unmarshalledObject = new RandomCutForestConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ignoreNearExpectedFromAbove", targetDepth))
                {
                    var unmarshaller = IgnoreNearExpectedUnmarshaller.Instance;
                    unmarshalledObject.IgnoreNearExpectedFromAbove = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ignoreNearExpectedFromBelow", targetDepth))
                {
                    var unmarshaller = IgnoreNearExpectedUnmarshaller.Instance;
                    unmarshalledObject.IgnoreNearExpectedFromBelow = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("query", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Query = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sampleSize", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SampleSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("shingleSize", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ShingleSize = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RandomCutForestConfigurationUnmarshaller _instance = new RandomCutForestConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RandomCutForestConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}