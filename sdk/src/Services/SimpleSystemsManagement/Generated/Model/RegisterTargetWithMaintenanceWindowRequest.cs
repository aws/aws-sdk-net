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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterTargetWithMaintenanceWindow operation.
    /// Registers a target with a Maintenance Window.
    /// </summary>
    public partial class RegisterTargetWithMaintenanceWindowRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _clientToken;
        private string _description;
        private string _name;
        private string _ownerInformation;
        private MaintenanceWindowResourceType _resourceType;
        private List<Target> _targets = new List<Target>();
        private string _windowId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// User-provided idempotency token.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the target.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// An optional name for the target.
        /// </para>
        /// </summary>
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
        /// User-provided value that will be included in any CloudWatch events raised while running
        /// tasks for these targets in this Maintenance Window.
        /// </para>
        /// </summary>
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
        /// The type of target being registered with the Maintenance Window.
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
        /// The targets (either instances or tags). 
        /// </para>
        ///  
        /// <para>
        /// Specify instances using the following format:
        /// </para>
        ///  
        /// <para>
        ///  <code>Key=InstanceIds,Values=&lt;instance-id-1&gt;,&lt;instance-id-2&gt;</code> 
        /// </para>
        ///  
        /// <para>
        /// Specify tags using either of the following formats:
        /// </para>
        ///  
        /// <para>
        ///  <code>Key=tag:&lt;tag-key&gt;,Values=&lt;tag-value-1&gt;,&lt;tag-value-2&gt;</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>Key=tag-key,Values=&lt;tag-key-1&gt;,&lt;tag-key-2&gt;</code> 
        /// </para>
        /// </summary>
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
        /// The ID of the Maintenance Window the target should be registered with.
        /// </para>
        /// </summary>
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

    }
}