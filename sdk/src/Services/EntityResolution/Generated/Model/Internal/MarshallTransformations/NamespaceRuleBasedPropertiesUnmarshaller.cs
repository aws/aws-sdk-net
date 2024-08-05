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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EntityResolution.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.EntityResolution.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for NamespaceRuleBasedProperties Object
    /// </summary>  
    public class NamespaceRuleBasedPropertiesUnmarshaller : IUnmarshaller<NamespaceRuleBasedProperties, XmlUnmarshallerContext>, IUnmarshaller<NamespaceRuleBasedProperties, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        NamespaceRuleBasedProperties IUnmarshaller<NamespaceRuleBasedProperties, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public NamespaceRuleBasedProperties Unmarshall(JsonUnmarshallerContext context)
        {
            NamespaceRuleBasedProperties unmarshalledObject = new NamespaceRuleBasedProperties();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("attributeMatchingModel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AttributeMatchingModel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("recordMatchingModels", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.RecordMatchingModels = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ruleDefinitionTypes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.RuleDefinitionTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rules", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Rule, RuleUnmarshaller>(RuleUnmarshaller.Instance);
                    unmarshalledObject.Rules = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static NamespaceRuleBasedPropertiesUnmarshaller _instance = new NamespaceRuleBasedPropertiesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NamespaceRuleBasedPropertiesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}