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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Information about the audit check.
    /// </summary>
    public partial class AuditCheckDetails
    {
        /// <summary>
        /// Gets and sets the property CheckCompliant. 
        /// <para>
        /// True if the check is complete and found all resources compliant.
        /// </para>
        /// </summary>
        public bool? CheckCompliant { get; set; }

        /// <summary>
        /// Checks to see if the CheckCompliant property is set.
        /// </summary>
        internal bool IsSetCheckCompliant() => this.CheckCompliant.HasValue;

        /// <summary>
        /// Gets and sets the property CheckRunStatus. 
        /// <para>
        /// The completion status of this check. One of "IN_PROGRESS", "WAITING_FOR_DATA_COLLECTION",
        /// "CANCELED", "COMPLETED_COMPLIANT", "COMPLETED_NON_COMPLIANT", or "FAILED".
        /// </para>
        /// </summary>
        public AuditCheckRunStatus CheckRunStatus { get; set; }

        /// <summary>
        /// Checks to see if the CheckRunStatus property is set.
        /// </summary>
        internal bool IsSetCheckRunStatus() => this.CheckRunStatus != null;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The code of any error encountered when this check is performed during this audit.
        /// One of "INSUFFICIENT_PERMISSIONS" or "AUDIT_CHECK_DISABLED".
        /// </para>
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message associated with any error encountered when this check is performed during
        /// this audit.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property NonCompliantResourcesCount. 
        /// <para>
        /// The number of resources that were found noncompliant during the check.
        /// </para>
        /// </summary>
        public long? NonCompliantResourcesCount { get; set; }

        /// <summary>
        /// Checks to see if the NonCompliantResourcesCount property is set.
        /// </summary>
        internal bool IsSetNonCompliantResourcesCount() => this.NonCompliantResourcesCount.HasValue;

        /// <summary>
        /// Gets and sets the property SuppressedNonCompliantResourcesCount. 
        /// <para>
        ///  Describes how many of the non-compliant resources created during the evaluation of
        /// an audit check were marked as suppressed. 
        /// </para>
        /// </summary>
        public long? SuppressedNonCompliantResourcesCount { get; set; }

        /// <summary>
        /// Checks to see if the SuppressedNonCompliantResourcesCount property is set.
        /// </summary>
        internal bool IsSetSuppressedNonCompliantResourcesCount() => this.SuppressedNonCompliantResourcesCount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalResourcesCount. 
        /// <para>
        /// The number of resources on which the check was performed.
        /// </para>
        /// </summary>
        public long? TotalResourcesCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalResourcesCount property is set.
        /// </summary>
        internal bool IsSetTotalResourcesCount() => this.TotalResourcesCount.HasValue;
    }
}
