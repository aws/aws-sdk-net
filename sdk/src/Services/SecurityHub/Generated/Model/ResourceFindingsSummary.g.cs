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
    /// A list of summaries for all finding types on a resource.
    /// </summary>
    public partial class ResourceFindingsSummary
    {
        /// <summary>
        /// Gets and sets the property FindingType. 
        /// <para>
        /// The category or classification of the security finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FindingType { get; set; }

        /// <summary>
        /// Checks to see if the FindingType property is set.
        /// </summary>
        internal bool IsSetFindingType() => this.FindingType != null;

        /// <summary>
        /// Gets and sets the property ProductName. 
        /// <para>
        /// The name of the product associated with the security finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProductName { get; set; }

        /// <summary>
        /// Checks to see if the ProductName property is set.
        /// </summary>
        internal bool IsSetProductName() => this.ProductName != null;

        /// <summary>
        /// Gets and sets the property Severities. 
        /// <para>
        /// A breakdown of security findings by their severity levels.
        /// </para>
        /// </summary>
        public ResourceSeverityBreakdown Severities { get; set; }

        /// <summary>
        /// Checks to see if the Severities property is set.
        /// </summary>
        internal bool IsSetSeverities() => this.Severities != null;

        /// <summary>
        /// Gets and sets the property TotalFindings. 
        /// <para>
        /// The total count of security findings.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? TotalFindings { get; set; }

        /// <summary>
        /// Checks to see if the TotalFindings property is set.
        /// </summary>
        internal bool IsSetTotalFindings() => this.TotalFindings.HasValue;
    }
}
