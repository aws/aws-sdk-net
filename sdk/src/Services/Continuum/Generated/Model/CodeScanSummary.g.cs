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
    /// Customer-visible summary of one environment scan.
    /// </summary>
    public partial class CodeScanSummary
    {
        /// <summary>
        /// Gets and sets the property CompletedAt. Time at which a terminal result was recorded.
        /// </summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Checks to see if the CompletedAt property is set.
        /// </summary>
        internal bool IsSetCompletedAt() => this.CompletedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. Time at which Continuum accepted the scan request.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property FailureMessage. Failure detail present for unsuccessful
        /// scans.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property FailureStage. Phase this scan failed in. Present only when
        /// `status` is FAILED, and absent for a scan that failed before this field existed.
        /// </summary>
        public ScanFailureStage FailureStage { get; set; }

        /// <summary>
        /// Checks to see if the FailureStage property is set.
        /// </summary>
        internal bool IsSetFailureStage() => this.FailureStage != null;

        /// <summary>
        /// Gets and sets the property Origin. Why the scan was created. Always present.
        /// </summary>
        [AWSProperty(Required = true)]
        public ScanOrigin Origin { get; set; }

        /// <summary>
        /// Checks to see if the Origin property is set.
        /// </summary>
        internal bool IsSetOrigin() => this.Origin != null;

        /// <summary>
        /// Gets and sets the property ScanRunId. The unique scan identifier.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ScanRunId { get; set; }

        /// <summary>
        /// Checks to see if the ScanRunId property is set.
        /// </summary>
        internal bool IsSetScanRunId() => this.ScanRunId != null;

        /// <summary>
        /// Gets and sets the property Status. Current customer-visible status.
        /// </summary>
        [AWSProperty(Required = true)]
        public ScanStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
