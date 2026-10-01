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
    /// Container for the parameters to the CancelLegalHold operation. Removes the specified
    /// legal hold on a recovery point. This action can only be performed by a user with sufficient
    /// permissions.
    /// </summary>
    public partial class CancelLegalHoldRequest : AmazonBackupRequest
    {
        /// <summary>
        /// Gets and sets the property CancelDescription. 
        /// <para>
        /// A string the describes the reason for removing the legal hold.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CancelDescription { get; set; }

        /// <summary>
        /// Checks to see if the CancelDescription property is set.
        /// </summary>
        internal bool IsSetCancelDescription() => this.CancelDescription != null;

        /// <summary>
        /// Gets and sets the property LegalHoldId. 
        /// <para>
        /// The ID of the legal hold.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LegalHoldId { get; set; }

        /// <summary>
        /// Checks to see if the LegalHoldId property is set.
        /// </summary>
        internal bool IsSetLegalHoldId() => this.LegalHoldId != null;

        /// <summary>
        /// Gets and sets the property RetainRecordInDays. 
        /// <para>
        /// The integer amount, in days, after which to remove legal hold.
        /// </para>
        /// </summary>
        public long? RetainRecordInDays { get; set; }

        /// <summary>
        /// Checks to see if the RetainRecordInDays property is set.
        /// </summary>
        internal bool IsSetRetainRecordInDays() => this.RetainRecordInDays.HasValue;
    }
}
