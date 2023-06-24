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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.VerifiedPermissions.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.VerifiedPermissions.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TemplateLinkedPolicyDefinitionItem Object
    /// </summary>  
    public class TemplateLinkedPolicyDefinitionItemUnmarshaller : IUnmarshaller<TemplateLinkedPolicyDefinitionItem, XmlUnmarshallerContext>, IUnmarshaller<TemplateLinkedPolicyDefinitionItem, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TemplateLinkedPolicyDefinitionItem IUnmarshaller<TemplateLinkedPolicyDefinitionItem, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TemplateLinkedPolicyDefinitionItem Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            TemplateLinkedPolicyDefinitionItem unmarshalledObject = new TemplateLinkedPolicyDefinitionItem();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("policyTemplateId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PolicyTemplateId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("principal", targetDepth))
                {
                    var unmarshaller = EntityIdentifierUnmarshaller.Instance;
                    unmarshalledObject.Principal = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resource", targetDepth))
                {
                    var unmarshaller = EntityIdentifierUnmarshaller.Instance;
                    unmarshalledObject.Resource = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static TemplateLinkedPolicyDefinitionItemUnmarshaller _instance = new TemplateLinkedPolicyDefinitionItemUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TemplateLinkedPolicyDefinitionItemUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}