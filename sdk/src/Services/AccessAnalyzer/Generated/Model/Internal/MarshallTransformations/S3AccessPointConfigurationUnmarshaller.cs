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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AccessAnalyzer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AccessAnalyzer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for S3AccessPointConfiguration Object
    /// </summary>  
    public class S3AccessPointConfigurationUnmarshaller : IUnmarshaller<S3AccessPointConfiguration, XmlUnmarshallerContext>, IUnmarshaller<S3AccessPointConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        S3AccessPointConfiguration IUnmarshaller<S3AccessPointConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public S3AccessPointConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            S3AccessPointConfiguration unmarshalledObject = new S3AccessPointConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("accessPointPolicy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccessPointPolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("networkOrigin", targetDepth))
                {
                    var unmarshaller = NetworkOriginConfigurationUnmarshaller.Instance;
                    unmarshalledObject.NetworkOrigin = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("publicAccessBlock", targetDepth))
                {
                    var unmarshaller = S3PublicAccessBlockConfigurationUnmarshaller.Instance;
                    unmarshalledObject.PublicAccessBlock = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static S3AccessPointConfigurationUnmarshaller _instance = new S3AccessPointConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static S3AccessPointConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}