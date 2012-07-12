/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
     ///   IdentityNotificationAttributes Unmarshaller
     /// </summary>
    internal class IdentityNotificationAttributesUnmarshaller : IUnmarshaller<IdentityNotificationAttributes, XmlUnmarshallerContext>, IUnmarshaller<IdentityNotificationAttributes, JsonUnmarshallerContext> 
    {
        public IdentityNotificationAttributes Unmarshall(XmlUnmarshallerContext context) 
        {
            IdentityNotificationAttributes identityNotificationAttributes = new IdentityNotificationAttributes();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("BounceTopic", targetDepth))
                    {
                        identityNotificationAttributes.BounceTopic = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ComplaintTopic", targetDepth))
                    {
                        identityNotificationAttributes.ComplaintTopic = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ForwardingEnabled", targetDepth))
                    {
                        identityNotificationAttributes.ForwardingEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return identityNotificationAttributes;
                }
            }
                        


            return identityNotificationAttributes;
        }

        public IdentityNotificationAttributes Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static IdentityNotificationAttributesUnmarshaller instance;

        public static IdentityNotificationAttributesUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new IdentityNotificationAttributesUnmarshaller();

            return instance;
        }
    }
}
    
