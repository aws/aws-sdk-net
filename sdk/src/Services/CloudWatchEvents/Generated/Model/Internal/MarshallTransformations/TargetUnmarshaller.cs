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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchEvents.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudWatchEvents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Target Object
    /// </summary>  
    public class TargetUnmarshaller : IUnmarshaller<Target, XmlUnmarshallerContext>, IUnmarshaller<Target, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Target IUnmarshaller<Target, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Target Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Target unmarshalledObject = new Target();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BatchParameters", targetDepth))
                {
                    var unmarshaller = BatchParametersUnmarshaller.Instance;
                    unmarshalledObject.BatchParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EcsParameters", targetDepth))
                {
                    var unmarshaller = EcsParametersUnmarshaller.Instance;
                    unmarshalledObject.EcsParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Input", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Input = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InputPath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InputPath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InputTransformer", targetDepth))
                {
                    var unmarshaller = InputTransformerUnmarshaller.Instance;
                    unmarshalledObject.InputTransformer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KinesisParameters", targetDepth))
                {
                    var unmarshaller = KinesisParametersUnmarshaller.Instance;
                    unmarshalledObject.KinesisParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RunCommandParameters", targetDepth))
                {
                    var unmarshaller = RunCommandParametersUnmarshaller.Instance;
                    unmarshalledObject.RunCommandParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SqsParameters", targetDepth))
                {
                    var unmarshaller = SqsParametersUnmarshaller.Instance;
                    unmarshalledObject.SqsParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static TargetUnmarshaller _instance = new TargetUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TargetUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}