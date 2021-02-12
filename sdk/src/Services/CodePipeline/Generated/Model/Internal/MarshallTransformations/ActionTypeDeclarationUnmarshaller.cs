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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodePipeline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodePipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ActionTypeDeclaration Object
    /// </summary>  
    public class ActionTypeDeclarationUnmarshaller : IUnmarshaller<ActionTypeDeclaration, XmlUnmarshallerContext>, IUnmarshaller<ActionTypeDeclaration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ActionTypeDeclaration IUnmarshaller<ActionTypeDeclaration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ActionTypeDeclaration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ActionTypeDeclaration unmarshalledObject = new ActionTypeDeclaration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("executor", targetDepth))
                {
                    var unmarshaller = ActionTypeExecutorUnmarshaller.Instance;
                    unmarshalledObject.Executor = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = ActionTypeIdentifierUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inputArtifactDetails", targetDepth))
                {
                    var unmarshaller = ActionTypeArtifactDetailsUnmarshaller.Instance;
                    unmarshalledObject.InputArtifactDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("outputArtifactDetails", targetDepth))
                {
                    var unmarshaller = ActionTypeArtifactDetailsUnmarshaller.Instance;
                    unmarshalledObject.OutputArtifactDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("permissions", targetDepth))
                {
                    var unmarshaller = ActionTypePermissionsUnmarshaller.Instance;
                    unmarshalledObject.Permissions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("properties", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ActionTypeProperty, ActionTypePropertyUnmarshaller>(ActionTypePropertyUnmarshaller.Instance);
                    unmarshalledObject.Properties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("urls", targetDepth))
                {
                    var unmarshaller = ActionTypeUrlsUnmarshaller.Instance;
                    unmarshalledObject.Urls = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ActionTypeDeclarationUnmarshaller _instance = new ActionTypeDeclarationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ActionTypeDeclarationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}