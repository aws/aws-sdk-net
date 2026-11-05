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
    /// Response Unmarshaller for TypeSummary Object
    /// </summary>
    public partial class TypeSummaryUnmarshaller : IXmlUnmarshaller<TypeSummary, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public TypeSummary Unmarshall(XmlUnmarshallerContext context)
        {
            TypeSummary unmarshalledObject = new TypeSummary();
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
                    if (context.TestExpression("DefaultVersionId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DefaultVersionId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("IsActivated", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.IsActivated = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("LastUpdated", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.LastUpdated = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("LatestPublicVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LatestPublicVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("OriginalTypeName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OriginalTypeName = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("PublicVersionNumber", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PublicVersionNumber = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("PublisherId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PublisherId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("PublisherIdentity", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PublisherIdentity = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("PublisherName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PublisherName = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Type", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("TypeArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TypeArn = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("TypeName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TypeName = unmarshaller.Unmarshall(context);
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

        private static TypeSummaryUnmarshaller _instance = new TypeSummaryUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static TypeSummaryUnmarshaller Instance => _instance;
    }
}
