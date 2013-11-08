/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;

using Amazon.SQS.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SQS.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   Message Unmarshaller
     /// </summary>
    internal class MessageUnmarshaller : IUnmarshaller<Message, XmlUnmarshallerContext>, IUnmarshaller<Message, JsonUnmarshallerContext> 
    {
        public Message Unmarshall(XmlUnmarshallerContext context) 
        {
            Message message = new Message();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("MessageId", targetDepth))
                    {
                        message.MessageId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ReceiptHandle", targetDepth))
                    {
                        message.ReceiptHandle = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("MD5OfBody", targetDepth))
                    {
                        message.MD5OfBody = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Body", targetDepth))
                    {
                        message.Body = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Attribute", targetDepth))
                    {
                        KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller> unmarshaller = new KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.GetInstance(), StringUnmarshaller.GetInstance());
                        KeyValuePair<string, string> kvp = unmarshaller.Unmarshall(context);
                        message.Attributes.Add(kvp.Key, kvp.Value);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return message;
                }
            }
                        


            return message;
        }

        public Message Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static MessageUnmarshaller instance;

        public static MessageUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new MessageUnmarshaller();

            return instance;
        }
    }
}
    
