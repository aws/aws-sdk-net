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

using Amazon.SimpleEmail.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SimpleEmail.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   SendDataPoint Unmarshaller
     /// </summary>
    internal class SendDataPointUnmarshaller : IUnmarshaller<SendDataPoint, XmlUnmarshallerContext>, IUnmarshaller<SendDataPoint, JsonUnmarshallerContext> 
    {
        public SendDataPoint Unmarshall(XmlUnmarshallerContext context) 
        {
            SendDataPoint sendDataPoint = new SendDataPoint();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Timestamp", targetDepth))
                    {
                        sendDataPoint.Timestamp = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DeliveryAttempts", targetDepth))
                    {
                        sendDataPoint.DeliveryAttempts = LongUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Bounces", targetDepth))
                    {
                        sendDataPoint.Bounces = LongUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Complaints", targetDepth))
                    {
                        sendDataPoint.Complaints = LongUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Rejects", targetDepth))
                    {
                        sendDataPoint.Rejects = LongUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return sendDataPoint;
                }
            }
                        


            return sendDataPoint;
        }

        public SendDataPoint Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static SendDataPointUnmarshaller instance;

        public static SendDataPointUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new SendDataPointUnmarshaller();

            return instance;
        }
    }
}
    
