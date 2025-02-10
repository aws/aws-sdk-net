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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudSearch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudSearch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for IndexField Object
    /// </summary>  
    public class IndexFieldUnmarshaller : IXmlUnmarshaller<IndexField, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
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
                    if (context.TestExpression("DateArrayOptions", targetDepth))
                    {
                        var unmarshaller = DateArrayOptionsUnmarshaller.Instance;
                        unmarshalledObject.DateArrayOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DateOptions", targetDepth))
                    {
                        var unmarshaller = DateOptionsUnmarshaller.Instance;
                        unmarshalledObject.DateOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DoubleArrayOptions", targetDepth))
                    {
                        var unmarshaller = DoubleArrayOptionsUnmarshaller.Instance;
                        unmarshalledObject.DoubleArrayOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DoubleOptions", targetDepth))
                    {
                        var unmarshaller = DoubleOptionsUnmarshaller.Instance;
                        unmarshalledObject.DoubleOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
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
                    if (context.TestExpression("IntArrayOptions", targetDepth))
                    {
                        var unmarshaller = IntArrayOptionsUnmarshaller.Instance;
                        unmarshalledObject.IntArrayOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IntOptions", targetDepth))
                    {
                        var unmarshaller = IntOptionsUnmarshaller.Instance;
                        unmarshalledObject.IntOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LatLonOptions", targetDepth))
                    {
                        var unmarshaller = LatLonOptionsUnmarshaller.Instance;
                        unmarshalledObject.LatLonOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LiteralArrayOptions", targetDepth))
                    {
                        var unmarshaller = LiteralArrayOptionsUnmarshaller.Instance;
                        unmarshalledObject.LiteralArrayOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LiteralOptions", targetDepth))
                    {
                        var unmarshaller = LiteralOptionsUnmarshaller.Instance;
                        unmarshalledObject.LiteralOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TextArrayOptions", targetDepth))
                    {
                        var unmarshaller = TextArrayOptionsUnmarshaller.Instance;
                        unmarshalledObject.TextArrayOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TextOptions", targetDepth))
                    {
                        var unmarshaller = TextOptionsUnmarshaller.Instance;
                        unmarshalledObject.TextOptions = unmarshaller.Unmarshall(context);
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

        private static IndexFieldUnmarshaller _instance = new IndexFieldUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static IndexFieldUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}