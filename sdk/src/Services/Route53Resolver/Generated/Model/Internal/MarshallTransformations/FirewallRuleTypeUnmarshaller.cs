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
    /// Response Unmarshaller for FirewallRuleType Object
    /// </summary>  
    public class FirewallRuleTypeUnmarshaller : IJsonUnmarshaller<FirewallRuleType, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public FirewallRuleType Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            FirewallRuleType unmarshalledObject = new FirewallRuleType();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("DnsThreatProtection", targetDepth))
                {
                    var unmarshaller = DnsThreatProtectionRuleTypeConfigUnmarshaller.Instance;
                    unmarshalledObject.DnsThreatProtection = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FirewallAdvancedContentCategory", targetDepth))
                {
                    var unmarshaller = FirewallAdvancedContentCategoryConfigUnmarshaller.Instance;
                    unmarshalledObject.FirewallAdvancedContentCategory = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FirewallAdvancedThreatCategory", targetDepth))
                {
                    var unmarshaller = FirewallAdvancedThreatCategoryConfigUnmarshaller.Instance;
                    unmarshalledObject.FirewallAdvancedThreatCategory = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static FirewallRuleTypeUnmarshaller _instance = new FirewallRuleTypeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FirewallRuleTypeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}