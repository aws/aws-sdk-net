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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object that represents the details of the first <c>RUNNABLE</c> job in each named
    /// quota share associated with a single job queue.
    /// </summary>
    public partial class FrontOfQuotaSharesDetail
    {
        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the first <c>RUNNABLE</c> job per quota
        /// share were all last updated.
        /// </para>
        /// </summary>
        public long? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property QuotaShares. 
        /// <para>
        /// Contains a list of the first <c>RUNNABLE</c> job in each named quota share.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<FrontOfQuotaShareJobSummary>> QuotaShares { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<FrontOfQuotaShareJobSummary>>() : null;

        /// <summary>
        /// Checks to see if the QuotaShares property is set.
        /// </summary>
        internal bool IsSetQuotaShares() => this.QuotaShares != null && (this.QuotaShares.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
