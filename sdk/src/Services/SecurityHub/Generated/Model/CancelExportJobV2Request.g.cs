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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the CancelExportJobV2 operation. Cancels a findings
    /// export job that is in progress. Security Hub transitions a running job to the <c>CANCELLED</c>
    /// state and returns the <c>ExportJobId</c> and its new <c>Status</c>. Canceling a job
    /// that is already in the <c>CANCELLED</c> state succeeds and returns the same result,
    /// so you can safely retry a cancel request. <para> You can't cancel an export job that
    /// has already reached a terminal <c>SUCCEEDED</c> or <c>FAILED</c> state; in that case,
    /// this operation returns a <c>ConflictException</c>. If no export job matches the <c>ExportJobId</c>
    /// that you provide, this operation returns a <c>ResourceNotFoundException</c>. </para>
    /// <para> The <c>Status</c> value returned by this operation reflects the cancellation
    /// immediately, even though the job can take a short time to stop completely. </para>
    /// </summary>
    public partial class CancelExportJobV2Request : AmazonSecurityHubRequest
    {
        /// <summary>
        /// Gets and sets the property ExportJobId. 
        /// <para>
        /// The unique identifier of the export job to cancel. This is the value returned by <c>StartExportJobV2</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ExportJobId { get; set; }

        /// <summary>
        /// Checks to see if the ExportJobId property is set.
        /// </summary>
        internal bool IsSetExportJobId() => this.ExportJobId != null;
    }
}
