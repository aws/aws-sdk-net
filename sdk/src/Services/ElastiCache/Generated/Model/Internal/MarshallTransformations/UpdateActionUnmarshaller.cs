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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for UpdateAction Object
    /// </summary>  
    public class UpdateActionUnmarshaller : IXmlUnmarshaller<UpdateAction, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public UpdateAction Unmarshall(XmlUnmarshallerContext context)
        {
            UpdateAction unmarshalledObject = new UpdateAction();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("CacheClusterId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CacheClusterId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CacheNodeUpdateStatus/CacheNodeUpdateStatus", targetDepth))
                    {
                        var unmarshaller = CacheNodeUpdateStatusUnmarshaller.Instance;
                        if (unmarshalledObject.CacheNodeUpdateStatus == null)
                        {
                            unmarshalledObject.CacheNodeUpdateStatus = new List<CacheNodeUpdateStatus>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.CacheNodeUpdateStatus.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Engine", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Engine = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EstimatedUpdateTime", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EstimatedUpdateTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NodeGroupUpdateStatus/NodeGroupUpdateStatus", targetDepth))
                    {
                        var unmarshaller = NodeGroupUpdateStatusUnmarshaller.Instance;
                        if (unmarshalledObject.NodeGroupUpdateStatus == null)
                        {
                            unmarshalledObject.NodeGroupUpdateStatus = new List<NodeGroupUpdateStatus>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.NodeGroupUpdateStatus.Add(item);
                        continue;
                    }
                    if (context.TestExpression("NodesUpdated", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NodesUpdated = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ReplicationGroupId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ReplicationGroupId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ServiceUpdateName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ServiceUpdateName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ServiceUpdateRecommendedApplyByDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.ServiceUpdateRecommendedApplyByDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ServiceUpdateReleaseDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.ServiceUpdateReleaseDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ServiceUpdateSeverity", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ServiceUpdateSeverity = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ServiceUpdateStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ServiceUpdateStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ServiceUpdateType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ServiceUpdateType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SlaMet", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SlaMet = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("UpdateActionAvailableDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.UpdateActionAvailableDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("UpdateActionStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.UpdateActionStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("UpdateActionStatusModifiedDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.UpdateActionStatusModifiedDate = unmarshaller.Unmarshall(context);
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

        private static UpdateActionUnmarshaller _instance = new UpdateActionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateActionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}