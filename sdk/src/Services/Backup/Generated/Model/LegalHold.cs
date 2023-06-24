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
    /// A legal hold is an administrative tool that helps prevent backups from being deleted
    /// while under a hold. While the hold is in place, backups under a hold cannot be deleted
    /// and lifecycle policies that would alter the backup status (such as transition to cold
    /// storage) are delayed until the legal hold is removed. A backup can have more than
    /// one legal hold. Legal holds are applied to one or more backups (also known as recovery
    /// points). These backups can be filtered by resource types and by resource IDs.
    /// </summary>
    public partial class LegalHold
    {
        private DateTime? _cancellationDate;
        private DateTime? _creationDate;
        private string _description;
        private string _legalHoldArn;
        private string _legalHoldId;
        private LegalHoldStatus _status;
        private string _title;

        /// <summary>
        /// Gets and sets the property CancellationDate. 
        /// <para>
        /// This is the time in number format when legal hold was cancelled.
        /// </para>
        /// </summary>
        public DateTime CancellationDate
        {
            get { return this._cancellationDate.GetValueOrDefault(); }
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
        /// This is the time in number format when legal hold was created.
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
        /// This is the description of a legal hold.
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
        /// This is an Amazon Resource Number (ARN) that uniquely identifies the legal hold; for
        /// example, <code>arn:aws:backup:us-east-1:123456789012:recovery-point:1EB3B5E7-9EB0-435A-A80B-108B488B0D45</code>.
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
        /// ID of specific legal hold on one or more recovery points.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// This is the status of the legal hold. Statuses can be <code>ACTIVE</code>, <code>CREATING</code>,
        /// <code>CANCELED</code>, and <code>CANCELING</code>.
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
        /// This is the title of a legal hold.
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