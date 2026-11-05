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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// The number of Amazon Web Services resources of a specific type that are compliant
    /// or noncompliant, up to a maximum of 100 for each.
    /// </summary>
    public partial class ComplianceSummaryByResourceType
    {
        /// <summary>
        /// Gets and sets the property ComplianceSummary. 
        /// <para>
        /// The number of Amazon Web Services resources that are compliant or noncompliant, up
        /// to a maximum of 100 for each.
        /// </para>
        /// </summary>
        public ComplianceSummary ComplianceSummary { get; set; }

        /// <summary>
        /// Checks to see if the ComplianceSummary property is set.
        /// </summary>
        internal bool IsSetComplianceSummary() => this.ComplianceSummary != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of Amazon Web Services resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
