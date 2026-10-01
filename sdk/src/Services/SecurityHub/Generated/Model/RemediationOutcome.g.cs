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
    /// The outcome from resolving the remediation target.
    /// </summary>
    public partial class RemediationOutcome
    {
        /// <summary>
        /// Gets and sets the property ResolvedFindingsCount. 
        /// <para>
        /// The number of associated exposure findings that are resolved by remediating the target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ResolvedFindingsCount { get; set; }

        /// <summary>
        /// Checks to see if the ResolvedFindingsCount property is set.
        /// </summary>
        internal bool IsSetResolvedFindingsCount() => this.ResolvedFindingsCount.HasValue;

        /// <summary>
        /// Gets and sets the property SeverityReductionFindingsCount. 
        /// <para>
        /// The number of associated exposure findings whose severity is reduced by remediating
        /// the target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? SeverityReductionFindingsCount { get; set; }

        /// <summary>
        /// Checks to see if the SeverityReductionFindingsCount property is set.
        /// </summary>
        internal bool IsSetSeverityReductionFindingsCount() => this.SeverityReductionFindingsCount.HasValue;

        /// <summary>
        /// Gets and sets the property SeverityUnchangedCount. 
        /// <para>
        /// The number of associated exposure findings whose severity is unchanged by remediating
        /// the target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? SeverityUnchangedCount { get; set; }

        /// <summary>
        /// Checks to see if the SeverityUnchangedCount property is set.
        /// </summary>
        internal bool IsSetSeverityUnchangedCount() => this.SeverityUnchangedCount.HasValue;
    }
}
