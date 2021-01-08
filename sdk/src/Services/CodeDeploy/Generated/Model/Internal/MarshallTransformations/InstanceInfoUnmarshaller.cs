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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeDeploy.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeDeploy.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InstanceInfo Object
    /// </summary>  
    public class InstanceInfoUnmarshaller : IUnmarshaller<InstanceInfo, XmlUnmarshallerContext>, IUnmarshaller<InstanceInfo, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        InstanceInfo IUnmarshaller<InstanceInfo, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public InstanceInfo Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            InstanceInfo unmarshalledObject = new InstanceInfo();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("deregisterTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.DeregisterTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("iamSessionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IamSessionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("iamUserArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IamUserArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("instanceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("instanceName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("registerTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.RegisterTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static InstanceInfoUnmarshaller _instance = new InstanceInfoUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InstanceInfoUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}