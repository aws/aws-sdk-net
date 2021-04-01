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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.FMS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DnsRuleGroupPriorityConflictViolation Object
    /// </summary>  
    public class DnsRuleGroupPriorityConflictViolationUnmarshaller : IUnmarshaller<DnsRuleGroupPriorityConflictViolation, XmlUnmarshallerContext>, IUnmarshaller<DnsRuleGroupPriorityConflictViolation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DnsRuleGroupPriorityConflictViolation IUnmarshaller<DnsRuleGroupPriorityConflictViolation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DnsRuleGroupPriorityConflictViolation Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DnsRuleGroupPriorityConflictViolation unmarshalledObject = new DnsRuleGroupPriorityConflictViolation();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ConflictingPolicyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConflictingPolicyId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConflictingPriority", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ConflictingPriority = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UnavailablePriorities", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.UnavailablePriorities = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ViolationTarget", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ViolationTarget = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ViolationTargetDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ViolationTargetDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DnsRuleGroupPriorityConflictViolationUnmarshaller _instance = new DnsRuleGroupPriorityConflictViolationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DnsRuleGroupPriorityConflictViolationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}