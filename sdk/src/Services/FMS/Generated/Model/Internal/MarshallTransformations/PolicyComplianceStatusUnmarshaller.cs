/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Response Unmarshaller for PolicyComplianceStatus Object
    /// </summary>  
    public class PolicyComplianceStatusUnmarshaller : IUnmarshaller<PolicyComplianceStatus, XmlUnmarshallerContext>, IUnmarshaller<PolicyComplianceStatus, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PolicyComplianceStatus IUnmarshaller<PolicyComplianceStatus, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PolicyComplianceStatus Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            PolicyComplianceStatus unmarshalledObject = new PolicyComplianceStatus();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("EvaluationResults", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<EvaluationResult, EvaluationResultUnmarshaller>(EvaluationResultUnmarshaller.Instance);
                    unmarshalledObject.EvaluationResults = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastUpdated", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdated = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MemberAccount", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MemberAccount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PolicyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PolicyId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PolicyName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PolicyName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PolicyOwner", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PolicyOwner = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static PolicyComplianceStatusUnmarshaller _instance = new PolicyComplianceStatusUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PolicyComplianceStatusUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}