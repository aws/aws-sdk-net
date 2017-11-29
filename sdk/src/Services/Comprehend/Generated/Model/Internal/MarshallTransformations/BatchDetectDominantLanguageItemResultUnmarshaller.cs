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
    /// Response Unmarshaller for BatchDetectDominantLanguageItemResult Object
    /// </summary>  
    public class BatchDetectDominantLanguageItemResultUnmarshaller : IUnmarshaller<BatchDetectDominantLanguageItemResult, XmlUnmarshallerContext>, IUnmarshaller<BatchDetectDominantLanguageItemResult, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        BatchDetectDominantLanguageItemResult IUnmarshaller<BatchDetectDominantLanguageItemResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public BatchDetectDominantLanguageItemResult Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            BatchDetectDominantLanguageItemResult unmarshalledObject = new BatchDetectDominantLanguageItemResult();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Index", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Index = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Languages", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DominantLanguage, DominantLanguageUnmarshaller>(DominantLanguageUnmarshaller.Instance);
                    unmarshalledObject.Languages = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static BatchDetectDominantLanguageItemResultUnmarshaller _instance = new BatchDetectDominantLanguageItemResultUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchDetectDominantLanguageItemResultUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}