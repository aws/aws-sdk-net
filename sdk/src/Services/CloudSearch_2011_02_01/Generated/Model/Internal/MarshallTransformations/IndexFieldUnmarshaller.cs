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
 * Do not modify this file. This file is generated from the cloudsearch-2011-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudSearch_2011_02_01.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.CloudSearch_2011_02_01.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for IndexField Object
    /// </summary>  
    public class IndexFieldUnmarshaller : IUnmarshaller<IndexField, XmlUnmarshallerContext>, IUnmarshaller<IndexField, JsonUnmarshallerContext>
    {
        public IndexField Unmarshall(XmlUnmarshallerContext context)
        {
            IndexField unmarshalledObject = new IndexField();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("IndexFieldName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IndexFieldName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IndexFieldType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IndexFieldType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LiteralOptions", targetDepth))
                    {
                        var unmarshaller = LiteralOptionsUnmarshaller.Instance;
                        unmarshalledObject.LiteralOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SourceAttributes/member", targetDepth))
                    {
                        var unmarshaller = SourceAttributeUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.SourceAttributes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("TextOptions", targetDepth))
                    {
                        var unmarshaller = TextOptionsUnmarshaller.Instance;
                        unmarshalledObject.TextOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("UIntOptions", targetDepth))
                    {
                        var unmarshaller = UIntOptionsUnmarshaller.Instance;
                        unmarshalledObject.UIntOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        public IndexField Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static IndexFieldUnmarshaller _instance = new IndexFieldUnmarshaller();        

        public static IndexFieldUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}