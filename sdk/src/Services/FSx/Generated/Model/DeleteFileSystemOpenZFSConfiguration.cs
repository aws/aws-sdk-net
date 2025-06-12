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
    /// The configuration object for the Amazon FSx for OpenZFS file system used in the <c>DeleteFileSystem</c>
    /// operation.
    /// </summary>
    public partial class DeleteFileSystemOpenZFSConfiguration
    {
        private List<Tag> _finalBackupTags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private List<string> _options = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _skipFinalBackup;

        /// <summary>
        /// Gets and sets the property FinalBackupTags. 
        /// <para>
        /// A list of tags to apply to the file system's final backup.
        /// </para>
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
        /// Gets and sets the property Options. 
        /// <para>
        /// To delete a file system if there are child volumes present below the root volume,
        /// use the string <c>DELETE_CHILD_VOLUMES_AND_SNAPSHOTS</c>. If your file system has
        /// child volumes and you don't use this option, the delete request will fail.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=1)]
        public List<string> Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null && (this._options.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SkipFinalBackup. 
        /// <para>
        /// By default, Amazon FSx for OpenZFS takes a final backup on your behalf when the <c>DeleteFileSystem</c>
        /// operation is invoked. Doing this helps protect you from data loss, and we highly recommend
        /// taking the final backup. If you want to skip taking a final backup, set this value
        /// to <c>true</c>.
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