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
 * Do not modify this file. This file is generated from the backupstorage-2018-04-10.normal.json service model.
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
namespace Amazon.BackupStorage.Model
{
    /// <summary>
    /// Container for the parameters to the GetObjectMetadata operation.
    /// Get metadata associated with an Object.
    /// </summary>
    public partial class GetObjectMetadataRequest : AmazonBackupStorageRequest
    {
        private string _objectToken;
        private string _storageJobId;

        /// <summary>
        /// Gets and sets the property ObjectToken. Object token.
        /// </summary>
        [AWSProperty(Required=true)]
        public string ObjectToken
        {
            get { return this._objectToken; }
            set { this._objectToken = value; }
        }

        // Check to see if ObjectToken property is set
        internal bool IsSetObjectToken()
        {
            return this._objectToken != null;
        }

        /// <summary>
        /// Gets and sets the property StorageJobId. Backup job id for the in-progress backup.
        /// </summary>
        [AWSProperty(Required=true)]
        public string StorageJobId
        {
            get { return this._storageJobId; }
            set { this._storageJobId = value; }
        }

        // Check to see if StorageJobId property is set
        internal bool IsSetStorageJobId()
        {
            return this._storageJobId != null;
        }

    }
}