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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Batch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Batch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EksContainer Object
    /// </summary>  
    public class EksContainerUnmarshaller : IUnmarshaller<EksContainer, XmlUnmarshallerContext>, IUnmarshaller<EksContainer, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        EksContainer IUnmarshaller<EksContainer, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public EksContainer Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            EksContainer unmarshalledObject = new EksContainer();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("args", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Args = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("command", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Command = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("env", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<EksContainerEnvironmentVariable, EksContainerEnvironmentVariableUnmarshaller>(EksContainerEnvironmentVariableUnmarshaller.Instance);
                    unmarshalledObject.Env = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("image", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Image = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("imagePullPolicy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImagePullPolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resources", targetDepth))
                {
                    var unmarshaller = EksContainerResourceRequirementsUnmarshaller.Instance;
                    unmarshalledObject.Resources = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("securityContext", targetDepth))
                {
                    var unmarshaller = EksContainerSecurityContextUnmarshaller.Instance;
                    unmarshalledObject.SecurityContext = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("volumeMounts", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<EksContainerVolumeMount, EksContainerVolumeMountUnmarshaller>(EksContainerVolumeMountUnmarshaller.Instance);
                    unmarshalledObject.VolumeMounts = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static EksContainerUnmarshaller _instance = new EksContainerUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EksContainerUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}