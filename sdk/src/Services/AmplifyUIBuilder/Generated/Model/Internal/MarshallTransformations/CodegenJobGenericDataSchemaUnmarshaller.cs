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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AmplifyUIBuilder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.AmplifyUIBuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CodegenJobGenericDataSchema Object
    /// </summary>  
    public class CodegenJobGenericDataSchemaUnmarshaller : IUnmarshaller<CodegenJobGenericDataSchema, XmlUnmarshallerContext>, IUnmarshaller<CodegenJobGenericDataSchema, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CodegenJobGenericDataSchema IUnmarshaller<CodegenJobGenericDataSchema, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public CodegenJobGenericDataSchema Unmarshall(JsonUnmarshallerContext context)
        {
            CodegenJobGenericDataSchema unmarshalledObject = new CodegenJobGenericDataSchema();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("dataSourceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataSourceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("enums", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, CodegenGenericDataEnum, StringUnmarshaller, CodegenGenericDataEnumUnmarshaller>(StringUnmarshaller.Instance, CodegenGenericDataEnumUnmarshaller.Instance);
                    unmarshalledObject.Enums = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("models", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, CodegenGenericDataModel, StringUnmarshaller, CodegenGenericDataModelUnmarshaller>(StringUnmarshaller.Instance, CodegenGenericDataModelUnmarshaller.Instance);
                    unmarshalledObject.Models = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("nonModels", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, CodegenGenericDataNonModel, StringUnmarshaller, CodegenGenericDataNonModelUnmarshaller>(StringUnmarshaller.Instance, CodegenGenericDataNonModelUnmarshaller.Instance);
                    unmarshalledObject.NonModels = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CodegenJobGenericDataSchemaUnmarshaller _instance = new CodegenJobGenericDataSchemaUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CodegenJobGenericDataSchemaUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}