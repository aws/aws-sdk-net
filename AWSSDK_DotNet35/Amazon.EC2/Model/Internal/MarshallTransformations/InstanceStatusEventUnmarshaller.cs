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
     ///   InstanceStatusEvent Unmarshaller
     /// </summary>
    internal class InstanceStatusEventUnmarshaller : IUnmarshaller<InstanceStatusEvent, XmlUnmarshallerContext>, IUnmarshaller<InstanceStatusEvent, JsonUnmarshallerContext> 
    {
        public InstanceStatusEvent Unmarshall(XmlUnmarshallerContext context) 
        {
            InstanceStatusEvent instanceStatusEvent = new InstanceStatusEvent();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("code", targetDepth))
                    {
                        instanceStatusEvent.Code = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("description", targetDepth))
                    {
                        instanceStatusEvent.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("notBefore", targetDepth))
                    {
                        instanceStatusEvent.NotBefore = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("notAfter", targetDepth))
                    {
                        instanceStatusEvent.NotAfter = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return instanceStatusEvent;
                }
            }
                        


            return instanceStatusEvent;
        }

        public InstanceStatusEvent Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static InstanceStatusEventUnmarshaller instance;

        public static InstanceStatusEventUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new InstanceStatusEventUnmarshaller();

            return instance;
        }
    }
}
    
