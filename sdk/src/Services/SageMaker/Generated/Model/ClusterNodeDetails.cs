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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Details of an instance (also called a <i>node</i> interchangeably) in a SageMaker
    /// HyperPod cluster.
    /// </summary>
    public partial class ClusterNodeDetails
    {
        private string _instanceGroupName;
        private string _instanceId;
        private ClusterInstanceStatusDetails _instanceStatus;
        private List<ClusterInstanceStorageConfig> _instanceStorageConfigs = AWSConfigs.InitializeCollections ? new List<ClusterInstanceStorageConfig>() : null;
        private ClusterInstanceType _instanceType;
        private DateTime? _launchTime;
        private ClusterLifeCycleConfig _lifeCycleConfig;
        private VpcConfig _overrideVpcConfig;
        private ClusterInstancePlacement _placement;
        private string _privateDnsHostname;
        private string _privatePrimaryIp;
        private string _privatePrimaryIpv6;
        private int? _threadsPerCore;

        /// <summary>
        /// Gets and sets the property InstanceGroupName. 
        /// <para>
        /// The instance group name in which the instance is.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string InstanceGroupName
        {
            get { return this._instanceGroupName; }
            set { this._instanceGroupName = value; }
        }

        // Check to see if InstanceGroupName property is set
        internal bool IsSetInstanceGroupName()
        {
            return this._instanceGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceStatus. 
        /// <para>
        /// The status of the instance.
        /// </para>
        /// </summary>
        public ClusterInstanceStatusDetails InstanceStatus
        {
            get { return this._instanceStatus; }
            set { this._instanceStatus = value; }
        }

        // Check to see if InstanceStatus property is set
        internal bool IsSetInstanceStatus()
        {
            return this._instanceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceStorageConfigs. 
        /// <para>
        /// The configurations of additional storage specified to the instance group where the
        /// instance (node) is launched.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<ClusterInstanceStorageConfig> InstanceStorageConfigs
        {
            get { return this._instanceStorageConfigs; }
            set { this._instanceStorageConfigs = value; }
        }

        // Check to see if InstanceStorageConfigs property is set
        internal bool IsSetInstanceStorageConfigs()
        {
            return this._instanceStorageConfigs != null && (this._instanceStorageConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type of the instance.
        /// </para>
        /// </summary>
        public ClusterInstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchTime. 
        /// <para>
        /// The time when the instance is launched.
        /// </para>
        /// </summary>
        public DateTime? LaunchTime
        {
            get { return this._launchTime; }
            set { this._launchTime = value; }
        }

        // Check to see if LaunchTime property is set
        internal bool IsSetLaunchTime()
        {
            return this._launchTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LifeCycleConfig. 
        /// <para>
        /// The LifeCycle configuration applied to the instance.
        /// </para>
        /// </summary>
        public ClusterLifeCycleConfig LifeCycleConfig
        {
            get { return this._lifeCycleConfig; }
            set { this._lifeCycleConfig = value; }
        }

        // Check to see if LifeCycleConfig property is set
        internal bool IsSetLifeCycleConfig()
        {
            return this._lifeCycleConfig != null;
        }

        /// <summary>
        /// Gets and sets the property OverrideVpcConfig. 
        /// <para>
        /// The customized VPC configuration at the instance group level that overrides the default
        /// VPC configuration of the SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        public VpcConfig OverrideVpcConfig
        {
            get { return this._overrideVpcConfig; }
            set { this._overrideVpcConfig = value; }
        }

        // Check to see if OverrideVpcConfig property is set
        internal bool IsSetOverrideVpcConfig()
        {
            return this._overrideVpcConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Placement. 
        /// <para>
        /// The placement details of the SageMaker HyperPod cluster node.
        /// </para>
        /// </summary>
        public ClusterInstancePlacement Placement
        {
            get { return this._placement; }
            set { this._placement = value; }
        }

        // Check to see if Placement property is set
        internal bool IsSetPlacement()
        {
            return this._placement != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateDnsHostname. 
        /// <para>
        /// The private DNS hostname of the SageMaker HyperPod cluster node.
        /// </para>
        /// </summary>
        public string PrivateDnsHostname
        {
            get { return this._privateDnsHostname; }
            set { this._privateDnsHostname = value; }
        }

        // Check to see if PrivateDnsHostname property is set
        internal bool IsSetPrivateDnsHostname()
        {
            return this._privateDnsHostname != null;
        }

        /// <summary>
        /// Gets and sets the property PrivatePrimaryIp. 
        /// <para>
        /// The private primary IP address of the SageMaker HyperPod cluster node.
        /// </para>
        /// </summary>
        public string PrivatePrimaryIp
        {
            get { return this._privatePrimaryIp; }
            set { this._privatePrimaryIp = value; }
        }

        // Check to see if PrivatePrimaryIp property is set
        internal bool IsSetPrivatePrimaryIp()
        {
            return this._privatePrimaryIp != null;
        }

        /// <summary>
        /// Gets and sets the property PrivatePrimaryIpv6. 
        /// <para>
        /// The private primary IPv6 address of the SageMaker HyperPod cluster node when configured
        /// with an Amazon VPC that supports IPv6 and includes subnets with IPv6 addressing enabled
        /// in either the cluster VPC configuration or the instance group VPC configuration.
        /// </para>
        /// </summary>
        public string PrivatePrimaryIpv6
        {
            get { return this._privatePrimaryIpv6; }
            set { this._privatePrimaryIpv6 = value; }
        }

        // Check to see if PrivatePrimaryIpv6 property is set
        internal bool IsSetPrivatePrimaryIpv6()
        {
            return this._privatePrimaryIpv6 != null;
        }

        /// <summary>
        /// Gets and sets the property ThreadsPerCore. 
        /// <para>
        /// The number of threads per CPU core you specified under <c>CreateCluster</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public int? ThreadsPerCore
        {
            get { return this._threadsPerCore; }
            set { this._threadsPerCore = value; }
        }

        // Check to see if ThreadsPerCore property is set
        internal bool IsSetThreadsPerCore()
        {
            return this._threadsPerCore.HasValue; 
        }

    }
}