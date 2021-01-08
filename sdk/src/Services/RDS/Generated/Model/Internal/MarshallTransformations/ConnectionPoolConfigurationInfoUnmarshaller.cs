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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConnectionPoolConfigurationInfo Object
    /// </summary>  
    public class ConnectionPoolConfigurationInfoUnmarshaller : IUnmarshaller<ConnectionPoolConfigurationInfo, XmlUnmarshallerContext>, IUnmarshaller<ConnectionPoolConfigurationInfo, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ConnectionPoolConfigurationInfo Unmarshall(XmlUnmarshallerContext context)
        {
            ConnectionPoolConfigurationInfo unmarshalledObject = new ConnectionPoolConfigurationInfo();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ConnectionBorrowTimeout", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.ConnectionBorrowTimeout = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("InitQuery", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InitQuery = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaxConnectionsPercent", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.MaxConnectionsPercent = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaxIdleConnectionsPercent", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.MaxIdleConnectionsPercent = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SessionPinningFilters/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.SessionPinningFilters.Add(item);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ConnectionPoolConfigurationInfo Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static ConnectionPoolConfigurationInfoUnmarshaller _instance = new ConnectionPoolConfigurationInfoUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConnectionPoolConfigurationInfoUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}