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
    /// Response Unmarshaller for ClarifyInferenceConfig Object
    /// </summary>  
    public class ClarifyInferenceConfigUnmarshaller : IUnmarshaller<ClarifyInferenceConfig, XmlUnmarshallerContext>, IUnmarshaller<ClarifyInferenceConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ClarifyInferenceConfig IUnmarshaller<ClarifyInferenceConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ClarifyInferenceConfig Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ClarifyInferenceConfig unmarshalledObject = new ClarifyInferenceConfig();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ContentTemplate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ContentTemplate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FeatureHeaders", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.FeatureHeaders = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FeaturesAttribute", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FeaturesAttribute = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FeatureTypes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.FeatureTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LabelAttribute", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LabelAttribute = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LabelHeaders", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.LabelHeaders = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LabelIndex", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.LabelIndex = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxPayloadInMB", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxPayloadInMB = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxRecordCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxRecordCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProbabilityAttribute", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProbabilityAttribute = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProbabilityIndex", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ProbabilityIndex = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ClarifyInferenceConfigUnmarshaller _instance = new ClarifyInferenceConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ClarifyInferenceConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}