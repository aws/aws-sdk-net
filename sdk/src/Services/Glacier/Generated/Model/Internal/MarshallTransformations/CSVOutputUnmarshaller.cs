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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glacier.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glacier.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CSVOutput Object
    /// </summary>  
    public class CSVOutputUnmarshaller : IUnmarshaller<CSVOutput, XmlUnmarshallerContext>, IUnmarshaller<CSVOutput, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CSVOutput IUnmarshaller<CSVOutput, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CSVOutput Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            CSVOutput unmarshalledObject = new CSVOutput();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("FieldDelimiter", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FieldDelimiter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QuoteCharacter", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QuoteCharacter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QuoteEscapeCharacter", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QuoteEscapeCharacter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QuoteFields", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QuoteFields = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecordDelimiter", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RecordDelimiter = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CSVOutputUnmarshaller _instance = new CSVOutputUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CSVOutputUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}