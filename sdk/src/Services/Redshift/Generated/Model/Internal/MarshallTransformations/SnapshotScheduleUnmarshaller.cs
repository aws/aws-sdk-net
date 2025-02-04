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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SnapshotSchedule Object
    /// </summary>  
    public class SnapshotScheduleUnmarshaller : IXmlUnmarshaller<SnapshotSchedule, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SnapshotSchedule Unmarshall(XmlUnmarshallerContext context)
        {
            SnapshotSchedule unmarshalledObject = new SnapshotSchedule();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AssociatedClusterCount", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.AssociatedClusterCount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AssociatedClusters/ClusterAssociatedToSchedule", targetDepth))
                    {
                        var unmarshaller = ClusterAssociatedToScheduleUnmarshaller.Instance;
                        if (unmarshalledObject.AssociatedClusters == null)
                        {
                            unmarshalledObject.AssociatedClusters = new List<ClusterAssociatedToSchedule>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.AssociatedClusters.Add(item);
                        continue;
                    }
                    if (context.TestExpression("NextInvocations/SnapshotTime", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        if (unmarshalledObject.NextInvocations == null)
                        {
                            unmarshalledObject.NextInvocations = new List<DateTime>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.NextInvocations.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ScheduleDefinitions/ScheduleDefinition", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.ScheduleDefinitions == null)
                        {
                            unmarshalledObject.ScheduleDefinitions = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ScheduleDefinitions.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ScheduleDescription", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ScheduleDescription = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ScheduleIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ScheduleIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Tags/Tag", targetDepth))
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
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        private static SnapshotScheduleUnmarshaller _instance = new SnapshotScheduleUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SnapshotScheduleUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}