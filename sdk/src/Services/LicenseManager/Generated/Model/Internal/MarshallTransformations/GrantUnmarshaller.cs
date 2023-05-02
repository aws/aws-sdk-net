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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LicenseManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LicenseManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Grant Object
    /// </summary>  
    public class GrantUnmarshaller : IUnmarshaller<Grant, XmlUnmarshallerContext>, IUnmarshaller<Grant, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Grant IUnmarshaller<Grant, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Grant Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Grant unmarshalledObject = new Grant();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("GrantArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GrantArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GrantedOperations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.GrantedOperations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GranteePrincipalArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GranteePrincipalArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GrantName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GrantName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GrantStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GrantStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HomeRegion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HomeRegion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LicenseArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LicenseArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Options", targetDepth))
                {
                    var unmarshaller = OptionsUnmarshaller.Instance;
                    unmarshalledObject.Options = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ParentArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ParentArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatusReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatusReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Version", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Version = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static GrantUnmarshaller _instance = new GrantUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GrantUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}