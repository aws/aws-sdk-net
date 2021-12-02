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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DocumentAttributeTarget Object
    /// </summary>  
    public class DocumentAttributeTargetUnmarshaller : IUnmarshaller<DocumentAttributeTarget, XmlUnmarshallerContext>, IUnmarshaller<DocumentAttributeTarget, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DocumentAttributeTarget IUnmarshaller<DocumentAttributeTarget, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DocumentAttributeTarget Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DocumentAttributeTarget unmarshalledObject = new DocumentAttributeTarget();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("TargetDocumentAttributeKey", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TargetDocumentAttributeKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetDocumentAttributeValue", targetDepth))
                {
                    var unmarshaller = DocumentAttributeValueUnmarshaller.Instance;
                    unmarshalledObject.TargetDocumentAttributeValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetDocumentAttributeValueDeletion", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.TargetDocumentAttributeValueDeletion = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DocumentAttributeTargetUnmarshaller _instance = new DocumentAttributeTargetUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DocumentAttributeTargetUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}