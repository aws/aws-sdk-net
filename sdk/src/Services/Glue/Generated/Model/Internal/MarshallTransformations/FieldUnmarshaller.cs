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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Field Object
    /// </summary>  
    public class FieldUnmarshaller : IUnmarshaller<Field, XmlUnmarshallerContext>, IUnmarshaller<Field, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Field IUnmarshaller<Field, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Field Unmarshall(JsonUnmarshallerContext context)
        {
            Field unmarshalledObject = new Field();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CustomProperties", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.CustomProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FieldName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FieldName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FieldType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FieldType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IsCreateable", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsCreateable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IsDefaultOnCreate", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsDefaultOnCreate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IsFilterable", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsFilterable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IsNullable", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsNullable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IsPartitionable", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsPartitionable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IsPrimaryKey", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsPrimaryKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IsRetrievable", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsRetrievable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IsUpdateable", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsUpdateable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IsUpsertable", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsUpsertable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Label", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Label = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NativeDataType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NativeDataType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ParentField", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ParentField = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SupportedFilterOperators", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SupportedFilterOperators = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SupportedValues", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SupportedValues = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static FieldUnmarshaller _instance = new FieldUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FieldUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}