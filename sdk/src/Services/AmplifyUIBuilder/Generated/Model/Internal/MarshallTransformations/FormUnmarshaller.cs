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

namespace Amazon.AmplifyUIBuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Form Object
    /// </summary>  
    public class FormUnmarshaller : IUnmarshaller<Form, XmlUnmarshallerContext>, IUnmarshaller<Form, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Form IUnmarshaller<Form, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Form Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Form unmarshalledObject = new Form();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("appId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AppId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("cta", targetDepth))
                {
                    var unmarshaller = FormCTAUnmarshaller.Instance;
                    unmarshalledObject.Cta = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataType", targetDepth))
                {
                    var unmarshaller = FormDataTypeConfigUnmarshaller.Instance;
                    unmarshalledObject.DataType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("environmentName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EnvironmentName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fields", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, FieldConfig, StringUnmarshaller, FieldConfigUnmarshaller>(StringUnmarshaller.Instance, FieldConfigUnmarshaller.Instance);
                    unmarshalledObject.Fields = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("formActionType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FormActionType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("labelDecorator", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LabelDecorator = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("schemaVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SchemaVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sectionalElements", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, SectionalElement, StringUnmarshaller, SectionalElementUnmarshaller>(StringUnmarshaller.Instance, SectionalElementUnmarshaller.Instance);
                    unmarshalledObject.SectionalElements = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("style", targetDepth))
                {
                    var unmarshaller = FormStyleUnmarshaller.Instance;
                    unmarshalledObject.Style = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static FormUnmarshaller _instance = new FormUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FormUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}