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

using Amazon.CloudFormation.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for StackInstanceResourceDriftsSummary Object
    /// </summary>
    public partial class StackInstanceResourceDriftsSummaryUnmarshaller : IXmlUnmarshaller<StackInstanceResourceDriftsSummary, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public StackInstanceResourceDriftsSummary Unmarshall(XmlUnmarshallerContext context)
        {
            StackInstanceResourceDriftsSummary unmarshalledObject = new StackInstanceResourceDriftsSummary();
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
                    if (context.TestExpression("LogicalResourceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LogicalResourceId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("PhysicalResourceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PhysicalResourceId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("PhysicalResourceIdContext/member", targetDepth))
                    {
                        if (unmarshalledObject.PhysicalResourceIdContext == null)
                        {
                            unmarshalledObject.PhysicalResourceIdContext = new List<PhysicalResourceIdContextKeyValuePair>();
                        }
                        var unmarshaller = PhysicalResourceIdContextKeyValuePairUnmarshaller.Instance;
                        unmarshalledObject.PhysicalResourceIdContext.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("PropertyDifferences/member", targetDepth))
                    {
                        if (unmarshalledObject.PropertyDifferences == null)
                        {
                            unmarshalledObject.PropertyDifferences = new List<PropertyDifference>();
                        }
                        var unmarshaller = PropertyDifferenceUnmarshaller.Instance;
                        unmarshalledObject.PropertyDifferences.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("ResourceType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResourceType = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("StackId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StackId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("StackResourceDriftStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StackResourceDriftStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Timestamp", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.Timestamp = unmarshaller.Unmarshall(context);
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

        private static StackInstanceResourceDriftsSummaryUnmarshaller _instance = new StackInstanceResourceDriftsSummaryUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static StackInstanceResourceDriftsSummaryUnmarshaller Instance => _instance;
    }
}
