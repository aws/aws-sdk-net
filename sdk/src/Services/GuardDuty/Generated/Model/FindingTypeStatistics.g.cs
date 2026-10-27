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
    /// Information about each finding type associated with the <c>groupedByFindingType</c>
    /// statistics.
    /// </summary>
    public partial class FindingTypeStatistics
    {
        /// <summary>
        /// Gets and sets the property FindingType. 
        /// <para>
        /// Name of the finding type.
        /// </para>
        /// </summary>
        public string FindingType { get; set; }

        /// <summary>
        /// Checks to see if the FindingType property is set.
        /// </summary>
        internal bool IsSetFindingType() => this.FindingType != null;

        /// <summary>
        /// Gets and sets the property LastGeneratedAt. 
        /// <para>
        /// The timestamp at which this finding type was last generated in your environment.
        /// </para>
        /// </summary>
        public DateTime? LastGeneratedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastGeneratedAt property is set.
        /// </summary>
        internal bool IsSetLastGeneratedAt() => this.LastGeneratedAt.HasValue;

        /// <summary>
        /// Gets and sets the property TotalFindings. 
        /// <para>
        /// The total number of findings associated with generated for each distinct finding type.
        /// </para>
        /// </summary>
        public int? TotalFindings { get; set; }

        /// <summary>
        /// Checks to see if the TotalFindings property is set.
        /// </summary>
        internal bool IsSetTotalFindings() => this.TotalFindings.HasValue;
    }
}
