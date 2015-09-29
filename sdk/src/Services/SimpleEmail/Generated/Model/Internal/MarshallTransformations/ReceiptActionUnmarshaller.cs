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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleEmail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.SimpleEmail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ReceiptAction Object
    /// </summary>  
    public class ReceiptActionUnmarshaller : IUnmarshaller<ReceiptAction, XmlUnmarshallerContext>, IUnmarshaller<ReceiptAction, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ReceiptAction Unmarshall(XmlUnmarshallerContext context)
        {
            ReceiptAction unmarshalledObject = new ReceiptAction();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AddHeaderAction", targetDepth))
                    {
                        var unmarshaller = AddHeaderActionUnmarshaller.Instance;
                        unmarshalledObject.AddHeaderAction = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("BounceAction", targetDepth))
                    {
                        var unmarshaller = BounceActionUnmarshaller.Instance;
                        unmarshalledObject.BounceAction = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LambdaAction", targetDepth))
                    {
                        var unmarshaller = LambdaActionUnmarshaller.Instance;
                        unmarshalledObject.LambdaAction = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("S3Action", targetDepth))
                    {
                        var unmarshaller = S3ActionUnmarshaller.Instance;
                        unmarshalledObject.S3Action = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SNSAction", targetDepth))
                    {
                        var unmarshaller = SNSActionUnmarshaller.Instance;
                        unmarshalledObject.SNSAction = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StopAction", targetDepth))
                    {
                        var unmarshaller = StopActionUnmarshaller.Instance;
                        unmarshalledObject.StopAction = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("WorkmailAction", targetDepth))
                    {
                        var unmarshaller = WorkmailActionUnmarshaller.Instance;
                        unmarshalledObject.WorkmailAction = unmarshaller.Unmarshall(context);
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
        public ReceiptAction Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static ReceiptActionUnmarshaller _instance = new ReceiptActionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReceiptActionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}