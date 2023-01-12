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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CleanRooms.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CleanRooms.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ProtectedQueryResult Object
    /// </summary>  
    public class ProtectedQueryResultUnmarshaller : IUnmarshaller<ProtectedQueryResult, XmlUnmarshallerContext>, IUnmarshaller<ProtectedQueryResult, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ProtectedQueryResult IUnmarshaller<ProtectedQueryResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ProtectedQueryResult Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ProtectedQueryResult unmarshalledObject = new ProtectedQueryResult();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("output", targetDepth))
                {
                    var unmarshaller = ProtectedQueryOutputUnmarshaller.Instance;
                    unmarshalledObject.Output = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ProtectedQueryResultUnmarshaller _instance = new ProtectedQueryResultUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ProtectedQueryResultUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}