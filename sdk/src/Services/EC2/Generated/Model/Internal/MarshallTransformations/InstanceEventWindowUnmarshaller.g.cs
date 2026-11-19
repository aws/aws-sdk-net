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
    /// Response Unmarshaller for InstanceEventWindow Object
    /// </summary>
    public partial class InstanceEventWindowUnmarshaller : IXmlUnmarshaller<InstanceEventWindow, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public InstanceEventWindow Unmarshall(XmlUnmarshallerContext context)
        {
            InstanceEventWindow unmarshalledObject = new InstanceEventWindow();
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
                    if (context.TestExpression("associationTarget", targetDepth))
                    {
                        var unmarshaller = InstanceEventWindowAssociationTargetUnmarshaller.Instance;
                        unmarshalledObject.AssociationTarget = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("cronExpression", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CronExpression = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("instanceEventWindowId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InstanceEventWindowId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("name", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("state", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.State = unmarshaller.Unmarshall(context);
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

                    if (context.TestExpression("timeRangeSet/item", targetDepth))
                    {
                        if (unmarshalledObject.TimeRanges == null)
                        {
                            unmarshalledObject.TimeRanges = new List<InstanceEventWindowTimeRange>();
                        }
                        var unmarshaller = InstanceEventWindowTimeRangeUnmarshaller.Instance;
                        unmarshalledObject.TimeRanges.Add(unmarshaller.Unmarshall(context));
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

        private static InstanceEventWindowUnmarshaller _instance = new InstanceEventWindowUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static InstanceEventWindowUnmarshaller Instance => _instance;
    }
}
