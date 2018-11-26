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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RoboMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.RoboMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SimulationJob Object
    /// </summary>  
    public class SimulationJobUnmarshaller : IUnmarshaller<SimulationJob, XmlUnmarshallerContext>, IUnmarshaller<SimulationJob, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SimulationJob IUnmarshaller<SimulationJob, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SimulationJob Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SimulationJob unmarshalledObject = new SimulationJob();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("clientRequestToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClientRequestToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("failureBehavior", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FailureBehavior = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("failureCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FailureCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("iamRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IamRole = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastUpdatedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maxJobDurationInSeconds", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.MaxJobDurationInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("outputLocation", targetDepth))
                {
                    var unmarshaller = OutputLocationUnmarshaller.Instance;
                    unmarshalledObject.OutputLocation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("robotApplications", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RobotApplicationConfig, RobotApplicationConfigUnmarshaller>(RobotApplicationConfigUnmarshaller.Instance);
                    unmarshalledObject.RobotApplications = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("simulationApplications", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SimulationApplicationConfig, SimulationApplicationConfigUnmarshaller>(SimulationApplicationConfigUnmarshaller.Instance);
                    unmarshalledObject.SimulationApplications = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("simulationTimeMillis", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.SimulationTimeMillis = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vpcConfig", targetDepth))
                {
                    var unmarshaller = VPCConfigResponseUnmarshaller.Instance;
                    unmarshalledObject.VpcConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SimulationJobUnmarshaller _instance = new SimulationJobUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SimulationJobUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}