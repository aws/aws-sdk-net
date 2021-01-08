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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DatabaseConfiguration Object
    /// </summary>  
    public class DatabaseConfigurationUnmarshaller : IUnmarshaller<DatabaseConfiguration, XmlUnmarshallerContext>, IUnmarshaller<DatabaseConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DatabaseConfiguration IUnmarshaller<DatabaseConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DatabaseConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DatabaseConfiguration unmarshalledObject = new DatabaseConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AclConfiguration", targetDepth))
                {
                    var unmarshaller = AclConfigurationUnmarshaller.Instance;
                    unmarshalledObject.AclConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ColumnConfiguration", targetDepth))
                {
                    var unmarshaller = ColumnConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ColumnConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConnectionConfiguration", targetDepth))
                {
                    var unmarshaller = ConnectionConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ConnectionConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DatabaseEngineType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DatabaseEngineType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SqlConfiguration", targetDepth))
                {
                    var unmarshaller = SqlConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SqlConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VpcConfiguration", targetDepth))
                {
                    var unmarshaller = DataSourceVpcConfigurationUnmarshaller.Instance;
                    unmarshalledObject.VpcConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DatabaseConfigurationUnmarshaller _instance = new DatabaseConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DatabaseConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}