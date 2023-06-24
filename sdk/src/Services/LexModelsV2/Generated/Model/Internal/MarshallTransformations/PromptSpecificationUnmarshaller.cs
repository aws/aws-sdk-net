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
    /// Response Unmarshaller for PromptSpecification Object
    /// </summary>  
    public class PromptSpecificationUnmarshaller : IUnmarshaller<PromptSpecification, XmlUnmarshallerContext>, IUnmarshaller<PromptSpecification, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PromptSpecification IUnmarshaller<PromptSpecification, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PromptSpecification Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            PromptSpecification unmarshalledObject = new PromptSpecification();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("allowInterrupt", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AllowInterrupt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maxRetries", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxRetries = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("messageGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MessageGroup, MessageGroupUnmarshaller>(MessageGroupUnmarshaller.Instance);
                    unmarshalledObject.MessageGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("messageSelectionStrategy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MessageSelectionStrategy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("promptAttemptsSpecification", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, PromptAttemptSpecification, StringUnmarshaller, PromptAttemptSpecificationUnmarshaller>(StringUnmarshaller.Instance, PromptAttemptSpecificationUnmarshaller.Instance);
                    unmarshalledObject.PromptAttemptsSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static PromptSpecificationUnmarshaller _instance = new PromptSpecificationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PromptSpecificationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}