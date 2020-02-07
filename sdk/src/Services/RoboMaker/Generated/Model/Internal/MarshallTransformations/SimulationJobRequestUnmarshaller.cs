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
    /// Response Unmarshaller for SimulationJobRequest Object
    /// </summary>  
    public class SimulationJobRequestUnmarshaller : IUnmarshaller<SimulationJobRequest, XmlUnmarshallerContext>, IUnmarshaller<SimulationJobRequest, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SimulationJobRequest IUnmarshaller<SimulationJobRequest, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SimulationJobRequest Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SimulationJobRequest unmarshalledObject = new SimulationJobRequest();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("dataSources", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DataSourceConfig, DataSourceConfigUnmarshaller>(DataSourceConfigUnmarshaller.Instance);
                    unmarshalledObject.DataSources = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("failureBehavior", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FailureBehavior = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("iamRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IamRole = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("loggingConfig", targetDepth))
                {
                    var unmarshaller = LoggingConfigUnmarshaller.Instance;
                    unmarshalledObject.LoggingConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maxJobDurationInSeconds", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.MaxJobDurationInSeconds = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("useDefaultApplications", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UseDefaultApplications = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vpcConfig", targetDepth))
                {
                    var unmarshaller = VPCConfigUnmarshaller.Instance;
                    unmarshalledObject.VpcConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SimulationJobRequestUnmarshaller _instance = new SimulationJobRequestUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SimulationJobRequestUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}