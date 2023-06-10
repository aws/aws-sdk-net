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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLegalHold operation.
    /// This action creates a legal hold on a recovery point (backup). A legal hold is a restraint
    /// on altering or deleting a backup until an authorized user cancels the legal hold.
    /// Any actions to delete or disassociate a recovery point will fail with an error if
    /// one or more active legal holds are on the recovery point.
    /// </summary>
    public partial class CreateLegalHoldRequest : AmazonBackupRequest
    {
        private string _description;
        private string _idempotencyToken;
        private RecoveryPointSelection _recoveryPointSelection;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _title;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// This is the string description of the legal hold.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// This is a user-chosen string used to distinguish between otherwise identical calls.
        /// Retrying a successful request with the same idempotency token results in a success
        /// message with no action taken.
        /// </para>
        /// </summary>
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property RecoveryPointSelection. 
        /// <para>
        /// This specifies criteria to assign a set of resources, such as resource types or backup
        /// vaults.
        /// </para>
        /// </summary>
        public RecoveryPointSelection RecoveryPointSelection
        {
            get { return this._recoveryPointSelection; }
            set { this._recoveryPointSelection = value; }
        }

        // Check to see if RecoveryPointSelection property is set
        internal bool IsSetRecoveryPointSelection()
        {
            return this._recoveryPointSelection != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optional tags to include. A tag is a key-value pair you can use to manage, filter,
        /// and search for your resources. Allowed characters include UTF-8 letters, numbers,
        /// spaces, and the following characters: + - = . _ : /. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// This is the string title of the legal hold.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}