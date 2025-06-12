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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
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
namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// If AUTOMERGE is the conflict resolution strategy, a list of inputs to use when resolving
    /// conflicts during a merge.
    /// </summary>
    public partial class ConflictResolution
    {
        private List<DeleteFileEntry> _deleteFiles = AWSConfigs.InitializeCollections ? new List<DeleteFileEntry>() : null;
        private List<ReplaceContentEntry> _replaceContents = AWSConfigs.InitializeCollections ? new List<ReplaceContentEntry>() : null;
        private List<SetFileModeEntry> _setFileModes = AWSConfigs.InitializeCollections ? new List<SetFileModeEntry>() : null;

        /// <summary>
        /// Gets and sets the property DeleteFiles. 
        /// <para>
        /// Files to be deleted as part of the merge conflict resolution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeleteFileEntry> DeleteFiles
        {
            get { return this._deleteFiles; }
            set { this._deleteFiles = value; }
        }

        // Check to see if DeleteFiles property is set
        internal bool IsSetDeleteFiles()
        {
            return this._deleteFiles != null && (this._deleteFiles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReplaceContents. 
        /// <para>
        /// Files to have content replaced as part of the merge conflict resolution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReplaceContentEntry> ReplaceContents
        {
            get { return this._replaceContents; }
            set { this._replaceContents = value; }
        }

        // Check to see if ReplaceContents property is set
        internal bool IsSetReplaceContents()
        {
            return this._replaceContents != null && (this._replaceContents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SetFileModes. 
        /// <para>
        /// File modes that are set as part of the merge conflict resolution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SetFileModeEntry> SetFileModes
        {
            get { return this._setFileModes; }
            set { this._setFileModes = value; }
        }

        // Check to see if SetFileModes property is set
        internal bool IsSetSetFileModes()
        {
            return this._setFileModes != null && (this._setFileModes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}