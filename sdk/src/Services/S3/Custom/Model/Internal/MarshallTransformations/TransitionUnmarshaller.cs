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

using Amazon.S3.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   Transition Unmarshaller
     /// </summary>
    internal class TransitionUnmarshaller : IUnmarshaller<LifecycleTransition, XmlUnmarshallerContext>, IUnmarshaller<LifecycleTransition, JsonUnmarshallerContext> 
    {
        public LifecycleTransition Unmarshall(XmlUnmarshallerContext context) 
        {
            LifecycleTransition transition = new LifecycleTransition();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Date", targetDepth))
                    {
                        transition.Date = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Days", targetDepth))
                    {
                        transition.Days = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("StorageClass", targetDepth))
                    {
                        transition.StorageClass = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return transition;
                }
            }
                        


            return transition;
        }

        public LifecycleTransition Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static TransitionUnmarshaller _instance;

        public static TransitionUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TransitionUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
    
