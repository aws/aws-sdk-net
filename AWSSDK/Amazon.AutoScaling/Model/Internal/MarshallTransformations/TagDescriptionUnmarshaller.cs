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

using Amazon.AutoScaling.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   TagDescription Unmarshaller
     /// </summary>
    internal class TagDescriptionUnmarshaller : IUnmarshaller<TagDescription, XmlUnmarshallerContext>, IUnmarshaller<TagDescription, JsonUnmarshallerContext> 
    {
        public TagDescription Unmarshall(XmlUnmarshallerContext context) 
        {
            TagDescription tagDescription = new TagDescription();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("ResourceId", targetDepth))
                    {
                        tagDescription.ResourceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ResourceType", targetDepth))
                    {
                        tagDescription.ResourceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Key", targetDepth))
                    {
                        tagDescription.Key = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Value", targetDepth))
                    {
                        tagDescription.Value = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("PropagateAtLaunch", targetDepth))
                    {
                        tagDescription.PropagateAtLaunch = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return tagDescription;
                }
            }
                        


            return tagDescription;
        }

        public TagDescription Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static TagDescriptionUnmarshaller instance;

        public static TagDescriptionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new TagDescriptionUnmarshaller();

            return instance;
        }
    }
}
    
