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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RedshiftPropertiesOutput Object
    /// </summary>  
    public class RedshiftPropertiesOutputUnmarshaller : IJsonUnmarshaller<RedshiftPropertiesOutput, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public RedshiftPropertiesOutput Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            RedshiftPropertiesOutput unmarshalledObject = new RedshiftPropertiesOutput();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("credentials", targetDepth))
                {
                    var unmarshaller = RedshiftCredentialsUnmarshaller.Instance;
                    unmarshalledObject.Credentials = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("databaseName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DatabaseName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("isProvisionedSecret", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IsProvisionedSecret = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("jdbcIamUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JdbcIamUrl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("jdbcUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JdbcUrl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lineageSync", targetDepth))
                {
                    var unmarshaller = RedshiftLineageSyncConfigurationOutputUnmarshaller.Instance;
                    unmarshalledObject.LineageSync = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("redshiftTempDir", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RedshiftTempDir = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("storage", targetDepth))
                {
                    var unmarshaller = RedshiftStoragePropertiesUnmarshaller.Instance;
                    unmarshalledObject.Storage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RedshiftPropertiesOutputUnmarshaller _instance = new RedshiftPropertiesOutputUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RedshiftPropertiesOutputUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}