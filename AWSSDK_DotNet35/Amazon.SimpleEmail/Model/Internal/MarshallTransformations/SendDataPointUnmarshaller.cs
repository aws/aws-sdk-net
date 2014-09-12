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
    /// Response Unmarshaller for SendDataPoint Object
    /// </summary>  
    public class SendDataPointUnmarshaller : IUnmarshaller<SendDataPoint, XmlUnmarshallerContext>, IUnmarshaller<SendDataPoint, JsonUnmarshallerContext>
    {
        public SendDataPoint Unmarshall(XmlUnmarshallerContext context)
        {
            SendDataPoint unmarshalledObject = new SendDataPoint();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Bounces", targetDepth))
                    {
                        var unmarshaller = LongUnmarshaller.Instance;
                        unmarshalledObject.Bounces = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Complaints", targetDepth))
                    {
                        var unmarshaller = LongUnmarshaller.Instance;
                        unmarshalledObject.Complaints = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DeliveryAttempts", targetDepth))
                    {
                        var unmarshaller = LongUnmarshaller.Instance;
                        unmarshalledObject.DeliveryAttempts = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Rejects", targetDepth))
                    {
                        var unmarshaller = LongUnmarshaller.Instance;
                        unmarshalledObject.Rejects = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Timestamp", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.Timestamp = unmarshaller.Unmarshall(context);
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

        public SendDataPoint Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static SendDataPointUnmarshaller _instance = new SendDataPointUnmarshaller();        

        public static SendDataPointUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}