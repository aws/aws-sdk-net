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
     ///   AccountAttributeValue Unmarshaller
     /// </summary>
    internal class AccountAttributeValueUnmarshaller : IUnmarshaller<AccountAttributeValue, XmlUnmarshallerContext>, IUnmarshaller<AccountAttributeValue, JsonUnmarshallerContext> 
    {
        public AccountAttributeValue Unmarshall(XmlUnmarshallerContext context) 
        {
            AccountAttributeValue accountAttributeValue = new AccountAttributeValue();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("attributeValue", targetDepth))
                    {
                        accountAttributeValue.AttributeValue = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return accountAttributeValue;
                }
            }
                        


            return accountAttributeValue;
        }

        public AccountAttributeValue Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static AccountAttributeValueUnmarshaller instance;

        public static AccountAttributeValueUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new AccountAttributeValueUnmarshaller();

            return instance;
        }
    }
}
    
