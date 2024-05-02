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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
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
namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEnvironment operation.
    /// Updates the configuration details for a specific runtime environment.
    /// </summary>
    public partial class UpdateEnvironmentRequest : AmazonMainframeModernizationRequest
    {
        private bool? _applyDuringMaintenanceWindow;
        private int? _desiredCapacity;
        private string _engineVersion;
        private string _environmentId;
        private bool? _forceUpdate;
        private string _instanceType;
        private string _preferredMaintenanceWindow;

        /// <summary>
        /// Gets and sets the property ApplyDuringMaintenanceWindow. 
        /// <para>
        /// Indicates whether to update the runtime environment during the maintenance window.
        /// The default is false. Currently, Amazon Web Services Mainframe Modernization accepts
        /// the <c>engineVersion</c> parameter only if <c>applyDuringMaintenanceWindow</c> is
        /// true. If any parameter other than <c>engineVersion</c> is provided in <c>UpdateEnvironmentRequest</c>,
        /// it will fail if <c>applyDuringMaintenanceWindow</c> is set to true.
        /// </para>
        /// </summary>
        public bool? ApplyDuringMaintenanceWindow
        {
            get { return this._applyDuringMaintenanceWindow; }
            set { this._applyDuringMaintenanceWindow = value; }
        }

        // Check to see if ApplyDuringMaintenanceWindow property is set
        internal bool IsSetApplyDuringMaintenanceWindow()
        {
            return this._applyDuringMaintenanceWindow.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DesiredCapacity. 
        /// <para>
        /// The desired capacity for the runtime environment to update. The minimum possible value
        /// is 0 and the maximum is 100.
        /// </para>
        /// </summary>
        public int? DesiredCapacity
        {
            get { return this._desiredCapacity; }
            set { this._desiredCapacity = value; }
        }

        // Check to see if DesiredCapacity property is set
        internal bool IsSetDesiredCapacity()
        {
            return this._desiredCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version of the runtime engine for the runtime environment.
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The unique identifier of the runtime environment that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property ForceUpdate. 
        /// <para>
        /// Forces the updates on the environment. This option is needed if the applications in
        /// the environment are not stopped or if there are ongoing application-related activities
        /// in the environment.
        /// </para>
        ///  
        /// <para>
        /// If you use this option, be aware that it could lead to data corruption in the applications,
        /// and that you might need to perform repair and recovery procedures for the applications.
        /// </para>
        ///  
        /// <para>
        /// This option is not needed if the attribute being updated is <c>preferredMaintenanceWindow</c>.
        /// </para>
        /// </summary>
        public bool? ForceUpdate
        {
            get { return this._forceUpdate; }
            set { this._forceUpdate = value; }
        }

        // Check to see if ForceUpdate property is set
        internal bool IsSetForceUpdate()
        {
            return this._forceUpdate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type for the runtime environment to update.
        /// </para>
        /// </summary>
        public string InstanceType
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
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// Configures the maintenance window that you want for the runtime environment. The maintenance
        /// window must have the format <c>ddd:hh24:mi-ddd:hh24:mi</c> and must be less than 24
        /// hours. The following two examples are valid maintenance windows: <c>sun:23:45-mon:00:15</c>
        /// or <c>sat:01:00-sat:03:00</c>. 
        /// </para>
        ///  
        /// <para>
        /// If you do not provide a value, a random system-generated value will be assigned.
        /// </para>
        /// </summary>
        public string PreferredMaintenanceWindow
        {
            get { return this._preferredMaintenanceWindow; }
            set { this._preferredMaintenanceWindow = value; }
        }

        // Check to see if PreferredMaintenanceWindow property is set
        internal bool IsSetPreferredMaintenanceWindow()
        {
            return this._preferredMaintenanceWindow != null;
        }

    }
}