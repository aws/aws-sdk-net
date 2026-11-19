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
    /// Response Unmarshaller for AdditionalDetail Object
    /// </summary>
    public partial class AdditionalDetailUnmarshaller : IXmlUnmarshaller<AdditionalDetail, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public AdditionalDetail Unmarshall(XmlUnmarshallerContext context)
        {
            AdditionalDetail unmarshalledObject = new AdditionalDetail();
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
                    if (context.TestExpression("additionalDetailType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AdditionalDetailType = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("component", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.Component = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("loadBalancerSet/item", targetDepth))
                    {
                        if (unmarshalledObject.LoadBalancers == null)
                        {
                            unmarshalledObject.LoadBalancers = new List<AnalysisComponent>();
                        }
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.LoadBalancers.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("ruleGroupRuleOptionsPairSet/item", targetDepth))
                    {
                        if (unmarshalledObject.RuleGroupRuleOptionsPairs == null)
                        {
                            unmarshalledObject.RuleGroupRuleOptionsPairs = new List<RuleGroupRuleOptionsPair>();
                        }
                        var unmarshaller = RuleGroupRuleOptionsPairUnmarshaller.Instance;
                        unmarshalledObject.RuleGroupRuleOptionsPairs.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("ruleGroupTypePairSet/item", targetDepth))
                    {
                        if (unmarshalledObject.RuleGroupTypePairs == null)
                        {
                            unmarshalledObject.RuleGroupTypePairs = new List<RuleGroupTypePair>();
                        }
                        var unmarshaller = RuleGroupTypePairUnmarshaller.Instance;
                        unmarshalledObject.RuleGroupTypePairs.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("ruleOptionSet/item", targetDepth))
                    {
                        if (unmarshalledObject.RuleOptions == null)
                        {
                            unmarshalledObject.RuleOptions = new List<RuleOption>();
                        }
                        var unmarshaller = RuleOptionUnmarshaller.Instance;
                        unmarshalledObject.RuleOptions.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("serviceName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ServiceName = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("vpcEndpointService", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.VpcEndpointService = unmarshaller.Unmarshall(context);
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

        private static AdditionalDetailUnmarshaller _instance = new AdditionalDetailUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AdditionalDetailUnmarshaller Instance => _instance;
    }
}
