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
    /// Lists a summary of the properties of an instance (also called a <i>node</i> interchangeably)
    /// of a SageMaker HyperPod cluster.
    /// </summary>
    public partial class ClusterNodeSummary
    {
        private string _instanceGroupName;
        private string _instanceId;
        private ClusterInstanceStatusDetails _instanceStatus;
        private ClusterInstanceType _instanceType;
        private DateTime? _lastSoftwareUpdateTime;
        private DateTime? _launchTime;
        private string _nodeLogicalId;
        private UltraServerInfo _ultraServerInfo;

        /// <summary>
        /// Gets and sets the property InstanceGroupName. 
        /// <para>
        /// The name of the instance group in which the instance is.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property LastSoftwareUpdateTime. 
        /// <para>
        /// The time when SageMaker last updated the software of the instances in the cluster.
        /// </para>
        /// </summary>
        public DateTime? LastSoftwareUpdateTime
        {
            get { return this._lastSoftwareUpdateTime; }
            set { this._lastSoftwareUpdateTime = value; }
        }

        // Check to see if LastSoftwareUpdateTime property is set
        internal bool IsSetLastSoftwareUpdateTime()
        {
            return this._lastSoftwareUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LaunchTime. 
        /// <para>
        /// The time when the instance is launched.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property NodeLogicalId. 
        /// <para>
        /// A unique identifier for the node that persists throughout its lifecycle, from provisioning
        /// request to termination. This identifier can be used to track the node even before
        /// it has an assigned <c>InstanceId</c>. This field is only included when <c>IncludeNodeLogicalIds</c>
        /// is set to <c>True</c> in the <c>ListClusterNodes</c> request.
        /// </para>
        /// </summary>
        public string NodeLogicalId
        {
            get { return this._nodeLogicalId; }
            set { this._nodeLogicalId = value; }
        }

        // Check to see if NodeLogicalId property is set
        internal bool IsSetNodeLogicalId()
        {
            return this._nodeLogicalId != null;
        }

        /// <summary>
        /// Gets and sets the property UltraServerInfo. 
        /// <para>
        /// Contains information about the UltraServer.
        /// </para>
        /// </summary>
        public UltraServerInfo UltraServerInfo
        {
            get { return this._ultraServerInfo; }
            set { this._ultraServerInfo = value; }
        }

        // Check to see if UltraServerInfo property is set
        internal bool IsSetUltraServerInfo()
        {
            return this._ultraServerInfo != null;
        }

    }
}