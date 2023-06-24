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
    /// This is the response object from the CreateLegalHold operation.
    /// </summary>
    public partial class CreateLegalHoldResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationDate;
        private string _description;
        private string _legalHoldArn;
        private string _legalHoldId;
        private RecoveryPointSelection _recoveryPointSelection;
        private LegalHoldStatus _status;
        private string _title;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// Time in number format when legal hold was created.
        /// </para>
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// This is the returned string description of the legal hold.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LegalHoldArn. 
        /// <para>
        /// This is the ARN (Amazon Resource Number) of the created legal hold.
        /// </para>
        /// </summary>
        public string LegalHoldArn
        {
            get { return this._legalHoldArn; }
            set { this._legalHoldArn = value; }
        }

        // Check to see if LegalHoldArn property is set
        internal bool IsSetLegalHoldArn()
        {
            return this._legalHoldArn != null;
        }

        /// <summary>
        /// Gets and sets the property LegalHoldId. 
        /// <para>
        /// Legal hold ID returned for the specified legal hold on a recovery point.
        /// </para>
        /// </summary>
        public string LegalHoldId
        {
            get { return this._legalHoldId; }
            set { this._legalHoldId = value; }
        }

        // Check to see if LegalHoldId property is set
        internal bool IsSetLegalHoldId()
        {
            return this._legalHoldId != null;
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
        /// Gets and sets the property Status. 
        /// <para>
        /// This displays the status of the legal hold returned after creating the legal hold.
        /// Statuses can be <code>ACTIVE</code>, <code>PENDING</code>, <code>CANCELED</code>,
        /// <code>CANCELING</code>, or <code>FAILED</code>.
        /// </para>
        /// </summary>
        public LegalHoldStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// This is the string title of the legal hold returned after creating the legal hold.
        /// </para>
        /// </summary>
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