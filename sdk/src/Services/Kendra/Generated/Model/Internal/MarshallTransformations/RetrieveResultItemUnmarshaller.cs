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

#pragma warning disable CS0612,CS0618
namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RetrieveResultItem Object
    /// </summary>  
    public class RetrieveResultItemUnmarshaller : IUnmarshaller<RetrieveResultItem, XmlUnmarshallerContext>, IUnmarshaller<RetrieveResultItem, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RetrieveResultItem IUnmarshaller<RetrieveResultItem, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RetrieveResultItem Unmarshall(JsonUnmarshallerContext context)
        {
            RetrieveResultItem unmarshalledObject = new RetrieveResultItem();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Content", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Content = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DocumentAttributes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DocumentAttribute, DocumentAttributeUnmarshaller>(DocumentAttributeUnmarshaller.Instance);
                    unmarshalledObject.DocumentAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DocumentId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DocumentId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DocumentTitle", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DocumentTitle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DocumentURI", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DocumentURI = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScoreAttributes", targetDepth))
                {
                    var unmarshaller = ScoreAttributesUnmarshaller.Instance;
                    unmarshalledObject.ScoreAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RetrieveResultItemUnmarshaller _instance = new RetrieveResultItemUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RetrieveResultItemUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618