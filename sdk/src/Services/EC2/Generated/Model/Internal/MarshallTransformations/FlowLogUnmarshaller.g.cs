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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.EC2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FlowLog Object
    /// </summary>
    public partial class FlowLogUnmarshaller : IXmlUnmarshaller<FlowLog, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public FlowLog Unmarshall(XmlUnmarshallerContext context)
        {
            FlowLog unmarshalledObject = new FlowLog();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument)
            {
                targetDepth += 2;
            }

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("creationTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("deliverCrossAccountRole", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DeliverCrossAccountRole = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("deliverLogsErrorMessage", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DeliverLogsErrorMessage = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("deliverLogsPermissionArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DeliverLogsPermissionArn = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("deliverLogsStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DeliverLogsStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("destinationOptions", targetDepth))
                    {
                        var unmarshaller = DestinationOptionsResponseUnmarshaller.Instance;
                        unmarshalledObject.DestinationOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("flowLogId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FlowLogId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("flowLogStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FlowLogStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("logDestination", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LogDestination = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("logDestinationType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LogDestinationType = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("logFormat", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LogFormat = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("logGroupName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LogGroupName = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("maxAggregationInterval", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MaxAggregationInterval = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("resourceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResourceId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("tagFieldSpecificationSet/item", targetDepth))
                    {
                        if (unmarshalledObject.TagFieldSpecifications == null)
                        {
                            unmarshalledObject.TagFieldSpecifications = new List<TagFieldSpecificationResponse>();
                        }
                        var unmarshaller = TagFieldSpecificationResponseUnmarshaller.Instance;
                        unmarshalledObject.TagFieldSpecifications.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        if (unmarshalledObject.Tags == null)
                        {
                            unmarshalledObject.Tags = new List<Tag>();
                        }
                        var unmarshaller = TagUnmarshaller.Instance;
                        unmarshalledObject.Tags.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("trafficType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TrafficType = unmarshaller.Unmarshall(context);
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

        private static FlowLogUnmarshaller _instance = new FlowLogUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static FlowLogUnmarshaller Instance => _instance;
    }
}
