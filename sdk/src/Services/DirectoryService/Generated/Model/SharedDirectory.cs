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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Details about the shared directory in the directory owner account for which the share
    /// request in the directory consumer account has been accepted.
    /// </summary>
    public partial class SharedDirectory
    {
        private DateTime? _createdDateTime;
        private DateTime? _lastUpdatedDateTime;
        private string _ownerAccountId;
        private string _ownerDirectoryId;
        private string _sharedAccountId;
        private string _sharedDirectoryId;
        private ShareMethod _shareMethod;
        private string _shareNotes;
        private ShareStatus _shareStatus;

        /// <summary>
        /// Gets and sets the property CreatedDateTime. 
        /// <para>
        /// The date and time that the shared directory was created.
        /// </para>
        /// </summary>
        public DateTime CreatedDateTime
        {
            get { return this._createdDateTime.GetValueOrDefault(); }
            set { this._createdDateTime = value; }
        }

        // Check to see if CreatedDateTime property is set
        internal bool IsSetCreatedDateTime()
        {
            return this._createdDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time that the shared directory was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedDateTime
        {
            get { return this._lastUpdatedDateTime.GetValueOrDefault(); }
            set { this._lastUpdatedDateTime = value; }
        }

        // Check to see if LastUpdatedDateTime property is set
        internal bool IsSetLastUpdatedDateTime()
        {
            return this._lastUpdatedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// Identifier of the directory owner account, which contains the directory that has been
        /// shared to the consumer account.
        /// </para>
        /// </summary>
        public string OwnerAccountId
        {
            get { return this._ownerAccountId; }
            set { this._ownerAccountId = value; }
        }

        // Check to see if OwnerAccountId property is set
        internal bool IsSetOwnerAccountId()
        {
            return this._ownerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerDirectoryId. 
        /// <para>
        /// Identifier of the directory in the directory owner account. 
        /// </para>
        /// </summary>
        public string OwnerDirectoryId
        {
            get { return this._ownerDirectoryId; }
            set { this._ownerDirectoryId = value; }
        }

        // Check to see if OwnerDirectoryId property is set
        internal bool IsSetOwnerDirectoryId()
        {
            return this._ownerDirectoryId != null;
        }

        /// <summary>
        /// Gets and sets the property SharedAccountId. 
        /// <para>
        /// Identifier of the directory consumer account that has access to the shared directory
        /// (<code>OwnerDirectoryId</code>) in the directory owner account.
        /// </para>
        /// </summary>
        public string SharedAccountId
        {
            get { return this._sharedAccountId; }
            set { this._sharedAccountId = value; }
        }

        // Check to see if SharedAccountId property is set
        internal bool IsSetSharedAccountId()
        {
            return this._sharedAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property SharedDirectoryId. 
        /// <para>
        /// Identifier of the shared directory in the directory consumer account. This identifier
        /// is different for each directory owner account.
        /// </para>
        /// </summary>
        public string SharedDirectoryId
        {
            get { return this._sharedDirectoryId; }
            set { this._sharedDirectoryId = value; }
        }

        // Check to see if SharedDirectoryId property is set
        internal bool IsSetSharedDirectoryId()
        {
            return this._sharedDirectoryId != null;
        }

        /// <summary>
        /// Gets and sets the property ShareMethod. 
        /// <para>
        /// The method used when sharing a directory to determine whether the directory should
        /// be shared within your Amazon Web Services organization (<code>ORGANIZATIONS</code>)
        /// or with any Amazon Web Services account by sending a shared directory request (<code>HANDSHAKE</code>).
        /// </para>
        /// </summary>
        public ShareMethod ShareMethod
        {
            get { return this._shareMethod; }
            set { this._shareMethod = value; }
        }

        // Check to see if ShareMethod property is set
        internal bool IsSetShareMethod()
        {
            return this._shareMethod != null;
        }

        /// <summary>
        /// Gets and sets the property ShareNotes. 
        /// <para>
        /// A directory share request that is sent by the directory owner to the directory consumer.
        /// The request includes a typed message to help the directory consumer administrator
        /// determine whether to approve or reject the share invitation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=1024)]
        public string ShareNotes
        {
            get { return this._shareNotes; }
            set { this._shareNotes = value; }
        }

        // Check to see if ShareNotes property is set
        internal bool IsSetShareNotes()
        {
            return this._shareNotes != null;
        }

        /// <summary>
        /// Gets and sets the property ShareStatus. 
        /// <para>
        /// Current directory status of the shared Managed Microsoft AD directory.
        /// </para>
        /// </summary>
        public ShareStatus ShareStatus
        {
            get { return this._shareStatus; }
            set { this._shareStatus = value; }
        }

        // Check to see if ShareStatus property is set
        internal bool IsSetShareStatus()
        {
            return this._shareStatus != null;
        }

    }
}