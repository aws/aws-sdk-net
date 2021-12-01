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
    /// The response object for the Amazon FSx for OpenZFS file system that's being deleted
    /// in the <code>DeleteFileSystem</code> operation.
    /// </summary>
    public partial class DeleteFileSystemOpenZFSResponse
    {
        private string _finalBackupId;
        private List<Tag> _finalBackupTags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property FinalBackupId.
        /// </summary>
        [AWSProperty(Min=12, Max=128)]
        public string FinalBackupId
        {
            get { return this._finalBackupId; }
            set { this._finalBackupId = value; }
        }

        // Check to see if FinalBackupId property is set
        internal bool IsSetFinalBackupId()
        {
            return this._finalBackupId != null;
        }

        /// <summary>
        /// Gets and sets the property FinalBackupTags.
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
            return this._finalBackupTags != null && this._finalBackupTags.Count > 0; 
        }

    }
}