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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the CopyBackup operation.
    /// Copies an existing backup within the same Amazon Web Services account to another Amazon
    /// Web Services Region (cross-Region copy) or within the same Amazon Web Services Region
    /// (in-Region copy). You can have up to five backup copy requests in progress to a single
    /// destination Region per account.
    /// 
    ///  
    /// <para>
    /// You can use cross-Region backup copies for cross-region disaster recovery. You periodically
    /// take backups and copy them to another Region so that in the event of a disaster in
    /// the primary Region, you can restore from backup and recover availability quickly in
    /// the other Region. You can make cross-Region copies only within your Amazon Web Services
    /// partition.
    /// </para>
    ///  
    /// <para>
    ///  You can also use backup copies to clone your file data set to another Region or within
    /// the same Region.
    /// </para>
    ///  
    /// <para>
    /// You can use the <code>SourceRegion</code> parameter to specify the Amazon Web Services
    /// Region from which the backup will be copied. For example, if you make the call from
    /// the <code>us-west-1</code> Region and want to copy a backup from the <code>us-east-2</code>
    /// Region, you specify <code>us-east-2</code> in the <code>SourceRegion</code> parameter
    /// to make a cross-Region copy. If you don't specify a Region, the backup copy is created
    /// in the same Region where the request is sent from (in-Region copy).
    /// </para>
    ///  
    /// <para>
    /// For more information on creating backup copies, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/using-backups.html#copy-backups">
    /// Copying backups</a> in the <i>Amazon FSx for Windows User Guide</i> and <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/using-backups-fsx.html#copy-backups">Copying
    /// backups</a> in the <i>Amazon FSx for Lustre User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CopyBackupRequest : AmazonFSxRequest
    {
        private string _clientRequestToken;
        private bool? _copyTags;
        private string _kmsKeyId;
        private string _sourceBackupId;
        private string _sourceRegion;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property CopyTags. 
        /// <para>
        /// A boolean flag indicating whether tags from the source backup should be copied to
        /// the backup copy. This value defaults to false.
        /// </para>
        ///  
        /// <para>
        /// If you set <code>CopyTags</code> to true and the source backup has existing tags,
        /// you can use the <code>Tags</code> parameter to create new tags, provided that the
        /// sum of the source backup tags and the new tags doesn't exceed 50. Both sets of tags
        /// are merged. If there are tag conflicts (for example, two tags with the same key but
        /// different values), the tags created with the <code>Tags</code> parameter take precedence.
        /// </para>
        /// </summary>
        public bool CopyTags
        {
            get { return this._copyTags.GetValueOrDefault(); }
            set { this._copyTags = value; }
        }

        // Check to see if CopyTags property is set
        internal bool IsSetCopyTags()
        {
            return this._copyTags.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId.
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceBackupId. 
        /// <para>
        /// The ID of the source backup. Specifies the ID of the backup that is being copied.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=128)]
        public string SourceBackupId
        {
            get { return this._sourceBackupId; }
            set { this._sourceBackupId = value; }
        }

        // Check to see if SourceBackupId property is set
        internal bool IsSetSourceBackupId()
        {
            return this._sourceBackupId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceRegion. 
        /// <para>
        /// The source Amazon Web Services Region of the backup. Specifies the Amazon Web Services
        /// Region from which the backup is being copied. The source and destination Regions must
        /// be in the same Amazon Web Services partition. If you don't specify a Region, it defaults
        /// to the Region where the request is sent from (in-Region copy).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string SourceRegion
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
        /// Gets and sets the property Tags.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}