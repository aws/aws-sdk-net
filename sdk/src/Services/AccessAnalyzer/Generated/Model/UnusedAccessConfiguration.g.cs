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
    /// Contains information about an unused access analyzer.
    /// </summary>
    public partial class UnusedAccessConfiguration
    {
        /// <summary>
        /// Gets and sets the property AnalysisRule.
        /// </summary>
        public AnalysisRule AnalysisRule { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisRule property is set.
        /// </summary>
        internal bool IsSetAnalysisRule() => this.AnalysisRule != null;

        /// <summary>
        /// Gets and sets the property UnusedAccessAge. 
        /// <para>
        /// The specified access age in days for which to generate findings for unused access.
        /// For example, if you specify 90 days, the analyzer will generate findings for IAM entities
        /// within the accounts of the selected organization for any access that hasn't been used
        /// in 90 or more days since the analyzer's last scan. You can choose a value between
        /// 1 and 365 days.
        /// </para>
        /// </summary>
        public int? UnusedAccessAge { get; set; }

        /// <summary>
        /// Checks to see if the UnusedAccessAge property is set.
        /// </summary>
        internal bool IsSetUnusedAccessAge() => this.UnusedAccessAge.HasValue;
    }
}
