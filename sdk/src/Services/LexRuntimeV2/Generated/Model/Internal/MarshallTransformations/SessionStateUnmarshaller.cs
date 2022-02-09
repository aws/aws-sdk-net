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
 * Do not modify this file. This file is generated from the runtime.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexRuntimeV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LexRuntimeV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SessionState Object
    /// </summary>  
    public class SessionStateUnmarshaller : IUnmarshaller<SessionState, XmlUnmarshallerContext>, IUnmarshaller<SessionState, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SessionState IUnmarshaller<SessionState, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SessionState Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SessionState unmarshalledObject = new SessionState();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("activeContexts", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ActiveContext, ActiveContextUnmarshaller>(ActiveContextUnmarshaller.Instance);
                    unmarshalledObject.ActiveContexts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dialogAction", targetDepth))
                {
                    var unmarshaller = DialogActionUnmarshaller.Instance;
                    unmarshalledObject.DialogAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("intent", targetDepth))
                {
                    var unmarshaller = IntentUnmarshaller.Instance;
                    unmarshalledObject.Intent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("originatingRequestId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OriginatingRequestId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("runtimeHints", targetDepth))
                {
                    var unmarshaller = RuntimeHintsUnmarshaller.Instance;
                    unmarshalledObject.RuntimeHints = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sessionAttributes", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.SessionAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SessionStateUnmarshaller _instance = new SessionStateUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SessionStateUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}