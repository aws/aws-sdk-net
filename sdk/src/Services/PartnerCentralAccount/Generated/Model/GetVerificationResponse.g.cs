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

namespace Amazon.PartnerCentralAccount.Model
{
    /// <summary>
    /// This is the response object from the GetVerification operation.
    /// </summary>
    public partial class GetVerificationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// The timestamp when the verification process was completed. This field is null if the
        /// verification is still in progress.
        /// </para>
        /// </summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Checks to see if the CompletedAt property is set.
        /// </summary>
        internal bool IsSetCompletedAt() => this.CompletedAt.HasValue;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp when the verification process was initiated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property VerificationResponseDetails. 
        /// <para>
        /// Detailed response information specific to the type of verification performed, including
        /// any verification-specific data or results.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VerificationResponseDetails VerificationResponseDetails { get; set; }

        /// <summary>
        /// Checks to see if the VerificationResponseDetails property is set.
        /// </summary>
        internal bool IsSetVerificationResponseDetails() => this.VerificationResponseDetails != null;

        /// <summary>
        /// Gets and sets the property VerificationStatus. 
        /// <para>
        /// The current status of the verification process. Possible values include pending, in-progress,
        /// completed, failed, or expired.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VerificationStatus VerificationStatus { get; set; }

        /// <summary>
        /// Checks to see if the VerificationStatus property is set.
        /// </summary>
        internal bool IsSetVerificationStatus() => this.VerificationStatus != null;

        /// <summary>
        /// Gets and sets the property VerificationStatusReason. 
        /// <para>
        /// Additional information explaining the current verification status, particularly useful
        /// when the status indicates a failure or requires additional action.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string VerificationStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the VerificationStatusReason property is set.
        /// </summary>
        internal bool IsSetVerificationStatusReason() => this.VerificationStatusReason != null;

        /// <summary>
        /// Gets and sets the property VerificationType. 
        /// <para>
        /// The type of verification that was requested and processed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VerificationType VerificationType { get; set; }

        /// <summary>
        /// Checks to see if the VerificationType property is set.
        /// </summary>
        internal bool IsSetVerificationType() => this.VerificationType != null;
    }
}
