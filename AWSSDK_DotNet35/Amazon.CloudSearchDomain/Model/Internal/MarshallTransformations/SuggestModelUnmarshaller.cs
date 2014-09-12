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
 * Do not modify this file. This file is generated from the cloudsearchdomain-2013-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudSearchDomain.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudSearchDomain.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SuggestModel Object
    /// </summary>  
    public class SuggestModelUnmarshaller : IUnmarshaller<SuggestModel, XmlUnmarshallerContext>, IUnmarshaller<SuggestModel, JsonUnmarshallerContext>
    {
        SuggestModel IUnmarshaller<SuggestModel, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public SuggestModel Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SuggestModel unmarshalledObject = new SuggestModel();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("found", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Found = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("query", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Query = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("suggestions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SuggestionMatch, SuggestionMatchUnmarshaller>(SuggestionMatchUnmarshaller.Instance);
                    unmarshalledObject.Suggestions = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SuggestModelUnmarshaller _instance = new SuggestModelUnmarshaller();        

        public static SuggestModelUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}