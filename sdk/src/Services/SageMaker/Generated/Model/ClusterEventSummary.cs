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
    /// A summary of an event in a HyperPod cluster.
    /// </summary>
    public partial class ClusterEventSummary
    {
        private string _clusterArn;
        private string _clusterName;
        private string _description;
        private string _eventId;
        private DateTime? _eventTime;
        private string _instanceGroupName;
        private string _instanceId;
        private ClusterEventResourceType _resourceType;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the HyperPod cluster associated with the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the HyperPod cluster associated with the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief, human-readable description of the event.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The unique identifier (UUID) of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EventId
        {
            get { return this._eventId; }
            set { this._eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this._eventId != null;
        }

        /// <summary>
        /// Gets and sets the property EventTime. 
        /// <para>
        /// The timestamp when the event occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EventTime
        {
            get { return this._eventTime; }
            set { this._eventTime = value; }
        }

        // Check to see if EventTime property is set
        internal bool IsSetEventTime()
        {
            return this._eventTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceGroupName. 
        /// <para>
        /// The name of the instance group associated with the event, if applicable.
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
        /// The Amazon Elastic Compute Cloud (EC2) instance ID associated with the event, if applicable.
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
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource associated with the event. Valid values are <c>Cluster</c>, <c>InstanceGroup</c>,
        /// or <c>Instance</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClusterEventResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}