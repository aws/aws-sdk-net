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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// The target registered with the maintenance window.
    /// </summary>
    public partial class MaintenanceWindowTarget
    {
        private string _description;
        private string _name;
        private string _ownerInformation;
        private MaintenanceWindowResourceType _resourceType;
        private List<Target> _targets = new List<Target>();
        private string _windowId;
        private string _windowTargetId;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the target.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the maintenance window target.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=128)]
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
        /// Gets and sets the property OwnerInformation. 
        /// <para>
        /// A user-provided value that will be included in any Amazon CloudWatch Events events
        /// that are raised while running tasks for these targets in this maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string OwnerInformation
        {
            get { return this._ownerInformation; }
            set { this._ownerInformation = value; }
        }

        // Check to see if OwnerInformation property is set
        internal bool IsSetOwnerInformation()
        {
            return this._ownerInformation != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of target that is being registered with the maintenance window.
        /// </para>
        /// </summary>
        public MaintenanceWindowResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The targets, either managed nodes or tags.
        /// </para>
        ///  
        /// <para>
        /// Specify managed nodes using the following format:
        /// </para>
        ///  
        /// <para>
        ///  <code>Key=instanceids,Values=&lt;instanceid1&gt;,&lt;instanceid2&gt;</code> 
        /// </para>
        ///  
        /// <para>
        /// Tags are specified using the following format:
        /// </para>
        ///  
        /// <para>
        ///  <code>Key=&lt;tag name&gt;,Values=&lt;tag value&gt;</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<Target> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && this._targets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WindowId. 
        /// <para>
        /// The ID of the maintenance window to register the target with.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=20)]
        public string WindowId
        {
            get { return this._windowId; }
            set { this._windowId = value; }
        }

        // Check to see if WindowId property is set
        internal bool IsSetWindowId()
        {
            return this._windowId != null;
        }

        /// <summary>
        /// Gets and sets the property WindowTargetId. 
        /// <para>
        /// The ID of the target.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string WindowTargetId
        {
            get { return this._windowTargetId; }
            set { this._windowTargetId = value; }
        }

        // Check to see if WindowTargetId property is set
        internal bool IsSetWindowTargetId()
        {
            return this._windowTargetId != null;
        }

    }
}