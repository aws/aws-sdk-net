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
    /// This is the response object from the CreateLegalHold operation.
    /// </summary>
    public partial class CreateLegalHoldResponse : AmazonWebServiceResponse
    {
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
        /// The description of the legal hold.
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
        /// The Amazon Resource Name (ARN) of the legal hold.
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
        /// Gets and sets the property RecoveryPointSelection. 
        /// <para>
        /// The criteria to assign to a set of resources, such as resource types or backup vaults.
        /// </para>
        /// </summary>
        public RecoveryPointSelection RecoveryPointSelection { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryPointSelection property is set.
        /// </summary>
        internal bool IsSetRecoveryPointSelection() => this.RecoveryPointSelection != null;

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
        /// The title of the legal hold.
        /// </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
