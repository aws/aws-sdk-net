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
     ///   ContentsItem Unmarshaller
     /// </summary>
    internal class ContentsItemUnmarshaller : IUnmarshaller<S3Object, XmlUnmarshallerContext>, IUnmarshaller<S3Object, JsonUnmarshallerContext> 
    {
        public S3Object Unmarshall(XmlUnmarshallerContext context) 
        {
            S3Object contentsItem = new S3Object();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ETag", targetDepth))
                    {
                        contentsItem.ETag = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Key", targetDepth))
                    {
                        contentsItem.Key = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("LastModified", targetDepth))
                    {
                        contentsItem.LastModified = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Owner", targetDepth))
                    {
                        contentsItem.Owner = OwnerUnmarshaller.Instance.Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Size", targetDepth))
                    {
                        contentsItem.Size = LongUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("StorageClass", targetDepth))
                    {
                        contentsItem.StorageClass = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return contentsItem;
                }
            }
                        


            return contentsItem;
        }

        public S3Object Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ContentsItemUnmarshaller _instance;

        public static ContentsItemUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ContentsItemUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
    
