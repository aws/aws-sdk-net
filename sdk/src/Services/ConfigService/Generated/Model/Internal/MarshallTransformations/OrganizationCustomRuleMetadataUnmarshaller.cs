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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConfigService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OrganizationCustomRuleMetadata Object
    /// </summary>  
    public class OrganizationCustomRuleMetadataUnmarshaller : IUnmarshaller<OrganizationCustomRuleMetadata, XmlUnmarshallerContext>, IUnmarshaller<OrganizationCustomRuleMetadata, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        OrganizationCustomRuleMetadata IUnmarshaller<OrganizationCustomRuleMetadata, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public OrganizationCustomRuleMetadata Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            OrganizationCustomRuleMetadata unmarshalledObject = new OrganizationCustomRuleMetadata();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InputParameters", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InputParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LambdaFunctionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LambdaFunctionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaximumExecutionFrequency", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaximumExecutionFrequency = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OrganizationConfigRuleTriggerTypes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.OrganizationConfigRuleTriggerTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceIdScope", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourceIdScope = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceTypesScope", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ResourceTypesScope = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TagKeyScope", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TagKeyScope = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TagValueScope", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TagValueScope = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static OrganizationCustomRuleMetadataUnmarshaller _instance = new OrganizationCustomRuleMetadataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OrganizationCustomRuleMetadataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}