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

#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DriftCheckBaselines Object
    /// </summary>  
    public class DriftCheckBaselinesUnmarshaller : IUnmarshaller<DriftCheckBaselines, XmlUnmarshallerContext>, IUnmarshaller<DriftCheckBaselines, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DriftCheckBaselines IUnmarshaller<DriftCheckBaselines, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public DriftCheckBaselines Unmarshall(JsonUnmarshallerContext context)
        {
            DriftCheckBaselines unmarshalledObject = new DriftCheckBaselines();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Bias", targetDepth))
                {
                    var unmarshaller = DriftCheckBiasUnmarshaller.Instance;
                    unmarshalledObject.Bias = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Explainability", targetDepth))
                {
                    var unmarshaller = DriftCheckExplainabilityUnmarshaller.Instance;
                    unmarshalledObject.Explainability = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelDataQuality", targetDepth))
                {
                    var unmarshaller = DriftCheckModelDataQualityUnmarshaller.Instance;
                    unmarshalledObject.ModelDataQuality = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelQuality", targetDepth))
                {
                    var unmarshaller = DriftCheckModelQualityUnmarshaller.Instance;
                    unmarshalledObject.ModelQuality = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DriftCheckBaselinesUnmarshaller _instance = new DriftCheckBaselinesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DriftCheckBaselinesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}