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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// Customer delivery of the patches Continuum produced for an issue, summarized across
    /// the issue's PATCH artifacts when the issue is read. Each artifact keeps its own `delivery.destination`
    /// with the full detail; this summary lets a caller see a failed delivery without listing
    /// artifacts.
    /// </summary>
    public partial class IssuePatchDelivery
    {
        /// <summary>
        /// Gets and sets the property FailedCount. Number of those patches whose delivery failed
        /// or exhausted its retries.
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? FailedCount { get; set; }

        /// <summary>
        /// Checks to see if the FailedCount property is set.
        /// </summary>
        internal bool IsSetFailedCount() => this.FailedCount.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReasons. Distinct reasons of the failed deliveries,
        /// in ascending order. Present only when failedCount is greater than zero.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FailureReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FailureReasons property is set.
        /// </summary>
        internal bool IsSetFailureReasons() => this.FailureReasons != null && (this.FailureReasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PatchCount. Number of the issue's patches that have a destination
        /// delivery.
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? PatchCount { get; set; }

        /// <summary>
        /// Checks to see if the PatchCount property is set.
        /// </summary>
        internal bool IsSetPatchCount() => this.PatchCount.HasValue;

        /// <summary>
        /// Gets and sets the property Status. The overall result, in priority order: FAILED when
        /// any patch's destination delivery failed or exhausted its retries; otherwise PENDING
        /// while any is still in progress; otherwise SUCCEEDED when at least one was delivered;
        /// otherwise SKIPPED.
        /// </summary>
        [AWSProperty(Required = true)]
        public IssuePatchDeliveryStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SucceededCount. Number of those patches delivered to their
        /// destination.
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? SucceededCount { get; set; }

        /// <summary>
        /// Checks to see if the SucceededCount property is set.
        /// </summary>
        internal bool IsSetSucceededCount() => this.SucceededCount.HasValue;
    }
}
