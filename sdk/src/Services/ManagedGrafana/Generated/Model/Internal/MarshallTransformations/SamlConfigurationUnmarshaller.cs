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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ManagedGrafana.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ManagedGrafana.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SamlConfiguration Object
    /// </summary>  
    public class SamlConfigurationUnmarshaller : IUnmarshaller<SamlConfiguration, XmlUnmarshallerContext>, IUnmarshaller<SamlConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SamlConfiguration IUnmarshaller<SamlConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SamlConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SamlConfiguration unmarshalledObject = new SamlConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("allowedOrganizations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AllowedOrganizations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assertionAttributes", targetDepth))
                {
                    var unmarshaller = AssertionAttributesUnmarshaller.Instance;
                    unmarshalledObject.AssertionAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("idpMetadata", targetDepth))
                {
                    var unmarshaller = IdpMetadataUnmarshaller.Instance;
                    unmarshalledObject.IdpMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("loginValidityDuration", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.LoginValidityDuration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("roleValues", targetDepth))
                {
                    var unmarshaller = RoleValuesUnmarshaller.Instance;
                    unmarshalledObject.RoleValues = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SamlConfigurationUnmarshaller _instance = new SamlConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SamlConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}