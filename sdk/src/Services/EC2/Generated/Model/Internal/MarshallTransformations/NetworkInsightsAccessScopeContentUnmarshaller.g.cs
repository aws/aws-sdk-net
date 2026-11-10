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
    /// Response Unmarshaller for NetworkInsightsAccessScopeContent Object
    /// </summary>
    public partial class NetworkInsightsAccessScopeContentUnmarshaller : IXmlUnmarshaller<NetworkInsightsAccessScopeContent, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public NetworkInsightsAccessScopeContent Unmarshall(XmlUnmarshallerContext context)
        {
            NetworkInsightsAccessScopeContent unmarshalledObject = new NetworkInsightsAccessScopeContent();
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
                    if (context.TestExpression("excludePathSet/item", targetDepth))
                    {
                        if (unmarshalledObject.ExcludePaths == null)
                        {
                            unmarshalledObject.ExcludePaths = new List<AccessScopePath>();
                        }
                        var unmarshaller = AccessScopePathUnmarshaller.Instance;
                        unmarshalledObject.ExcludePaths.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("matchPathSet/item", targetDepth))
                    {
                        if (unmarshalledObject.MatchPaths == null)
                        {
                            unmarshalledObject.MatchPaths = new List<AccessScopePath>();
                        }
                        var unmarshaller = AccessScopePathUnmarshaller.Instance;
                        unmarshalledObject.MatchPaths.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("networkInsightsAccessScopeId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NetworkInsightsAccessScopeId = unmarshaller.Unmarshall(context);
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

        private static NetworkInsightsAccessScopeContentUnmarshaller _instance = new NetworkInsightsAccessScopeContentUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static NetworkInsightsAccessScopeContentUnmarshaller Instance => _instance;
    }
}
