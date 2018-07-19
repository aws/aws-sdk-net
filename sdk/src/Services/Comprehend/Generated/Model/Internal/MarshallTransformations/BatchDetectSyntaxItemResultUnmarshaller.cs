/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Comprehend.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Comprehend.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BatchDetectSyntaxItemResult Object
    /// </summary>  
    public class BatchDetectSyntaxItemResultUnmarshaller : IUnmarshaller<BatchDetectSyntaxItemResult, XmlUnmarshallerContext>, IUnmarshaller<BatchDetectSyntaxItemResult, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        BatchDetectSyntaxItemResult IUnmarshaller<BatchDetectSyntaxItemResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public BatchDetectSyntaxItemResult Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            BatchDetectSyntaxItemResult unmarshalledObject = new BatchDetectSyntaxItemResult();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Index", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Index = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SyntaxTokens", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SyntaxToken, SyntaxTokenUnmarshaller>(SyntaxTokenUnmarshaller.Instance);
                    unmarshalledObject.SyntaxTokens = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static BatchDetectSyntaxItemResultUnmarshaller _instance = new BatchDetectSyntaxItemResultUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchDetectSyntaxItemResultUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}