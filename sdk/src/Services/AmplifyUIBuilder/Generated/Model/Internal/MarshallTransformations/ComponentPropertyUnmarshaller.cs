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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.AmplifyUIBuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ComponentProperty Object
    /// </summary>  
    public class ComponentPropertyUnmarshaller : IJsonUnmarshaller<ComponentProperty, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ComponentProperty Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ComponentProperty unmarshalledObject = new ComponentProperty();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("bindingProperties", targetDepth))
                {
                    var unmarshaller = ComponentPropertyBindingPropertiesUnmarshaller.Instance;
                    unmarshalledObject.BindingProperties = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("bindings", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, FormBindingElement, StringUnmarshaller, FormBindingElementUnmarshaller>(StringUnmarshaller.Instance, FormBindingElementUnmarshaller.Instance);
                    unmarshalledObject.Bindings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("collectionBindingProperties", targetDepth))
                {
                    var unmarshaller = ComponentPropertyBindingPropertiesUnmarshaller.Instance;
                    unmarshalledObject.CollectionBindingProperties = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("componentName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ComponentName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("concat", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ComponentProperty, ComponentPropertyUnmarshaller>(ComponentPropertyUnmarshaller.Instance);
                    unmarshalledObject.Concat = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("condition", targetDepth))
                {
                    var unmarshaller = ComponentConditionPropertyUnmarshaller.Instance;
                    unmarshalledObject.Condition = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("configured", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.Configured = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("defaultValue", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DefaultValue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("event", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Event = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("importedValue", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImportedValue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("model", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Model = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("property", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Property = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("userAttribute", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserAttribute = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("value", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Value = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ComponentPropertyUnmarshaller _instance = new ComponentPropertyUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ComponentPropertyUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}