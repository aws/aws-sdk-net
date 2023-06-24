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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PostDialogCodeHookInvocationSpecification Object
    /// </summary>  
    public class PostDialogCodeHookInvocationSpecificationUnmarshaller : IUnmarshaller<PostDialogCodeHookInvocationSpecification, XmlUnmarshallerContext>, IUnmarshaller<PostDialogCodeHookInvocationSpecification, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PostDialogCodeHookInvocationSpecification IUnmarshaller<PostDialogCodeHookInvocationSpecification, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PostDialogCodeHookInvocationSpecification Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            PostDialogCodeHookInvocationSpecification unmarshalledObject = new PostDialogCodeHookInvocationSpecification();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("failureConditional", targetDepth))
                {
                    var unmarshaller = ConditionalSpecificationUnmarshaller.Instance;
                    unmarshalledObject.FailureConditional = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("failureNextStep", targetDepth))
                {
                    var unmarshaller = DialogStateUnmarshaller.Instance;
                    unmarshalledObject.FailureNextStep = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("failureResponse", targetDepth))
                {
                    var unmarshaller = ResponseSpecificationUnmarshaller.Instance;
                    unmarshalledObject.FailureResponse = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("successConditional", targetDepth))
                {
                    var unmarshaller = ConditionalSpecificationUnmarshaller.Instance;
                    unmarshalledObject.SuccessConditional = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("successNextStep", targetDepth))
                {
                    var unmarshaller = DialogStateUnmarshaller.Instance;
                    unmarshalledObject.SuccessNextStep = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("successResponse", targetDepth))
                {
                    var unmarshaller = ResponseSpecificationUnmarshaller.Instance;
                    unmarshalledObject.SuccessResponse = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timeoutConditional", targetDepth))
                {
                    var unmarshaller = ConditionalSpecificationUnmarshaller.Instance;
                    unmarshalledObject.TimeoutConditional = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timeoutNextStep", targetDepth))
                {
                    var unmarshaller = DialogStateUnmarshaller.Instance;
                    unmarshalledObject.TimeoutNextStep = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timeoutResponse", targetDepth))
                {
                    var unmarshaller = ResponseSpecificationUnmarshaller.Instance;
                    unmarshalledObject.TimeoutResponse = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static PostDialogCodeHookInvocationSpecificationUnmarshaller _instance = new PostDialogCodeHookInvocationSpecificationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PostDialogCodeHookInvocationSpecificationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}