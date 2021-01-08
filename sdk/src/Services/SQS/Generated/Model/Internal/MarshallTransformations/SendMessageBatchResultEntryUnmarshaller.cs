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
    /// Response Unmarshaller for SendMessageBatchResultEntry Object
    /// </summary>  
    public class SendMessageBatchResultEntryUnmarshaller : IUnmarshaller<SendMessageBatchResultEntry, XmlUnmarshallerContext>, IUnmarshaller<SendMessageBatchResultEntry, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SendMessageBatchResultEntry Unmarshall(XmlUnmarshallerContext context)
        {
            SendMessageBatchResultEntry unmarshalledObject = new SendMessageBatchResultEntry();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Id", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MD5OfMessageAttributes", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MD5OfMessageAttributes = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MD5OfMessageBody", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MD5OfMessageBody = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MD5OfMessageSystemAttributes", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MD5OfMessageSystemAttributes = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MessageId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MessageId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SequenceNumber", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SequenceNumber = unmarshaller.Unmarshall(context);
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
        public SendMessageBatchResultEntry Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static SendMessageBatchResultEntryUnmarshaller _instance = new SendMessageBatchResultEntryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendMessageBatchResultEntryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}