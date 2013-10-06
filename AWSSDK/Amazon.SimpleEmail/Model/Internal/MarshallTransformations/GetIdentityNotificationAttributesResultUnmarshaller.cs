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
     ///   GetIdentityNotificationAttributesResult Unmarshaller
     /// </summary>
    internal class GetIdentityNotificationAttributesResultUnmarshaller : IUnmarshaller<GetIdentityNotificationAttributesResult, XmlUnmarshallerContext>, IUnmarshaller<GetIdentityNotificationAttributesResult, JsonUnmarshallerContext> 
    {
        public GetIdentityNotificationAttributesResult Unmarshall(XmlUnmarshallerContext context) 
        {
            GetIdentityNotificationAttributesResult getIdentityNotificationAttributesResult = new GetIdentityNotificationAttributesResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("NotificationAttributes/entry", targetDepth))
                    {
                        KeyValueUnmarshaller<string, IdentityNotificationAttributes, StringUnmarshaller, IdentityNotificationAttributesUnmarshaller> unmarshaller = new KeyValueUnmarshaller<string, IdentityNotificationAttributes, StringUnmarshaller, IdentityNotificationAttributesUnmarshaller>(StringUnmarshaller.GetInstance(), IdentityNotificationAttributesUnmarshaller.GetInstance());
                        KeyValuePair<string, IdentityNotificationAttributes> kvp = unmarshaller.Unmarshall(context);
                        getIdentityNotificationAttributesResult.NotificationAttributes.Add(kvp.Key, kvp.Value);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return getIdentityNotificationAttributesResult;
                }
            }
                        


            return getIdentityNotificationAttributesResult;
        }

        public GetIdentityNotificationAttributesResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static GetIdentityNotificationAttributesResultUnmarshaller instance;

        public static GetIdentityNotificationAttributesResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new GetIdentityNotificationAttributesResultUnmarshaller();

            return instance;
        }
    }
}
    
