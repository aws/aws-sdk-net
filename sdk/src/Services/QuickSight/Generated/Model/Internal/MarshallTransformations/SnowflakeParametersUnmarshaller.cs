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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SnowflakeParameters Object
    /// </summary>  
    public class SnowflakeParametersUnmarshaller : IUnmarshaller<SnowflakeParameters, XmlUnmarshallerContext>, IUnmarshaller<SnowflakeParameters, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SnowflakeParameters IUnmarshaller<SnowflakeParameters, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SnowflakeParameters Unmarshall(JsonUnmarshallerContext context)
        {
            SnowflakeParameters unmarshalledObject = new SnowflakeParameters();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AuthenticationType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AuthenticationType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Database", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Database = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DatabaseAccessControlRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DatabaseAccessControlRole = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Host", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Host = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OAuthParameters", targetDepth))
                {
                    var unmarshaller = OAuthParametersUnmarshaller.Instance;
                    unmarshalledObject.OAuthParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Warehouse", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Warehouse = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SnowflakeParametersUnmarshaller _instance = new SnowflakeParametersUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SnowflakeParametersUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}