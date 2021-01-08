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
    /// Container for the parameters to the CreateBackup operation.
    /// Creates a backup of an existing Amazon FSx file system. Creating regular backups for
    /// your file system is a best practice, enabling you to restore a file system from a
    /// backup if an issue arises with the original file system.
    /// 
    ///  
    /// <para>
    /// For Amazon FSx for Lustre file systems, you can create a backup only for file systems
    /// with the following configuration:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// a Persistent deployment type
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// is <i>not</i> linked to a data respository.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about backing up Amazon FSx for Lustre file systems, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/using-backups-fsx.html">Working
    /// with FSx for Lustre backups</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information about backing up Amazon FSx for Windows file systems, see <a
    /// href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/using-backups.html">Working
    /// with FSx for Windows backups</a>.
    /// </para>
    ///  
    /// <para>
    /// If a backup with the specified client request token exists, and the parameters match,
    /// this operation returns the description of the existing backup. If a backup specified
    /// client request token exists, and the parameters don't match, this operation returns
    /// <code>IncompatibleParameterError</code>. If a backup with the specified client request
    /// token doesn't exist, <code>CreateBackup</code> does the following: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Creates a new Amazon FSx backup with an assigned ID, and an initial lifecycle state
    /// of <code>CREATING</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Returns the description of the backup.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// By using the idempotent operation, you can retry a <code>CreateBackup</code> operation
    /// without the risk of creating an extra backup. This approach can be useful when an
    /// initial call fails in a way that makes it unclear whether a backup was created. If
    /// you use the same client request token and the initial call created a backup, the operation
    /// returns a successful result because all the parameters are the same.
    /// </para>
    ///  
    /// <para>
    /// The <code>CreateBackup</code> operation returns while the backup's lifecycle state
    /// is still <code>CREATING</code>. You can check the backup creation status by calling
    /// the <a>DescribeBackups</a> operation, which returns the backup state along with other
    /// information.
    /// </para>
    /// </summary>
    public partial class CreateBackupRequest : AmazonFSxRequest
    {
        private string _clientRequestToken;
        private string _fileSystemId;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// (Optional) A string of up to 64 ASCII characters that Amazon FSx uses to ensure idempotent
        /// creation. This string is automatically filled on your behalf when you use the AWS
        /// Command Line Interface (AWS CLI) or an AWS SDK.
        /// </para>
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
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The ID of the file system to back up.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=11, Max=21)]
        public string FileSystemId
        {
            get { return this._fileSystemId; }
            set { this._fileSystemId = value; }
        }

        // Check to see if FileSystemId property is set
        internal bool IsSetFileSystemId()
        {
            return this._fileSystemId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// (Optional) The tags to apply to the backup at backup creation. The key value of the
        /// <code>Name</code> tag appears in the console as the backup name. If you have set <code>CopyTagsToBackups</code>
        /// to true, and you specify one or more tags using the <code>CreateBackup</code> action,
        /// no existing file system tags are copied from the file system to the backup.
        /// </para>
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