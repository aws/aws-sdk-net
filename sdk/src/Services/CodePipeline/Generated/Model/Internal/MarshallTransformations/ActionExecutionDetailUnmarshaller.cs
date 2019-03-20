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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodePipeline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodePipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ActionExecutionDetail Object
    /// </summary>  
    public class ActionExecutionDetailUnmarshaller : IUnmarshaller<ActionExecutionDetail, XmlUnmarshallerContext>, IUnmarshaller<ActionExecutionDetail, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ActionExecutionDetail IUnmarshaller<ActionExecutionDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ActionExecutionDetail Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ActionExecutionDetail unmarshalledObject = new ActionExecutionDetail();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("actionExecutionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ActionExecutionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("actionName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ActionName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("input", targetDepth))
                {
                    var unmarshaller = ActionExecutionInputUnmarshaller.Instance;
                    unmarshalledObject.Input = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastUpdateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("output", targetDepth))
                {
                    var unmarshaller = ActionExecutionOutputUnmarshaller.Instance;
                    unmarshalledObject.Output = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pipelineExecutionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PipelineExecutionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pipelineVersion", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.PipelineVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stageName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StageName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("startTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ActionExecutionDetailUnmarshaller _instance = new ActionExecutionDetailUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ActionExecutionDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}