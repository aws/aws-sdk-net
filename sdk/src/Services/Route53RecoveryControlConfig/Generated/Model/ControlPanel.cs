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
 * Do not modify this file. This file is generated from the route53-recovery-control-config-2020-11-02.normal.json service model.
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
namespace Amazon.Route53RecoveryControlConfig.Model
{
    /// <summary>
    /// A control panel represents a group of routing controls that can be changed together
    /// in a single transaction.
    /// </summary>
    public partial class ControlPanel
    {
        private string _clusterArn;
        private string _controlPanelArn;
        private bool? _defaultControlPanel;
        private string _name;
        private string _owner;
        private int? _routingControlCount;
        private Status _status;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster that includes the control panel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property ControlPanelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the control panel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ControlPanelArn
        {
            get { return this._controlPanelArn; }
            set { this._controlPanelArn = value; }
        }

        // Check to see if ControlPanelArn property is set
        internal bool IsSetControlPanelArn()
        {
            return this._controlPanelArn != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultControlPanel. 
        /// <para>
        /// A flag that Amazon Route 53 Application Recovery Controller sets to true to designate
        /// the default control panel for a cluster. When you create a cluster, Amazon Route 53
        /// Application Recovery Controller creates a control panel, and sets this flag for that
        /// control panel. If you create a control panel yourself, this flag is set to false.
        /// </para>
        /// </summary>
        public bool? DefaultControlPanel
        {
            get { return this._defaultControlPanel; }
            set { this._defaultControlPanel = value; }
        }

        // Check to see if DefaultControlPanel property is set
        internal bool IsSetDefaultControlPanel()
        {
            return this._defaultControlPanel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the control panel. You can use any non-white space character in the name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The Amazon Web Services account ID of the control panel owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property RoutingControlCount. 
        /// <para>
        /// The number of routing controls in the control panel.
        /// </para>
        /// </summary>
        public int? RoutingControlCount
        {
            get { return this._routingControlCount; }
            set { this._routingControlCount = value; }
        }

        // Check to see if RoutingControlCount property is set
        internal bool IsSetRoutingControlCount()
        {
            return this._routingControlCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The deployment status of control panel. Status can be one of the following: PENDING,
        /// DEPLOYED, PENDING_DELETION.
        /// </para>
        /// </summary>
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}