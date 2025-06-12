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
    /// The configuration object for the Amazon FSx for Lustre file system being deleted in
    /// the <c>DeleteFileSystem</c> operation.
    /// </summary>
    public partial class DeleteFileSystemLustreConfiguration
    {
        private List<Tag> _finalBackupTags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private bool? _skipFinalBackup;

        /// <summary>
        /// Gets and sets the property FinalBackupTags. 
        /// <para>
        /// Use if <c>SkipFinalBackup</c> is set to <c>false</c>, and you want to apply an array
        /// of tags to the final backup. If you have set the file system property <c>CopyTagsToBackups</c>
        /// to true, and you specify one or more <c>FinalBackupTags</c> when deleting a file system,
        /// Amazon FSx will not copy any existing file system tags to the backup.
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
        /// Gets and sets the property SkipFinalBackup. 
        /// <para>
        /// Set <c>SkipFinalBackup</c> to false if you want to take a final backup of the file
        /// system you are deleting. By default, Amazon FSx will not take a final backup on your
        /// behalf when the <c>DeleteFileSystem</c> operation is invoked. (Default = true)
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>fsx:CreateBackup</c> permission is required if you set <c>SkipFinalBackup</c>
        /// to <c>false</c> in order to delete the file system and take a final backup.
        /// </para>
        ///  </note>
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