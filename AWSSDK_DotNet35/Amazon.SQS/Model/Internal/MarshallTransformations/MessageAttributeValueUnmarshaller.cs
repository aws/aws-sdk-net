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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SQS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.SQS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MessageAttributeValue Object
    /// </summary>  
    public class MessageAttributeValueUnmarshaller : IUnmarshaller<MessageAttributeValue, XmlUnmarshallerContext>, IUnmarshaller<MessageAttributeValue, JsonUnmarshallerContext>
    {
        public MessageAttributeValue Unmarshall(XmlUnmarshallerContext context)
        {
            MessageAttributeValue unmarshalledObject = new MessageAttributeValue();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("BinaryListValues/BinaryListValue", targetDepth))
                    {
                        var unmarshaller = MemoryStreamUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.BinaryListValues.Add(item);
                        continue;
                    }
                    if (context.TestExpression("BinaryValue", targetDepth))
                    {
                        var unmarshaller = MemoryStreamUnmarshaller.Instance;
                        unmarshalledObject.BinaryValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DataType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DataType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StringListValues/StringListValue", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.StringListValues.Add(item);
                        continue;
                    }
                    if (context.TestExpression("StringValue", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StringValue = unmarshaller.Unmarshall(context);
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

        public MessageAttributeValue Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static MessageAttributeValueUnmarshaller _instance = new MessageAttributeValueUnmarshaller();        

        public static MessageAttributeValueUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}