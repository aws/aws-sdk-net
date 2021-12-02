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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DriftCheckExplainability Object
    /// </summary>  
    public class DriftCheckExplainabilityUnmarshaller : IUnmarshaller<DriftCheckExplainability, XmlUnmarshallerContext>, IUnmarshaller<DriftCheckExplainability, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DriftCheckExplainability IUnmarshaller<DriftCheckExplainability, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DriftCheckExplainability Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DriftCheckExplainability unmarshalledObject = new DriftCheckExplainability();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ConfigFile", targetDepth))
                {
                    var unmarshaller = FileSourceUnmarshaller.Instance;
                    unmarshalledObject.ConfigFile = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Constraints", targetDepth))
                {
                    var unmarshaller = MetricsSourceUnmarshaller.Instance;
                    unmarshalledObject.Constraints = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DriftCheckExplainabilityUnmarshaller _instance = new DriftCheckExplainabilityUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DriftCheckExplainabilityUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}