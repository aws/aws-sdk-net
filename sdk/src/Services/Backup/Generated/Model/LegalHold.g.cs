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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// A legal hold is an administrative tool that helps prevent backups from being deleted
    /// while under a hold. While the hold is in place, backups under a hold cannot be deleted
    /// and lifecycle policies that would alter the backup status (such as transition to cold
    /// storage) are delayed until the legal hold is removed. A backup can have more than
    /// one legal hold. Legal holds are applied to one or more backups (also known as recovery
    /// points). These backups can be filtered by resource types and by resource IDs.
    /// </summary>
    public partial class LegalHold
    {
        /// <summary>
        /// Gets and sets the property CancellationDate. 
        /// <para>
        /// The time when the legal hold was cancelled.
        /// </para>
        /// </summary>
        public DateTime? CancellationDate { get; set; }

        /// <summary>
        /// Checks to see if the CancellationDate property is set.
        /// </summary>
        internal bool IsSetCancellationDate() => this.CancellationDate.HasValue;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The time when the legal hold was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of a legal hold.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LegalHoldArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the legal hold; for example, <c>arn:aws:backup:us-east-1:123456789012:recovery-point:1EB3B5E7-9EB0-435A-A80B-108B488B0D45</c>.
        /// </para>
        /// </summary>
        public string LegalHoldArn { get; set; }

        /// <summary>
        /// Checks to see if the LegalHoldArn property is set.
        /// </summary>
        internal bool IsSetLegalHoldArn() => this.LegalHoldArn != null;

        /// <summary>
        /// Gets and sets the property LegalHoldId. 
        /// <para>
        /// The ID of the legal hold.
        /// </para>
        /// </summary>
        public string LegalHoldId { get; set; }

        /// <summary>
        /// Checks to see if the LegalHoldId property is set.
        /// </summary>
        internal bool IsSetLegalHoldId() => this.LegalHoldId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the legal hold.
        /// </para>
        /// </summary>
        public LegalHoldStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of a legal hold.
        /// </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
