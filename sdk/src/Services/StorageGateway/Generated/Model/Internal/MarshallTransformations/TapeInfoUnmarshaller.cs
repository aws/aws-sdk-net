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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.StorageGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TapeInfo Object
    /// </summary>  
    public class TapeInfoUnmarshaller : IUnmarshaller<TapeInfo, XmlUnmarshallerContext>, IUnmarshaller<TapeInfo, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TapeInfo IUnmarshaller<TapeInfo, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TapeInfo Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            TapeInfo unmarshalledObject = new TapeInfo();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("GatewayARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GatewayARN = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PoolEntryDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.PoolEntryDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PoolId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PoolId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RetentionStartDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.RetentionStartDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TapeARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TapeARN = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TapeBarcode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TapeBarcode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TapeSizeInBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.TapeSizeInBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TapeStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TapeStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static TapeInfoUnmarshaller _instance = new TapeInfoUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TapeInfoUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}