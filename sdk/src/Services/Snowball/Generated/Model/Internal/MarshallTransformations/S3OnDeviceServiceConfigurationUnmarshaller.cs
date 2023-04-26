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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Snowball.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Snowball.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for S3OnDeviceServiceConfiguration Object
    /// </summary>  
    public class S3OnDeviceServiceConfigurationUnmarshaller : IUnmarshaller<S3OnDeviceServiceConfiguration, XmlUnmarshallerContext>, IUnmarshaller<S3OnDeviceServiceConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        S3OnDeviceServiceConfiguration IUnmarshaller<S3OnDeviceServiceConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public S3OnDeviceServiceConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            S3OnDeviceServiceConfiguration unmarshalledObject = new S3OnDeviceServiceConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("FaultTolerance", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.FaultTolerance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceSize", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ServiceSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StorageLimit", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.StorageLimit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StorageUnit", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StorageUnit = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static S3OnDeviceServiceConfigurationUnmarshaller _instance = new S3OnDeviceServiceConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static S3OnDeviceServiceConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}