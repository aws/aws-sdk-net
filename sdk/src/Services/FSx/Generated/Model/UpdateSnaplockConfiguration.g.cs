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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Updates the SnapLock configuration for an existing FSx for ONTAP volume.
    /// </summary>
    public partial class UpdateSnaplockConfiguration
    {
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
        public bool? AuditLogVolume { get; set; }

        /// <summary>
        /// Checks to see if the AuditLogVolume property is set.
        /// </summary>
        internal bool IsSetAuditLogVolume() => this.AuditLogVolume.HasValue;

        /// <summary>
        /// Gets and sets the property AutocommitPeriod. 
        /// <para>
        /// The configuration object for setting the autocommit period of files in an FSx for
        /// ONTAP SnapLock volume. 
        /// </para>
        /// </summary>
        public AutocommitPeriod AutocommitPeriod { get; set; }

        /// <summary>
        /// Checks to see if the AutocommitPeriod property is set.
        /// </summary>
        internal bool IsSetAutocommitPeriod() => this.AutocommitPeriod != null;

        /// <summary>
        /// Gets and sets the property PrivilegedDelete. 
        /// <para>
        /// Enables, disables, or permanently disables privileged delete on an FSx for ONTAP SnapLock
        /// Enterprise volume. Enabling privileged delete allows SnapLock administrators to delete
        /// write once, read many (WORM) files even if they have active retention periods. <c>PERMANENTLY_DISABLED</c>
        /// is a terminal state. If privileged delete is permanently disabled on a SnapLock volume,
        /// you can't re-enable it. The default value is <c>DISABLED</c>. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/snaplock-enterprise.html#privileged-delete">Privileged
        /// delete</a>. 
        /// </para>
        /// </summary>
        public PrivilegedDelete PrivilegedDelete { get; set; }

        /// <summary>
        /// Checks to see if the PrivilegedDelete property is set.
        /// </summary>
        internal bool IsSetPrivilegedDelete() => this.PrivilegedDelete != null;

        /// <summary>
        /// Gets and sets the property RetentionPeriod. 
        /// <para>
        /// Specifies the retention period of an FSx for ONTAP SnapLock volume. 
        /// </para>
        /// </summary>
        public SnaplockRetentionPeriod RetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the RetentionPeriod property is set.
        /// </summary>
        internal bool IsSetRetentionPeriod() => this.RetentionPeriod != null;

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
        public bool? VolumeAppendModeEnabled { get; set; }

        /// <summary>
        /// Checks to see if the VolumeAppendModeEnabled property is set.
        /// </summary>
        internal bool IsSetVolumeAppendModeEnabled() => this.VolumeAppendModeEnabled.HasValue;
    }
}
