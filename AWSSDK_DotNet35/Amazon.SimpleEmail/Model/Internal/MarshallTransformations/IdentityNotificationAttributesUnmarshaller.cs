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
    /// Response Unmarshaller for IdentityNotificationAttributes Object
    /// </summary>  
    public class IdentityNotificationAttributesUnmarshaller : IUnmarshaller<IdentityNotificationAttributes, XmlUnmarshallerContext>, IUnmarshaller<IdentityNotificationAttributes, JsonUnmarshallerContext>
    {
        public IdentityNotificationAttributes Unmarshall(XmlUnmarshallerContext context)
        {
            IdentityNotificationAttributes unmarshalledObject = new IdentityNotificationAttributes();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("BounceTopic", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.BounceTopic = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ComplaintTopic", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ComplaintTopic = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DeliveryTopic", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DeliveryTopic = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ForwardingEnabled", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.ForwardingEnabled = unmarshaller.Unmarshall(context);
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

        public IdentityNotificationAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static IdentityNotificationAttributesUnmarshaller _instance = new IdentityNotificationAttributesUnmarshaller();        

        public static IdentityNotificationAttributesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}