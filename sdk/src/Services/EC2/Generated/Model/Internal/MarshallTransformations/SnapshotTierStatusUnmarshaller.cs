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

/*
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SnapshotTierStatus Object
    /// </summary>  
    public class SnapshotTierStatusUnmarshaller : IUnmarshaller<SnapshotTierStatus, XmlUnmarshallerContext>, IUnmarshaller<SnapshotTierStatus, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SnapshotTierStatus Unmarshall(XmlUnmarshallerContext context)
        {
            SnapshotTierStatus unmarshalledObject = new SnapshotTierStatus();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("archivalCompleteTime", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.ArchivalCompleteTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("lastTieringOperationStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LastTieringOperationStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("lastTieringOperationStatusDetail", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LastTieringOperationStatusDetail = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("lastTieringProgress", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.LastTieringProgress = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("lastTieringStartTime", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.LastTieringStartTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ownerId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OwnerId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("restoreExpiryTime", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.RestoreExpiryTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("snapshotId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SnapshotId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("storageTier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StorageTier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        if (unmarshalledObject.Tags == null)
                        {
                            unmarshalledObject.Tags = new List<Tag>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Tags.Add(item);
                        continue;
                    }
                    if (context.TestExpression("volumeId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VolumeId = unmarshaller.Unmarshall(context);
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

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SnapshotTierStatus Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static SnapshotTierStatusUnmarshaller _instance = new SnapshotTierStatusUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SnapshotTierStatusUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618