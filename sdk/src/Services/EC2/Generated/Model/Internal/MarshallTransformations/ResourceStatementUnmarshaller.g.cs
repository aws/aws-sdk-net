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
    /// Response Unmarshaller for ResourceStatement Object
    /// </summary>
    public partial class ResourceStatementUnmarshaller : IXmlUnmarshaller<ResourceStatement, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ResourceStatement Unmarshall(XmlUnmarshallerContext context)
        {
            ResourceStatement unmarshalledObject = new ResourceStatement();
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
                    if (context.TestExpression("resourceTypeSet/item", targetDepth))
                    {
                        if (unmarshalledObject.ResourceTypes == null)
                        {
                            unmarshalledObject.ResourceTypes = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResourceTypes.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("resourceSet/item", targetDepth))
                    {
                        if (unmarshalledObject.Resources == null)
                        {
                            unmarshalledObject.Resources = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Resources.Add(unmarshaller.Unmarshall(context));
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

        private static ResourceStatementUnmarshaller _instance = new ResourceStatementUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ResourceStatementUnmarshaller Instance => _instance;
    }
}
