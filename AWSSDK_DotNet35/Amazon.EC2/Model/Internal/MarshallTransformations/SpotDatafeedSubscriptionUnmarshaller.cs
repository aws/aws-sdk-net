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

using Amazon.EC2.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   SpotDatafeedSubscription Unmarshaller
     /// </summary>
    internal class SpotDatafeedSubscriptionUnmarshaller : IUnmarshaller<SpotDatafeedSubscription, XmlUnmarshallerContext>, IUnmarshaller<SpotDatafeedSubscription, JsonUnmarshallerContext> 
    {
        public SpotDatafeedSubscription Unmarshall(XmlUnmarshallerContext context) 
        {
            SpotDatafeedSubscription spotDatafeedSubscription = new SpotDatafeedSubscription();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ownerId", targetDepth))
                    {
                        spotDatafeedSubscription.OwnerId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("bucket", targetDepth))
                    {
                        spotDatafeedSubscription.Bucket = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("prefix", targetDepth))
                    {
                        spotDatafeedSubscription.Prefix = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("state", targetDepth))
                    {
                        spotDatafeedSubscription.State = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("fault", targetDepth))
                    {
                        spotDatafeedSubscription.Fault = SpotInstanceStateFaultUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return spotDatafeedSubscription;
                }
            }
                        


            return spotDatafeedSubscription;
        }

        public SpotDatafeedSubscription Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static SpotDatafeedSubscriptionUnmarshaller instance;

        public static SpotDatafeedSubscriptionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new SpotDatafeedSubscriptionUnmarshaller();

            return instance;
        }
    }
}
    
