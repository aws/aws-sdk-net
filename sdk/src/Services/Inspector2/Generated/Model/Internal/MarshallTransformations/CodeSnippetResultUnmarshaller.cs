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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Inspector2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CodeSnippetResult Object
    /// </summary>  
    public class CodeSnippetResultUnmarshaller : IUnmarshaller<CodeSnippetResult, XmlUnmarshallerContext>, IUnmarshaller<CodeSnippetResult, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CodeSnippetResult IUnmarshaller<CodeSnippetResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CodeSnippetResult Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            CodeSnippetResult unmarshalledObject = new CodeSnippetResult();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("codeSnippet", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<CodeLine, CodeLineUnmarshaller>(CodeLineUnmarshaller.Instance);
                    unmarshalledObject.CodeSnippet = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("endLine", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.EndLine = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("findingArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FindingArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("startLine", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.StartLine = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("suggestedFixes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SuggestedFix, SuggestedFixUnmarshaller>(SuggestedFixUnmarshaller.Instance);
                    unmarshalledObject.SuggestedFixes = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CodeSnippetResultUnmarshaller _instance = new CodeSnippetResultUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CodeSnippetResultUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}