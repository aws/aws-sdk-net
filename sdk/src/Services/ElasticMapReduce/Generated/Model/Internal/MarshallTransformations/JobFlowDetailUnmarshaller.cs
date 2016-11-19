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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for JobFlowDetail Object
    /// </summary>  
    public class JobFlowDetailUnmarshaller : IUnmarshaller<JobFlowDetail, XmlUnmarshallerContext>, IUnmarshaller<JobFlowDetail, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        JobFlowDetail IUnmarshaller<JobFlowDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public JobFlowDetail Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            JobFlowDetail unmarshalledObject = new JobFlowDetail();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AmiVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AmiVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutoScalingRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AutoScalingRole = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BootstrapActions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<BootstrapActionDetail, BootstrapActionDetailUnmarshaller>(BootstrapActionDetailUnmarshaller.Instance);
                    unmarshalledObject.BootstrapActions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExecutionStatusDetail", targetDepth))
                {
                    var unmarshaller = JobFlowExecutionStatusDetailUnmarshaller.Instance;
                    unmarshalledObject.ExecutionStatusDetail = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Instances", targetDepth))
                {
                    var unmarshaller = JobFlowInstancesDetailUnmarshaller.Instance;
                    unmarshalledObject.Instances = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JobFlowId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JobFlowId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JobFlowRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JobFlowRole = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LogUri", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogUri = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScaleDownBehavior", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScaleDownBehavior = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceRole = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Steps", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StepDetail, StepDetailUnmarshaller>(StepDetailUnmarshaller.Instance);
                    unmarshalledObject.Steps = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SupportedProducts", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SupportedProducts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VisibleToAllUsers", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.VisibleToAllUsers = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static JobFlowDetailUnmarshaller _instance = new JobFlowDetailUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JobFlowDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}