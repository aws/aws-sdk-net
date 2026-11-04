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

using Amazon.RDS.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BlueGreenDeployment Object
    /// </summary>
    public partial class BlueGreenDeploymentUnmarshaller : IXmlUnmarshaller<BlueGreenDeployment, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public BlueGreenDeployment Unmarshall(XmlUnmarshallerContext context)
        {
            BlueGreenDeployment unmarshalledObject = new BlueGreenDeployment();
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
                    if (context.TestExpression("BlueGreenDeploymentIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.BlueGreenDeploymentIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("BlueGreenDeploymentName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.BlueGreenDeploymentName = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("CreateTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreateTime = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("DeleteTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.DeleteTime = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Source", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Source = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("StatusDetails", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StatusDetails = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("SwitchoverDetails/member", targetDepth))
                    {
                        if (unmarshalledObject.SwitchoverDetails == null)
                        {
                            unmarshalledObject.SwitchoverDetails = new List<SwitchoverDetail>();
                        }
                        var unmarshaller = SwitchoverDetailUnmarshaller.Instance;
                        unmarshalledObject.SwitchoverDetails.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("TagList/Tag", targetDepth))
                    {
                        if (unmarshalledObject.TagList == null)
                        {
                            unmarshalledObject.TagList = new List<Tag>();
                        }
                        var unmarshaller = TagUnmarshaller.Instance;
                        unmarshalledObject.TagList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("Target", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Target = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Tasks/member", targetDepth))
                    {
                        if (unmarshalledObject.Tasks == null)
                        {
                            unmarshalledObject.Tasks = new List<BlueGreenDeploymentTask>();
                        }
                        var unmarshaller = BlueGreenDeploymentTaskUnmarshaller.Instance;
                        unmarshalledObject.Tasks.Add(unmarshaller.Unmarshall(context));
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

        private static BlueGreenDeploymentUnmarshaller _instance = new BlueGreenDeploymentUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static BlueGreenDeploymentUnmarshaller Instance => _instance;
    }
}
