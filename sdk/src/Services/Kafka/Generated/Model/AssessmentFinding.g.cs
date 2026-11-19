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

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// A single finding from an assessment, describing a specific issue or observation.
    /// </summary>
    public partial class AssessmentFinding
    {
        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of this finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FindingCategory Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property FindingId. 
        /// <para>
        /// A deterministic content-based identifier for this finding. Generated from hash(category
        /// + resource + check_type). The same resource with the same problem always produces
        /// the same findingId across assessment runs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FindingId { get; set; }

        /// <summary>
        /// Checks to see if the FindingId property is set.
        /// </summary>
        internal bool IsSetFindingId() => this.FindingId != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Human-readable description of what is wrong, why it matters, and what to do.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Remediation. 
        /// <para>
        /// Guidance for resolving this finding. Absent when no specific remediation applies.
        /// </para>
        /// </summary>
        public FindingRemediation Remediation { get; set; }

        /// <summary>
        /// Checks to see if the Remediation property is set.
        /// </summary>
        internal bool IsSetRemediation() => this.Remediation != null;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The specific resource affected (e.g., topic name). Absent for cluster-level findings.
        /// </para>
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of this finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FindingSeverity Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;
    }
}
