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

using Amazon.ElasticLoadBalancing.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Policies Object
    /// </summary>
    public partial class PoliciesUnmarshaller : IXmlUnmarshaller<Policies, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Policies Unmarshall(XmlUnmarshallerContext context)
        {
            Policies unmarshalledObject = new Policies();
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
                    if (context.TestExpression("AppCookieStickinessPolicies/member", targetDepth))
                    {
                        if (unmarshalledObject.AppCookieStickinessPolicies == null)
                        {
                            unmarshalledObject.AppCookieStickinessPolicies = new List<AppCookieStickinessPolicy>();
                        }
                        var unmarshaller = AppCookieStickinessPolicyUnmarshaller.Instance;
                        unmarshalledObject.AppCookieStickinessPolicies.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("LBCookieStickinessPolicies/member", targetDepth))
                    {
                        if (unmarshalledObject.LBCookieStickinessPolicies == null)
                        {
                            unmarshalledObject.LBCookieStickinessPolicies = new List<LBCookieStickinessPolicy>();
                        }
                        var unmarshaller = LBCookieStickinessPolicyUnmarshaller.Instance;
                        unmarshalledObject.LBCookieStickinessPolicies.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("OtherPolicies/member", targetDepth))
                    {
                        if (unmarshalledObject.OtherPolicies == null)
                        {
                            unmarshalledObject.OtherPolicies = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OtherPolicies.Add(unmarshaller.Unmarshall(context));
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

        private static PoliciesUnmarshaller _instance = new PoliciesUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PoliciesUnmarshaller Instance => _instance;
    }
}
