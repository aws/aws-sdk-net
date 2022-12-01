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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pipes.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Pipes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BatchContainerOverrides Object
    /// </summary>  
    public class BatchContainerOverridesUnmarshaller : IUnmarshaller<BatchContainerOverrides, XmlUnmarshallerContext>, IUnmarshaller<BatchContainerOverrides, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        BatchContainerOverrides IUnmarshaller<BatchContainerOverrides, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public BatchContainerOverrides Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            BatchContainerOverrides unmarshalledObject = new BatchContainerOverrides();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Command", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Command = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Environment", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<BatchEnvironmentVariable, BatchEnvironmentVariableUnmarshaller>(BatchEnvironmentVariableUnmarshaller.Instance);
                    unmarshalledObject.Environment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceRequirements", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<BatchResourceRequirement, BatchResourceRequirementUnmarshaller>(BatchResourceRequirementUnmarshaller.Instance);
                    unmarshalledObject.ResourceRequirements = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static BatchContainerOverridesUnmarshaller _instance = new BatchContainerOverridesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchContainerOverridesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}