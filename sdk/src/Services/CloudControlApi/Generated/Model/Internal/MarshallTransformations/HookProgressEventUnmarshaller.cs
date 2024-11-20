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
 * Do not modify this file. This file is generated from the cloudcontrol-2021-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudControlApi.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudControlApi.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for HookProgressEvent Object
    /// </summary>  
    public class HookProgressEventUnmarshaller : IUnmarshaller<HookProgressEvent, XmlUnmarshallerContext>, IUnmarshaller<HookProgressEvent, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        HookProgressEvent IUnmarshaller<HookProgressEvent, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public HookProgressEvent Unmarshall(JsonUnmarshallerContext context)
        {
            HookProgressEvent unmarshalledObject = new HookProgressEvent();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("FailureMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FailureMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HookEventTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.HookEventTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HookStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HookStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HookStatusMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HookStatusMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HookTypeArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HookTypeArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HookTypeName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HookTypeName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HookTypeVersionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HookTypeVersionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InvocationPoint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InvocationPoint = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static HookProgressEventUnmarshaller _instance = new HookProgressEventUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HookProgressEventUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}