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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AutomationRulesActionV2 Object
    /// </summary>  
    public class AutomationRulesActionV2Unmarshaller : IUnmarshaller<AutomationRulesActionV2, XmlUnmarshallerContext>, IUnmarshaller<AutomationRulesActionV2, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AutomationRulesActionV2 IUnmarshaller<AutomationRulesActionV2, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AutomationRulesActionV2 Unmarshall(JsonUnmarshallerContext context)
        {
            AutomationRulesActionV2 unmarshalledObject = new AutomationRulesActionV2();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ExternalIntegrationConfiguration", targetDepth))
                {
                    var unmarshaller = ExternalIntegrationConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ExternalIntegrationConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FindingFieldsUpdate", targetDepth))
                {
                    var unmarshaller = AutomationRulesFindingFieldsUpdateV2Unmarshaller.Instance;
                    unmarshalledObject.FindingFieldsUpdate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AutomationRulesActionV2Unmarshaller _instance = new AutomationRulesActionV2Unmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AutomationRulesActionV2Unmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}