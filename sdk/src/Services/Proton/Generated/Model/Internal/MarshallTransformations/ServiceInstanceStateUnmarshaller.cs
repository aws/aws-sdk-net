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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Proton.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Proton.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ServiceInstanceState Object
    /// </summary>  
    public class ServiceInstanceStateUnmarshaller : IUnmarshaller<ServiceInstanceState, XmlUnmarshallerContext>, IUnmarshaller<ServiceInstanceState, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ServiceInstanceState IUnmarshaller<ServiceInstanceState, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ServiceInstanceState Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ServiceInstanceState unmarshalledObject = new ServiceInstanceState();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("lastSuccessfulComponentDeploymentIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.LastSuccessfulComponentDeploymentIds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastSuccessfulEnvironmentDeploymentId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastSuccessfulEnvironmentDeploymentId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastSuccessfulServicePipelineDeploymentId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastSuccessfulServicePipelineDeploymentId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("spec", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Spec = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("templateMajorVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TemplateMajorVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("templateMinorVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TemplateMinorVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("templateName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TemplateName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ServiceInstanceStateUnmarshaller _instance = new ServiceInstanceStateUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ServiceInstanceStateUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}