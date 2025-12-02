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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lambda.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Operation Object
    /// </summary>  
    public class OperationUnmarshaller : IUnmarshaller<Operation, XmlUnmarshallerContext>, IUnmarshaller<Operation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Operation IUnmarshaller<Operation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Operation Unmarshall(JsonUnmarshallerContext context)
        {
            Operation unmarshalledObject = new Operation();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CallbackDetails", targetDepth))
                {
                    var unmarshaller = CallbackDetailsUnmarshaller.Instance;
                    unmarshalledObject.CallbackDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ChainedInvokeDetails", targetDepth))
                {
                    var unmarshaller = ChainedInvokeDetailsUnmarshaller.Instance;
                    unmarshalledObject.ChainedInvokeDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ContextDetails", targetDepth))
                {
                    var unmarshaller = ContextDetailsUnmarshaller.Instance;
                    unmarshalledObject.ContextDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.EndTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExecutionDetails", targetDepth))
                {
                    var unmarshaller = ExecutionDetailsUnmarshaller.Instance;
                    unmarshalledObject.ExecutionDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ParentId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ParentId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StepDetails", targetDepth))
                {
                    var unmarshaller = StepDetailsUnmarshaller.Instance;
                    unmarshalledObject.StepDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SubType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WaitDetails", targetDepth))
                {
                    var unmarshaller = WaitDetailsUnmarshaller.Instance;
                    unmarshalledObject.WaitDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static OperationUnmarshaller _instance = new OperationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OperationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}