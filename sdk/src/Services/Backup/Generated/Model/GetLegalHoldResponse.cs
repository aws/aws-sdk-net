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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Backup.Model
{
    /// <summary>
    /// This is the response object from the GetLegalHold operation.
    /// </summary>
    public partial class GetLegalHoldResponse : AmazonWebServiceResponse
    {
        private string _cancelDescription;
        private DateTime? _cancellationDate;
        private DateTime? _creationDate;
        private string _description;
        private string _legalHoldArn;
        private string _legalHoldId;
        private RecoveryPointSelection _recoveryPointSelection;
        private DateTime? _retainRecordUntil;
        private LegalHoldStatus _status;
        private string _title;

        /// <summary>
        /// Gets and sets the property CancelDescription. 
        /// <para>
        /// The reason for removing the legal hold.
        /// </para>
        /// </summary>
        public string CancelDescription
        {
            get { return this._cancelDescription; }
            set { this._cancelDescription = value; }
        }

        // Check to see if CancelDescription property is set
        internal bool IsSetCancelDescription()
        {
            return this._cancelDescription != null;
        }

        /// <summary>
        /// Gets and sets the property CancellationDate. 
        /// <para>
        /// The time when the legal hold was cancelled.
        /// </para>
        /// </summary>
        public DateTime? CancellationDate
        {
            get { return this._cancellationDate; }
            set { this._cancellationDate = value; }
        }

        // Check to see if CancellationDate property is set
        internal bool IsSetCancellationDate()
        {
            return this._cancellationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The time when the legal hold was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
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
        /// The description of the legal hold.
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
        /// The framework ARN for the specified legal hold. The format of the ARN depends on the
        /// resource type.
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
        /// The ID of the legal hold.
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
        /// The criteria to assign a set of resources, such as resource types or backup vaults.
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
        /// Gets and sets the property RetainRecordUntil. 
        /// <para>
        /// The date and time until which the legal hold record is retained.
        /// </para>
        /// </summary>
        public DateTime? RetainRecordUntil
        {
            get { return this._retainRecordUntil; }
            set { this._retainRecordUntil = value; }
        }

        // Check to see if RetainRecordUntil property is set
        internal bool IsSetRetainRecordUntil()
        {
            return this._retainRecordUntil.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the legal hold.
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
        /// The title of the legal hold.
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