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

#pragma warning disable CS0612,CS0618
namespace Amazon.CodePipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for StageDeclaration Object
    /// </summary>  
    public class StageDeclarationUnmarshaller : IUnmarshaller<StageDeclaration, XmlUnmarshallerContext>, IUnmarshaller<StageDeclaration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        StageDeclaration IUnmarshaller<StageDeclaration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public StageDeclaration Unmarshall(JsonUnmarshallerContext context)
        {
            StageDeclaration unmarshalledObject = new StageDeclaration();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("actions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ActionDeclaration, ActionDeclarationUnmarshaller>(ActionDeclarationUnmarshaller.Instance);
                    unmarshalledObject.Actions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("beforeEntry", targetDepth))
                {
                    var unmarshaller = BeforeEntryConditionsUnmarshaller.Instance;
                    unmarshalledObject.BeforeEntry = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("blockers", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<BlockerDeclaration, BlockerDeclarationUnmarshaller>(BlockerDeclarationUnmarshaller.Instance);
                    unmarshalledObject.Blockers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("onFailure", targetDepth))
                {
                    var unmarshaller = FailureConditionsUnmarshaller.Instance;
                    unmarshalledObject.OnFailure = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("onSuccess", targetDepth))
                {
                    var unmarshaller = SuccessConditionsUnmarshaller.Instance;
                    unmarshalledObject.OnSuccess = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static StageDeclarationUnmarshaller _instance = new StageDeclarationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StageDeclarationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}