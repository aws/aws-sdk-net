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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectCases.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ConnectCases.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RelatedItemContent Object
    /// </summary>  
    public class RelatedItemContentUnmarshaller : IUnmarshaller<RelatedItemContent, XmlUnmarshallerContext>, IUnmarshaller<RelatedItemContent, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RelatedItemContent IUnmarshaller<RelatedItemContent, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RelatedItemContent Unmarshall(JsonUnmarshallerContext context)
        {
            RelatedItemContent unmarshalledObject = new RelatedItemContent();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("comment", targetDepth))
                {
                    var unmarshaller = CommentContentUnmarshaller.Instance;
                    unmarshalledObject.Comment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("contact", targetDepth))
                {
                    var unmarshaller = ContactContentUnmarshaller.Instance;
                    unmarshalledObject.Contact = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("file", targetDepth))
                {
                    var unmarshaller = FileContentUnmarshaller.Instance;
                    unmarshalledObject.File = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sla", targetDepth))
                {
                    var unmarshaller = SlaContentUnmarshaller.Instance;
                    unmarshalledObject.Sla = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RelatedItemContentUnmarshaller _instance = new RelatedItemContentUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RelatedItemContentUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}