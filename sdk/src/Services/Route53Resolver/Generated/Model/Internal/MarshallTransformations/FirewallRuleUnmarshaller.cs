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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53Resolver.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Route53Resolver.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FirewallRule Object
    /// </summary>  
    public class FirewallRuleUnmarshaller : IJsonUnmarshaller<FirewallRule, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public FirewallRule Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            FirewallRule unmarshalledObject = new FirewallRule();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Action", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Action = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BlockOverrideDnsType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BlockOverrideDnsType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BlockOverrideDomain", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BlockOverrideDomain = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BlockOverrideTtl", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.BlockOverrideTtl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BlockResponse", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BlockResponse = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ConfidenceThreshold", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConfidenceThreshold = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreatorRequestId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreatorRequestId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DnsThreatProtection", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DnsThreatProtection = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FirewallDomainListId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FirewallDomainListId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FirewallDomainRedirectionAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FirewallDomainRedirectionAction = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FirewallRuleGroupId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FirewallRuleGroupId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FirewallThreatProtectionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FirewallThreatProtectionId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ModificationTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ModificationTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Priority", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Priority = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Qtype", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Qtype = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static FirewallRuleUnmarshaller _instance = new FirewallRuleUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FirewallRuleUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}