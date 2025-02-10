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
    /// Response Unmarshaller for NodeGroupMemberUpdateStatus Object
    /// </summary>  
    public class NodeGroupMemberUpdateStatusUnmarshaller : IXmlUnmarshaller<NodeGroupMemberUpdateStatus, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public NodeGroupMemberUpdateStatus Unmarshall(XmlUnmarshallerContext context)
        {
            NodeGroupMemberUpdateStatus unmarshalledObject = new NodeGroupMemberUpdateStatus();
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
                    if (context.TestExpression("CacheNodeId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CacheNodeId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NodeDeletionDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.NodeDeletionDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NodeUpdateEndDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.NodeUpdateEndDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NodeUpdateInitiatedBy", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NodeUpdateInitiatedBy = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NodeUpdateInitiatedDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.NodeUpdateInitiatedDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NodeUpdateStartDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.NodeUpdateStartDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NodeUpdateStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NodeUpdateStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NodeUpdateStatusModifiedDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.NodeUpdateStatusModifiedDate = unmarshaller.Unmarshall(context);
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

        private static NodeGroupMemberUpdateStatusUnmarshaller _instance = new NodeGroupMemberUpdateStatusUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NodeGroupMemberUpdateStatusUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}