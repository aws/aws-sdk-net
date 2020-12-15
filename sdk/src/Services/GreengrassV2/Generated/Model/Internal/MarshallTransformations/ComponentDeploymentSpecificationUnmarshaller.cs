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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GreengrassV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GreengrassV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ComponentDeploymentSpecification Object
    /// </summary>  
    public class ComponentDeploymentSpecificationUnmarshaller : IUnmarshaller<ComponentDeploymentSpecification, XmlUnmarshallerContext>, IUnmarshaller<ComponentDeploymentSpecification, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ComponentDeploymentSpecification IUnmarshaller<ComponentDeploymentSpecification, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ComponentDeploymentSpecification Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ComponentDeploymentSpecification unmarshalledObject = new ComponentDeploymentSpecification();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("componentVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ComponentVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("configurationUpdate", targetDepth))
                {
                    var unmarshaller = ComponentConfigurationUpdateUnmarshaller.Instance;
                    unmarshalledObject.ConfigurationUpdate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("runWith", targetDepth))
                {
                    var unmarshaller = ComponentRunWithUnmarshaller.Instance;
                    unmarshalledObject.RunWith = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ComponentDeploymentSpecificationUnmarshaller _instance = new ComponentDeploymentSpecificationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ComponentDeploymentSpecificationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}