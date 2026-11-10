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

using Amazon.NetworkFirewall.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.NetworkFirewall.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FirewallPolicyV2 Object
    /// </summary>
    public partial class FirewallPolicyV2Unmarshaller : IJsonUnmarshaller<FirewallPolicyV2, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public FirewallPolicyV2 Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new FirewallPolicyV2();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("FirewallDefaultAction", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FirewallDefaultAction = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("FirewallRuleGroupEntries", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<FirewallRuleGroupEntry, FirewallRuleGroupEntryUnmarshaller>(FirewallRuleGroupEntryUnmarshaller.Instance);
                    unmarshalledObject.FirewallRuleGroupEntries = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("IpsRuleGroupEntries", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<IpsRuleGroupEntry, IpsRuleGroupEntryUnmarshaller>(IpsRuleGroupEntryUnmarshaller.Instance);
                    unmarshalledObject.IpsRuleGroupEntries = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("PolicyMode", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PolicyMode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("PolicyVariables", targetDepth, ref reader))
                {
                    var unmarshaller = PolicyVariablesUnmarshaller.Instance;
                    unmarshalledObject.PolicyVariables = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Route53ResolvedIPValidation", targetDepth, ref reader))
                {
                    var unmarshaller = Route53ResolvedIPValidationUnmarshaller.Instance;
                    unmarshalledObject.Route53ResolvedIPValidation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("StatefulEngineOptions", targetDepth, ref reader))
                {
                    var unmarshaller = StatefulEngineOptionsV2Unmarshaller.Instance;
                    unmarshalledObject.StatefulEngineOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("TLSInspectionConfigurationArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TLSInspectionConfigurationArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static FirewallPolicyV2Unmarshaller _instance = new FirewallPolicyV2Unmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static FirewallPolicyV2Unmarshaller Instance => _instance;
    }
}
