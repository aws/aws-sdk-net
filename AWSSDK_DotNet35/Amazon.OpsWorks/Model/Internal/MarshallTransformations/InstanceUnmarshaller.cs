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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Instance Object
    /// </summary>  
    public class InstanceUnmarshaller : IUnmarshaller<Instance, XmlUnmarshallerContext>, IUnmarshaller<Instance, JsonUnmarshallerContext>
    {
        Instance IUnmarshaller<Instance, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public Instance Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Instance unmarshalledObject = new Instance();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AgentVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AgentVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AmiId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AmiId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Architecture", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Architecture = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutoScalingType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AutoScalingType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AvailabilityZone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BlockDeviceMappings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<BlockDeviceMapping, BlockDeviceMappingUnmarshaller>(BlockDeviceMappingUnmarshaller.Instance);
                    unmarshalledObject.BlockDeviceMappings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreatedAt", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EbsOptimized", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EbsOptimized = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Ec2InstanceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Ec2InstanceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EcsClusterArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EcsClusterArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EcsContainerInstanceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EcsContainerInstanceArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ElasticIp", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ElasticIp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Hostname", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Hostname = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InfrastructureClass", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InfrastructureClass = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstallUpdatesOnBoot", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.InstallUpdatesOnBoot = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceProfileArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceProfileArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastServiceErrorId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastServiceErrorId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LayerIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.LayerIds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Os", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Os = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Platform", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Platform = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PrivateDns", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrivateDns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PrivateIp", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrivateIp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PublicDns", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PublicDns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PublicIp", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PublicIp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RegisteredBy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RegisteredBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReportedAgentVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReportedAgentVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReportedOs", targetDepth))
                {
                    var unmarshaller = ReportedOsUnmarshaller.Instance;
                    unmarshalledObject.ReportedOs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RootDeviceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RootDeviceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RootDeviceVolumeId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RootDeviceVolumeId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecurityGroupIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SecurityGroupIds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SshHostDsaKeyFingerprint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SshHostDsaKeyFingerprint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SshHostRsaKeyFingerprint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SshHostRsaKeyFingerprint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SshKeyName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SshKeyName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StackId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StackId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubnetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SubnetId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VirtualizationType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VirtualizationType = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static InstanceUnmarshaller _instance = new InstanceUnmarshaller();        

        public static InstanceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}