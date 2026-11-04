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

using Amazon.IdentityManagement.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DeletionTaskFailureReasonType Object
    /// </summary>
    public partial class DeletionTaskFailureReasonTypeUnmarshaller : IXmlUnmarshaller<DeletionTaskFailureReasonType, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public DeletionTaskFailureReasonType Unmarshall(XmlUnmarshallerContext context)
        {
            DeletionTaskFailureReasonType unmarshalledObject = new DeletionTaskFailureReasonType();
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
                    if (context.TestExpression("Reason", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Reason = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("RoleUsageList/member", targetDepth))
                    {
                        if (unmarshalledObject.RoleUsageList == null)
                        {
                            unmarshalledObject.RoleUsageList = new List<RoleUsageType>();
                        }
                        var unmarshaller = RoleUsageTypeUnmarshaller.Instance;
                        unmarshalledObject.RoleUsageList.Add(unmarshaller.Unmarshall(context));
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

        private static DeletionTaskFailureReasonTypeUnmarshaller _instance = new DeletionTaskFailureReasonTypeUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeletionTaskFailureReasonTypeUnmarshaller Instance => _instance;
    }
}
