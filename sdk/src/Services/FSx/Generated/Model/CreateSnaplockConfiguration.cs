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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// Defines the SnapLock configuration when creating an FSx for ONTAP SnapLock volume.
    /// </summary>
    public partial class CreateSnaplockConfiguration
    {
        private bool? _auditLogVolume;
        private AutocommitPeriod _autocommitPeriod;
        private PrivilegedDelete _privilegedDelete;
        private SnaplockRetentionPeriod _retentionPeriod;
        private SnaplockType _snaplockType;
        private bool? _volumeAppendModeEnabled;

        /// <summary>
        /// Gets and sets the property AuditLogVolume. 
        /// <para>
        /// Enables or disables the audit log volume for an FSx for ONTAP SnapLock volume. The
        /// default value is <c>false</c>. If you set <c>AuditLogVolume</c> to <c>true</c>, the
        /// SnapLock volume is created as an audit log volume. The minimum retention period for
        /// an audit log volume is six months. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/how-snaplock-works.html#snaplock-audit-log-volume">
        /// SnapLock audit log volumes</a>. 
        /// </para>
        /// </summary>
        public bool? AuditLogVolume
        {
            get { return this._auditLogVolume; }
            set { this._auditLogVolume = value; }
        }

        // Check to see if AuditLogVolume property is set
        internal bool IsSetAuditLogVolume()
        {
            return this._auditLogVolume.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutocommitPeriod. 
        /// <para>
        /// The configuration object for setting the autocommit period of files in an FSx for
        /// ONTAP SnapLock volume. 
        /// </para>
        /// </summary>
        public AutocommitPeriod AutocommitPeriod
        {
            get { return this._autocommitPeriod; }
            set { this._autocommitPeriod = value; }
        }

        // Check to see if AutocommitPeriod property is set
        internal bool IsSetAutocommitPeriod()
        {
            return this._autocommitPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property PrivilegedDelete. 
        /// <para>
        /// Enables, disables, or permanently disables privileged delete on an FSx for ONTAP SnapLock
        /// Enterprise volume. Enabling privileged delete allows SnapLock administrators to delete
        /// WORM files even if they have active retention periods. <c>PERMANENTLY_DISABLED</c>
        /// is a terminal state. If privileged delete is permanently disabled on a SnapLock volume,
        /// you can't re-enable it. The default value is <c>DISABLED</c>. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/snaplock-enterprise.html#privileged-delete">Privileged
        /// delete</a>. 
        /// </para>
        /// </summary>
        public PrivilegedDelete PrivilegedDelete
        {
            get { return this._privilegedDelete; }
            set { this._privilegedDelete = value; }
        }

        // Check to see if PrivilegedDelete property is set
        internal bool IsSetPrivilegedDelete()
        {
            return this._privilegedDelete != null;
        }

        /// <summary>
        /// Gets and sets the property RetentionPeriod. 
        /// <para>
        /// Specifies the retention period of an FSx for ONTAP SnapLock volume. 
        /// </para>
        /// </summary>
        public SnaplockRetentionPeriod RetentionPeriod
        {
            get { return this._retentionPeriod; }
            set { this._retentionPeriod = value; }
        }

        // Check to see if RetentionPeriod property is set
        internal bool IsSetRetentionPeriod()
        {
            return this._retentionPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property SnaplockType. 
        /// <para>
        /// Specifies the retention mode of an FSx for ONTAP SnapLock volume. After it is set,
        /// it can't be changed. You can choose one of the following retention modes: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>COMPLIANCE</c>: Files transitioned to write once, read many (WORM) on a Compliance
        /// volume can't be deleted until their retention periods expire. This retention mode
        /// is used to address government or industry-specific mandates or to protect against
        /// ransomware attacks. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/snaplock-compliance.html">SnapLock
        /// Compliance</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENTERPRISE</c>: Files transitioned to WORM on an Enterprise volume can be deleted
        /// by authorized users before their retention periods expire using privileged delete.
        /// This retention mode is used to advance an organization's data integrity and internal
        /// compliance or to test retention settings before using SnapLock Compliance. For more
        /// information, see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/snaplock-enterprise.html">SnapLock
        /// Enterprise</a>. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public SnaplockType SnaplockType
        {
            get { return this._snaplockType; }
            set { this._snaplockType = value; }
        }

        // Check to see if SnaplockType property is set
        internal bool IsSetSnaplockType()
        {
            return this._snaplockType != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeAppendModeEnabled. 
        /// <para>
        /// Enables or disables volume-append mode on an FSx for ONTAP SnapLock volume. Volume-append
        /// mode allows you to create WORM-appendable files and write data to them incrementally.
        /// The default value is <c>false</c>. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/worm-state.html#worm-state-append">Volume-append
        /// mode</a>. 
        /// </para>
        /// </summary>
        public bool? VolumeAppendModeEnabled
        {
            get { return this._volumeAppendModeEnabled; }
            set { this._volumeAppendModeEnabled = value; }
        }

        // Check to see if VolumeAppendModeEnabled property is set
        internal bool IsSetVolumeAppendModeEnabled()
        {
            return this._volumeAppendModeEnabled.HasValue; 
        }

    }
}