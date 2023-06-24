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
    /// Response Unmarshaller for ImportResourceSpecification Object
    /// </summary>  
    public class ImportResourceSpecificationUnmarshaller : IUnmarshaller<ImportResourceSpecification, XmlUnmarshallerContext>, IUnmarshaller<ImportResourceSpecification, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ImportResourceSpecification IUnmarshaller<ImportResourceSpecification, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ImportResourceSpecification Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ImportResourceSpecification unmarshalledObject = new ImportResourceSpecification();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("botImportSpecification", targetDepth))
                {
                    var unmarshaller = BotImportSpecificationUnmarshaller.Instance;
                    unmarshalledObject.BotImportSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("botLocaleImportSpecification", targetDepth))
                {
                    var unmarshaller = BotLocaleImportSpecificationUnmarshaller.Instance;
                    unmarshalledObject.BotLocaleImportSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("customVocabularyImportSpecification", targetDepth))
                {
                    var unmarshaller = CustomVocabularyImportSpecificationUnmarshaller.Instance;
                    unmarshalledObject.CustomVocabularyImportSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("testSetImportResourceSpecification", targetDepth))
                {
                    var unmarshaller = TestSetImportResourceSpecificationUnmarshaller.Instance;
                    unmarshalledObject.TestSetImportResourceSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ImportResourceSpecificationUnmarshaller _instance = new ImportResourceSpecificationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ImportResourceSpecificationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}