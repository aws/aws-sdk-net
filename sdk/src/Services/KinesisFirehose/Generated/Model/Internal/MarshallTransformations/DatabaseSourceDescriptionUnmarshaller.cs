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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisFirehose.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisFirehose.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DatabaseSourceDescription Object
    /// </summary>  
    public class DatabaseSourceDescriptionUnmarshaller : IUnmarshaller<DatabaseSourceDescription, XmlUnmarshallerContext>, IUnmarshaller<DatabaseSourceDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DatabaseSourceDescription IUnmarshaller<DatabaseSourceDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public DatabaseSourceDescription Unmarshall(JsonUnmarshallerContext context)
        {
            DatabaseSourceDescription unmarshalledObject = new DatabaseSourceDescription();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Columns", targetDepth))
                {
                    var unmarshaller = DatabaseColumnListUnmarshaller.Instance;
                    unmarshalledObject.Columns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Databases", targetDepth))
                {
                    var unmarshaller = DatabaseListUnmarshaller.Instance;
                    unmarshalledObject.Databases = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DatabaseSourceAuthenticationConfiguration", targetDepth))
                {
                    var unmarshaller = DatabaseSourceAuthenticationConfigurationUnmarshaller.Instance;
                    unmarshalledObject.DatabaseSourceAuthenticationConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DatabaseSourceVPCConfiguration", targetDepth))
                {
                    var unmarshaller = DatabaseSourceVPCConfigurationUnmarshaller.Instance;
                    unmarshalledObject.DatabaseSourceVPCConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Endpoint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Endpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Port", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Port = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SnapshotInfo", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DatabaseSnapshotInfo, DatabaseSnapshotInfoUnmarshaller>(DatabaseSnapshotInfoUnmarshaller.Instance);
                    unmarshalledObject.SnapshotInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SnapshotWatermarkTable", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SnapshotWatermarkTable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SSLMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SSLMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SurrogateKeys", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SurrogateKeys = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Tables", targetDepth))
                {
                    var unmarshaller = DatabaseTableListUnmarshaller.Instance;
                    unmarshalledObject.Tables = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DatabaseSourceDescriptionUnmarshaller _instance = new DatabaseSourceDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DatabaseSourceDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}