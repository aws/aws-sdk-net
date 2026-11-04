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
    /// Response Unmarshaller for OptionGroup Object
    /// </summary>
    public partial class OptionGroupUnmarshaller : IXmlUnmarshaller<OptionGroup, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public OptionGroup Unmarshall(XmlUnmarshallerContext context)
        {
            OptionGroup unmarshalledObject = new OptionGroup();
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
                    if (context.TestExpression("AllowsVpcAndNonVpcInstanceMemberships", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.AllowsVpcAndNonVpcInstanceMemberships = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("CopyTimestamp", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CopyTimestamp = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("EngineName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EngineName = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("MajorEngineVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MajorEngineVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("OptionGroupArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OptionGroupArn = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("OptionGroupDescription", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OptionGroupDescription = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("OptionGroupName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OptionGroupName = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Options/Option", targetDepth))
                    {
                        if (unmarshalledObject.Options == null)
                        {
                            unmarshalledObject.Options = new List<Option>();
                        }
                        var unmarshaller = OptionUnmarshaller.Instance;
                        unmarshalledObject.Options.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("SourceAccountId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SourceAccountId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("SourceOptionGroup", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SourceOptionGroup = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("VpcId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VpcId = unmarshaller.Unmarshall(context);
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

        private static OptionGroupUnmarshaller _instance = new OptionGroupUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static OptionGroupUnmarshaller Instance => _instance;
    }
}
