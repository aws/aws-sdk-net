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

#pragma warning disable CS0612,CS0618
namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SchemaResponse Object
    /// </summary>  
    public class SchemaResponseUnmarshaller : IUnmarshaller<SchemaResponse, XmlUnmarshallerContext>, IUnmarshaller<SchemaResponse, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SchemaResponse IUnmarshaller<SchemaResponse, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SchemaResponse Unmarshall(JsonUnmarshallerContext context)
        {
            SchemaResponse unmarshalledObject = new SchemaResponse();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CodeLineCount", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.CodeLineCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CodeSize", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.CodeSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Complexity", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Complexity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DatabaseInstance", targetDepth))
                {
                    var unmarshaller = DatabaseShortInfoResponseUnmarshaller.Instance;
                    unmarshalledObject.DatabaseInstance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OriginalSchema", targetDepth))
                {
                    var unmarshaller = SchemaShortInfoResponseUnmarshaller.Instance;
                    unmarshalledObject.OriginalSchema = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SchemaId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SchemaId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SchemaName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SchemaName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Server", targetDepth))
                {
                    var unmarshaller = ServerShortInfoResponseUnmarshaller.Instance;
                    unmarshalledObject.Server = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Similarity", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Similarity = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SchemaResponseUnmarshaller _instance = new SchemaResponseUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SchemaResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}