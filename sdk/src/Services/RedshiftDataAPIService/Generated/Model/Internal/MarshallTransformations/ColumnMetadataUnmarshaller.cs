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
 * Do not modify this file. This file is generated from the redshift-data-2019-12-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RedshiftDataAPIService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.RedshiftDataAPIService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ColumnMetadata Object
    /// </summary>  
    public class ColumnMetadataUnmarshaller : IJsonUnmarshaller<ColumnMetadata, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ColumnMetadata Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ColumnMetadata unmarshalledObject = new ColumnMetadata();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("columnDefault", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ColumnDefault = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("isCaseSensitive", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IsCaseSensitive = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("isCurrency", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IsCurrency = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("isSigned", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IsSigned = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("label", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Label = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("length", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Length = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("nullable", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Nullable = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("precision", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Precision = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("scale", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Scale = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("schemaName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SchemaName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tableName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TableName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("typeName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TypeName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ColumnMetadataUnmarshaller _instance = new ColumnMetadataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ColumnMetadataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}