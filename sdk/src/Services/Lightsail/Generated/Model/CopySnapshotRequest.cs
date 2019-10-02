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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the CopySnapshot operation.
    /// Copies a manual instance or disk snapshot as another manual snapshot, or copies an
    /// automatic instance or disk snapshot as a manual snapshot. This operation can also
    /// be used to copy a manual or automatic snapshot of an instance or a disk from one AWS
    /// Region to another in Amazon Lightsail.
    /// 
    ///  
    /// <para>
    /// When copying a <i>manual snapshot</i>, be sure to define the <code>source region</code>,
    /// <code>source snapshot name</code>, and <code>target snapshot name</code> parameters.
    /// </para>
    ///  
    /// <para>
    /// When copying an <i>automatic snapshot</i>, be sure to define the <code>source region</code>,
    /// <code>source resource name</code>, <code>target snapshot name</code>, and either the
    /// <code>restore date</code> or the <code>use latest restorable auto snapshot</code>
    /// parameters.
    /// </para>
    ///  <note> 
    /// <para>
    /// Database snapshots cannot be copied at this time.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CopySnapshotRequest : AmazonLightsailRequest
    {
        private string _restoreDate;
        private RegionName _sourceRegion;
        private string _sourceResourceName;
        private string _sourceSnapshotName;
        private string _targetSnapshotName;
        private bool? _useLatestRestorableAutoSnapshot;

        /// <summary>
        /// Gets and sets the property RestoreDate. 
        /// <para>
        /// The date of the automatic snapshot to copy for the new manual snapshot.
        /// </para>
        ///  
        /// <para>
        /// Use the <code>get auto snapshots</code> operation to identify the dates of the available
        /// automatic snapshots.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be specified in <code>YYYY-MM-DD</code> format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This parameter cannot be defined together with the <code>use latest restorable auto
        /// snapshot</code> parameter. The <code>restore date</code> and <code>use latest restorable
        /// auto snapshot</code> parameters are mutually exclusive.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Define this parameter only when copying an automatic snapshot as a manual snapshot.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-configuring-automatic-snapshots">Lightsail
        /// Dev Guide</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public string RestoreDate
        {
            get { return this._restoreDate; }
            set { this._restoreDate = value; }
        }

        // Check to see if RestoreDate property is set
        internal bool IsSetRestoreDate()
        {
            return this._restoreDate != null;
        }

        /// <summary>
        /// Gets and sets the property SourceRegion. 
        /// <para>
        /// The AWS Region where the source manual or automatic snapshot is located.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RegionName SourceRegion
        {
            get { return this._sourceRegion; }
            set { this._sourceRegion = value; }
        }

        // Check to see if SourceRegion property is set
        internal bool IsSetSourceRegion()
        {
            return this._sourceRegion != null;
        }

        /// <summary>
        /// Gets and sets the property SourceResourceName. 
        /// <para>
        /// The name of the source resource from which the automatic snapshot was created.
        /// </para>
        ///  <note> 
        /// <para>
        /// Define this parameter only when copying an automatic snapshot as a manual snapshot.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-configuring-automatic-snapshots">Lightsail
        /// Dev Guide</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public string SourceResourceName
        {
            get { return this._sourceResourceName; }
            set { this._sourceResourceName = value; }
        }

        // Check to see if SourceResourceName property is set
        internal bool IsSetSourceResourceName()
        {
            return this._sourceResourceName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceSnapshotName. 
        /// <para>
        /// The name of the source instance or disk snapshot to be copied.
        /// </para>
        ///  <note> 
        /// <para>
        /// Define this parameter only when copying a manual snapshot as another manual snapshot.
        /// </para>
        ///  </note>
        /// </summary>
        public string SourceSnapshotName
        {
            get { return this._sourceSnapshotName; }
            set { this._sourceSnapshotName = value; }
        }

        // Check to see if SourceSnapshotName property is set
        internal bool IsSetSourceSnapshotName()
        {
            return this._sourceSnapshotName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetSnapshotName. 
        /// <para>
        /// The name of the new instance or disk snapshot to be created as a copy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetSnapshotName
        {
            get { return this._targetSnapshotName; }
            set { this._targetSnapshotName = value; }
        }

        // Check to see if TargetSnapshotName property is set
        internal bool IsSetTargetSnapshotName()
        {
            return this._targetSnapshotName != null;
        }

        /// <summary>
        /// Gets and sets the property UseLatestRestorableAutoSnapshot. 
        /// <para>
        /// A Boolean value to indicate whether to use the latest available automatic snapshot.
        /// </para>
        ///  
        /// <para>
        /// This parameter cannot be defined together with the <code>restore date</code> parameter.
        /// The <code>use latest restorable auto snapshot</code> and <code>restore date</code>
        /// parameters are mutually exclusive.
        /// </para>
        ///  <note> 
        /// <para>
        /// Define this parameter only when copying an automatic snapshot as a manual snapshot.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-configuring-automatic-snapshots">Lightsail
        /// Dev Guide</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public bool UseLatestRestorableAutoSnapshot
        {
            get { return this._useLatestRestorableAutoSnapshot.GetValueOrDefault(); }
            set { this._useLatestRestorableAutoSnapshot = value; }
        }

        // Check to see if UseLatestRestorableAutoSnapshot property is set
        internal bool IsSetUseLatestRestorableAutoSnapshot()
        {
            return this._useLatestRestorableAutoSnapshot.HasValue; 
        }

    }
}