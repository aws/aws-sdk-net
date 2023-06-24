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
    /// Response Unmarshaller for ActionParameters Object
    /// </summary>  
    public class ActionParametersUnmarshaller : IUnmarshaller<ActionParameters, XmlUnmarshallerContext>, IUnmarshaller<ActionParameters, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ActionParameters IUnmarshaller<ActionParameters, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ActionParameters Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ActionParameters unmarshalledObject = new ActionParameters();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("anchor", targetDepth))
                {
                    var unmarshaller = ComponentPropertyUnmarshaller.Instance;
                    unmarshalledObject.Anchor = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fields", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, ComponentProperty, StringUnmarshaller, ComponentPropertyUnmarshaller>(StringUnmarshaller.Instance, ComponentPropertyUnmarshaller.Instance);
                    unmarshalledObject.Fields = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("global", targetDepth))
                {
                    var unmarshaller = ComponentPropertyUnmarshaller.Instance;
                    unmarshalledObject.Global = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = ComponentPropertyUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("model", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Model = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("state", targetDepth))
                {
                    var unmarshaller = MutationActionSetStateParameterUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("target", targetDepth))
                {
                    var unmarshaller = ComponentPropertyUnmarshaller.Instance;
                    unmarshalledObject.Target = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("type", targetDepth))
                {
                    var unmarshaller = ComponentPropertyUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("url", targetDepth))
                {
                    var unmarshaller = ComponentPropertyUnmarshaller.Instance;
                    unmarshalledObject.Url = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ActionParametersUnmarshaller _instance = new ActionParametersUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ActionParametersUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}