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

namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Represents the status of a multi-region operation in a specific Amazon Web Services
    /// Region. This structure is used to report per-region progress for both telemetry evaluation
    /// and telemetry rule replication.
    /// </summary>
    public partial class RegionStatus
    {
        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        ///  The reason for a failure status in this region. This field is only populated when
        /// <c>Status</c> indicates a failure. 
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        ///  The Amazon Web Services Region code (for example, <c>eu-west-1</c> or <c>us-west-2</c>)
        /// that this status applies to. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property RuleArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the telemetry rule in this spoke region. This field
        /// is only present for telemetry rule region statuses and is populated when the rule
        /// has been successfully created in the spoke region (status is <c>ACTIVE</c>). 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string RuleArn { get; set; }

        /// <summary>
        /// Checks to see if the RuleArn property is set.
        /// </summary>
        internal bool IsSetRuleArn() => this.RuleArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the operation in this region. For telemetry evaluation, valid values
        /// include <c>STARTING</c>, <c>RUNNING</c>, and <c>FAILED_START</c>. For telemetry rules,
        /// valid values include <c>PENDING</c>, <c>ACTIVE</c>, and <c>FAILED</c>. 
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
