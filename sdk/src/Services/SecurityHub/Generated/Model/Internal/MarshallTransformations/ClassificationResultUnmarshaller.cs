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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ClassificationResult Object
    /// </summary>  
    public class ClassificationResultUnmarshaller : IUnmarshaller<ClassificationResult, XmlUnmarshallerContext>, IUnmarshaller<ClassificationResult, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ClassificationResult IUnmarshaller<ClassificationResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ClassificationResult Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ClassificationResult unmarshalledObject = new ClassificationResult();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AdditionalOccurrences", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AdditionalOccurrences = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomDataIdentifiers", targetDepth))
                {
                    var unmarshaller = CustomDataIdentifiersResultUnmarshaller.Instance;
                    unmarshalledObject.CustomDataIdentifiers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MimeType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MimeType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SensitiveData", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SensitiveDataResult, SensitiveDataResultUnmarshaller>(SensitiveDataResultUnmarshaller.Instance);
                    unmarshalledObject.SensitiveData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SizeClassified", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.SizeClassified = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = ClassificationStatusUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ClassificationResultUnmarshaller _instance = new ClassificationResultUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ClassificationResultUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}