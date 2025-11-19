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

#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Cluster Object
    /// </summary>  
    public class ClusterUnmarshaller : IUnmarshaller<Cluster, XmlUnmarshallerContext>, IUnmarshaller<Cluster, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Cluster IUnmarshaller<Cluster, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Cluster Unmarshall(JsonUnmarshallerContext context)
        {
            Cluster unmarshalledObject = new Cluster();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Applications", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Application, ApplicationUnmarshaller>(ApplicationUnmarshaller.Instance);
                    unmarshalledObject.Applications = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutoScalingRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AutoScalingRole = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutoTerminate", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AutoTerminate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClusterArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClusterArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Configurations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Configuration, ConfigurationUnmarshaller>(ConfigurationUnmarshaller.Instance);
                    unmarshalledObject.Configurations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomAmiId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CustomAmiId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EbsRootVolumeIops", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.EbsRootVolumeIops = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EbsRootVolumeSize", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.EbsRootVolumeSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EbsRootVolumeThroughput", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.EbsRootVolumeThroughput = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Ec2InstanceAttributes", targetDepth))
                {
                    var unmarshaller = Ec2InstanceAttributesUnmarshaller.Instance;
                    unmarshalledObject.Ec2InstanceAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExtendedSupport", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ExtendedSupport = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceCollectionType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceCollectionType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KerberosAttributes", targetDepth))
                {
                    var unmarshaller = KerberosAttributesUnmarshaller.Instance;
                    unmarshalledObject.KerberosAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LogEncryptionKmsKeyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogEncryptionKmsKeyId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LogUri", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogUri = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MasterPublicDnsName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MasterPublicDnsName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MonitoringConfiguration", targetDepth))
                {
                    var unmarshaller = MonitoringConfigurationUnmarshaller.Instance;
                    unmarshalledObject.MonitoringConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NormalizedInstanceHours", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NormalizedInstanceHours = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OSReleaseLabel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OSReleaseLabel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OutpostArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OutpostArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PlacementGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PlacementGroupConfig, PlacementGroupConfigUnmarshaller>(PlacementGroupConfigUnmarshaller.Instance);
                    unmarshalledObject.PlacementGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReleaseLabel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReleaseLabel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RepoUpgradeOnBoot", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RepoUpgradeOnBoot = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RequestedAmiVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RequestedAmiVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RunningAmiVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RunningAmiVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScaleDownBehavior", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScaleDownBehavior = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecurityConfiguration", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecurityConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceRole = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = ClusterStatusUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StepConcurrencyLevel", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.StepConcurrencyLevel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Tags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TerminationProtected", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.TerminationProtected = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UnhealthyNodeReplacement", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UnhealthyNodeReplacement = unmarshaller.Unmarshall(context);
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


        private static ClusterUnmarshaller _instance = new ClusterUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ClusterUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}