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
 * Do not modify this file. This file is generated from the sdb-2009-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleDB.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.SimpleDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Item Object
    /// </summary>  
    public class ItemUnmarshaller : IUnmarshaller<Item, XmlUnmarshallerContext>, IUnmarshaller<Item, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Item Unmarshall(XmlUnmarshallerContext context)
        {
            Item unmarshalledObject = new Item();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AlternateNameEncoding", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AlternateNameEncoding = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Attribute", targetDepth))
                    {
                        var unmarshaller = AttributeUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Attributes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Name", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Name = unmarshaller.Unmarshall(context);
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

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Item Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static ItemUnmarshaller _instance = new ItemUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ItemUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}