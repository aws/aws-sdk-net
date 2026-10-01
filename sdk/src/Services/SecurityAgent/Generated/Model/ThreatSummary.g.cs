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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Contains summary information about a threat.
    /// </summary>
    public partial class ThreatSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the threat was created, in UTC format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Who created this threat.
        /// </para>
        /// </summary>
        public ThreatActor CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity level of the threat.
        /// </para>
        /// </summary>
        public ThreatSeverity Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property Statement. 
        /// <para>
        /// The natural-language threat statement.
        /// </para>
        /// </summary>
        public string Statement { get; set; }

        /// <summary>
        /// Checks to see if the Statement property is set.
        /// </summary>
        internal bool IsSetStatement() => this.Statement != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the threat.
        /// </para>
        /// </summary>
        public ThreatStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Stride. 
        /// <para>
        /// The STRIDE categories applicable to this threat.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Stride { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Stride property is set.
        /// </summary>
        internal bool IsSetStride() => this.Stride != null && (this.Stride.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThreatId. 
        /// <para>
        /// The unique identifier of the threat.
        /// </para>
        /// </summary>
        public string ThreatId { get; set; }

        /// <summary>
        /// Checks to see if the ThreatId property is set.
        /// </summary>
        internal bool IsSetThreatId() => this.ThreatId != null;

        /// <summary>
        /// Gets and sets the property ThreatJobId. 
        /// <para>
        /// The unique identifier of the threat model job that produced the threat.
        /// </para>
        /// </summary>
        public string ThreatJobId { get; set; }

        /// <summary>
        /// Checks to see if the ThreatJobId property is set.
        /// </summary>
        internal bool IsSetThreatJobId() => this.ThreatJobId != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A short title summarizing the threat.
        /// </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the threat was last updated, in UTC format.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// Who last updated this threat.
        /// </para>
        /// </summary>
        public ThreatActor UpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedBy property is set.
        /// </summary>
        internal bool IsSetUpdatedBy() => this.UpdatedBy != null;
    }
}
