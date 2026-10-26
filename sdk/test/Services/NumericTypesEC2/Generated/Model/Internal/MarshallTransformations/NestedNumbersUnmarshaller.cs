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
 * Do not modify this file. This file is generated from the numerictypesec2-2026-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.NumericTypesEC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.NumericTypesEC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for NestedNumbers Object
    /// </summary>  
    public class NestedNumbersUnmarshaller : IXmlUnmarshaller<NestedNumbers, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public NestedNumbers Unmarshall(XmlUnmarshallerContext context)
        {
            NestedNumbers unmarshalledObject = new NestedNumbers();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("bigDecimalValue", targetDepth))
                    {
                        var unmarshaller = NullableBigDecimalUnmarshaller.Instance;
                        unmarshalledObject.BigDecimalValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("bigIntegerValue", targetDepth))
                    {
                        var unmarshaller = NullableBigIntegerUnmarshaller.Instance;
                        unmarshalledObject.BigIntegerValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("byteValue", targetDepth))
                    {
                        var unmarshaller = NullableSByteUnmarshaller.Instance;
                        unmarshalledObject.ByteValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("shortValue", targetDepth))
                    {
                        var unmarshaller = NullableShortUnmarshaller.Instance;
                        unmarshalledObject.ShortValue = unmarshaller.Unmarshall(context);
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

        private static NestedNumbersUnmarshaller _instance = new NestedNumbersUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NestedNumbersUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}