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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AgentInfo Object
    /// </summary>  
    public class AgentInfoUnmarshaller : IUnmarshaller<AgentInfo, XmlUnmarshallerContext>, IUnmarshaller<AgentInfo, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AgentInfo IUnmarshaller<AgentInfo, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AgentInfo Unmarshall(JsonUnmarshallerContext context)
        {
            AgentInfo unmarshalledObject = new AgentInfo();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AcceptedByAgentTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.AcceptedByAgentTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AfterContactWorkDuration", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AfterContactWorkDuration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AfterContactWorkEndTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.AfterContactWorkEndTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AfterContactWorkStartTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.AfterContactWorkStartTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AgentInitiatedHoldDuration", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AgentInitiatedHoldDuration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AgentPauseDurationInSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AgentPauseDurationInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Capabilities", targetDepth))
                {
                    var unmarshaller = ParticipantCapabilitiesUnmarshaller.Instance;
                    unmarshalledObject.Capabilities = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConnectedToAgentTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ConnectedToAgentTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeviceInfo", targetDepth))
                {
                    var unmarshaller = DeviceInfoUnmarshaller.Instance;
                    unmarshalledObject.DeviceInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HierarchyGroups", targetDepth))
                {
                    var unmarshaller = HierarchyGroupsUnmarshaller.Instance;
                    unmarshalledObject.HierarchyGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreviewEndTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.PreviewEndTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StateTransitions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StateTransition, StateTransitionUnmarshaller>(StateTransitionUnmarshaller.Instance);
                    unmarshalledObject.StateTransitions = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AgentInfoUnmarshaller _instance = new AgentInfoUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AgentInfoUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}