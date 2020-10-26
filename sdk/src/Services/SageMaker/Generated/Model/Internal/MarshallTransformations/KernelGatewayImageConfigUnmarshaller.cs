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
    /// Response Unmarshaller for KernelGatewayImageConfig Object
    /// </summary>  
    public class KernelGatewayImageConfigUnmarshaller : IUnmarshaller<KernelGatewayImageConfig, XmlUnmarshallerContext>, IUnmarshaller<KernelGatewayImageConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        KernelGatewayImageConfig IUnmarshaller<KernelGatewayImageConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public KernelGatewayImageConfig Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            KernelGatewayImageConfig unmarshalledObject = new KernelGatewayImageConfig();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("FileSystemConfig", targetDepth))
                {
                    var unmarshaller = FileSystemConfigUnmarshaller.Instance;
                    unmarshalledObject.FileSystemConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KernelSpecs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<KernelSpec, KernelSpecUnmarshaller>(KernelSpecUnmarshaller.Instance);
                    unmarshalledObject.KernelSpecs = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static KernelGatewayImageConfigUnmarshaller _instance = new KernelGatewayImageConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static KernelGatewayImageConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}