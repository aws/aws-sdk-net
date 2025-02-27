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
    /// Container for the parameters to the RestoreSnapshotTier operation.
    /// Restores an archived Amazon EBS snapshot for use temporarily or permanently, or modifies
    /// the restore period or restore type for a snapshot that was previously temporarily
    /// restored.
    /// 
    ///  
    /// <para>
    /// For more information see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/working-with-snapshot-archiving.html#restore-archived-snapshot">
    /// Restore an archived snapshot</a> and <a href="https://docs.aws.amazon.com/ebs/latest/userguide/working-with-snapshot-archiving.html#modify-temp-restore-period">
    /// modify the restore period or restore type for a temporarily restored snapshot</a>
    /// in the <i>Amazon EBS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class RestoreSnapshotTierRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private bool? _permanentRestore;
        private string _snapshotId;
        private int? _temporaryRestoreDays;

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
        /// Gets and sets the property PermanentRestore. 
        /// <para>
        /// Indicates whether to permanently restore an archived snapshot. To permanently restore
        /// an archived snapshot, specify <c>true</c> and omit the <b>RestoreSnapshotTierRequest$TemporaryRestoreDays</b>
        /// parameter.
        /// </para>
        /// </summary>
        public bool? PermanentRestore
        {
            get { return this._permanentRestore; }
            set { this._permanentRestore = value; }
        }

        // Check to see if PermanentRestore property is set
        internal bool IsSetPermanentRestore()
        {
            return this._permanentRestore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the snapshot to restore.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SnapshotId
        {
            get { return this._snapshotId; }
            set { this._snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this._snapshotId != null;
        }

        /// <summary>
        /// Gets and sets the property TemporaryRestoreDays. 
        /// <para>
        /// Specifies the number of days for which to temporarily restore an archived snapshot.
        /// Required for temporary restores only. The snapshot will be automatically re-archived
        /// after this period.
        /// </para>
        ///  
        /// <para>
        /// To temporarily restore an archived snapshot, specify the number of days and omit the
        /// <b>PermanentRestore</b> parameter or set it to <c>false</c>.
        /// </para>
        /// </summary>
        public int? TemporaryRestoreDays
        {
            get { return this._temporaryRestoreDays; }
            set { this._temporaryRestoreDays = value; }
        }

        // Check to see if TemporaryRestoreDays property is set
        internal bool IsSetTemporaryRestoreDays()
        {
            return this._temporaryRestoreDays.HasValue; 
        }

    }
}