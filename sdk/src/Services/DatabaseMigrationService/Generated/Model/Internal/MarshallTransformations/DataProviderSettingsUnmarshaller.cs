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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DatabaseMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DataProviderSettings Object
    /// </summary>  
    public class DataProviderSettingsUnmarshaller : IUnmarshaller<DataProviderSettings, XmlUnmarshallerContext>, IUnmarshaller<DataProviderSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DataProviderSettings IUnmarshaller<DataProviderSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DataProviderSettings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DataProviderSettings unmarshalledObject = new DataProviderSettings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DocDbSettings", targetDepth))
                {
                    var unmarshaller = DocDbDataProviderSettingsUnmarshaller.Instance;
                    unmarshalledObject.DocDbSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MariaDbSettings", targetDepth))
                {
                    var unmarshaller = MariaDbDataProviderSettingsUnmarshaller.Instance;
                    unmarshalledObject.MariaDbSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MicrosoftSqlServerSettings", targetDepth))
                {
                    var unmarshaller = MicrosoftSqlServerDataProviderSettingsUnmarshaller.Instance;
                    unmarshalledObject.MicrosoftSqlServerSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MongoDbSettings", targetDepth))
                {
                    var unmarshaller = MongoDbDataProviderSettingsUnmarshaller.Instance;
                    unmarshalledObject.MongoDbSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MySqlSettings", targetDepth))
                {
                    var unmarshaller = MySqlDataProviderSettingsUnmarshaller.Instance;
                    unmarshalledObject.MySqlSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OracleSettings", targetDepth))
                {
                    var unmarshaller = OracleDataProviderSettingsUnmarshaller.Instance;
                    unmarshalledObject.OracleSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PostgreSqlSettings", targetDepth))
                {
                    var unmarshaller = PostgreSqlDataProviderSettingsUnmarshaller.Instance;
                    unmarshalledObject.PostgreSqlSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RedshiftSettings", targetDepth))
                {
                    var unmarshaller = RedshiftDataProviderSettingsUnmarshaller.Instance;
                    unmarshalledObject.RedshiftSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DataProviderSettingsUnmarshaller _instance = new DataProviderSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DataProviderSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}