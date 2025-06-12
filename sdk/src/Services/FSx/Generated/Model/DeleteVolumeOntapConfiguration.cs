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
    /// Use to specify skipping a final backup, adding tags to a final backup, or bypassing
    /// the retention period of an FSx for ONTAP SnapLock Enterprise volume when deleting
    /// an FSx for ONTAP volume.
    /// </summary>
    public partial class DeleteVolumeOntapConfiguration
    {
        private bool? _bypassSnaplockEnterpriseRetention;
        private List<Tag> _finalBackupTags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private bool? _skipFinalBackup;

        /// <summary>
        /// Gets and sets the property BypassSnaplockEnterpriseRetention. 
        /// <para>
        /// Setting this to <c>true</c> allows a SnapLock administrator to delete an FSx for ONTAP
        /// SnapLock Enterprise volume with unexpired write once, read many (WORM) files. The
        /// IAM permission <c>fsx:BypassSnaplockEnterpriseRetention</c> is also required to delete
        /// SnapLock Enterprise volumes with unexpired WORM files. The default value is <c>false</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/snaplock-delete-volume.html">
        /// Deleting a SnapLock volume</a>. 
        /// </para>
        /// </summary>
        public bool? BypassSnaplockEnterpriseRetention
        {
            get { return this._bypassSnaplockEnterpriseRetention; }
            set { this._bypassSnaplockEnterpriseRetention = value; }
        }

        // Check to see if BypassSnaplockEnterpriseRetention property is set
        internal bool IsSetBypassSnaplockEnterpriseRetention()
        {
            return this._bypassSnaplockEnterpriseRetention.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FinalBackupTags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> FinalBackupTags
        {
            get { return this._finalBackupTags; }
            set { this._finalBackupTags = value; }
        }

        // Check to see if FinalBackupTags property is set
        internal bool IsSetFinalBackupTags()
        {
            return this._finalBackupTags != null && (this._finalBackupTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SkipFinalBackup. 
        /// <para>
        /// Set to true if you want to skip taking a final backup of the volume you are deleting.
        /// </para>
        /// </summary>
        public bool? SkipFinalBackup
        {
            get { return this._skipFinalBackup; }
            set { this._skipFinalBackup = value; }
        }

        // Check to see if SkipFinalBackup property is set
        internal bool IsSetSkipFinalBackup()
        {
            return this._skipFinalBackup.HasValue; 
        }

    }
}