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
    /// Response Unmarshaller for JobFlowInstancesDetail Object
    /// </summary>  
    public class JobFlowInstancesDetailUnmarshaller : IUnmarshaller<JobFlowInstancesDetail, XmlUnmarshallerContext>, IUnmarshaller<JobFlowInstancesDetail, JsonUnmarshallerContext>
    {
        JobFlowInstancesDetail IUnmarshaller<JobFlowInstancesDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public JobFlowInstancesDetail Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            JobFlowInstancesDetail unmarshalledObject = new JobFlowInstancesDetail();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Ec2KeyName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Ec2KeyName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Ec2SubnetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Ec2SubnetId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HadoopVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HadoopVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.InstanceCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<InstanceGroupDetail, InstanceGroupDetailUnmarshaller>(InstanceGroupDetailUnmarshaller.Instance);
                    unmarshalledObject.InstanceGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KeepJobFlowAliveWhenNoSteps", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.KeepJobFlowAliveWhenNoSteps = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MasterInstanceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MasterInstanceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MasterInstanceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MasterInstanceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MasterPublicDnsName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MasterPublicDnsName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NormalizedInstanceHours", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NormalizedInstanceHours = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Placement", targetDepth))
                {
                    var unmarshaller = PlacementTypeUnmarshaller.Instance;
                    unmarshalledObject.Placement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SlaveInstanceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SlaveInstanceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TerminationProtected", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.TerminationProtected = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static JobFlowInstancesDetailUnmarshaller _instance = new JobFlowInstancesDetailUnmarshaller();        

        public static JobFlowInstancesDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}