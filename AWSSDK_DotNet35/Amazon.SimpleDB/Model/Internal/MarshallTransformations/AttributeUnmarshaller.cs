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

using Amazon.SimpleDB.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SimpleDB.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   Attribute Unmarshaller
     /// </summary>
    internal class AttributeUnmarshaller : IUnmarshaller<Attribute, XmlUnmarshallerContext>, IUnmarshaller<Attribute, JsonUnmarshallerContext> 
    {
        public Attribute Unmarshall(XmlUnmarshallerContext context) 
        {
            Attribute attribute = new Attribute();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Name", targetDepth))
                    {
                        attribute.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Name/@encoding", targetDepth))
                    {
                        attribute.AlternateNameEncoding = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Value", targetDepth))
                    {
                        attribute.Value = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Value/@encoding", targetDepth))
                    {
                        attribute.AlternateValueEncoding = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return attribute;
                }
            }
                        


            return attribute;
        }

        public Attribute Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static AttributeUnmarshaller instance;

        public static AttributeUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new AttributeUnmarshaller();

            return instance;
        }
    }
}
    
