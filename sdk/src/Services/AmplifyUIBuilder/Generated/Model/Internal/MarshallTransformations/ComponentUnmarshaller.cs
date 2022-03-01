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
    /// Response Unmarshaller for Component Object
    /// </summary>  
    public class ComponentUnmarshaller : IUnmarshaller<Component, XmlUnmarshallerContext>, IUnmarshaller<Component, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Component IUnmarshaller<Component, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Component Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Component unmarshalledObject = new Component();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("appId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AppId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("bindingProperties", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, ComponentBindingPropertiesValue, StringUnmarshaller, ComponentBindingPropertiesValueUnmarshaller>(StringUnmarshaller.Instance, ComponentBindingPropertiesValueUnmarshaller.Instance);
                    unmarshalledObject.BindingProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("children", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ComponentChild, ComponentChildUnmarshaller>(ComponentChildUnmarshaller.Instance);
                    unmarshalledObject.Children = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("collectionProperties", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, ComponentDataConfiguration, StringUnmarshaller, ComponentDataConfigurationUnmarshaller>(StringUnmarshaller.Instance, ComponentDataConfigurationUnmarshaller.Instance);
                    unmarshalledObject.CollectionProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("componentType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ComponentType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("environmentName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EnvironmentName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("events", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, ComponentEvent, StringUnmarshaller, ComponentEventUnmarshaller>(StringUnmarshaller.Instance, ComponentEventUnmarshaller.Instance);
                    unmarshalledObject.Events = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("modifiedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ModifiedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("overrides", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, Dictionary<string, string>, StringUnmarshaller, DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>>(StringUnmarshaller.Instance, new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance));
                    unmarshalledObject.Overrides = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("properties", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, ComponentProperty, StringUnmarshaller, ComponentPropertyUnmarshaller>(StringUnmarshaller.Instance, ComponentPropertyUnmarshaller.Instance);
                    unmarshalledObject.Properties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("schemaVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SchemaVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("variants", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ComponentVariant, ComponentVariantUnmarshaller>(ComponentVariantUnmarshaller.Instance);
                    unmarshalledObject.Variants = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ComponentUnmarshaller _instance = new ComponentUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ComponentUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}