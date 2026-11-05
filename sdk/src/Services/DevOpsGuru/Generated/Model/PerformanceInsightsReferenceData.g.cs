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

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Reference data used to evaluate Performance Insights to determine if its performance
    /// is anomalous or not.
    /// </summary>
    public partial class PerformanceInsightsReferenceData
    {
        /// <summary>
        /// Gets and sets the property ComparisonValues. 
        /// <para>
        /// The specific reference values used to evaluate the Performance Insights. For more
        /// information, see <c> <a href="https://docs.aws.amazon.com/devops-guru/latest/APIReference/API_PerformanceInsightsReferenceComparisonValues.html">PerformanceInsightsReferenceComparisonValues</a>
        /// </c>. 
        /// </para>
        /// </summary>
        public PerformanceInsightsReferenceComparisonValues ComparisonValues { get; set; }

        /// <summary>
        /// Checks to see if the ComparisonValues property is set.
        /// </summary>
        internal bool IsSetComparisonValues() => this.ComparisonValues != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the reference data.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
