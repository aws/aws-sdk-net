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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyInstanceMaintenanceOptions operation.
    /// Modifies the recovery behavior of your instance to disable simplified automatic recovery
    /// or set the recovery behavior to default. The default configuration will not enable
    /// simplified automatic recovery for an unsupported instance type. For more information,
    /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-recover.html#instance-configuration-recovery">Simplified
    /// automatic recovery</a>.
    /// 
    ///  
    /// <para>
    /// Modifies the reboot migration behavior during a user-initiated reboot of an instance
    /// that has a pending <c>system-reboot</c> event. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/schedevents_actions_reboot.html#reboot-migration">Enable
    /// or disable reboot migration</a>.
    /// </para>
    /// </summary>
    public partial class ModifyInstanceMaintenanceOptionsRequest : AmazonEC2Request
    {
        private InstanceAutoRecoveryState _autoRecovery;
        private bool? _dryRun;
        private string _instanceId;
        private InstanceRebootMigrationState _rebootMigration;

        /// <summary>
        /// Gets and sets the property AutoRecovery. 
        /// <para>
        /// Disables the automatic recovery behavior of your instance or sets it to default.
        /// </para>
        /// </summary>
        public InstanceAutoRecoveryState AutoRecovery
        {
            get { return this._autoRecovery; }
            set { this._autoRecovery = value; }
        }

        // Check to see if AutoRecovery property is set
        internal bool IsSetAutoRecovery()
        {
            return this._autoRecovery != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
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
        /// Gets and sets the property RebootMigration. 
        /// <para>
        /// Specifies whether to attempt reboot migration during a user-initiated reboot of an
        /// instance that has a scheduled <c>system-reboot</c> event:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>default</c> - Amazon EC2 attempts to migrate the instance to new hardware (reboot
        /// migration). If successful, the <c>system-reboot</c> event is cleared. If unsuccessful,
        /// an in-place reboot occurs and the event remains scheduled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>disabled</c> - Amazon EC2 keeps the instance on the same hardware (in-place reboot).
        /// The <c>system-reboot</c> event remains scheduled.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This setting only applies to supported instances that have a scheduled reboot event.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/schedevents_actions_reboot.html#reboot-migration">Enable
        /// or disable reboot migration</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public InstanceRebootMigrationState RebootMigration
        {
            get { return this._rebootMigration; }
            set { this._rebootMigration = value; }
        }

        // Check to see if RebootMigration property is set
        internal bool IsSetRebootMigration()
        {
            return this._rebootMigration != null;
        }

    }
}