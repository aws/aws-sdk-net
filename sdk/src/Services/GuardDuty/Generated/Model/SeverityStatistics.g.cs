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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Information about severity level for each finding type.
    /// </summary>
    public partial class SeverityStatistics
    {
        /// <summary>
        /// Gets and sets the property LastGeneratedAt. 
        /// <para>
        /// The timestamp at which a finding type for a specific severity was last generated.
        /// </para>
        /// </summary>
        public DateTime? LastGeneratedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastGeneratedAt property is set.
        /// </summary>
        internal bool IsSetLastGeneratedAt() => this.LastGeneratedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity level associated with each finding type.
        /// </para>
        /// </summary>
        public double? Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity.HasValue;

        /// <summary>
        /// Gets and sets the property TotalFindings. 
        /// <para>
        /// The total number of findings associated with this severity.
        /// </para>
        /// </summary>
        public int? TotalFindings { get; set; }

        /// <summary>
        /// Checks to see if the TotalFindings property is set.
        /// </summary>
        internal bool IsSetTotalFindings() => this.TotalFindings.HasValue;
    }
}
