/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
     ///   Tag Unmarshaller
     /// </summary>
    public class TagUnmarshaller : IUnmarshaller<Tag, XmlUnmarshallerContext>, IUnmarshaller<Tag, JsonUnmarshallerContext> 
    {
        public Tag Unmarshall(XmlUnmarshallerContext context) 
        {
            Tag tag = new Tag();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Key", targetDepth))
                    {
                        tag.Key = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Value", targetDepth))
                    {
                        tag.Value = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return tag;
                }
            }
                        


            return tag;
        }

        public Tag Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static TagUnmarshaller _instance;

        public static TagUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TagUnmarshaller();
                }
                return _instance;
            }
        }

    }
}
    
