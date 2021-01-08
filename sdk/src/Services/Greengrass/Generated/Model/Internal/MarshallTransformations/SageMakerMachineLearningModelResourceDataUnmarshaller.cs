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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Greengrass.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Greengrass.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SageMakerMachineLearningModelResourceData Object
    /// </summary>  
    public class SageMakerMachineLearningModelResourceDataUnmarshaller : IUnmarshaller<SageMakerMachineLearningModelResourceData, XmlUnmarshallerContext>, IUnmarshaller<SageMakerMachineLearningModelResourceData, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SageMakerMachineLearningModelResourceData IUnmarshaller<SageMakerMachineLearningModelResourceData, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SageMakerMachineLearningModelResourceData Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SageMakerMachineLearningModelResourceData unmarshalledObject = new SageMakerMachineLearningModelResourceData();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DestinationPath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DestinationPath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OwnerSetting", targetDepth))
                {
                    var unmarshaller = ResourceDownloadOwnerSettingUnmarshaller.Instance;
                    unmarshalledObject.OwnerSetting = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SageMakerJobArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SageMakerJobArn = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SageMakerMachineLearningModelResourceDataUnmarshaller _instance = new SageMakerMachineLearningModelResourceDataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SageMakerMachineLearningModelResourceDataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}