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
     ///   Snapshot Unmarshaller
     /// </summary>
    internal class SnapshotUnmarshaller : IUnmarshaller<Snapshot, XmlUnmarshallerContext>, IUnmarshaller<Snapshot, JsonUnmarshallerContext> 
    {
        public Snapshot Unmarshall(XmlUnmarshallerContext context) 
        {
            Snapshot snapshot = new Snapshot();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("snapshotId", targetDepth))
                    {
                        snapshot.SnapshotId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("volumeId", targetDepth))
                    {
                        snapshot.VolumeId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("status", targetDepth))
                    {
                        snapshot.State = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("startTime", targetDepth))
                    {
                        snapshot.StartTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("progress", targetDepth))
                    {
                        snapshot.Progress = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ownerId", targetDepth))
                    {
                        snapshot.OwnerId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("description", targetDepth))
                    {
                        snapshot.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("volumeSize", targetDepth))
                    {
                        snapshot.VolumeSize = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ownerAlias", targetDepth))
                    {
                        snapshot.OwnerAlias = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        snapshot.Tags.Add(TagUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return snapshot;
                }
            }
                        


            return snapshot;
        }

        public Snapshot Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static SnapshotUnmarshaller instance;

        public static SnapshotUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new SnapshotUnmarshaller();

            return instance;
        }
    }
}
    
