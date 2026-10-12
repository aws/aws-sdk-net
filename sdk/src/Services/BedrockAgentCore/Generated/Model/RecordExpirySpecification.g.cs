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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Specifies the record expiry (long-term memory time-to-live) applied to the records
    /// in a batch request. Provide exactly one of <c>recordExpiryDurationDays</c> or <c>action</c>.
    /// Set <c>recordExpiryDurationDays</c> to configure or update the expiry, or set <c>action</c>
    /// to <c>REMOVE</c> to remove a previously configured expiry.
    /// </summary>
    public partial class RecordExpirySpecification
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to apply to the existing record expiry configuration. Set to <c>REMOVE</c>
        /// to remove a previously configured expiry so that the records no longer expire. This
        /// value does not apply when creating records.
        /// </para>
        /// </summary>
        public RecordExpiryAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property RecordExpiryDurationDays. 
        /// <para>
        /// The duration, in days, after which the records in this request expire. The minimum
        /// is 31 days.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 31)]
        public int? RecordExpiryDurationDays { get; set; }

        /// <summary>
        /// Checks to see if the RecordExpiryDurationDays property is set.
        /// </summary>
        internal bool IsSetRecordExpiryDurationDays() => this.RecordExpiryDurationDays.HasValue;
    }
}
