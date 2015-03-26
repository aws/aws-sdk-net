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
    ///   DeletedObject Unmarshaller
     /// </summary>
    internal class DeletedObjectUnmarshaller : IUnmarshaller<DeletedObject, XmlUnmarshallerContext>, IUnmarshaller<DeletedObject, JsonUnmarshallerContext> 
    {
        public DeletedObject Unmarshall(XmlUnmarshallerContext context) 
        {
            DeletedObject deletedItem = new DeletedObject();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("DeleteMarker", targetDepth))
                    {
                        deletedItem.DeleteMarker = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DeleteMarkerVersionId", targetDepth))
                    {
                        deletedItem.DeleteMarkerVersionId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Key", targetDepth))
                    {
                        deletedItem.Key = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("VersionId", targetDepth))
                    {
                        deletedItem.VersionId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return deletedItem;
                }
            }
                        


            return deletedItem;
        }

        public DeletedObject Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DeletedObjectUnmarshaller _instance;

        public static DeletedObjectUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DeletedObjectUnmarshaller();
                }
                return _instance;
            }
        }

    }
}
    
