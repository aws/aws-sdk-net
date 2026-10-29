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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// A summary of compliance information by compliance type.
    /// </summary>
    public partial class ComplianceSummaryItem
    {
        /// <summary>
        /// Gets and sets the property ComplianceType. 
        /// <para>
        /// The type of compliance item. For example, the compliance type can be Association,
        /// Patch, or Custom:string.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ComplianceType { get; set; }

        /// <summary>
        /// Checks to see if the ComplianceType property is set.
        /// </summary>
        internal bool IsSetComplianceType() => this.ComplianceType != null;

        /// <summary>
        /// Gets and sets the property CompliantSummary. 
        /// <para>
        /// A list of COMPLIANT items for the specified compliance type.
        /// </para>
        /// </summary>
        public CompliantSummary CompliantSummary { get; set; }

        /// <summary>
        /// Checks to see if the CompliantSummary property is set.
        /// </summary>
        internal bool IsSetCompliantSummary() => this.CompliantSummary != null;

        /// <summary>
        /// Gets and sets the property NonCompliantSummary. 
        /// <para>
        /// A list of NON_COMPLIANT items for the specified compliance type.
        /// </para>
        /// </summary>
        public NonCompliantSummary NonCompliantSummary { get; set; }

        /// <summary>
        /// Checks to see if the NonCompliantSummary property is set.
        /// </summary>
        internal bool IsSetNonCompliantSummary() => this.NonCompliantSummary != null;
    }
}
