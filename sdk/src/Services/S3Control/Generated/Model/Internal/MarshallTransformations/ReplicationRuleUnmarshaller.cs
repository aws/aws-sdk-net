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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3Control.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ReplicationRule Object
    /// </summary>  
    public class ReplicationRuleUnmarshaller : IUnmarshaller<ReplicationRule, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ReplicationRule Unmarshall(XmlUnmarshallerContext context)
        {
            ReplicationRule unmarshalledObject = new ReplicationRule();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Bucket", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Bucket = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DeleteMarkerReplication", targetDepth))
                    {
                        var unmarshaller = DeleteMarkerReplicationUnmarshaller.Instance;
                        unmarshalledObject.DeleteMarkerReplication = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Destination", targetDepth))
                    {
                        var unmarshaller = DestinationUnmarshaller.Instance;
                        unmarshalledObject.Destination = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ExistingObjectReplication", targetDepth))
                    {
                        var unmarshaller = ExistingObjectReplicationUnmarshaller.Instance;
                        unmarshalledObject.ExistingObjectReplication = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Filter", targetDepth))
                    {
                        var unmarshaller = ReplicationRuleFilterUnmarshaller.Instance;
                        unmarshalledObject.Filter = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ID", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ID = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Prefix", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Prefix = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Priority", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.Priority = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SourceSelectionCriteria", targetDepth))
                    {
                        var unmarshaller = SourceSelectionCriteriaUnmarshaller.Instance;
                        unmarshalledObject.SourceSelectionCriteria = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
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

        private static ReplicationRuleUnmarshaller _instance = new ReplicationRuleUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReplicationRuleUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}