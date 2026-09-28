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

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Contains information about the total number of active, archived, and resolved findings
    /// for a resource type of an internal access analyzer.
    /// </summary>
    public partial class InternalAccessResourceTypeDetails
    {
        /// <summary>
        /// Gets and sets the property TotalActiveFindings. 
        /// <para>
        /// The total number of active findings for the resource type in the internal access analyzer.
        /// </para>
        /// </summary>
        public int? TotalActiveFindings { get; set; }

        /// <summary>
        /// Checks to see if the TotalActiveFindings property is set.
        /// </summary>
        internal bool IsSetTotalActiveFindings() => this.TotalActiveFindings.HasValue;

        /// <summary>
        /// Gets and sets the property TotalArchivedFindings. 
        /// <para>
        /// The total number of archived findings for the resource type in the internal access
        /// analyzer.
        /// </para>
        /// </summary>
        public int? TotalArchivedFindings { get; set; }

        /// <summary>
        /// Checks to see if the TotalArchivedFindings property is set.
        /// </summary>
        internal bool IsSetTotalArchivedFindings() => this.TotalArchivedFindings.HasValue;

        /// <summary>
        /// Gets and sets the property TotalResolvedFindings. 
        /// <para>
        /// The total number of resolved findings for the resource type in the internal access
        /// analyzer.
        /// </para>
        /// </summary>
        public int? TotalResolvedFindings { get; set; }

        /// <summary>
        /// Checks to see if the TotalResolvedFindings property is set.
        /// </summary>
        internal bool IsSetTotalResolvedFindings() => this.TotalResolvedFindings.HasValue;
    }
}
