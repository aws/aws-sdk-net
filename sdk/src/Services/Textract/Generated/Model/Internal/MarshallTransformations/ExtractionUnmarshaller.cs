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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Textract.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Textract.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Extraction Object
    /// </summary>  
    public class ExtractionUnmarshaller : IUnmarshaller<Extraction, XmlUnmarshallerContext>, IUnmarshaller<Extraction, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Extraction IUnmarshaller<Extraction, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Extraction Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Extraction unmarshalledObject = new Extraction();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ExpenseDocument", targetDepth))
                {
                    var unmarshaller = ExpenseDocumentUnmarshaller.Instance;
                    unmarshalledObject.ExpenseDocument = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IdentityDocument", targetDepth))
                {
                    var unmarshaller = IdentityDocumentUnmarshaller.Instance;
                    unmarshalledObject.IdentityDocument = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LendingDocument", targetDepth))
                {
                    var unmarshaller = LendingDocumentUnmarshaller.Instance;
                    unmarshalledObject.LendingDocument = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ExtractionUnmarshaller _instance = new ExtractionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ExtractionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}