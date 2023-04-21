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
    /// Response Unmarshaller for AdminScope Object
    /// </summary>  
    public class AdminScopeUnmarshaller : IUnmarshaller<AdminScope, XmlUnmarshallerContext>, IUnmarshaller<AdminScope, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AdminScope IUnmarshaller<AdminScope, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AdminScope Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AdminScope unmarshalledObject = new AdminScope();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AccountScope", targetDepth))
                {
                    var unmarshaller = AccountScopeUnmarshaller.Instance;
                    unmarshalledObject.AccountScope = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OrganizationalUnitScope", targetDepth))
                {
                    var unmarshaller = OrganizationalUnitScopeUnmarshaller.Instance;
                    unmarshalledObject.OrganizationalUnitScope = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PolicyTypeScope", targetDepth))
                {
                    var unmarshaller = PolicyTypeScopeUnmarshaller.Instance;
                    unmarshalledObject.PolicyTypeScope = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RegionScope", targetDepth))
                {
                    var unmarshaller = RegionScopeUnmarshaller.Instance;
                    unmarshalledObject.RegionScope = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AdminScopeUnmarshaller _instance = new AdminScopeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AdminScopeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}