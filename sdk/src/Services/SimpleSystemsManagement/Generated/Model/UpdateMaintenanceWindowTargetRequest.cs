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
    /// Container for the parameters to the UpdateMaintenanceWindowTarget operation.
    /// Modifies the target of an existing maintenance window. You can change the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Name
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Description
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Owner
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// IDs for an ID target
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Tags for a Tag target
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// From any supported tag type to another. The three supported tag types are ID target,
    /// Tag target, and resource group. For more information, see <a>Target</a>.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// If a parameter is null, then the corresponding field isn't modified.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateMaintenanceWindowTargetRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _description;
        private string _name;
        private string _ownerInformation;
        private bool? _replace;
        private List<Target> _targets = new List<Target>();
        private string _windowId;
        private string _windowTargetId;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the update.
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
        /// A name for the update.
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
        /// User-provided value that will be included in any Amazon CloudWatch Events events raised
        /// while running tasks for these targets in this maintenance window.
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
        /// Gets and sets the property Replace. 
        /// <para>
        /// If <code>True</code>, then all fields that are required by the <a>RegisterTargetWithMaintenanceWindow</a>
        /// operation are also required for this API request. Optional fields that aren't specified
        /// are set to null.
        /// </para>
        /// </summary>
        public bool Replace
        {
            get { return this._replace.GetValueOrDefault(); }
            set { this._replace = value; }
        }

        // Check to see if Replace property is set
        internal bool IsSetReplace()
        {
            return this._replace.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The targets to add or replace.
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
        /// The maintenance window ID with which to modify the target.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=20)]
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
        /// The target ID to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
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