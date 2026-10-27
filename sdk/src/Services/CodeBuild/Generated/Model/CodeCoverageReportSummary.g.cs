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

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Contains a summary of a code coverage report.
    /// 
    ///  
    /// <para>
    /// Line coverage measures how many statements your tests cover. A statement is a single
    /// instruction, not including comments, conditionals, etc.
    /// </para>
    ///  
    /// <para>
    /// Branch coverage determines if your tests cover every possible branch of a control
    /// structure, such as an <c>if</c> or <c>case</c> statement.
    /// </para>
    /// </summary>
    public partial class CodeCoverageReportSummary
    {
        /// <summary>
        /// Gets and sets the property BranchCoveragePercentage. 
        /// <para>
        /// The percentage of branches that are covered by your tests.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public double? BranchCoveragePercentage { get; set; }

        /// <summary>
        /// Checks to see if the BranchCoveragePercentage property is set.
        /// </summary>
        internal bool IsSetBranchCoveragePercentage() => this.BranchCoveragePercentage.HasValue;

        /// <summary>
        /// Gets and sets the property BranchesCovered. 
        /// <para>
        /// The number of conditional branches that are covered by your tests.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? BranchesCovered { get; set; }

        /// <summary>
        /// Checks to see if the BranchesCovered property is set.
        /// </summary>
        internal bool IsSetBranchesCovered() => this.BranchesCovered.HasValue;

        /// <summary>
        /// Gets and sets the property BranchesMissed. 
        /// <para>
        /// The number of conditional branches that are not covered by your tests.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? BranchesMissed { get; set; }

        /// <summary>
        /// Checks to see if the BranchesMissed property is set.
        /// </summary>
        internal bool IsSetBranchesMissed() => this.BranchesMissed.HasValue;

        /// <summary>
        /// Gets and sets the property LineCoveragePercentage. 
        /// <para>
        /// The percentage of lines that are covered by your tests.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public double? LineCoveragePercentage { get; set; }

        /// <summary>
        /// Checks to see if the LineCoveragePercentage property is set.
        /// </summary>
        internal bool IsSetLineCoveragePercentage() => this.LineCoveragePercentage.HasValue;

        /// <summary>
        /// Gets and sets the property LinesCovered. 
        /// <para>
        /// The number of lines that are covered by your tests.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? LinesCovered { get; set; }

        /// <summary>
        /// Checks to see if the LinesCovered property is set.
        /// </summary>
        internal bool IsSetLinesCovered() => this.LinesCovered.HasValue;

        /// <summary>
        /// Gets and sets the property LinesMissed. 
        /// <para>
        /// The number of lines that are not covered by your tests.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? LinesMissed { get; set; }

        /// <summary>
        /// Checks to see if the LinesMissed property is set.
        /// </summary>
        internal bool IsSetLinesMissed() => this.LinesMissed.HasValue;
    }
}
