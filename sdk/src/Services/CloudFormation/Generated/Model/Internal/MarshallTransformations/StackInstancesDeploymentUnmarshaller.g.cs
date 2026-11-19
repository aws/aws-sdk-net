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
    /// Response Unmarshaller for StackInstancesDeployment Object
    /// </summary>
    public partial class StackInstancesDeploymentUnmarshaller : IXmlUnmarshaller<StackInstancesDeployment, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public StackInstancesDeployment Unmarshall(XmlUnmarshallerContext context)
        {
            StackInstancesDeployment unmarshalledObject = new StackInstancesDeployment();
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
                    if (context.TestExpression("CancelledStackInstancesCount", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.CancelledStackInstancesCount = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("CompletedStackInstancesCount", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.CompletedStackInstancesCount = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("FailedStackInstancesCount", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.FailedStackInstancesCount = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("PendingStackInstancesCount", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.PendingStackInstancesCount = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("PercentageCompleted", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.PercentageCompleted = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("SkippedStackInstancesCount", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.SkippedStackInstancesCount = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("SucceededStackInstancesCount", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.SucceededStackInstancesCount = unmarshaller.Unmarshall(context);
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

        private static StackInstancesDeploymentUnmarshaller _instance = new StackInstancesDeploymentUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static StackInstancesDeploymentUnmarshaller Instance => _instance;
    }
}
