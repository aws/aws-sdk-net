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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Lists a summary of the properties of an instance (also called a <i>node</i> interchangeably)
    /// of a SageMaker HyperPod cluster.
    /// </summary>
    public partial class ClusterNodeSummary
    {
        /// <summary>
        /// Gets and sets the property CurrentImageReleaseVersion. 
        /// <para>
        /// The version of the HyperPod-managed AMI currently running on the node.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 64)]
        public string CurrentImageReleaseVersion { get; set; }

        /// <summary>
        /// Checks to see if the CurrentImageReleaseVersion property is set.
        /// </summary>
        internal bool IsSetCurrentImageReleaseVersion() => this.CurrentImageReleaseVersion != null;

        /// <summary>
        /// Gets and sets the property ImageVersionStatus. 
        /// <para>
        /// The status of the image version for the cluster node.
        /// </para>
        /// </summary>
        public ClusterImageVersionStatus ImageVersionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ImageVersionStatus property is set.
        /// </summary>
        internal bool IsSetImageVersionStatus() => this.ImageVersionStatus != null;

        /// <summary>
        /// Gets and sets the property InstanceGroupName. 
        /// <para>
        /// The name of the instance group in which the instance is.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string InstanceGroupName { get; set; }

        /// <summary>
        /// Checks to see if the InstanceGroupName property is set.
        /// </summary>
        internal bool IsSetInstanceGroupName() => this.InstanceGroupName != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property InstanceStatus. 
        /// <para>
        /// The status of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ClusterInstanceStatusDetails InstanceStatus { get; set; }

        /// <summary>
        /// Checks to see if the InstanceStatus property is set.
        /// </summary>
        internal bool IsSetInstanceStatus() => this.InstanceStatus != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ClusterInstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property LastSoftwareUpdateTime. 
        /// <para>
        /// The time when SageMaker last updated the software of the instances in the cluster.
        /// </para>
        /// </summary>
        public DateTime? LastSoftwareUpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastSoftwareUpdateTime property is set.
        /// </summary>
        internal bool IsSetLastSoftwareUpdateTime() => this.LastSoftwareUpdateTime.HasValue;

        /// <summary>
        /// Gets and sets the property LaunchTime. 
        /// <para>
        /// The time when the instance is launched.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LaunchTime { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTime property is set.
        /// </summary>
        internal bool IsSetLaunchTime() => this.LaunchTime.HasValue;

        /// <summary>
        /// Gets and sets the property NodeLogicalId. 
        /// <para>
        /// A unique identifier for the node that persists throughout its lifecycle, from provisioning
        /// request to termination. This identifier can be used to track the node even before
        /// it has an assigned <c>InstanceId</c>. This field is only included when <c>IncludeNodeLogicalIds</c>
        /// is set to <c>True</c> in the <c>ListClusterNodes</c> request.
        /// </para>
        /// </summary>
        public string NodeLogicalId { get; set; }

        /// <summary>
        /// Checks to see if the NodeLogicalId property is set.
        /// </summary>
        internal bool IsSetNodeLogicalId() => this.NodeLogicalId != null;

        /// <summary>
        /// Gets and sets the property PrivateDnsHostname. 
        /// <para>
        /// The private DNS hostname of the SageMaker HyperPod cluster node.
        /// </para>
        /// </summary>
        public string PrivateDnsHostname { get; set; }

        /// <summary>
        /// Checks to see if the PrivateDnsHostname property is set.
        /// </summary>
        internal bool IsSetPrivateDnsHostname() => this.PrivateDnsHostname != null;

        /// <summary>
        /// Gets and sets the property UltraServerInfo. 
        /// <para>
        /// Contains information about the UltraServer.
        /// </para>
        /// </summary>
        public UltraServerInfo UltraServerInfo { get; set; }

        /// <summary>
        /// Checks to see if the UltraServerInfo property is set.
        /// </summary>
        internal bool IsSetUltraServerInfo() => this.UltraServerInfo != null;
    }
}
