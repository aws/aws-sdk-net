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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
    /// Contains code coverage report information.
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
    public partial class CodeCoverage
    {
        private double? _branchCoveragePercentage;
        private int? _branchesCovered;
        private int? _branchesMissed;
        private DateTime? _expired;
        private string _filePath;
        private string _id;
        private double? _lineCoveragePercentage;
        private int? _linesCovered;
        private int? _linesMissed;
        private string _reportarn;

        /// <summary>
        /// Gets and sets the property BranchCoveragePercentage. 
        /// <para>
        /// The percentage of branches that are covered by your tests.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public double? BranchCoveragePercentage
        {
            get { return this._branchCoveragePercentage; }
            set { this._branchCoveragePercentage = value; }
        }

        // Check to see if BranchCoveragePercentage property is set
        internal bool IsSetBranchCoveragePercentage()
        {
            return this._branchCoveragePercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BranchesCovered. 
        /// <para>
        /// The number of conditional branches that are covered by your tests.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? BranchesCovered
        {
            get { return this._branchesCovered; }
            set { this._branchesCovered = value; }
        }

        // Check to see if BranchesCovered property is set
        internal bool IsSetBranchesCovered()
        {
            return this._branchesCovered.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BranchesMissed. 
        /// <para>
        /// The number of conditional branches that are not covered by your tests.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? BranchesMissed
        {
            get { return this._branchesMissed; }
            set { this._branchesMissed = value; }
        }

        // Check to see if BranchesMissed property is set
        internal bool IsSetBranchesMissed()
        {
            return this._branchesMissed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Expired. 
        /// <para>
        /// The date and time that the tests were run.
        /// </para>
        /// </summary>
        public DateTime? Expired
        {
            get { return this._expired; }
            set { this._expired = value; }
        }

        // Check to see if Expired property is set
        internal bool IsSetExpired()
        {
            return this._expired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FilePath. 
        /// <para>
        /// The path of the test report file.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string FilePath
        {
            get { return this._filePath; }
            set { this._filePath = value; }
        }

        // Check to see if FilePath property is set
        internal bool IsSetFilePath()
        {
            return this._filePath != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the code coverage report.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LineCoveragePercentage. 
        /// <para>
        /// The percentage of lines that are covered by your tests.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public double? LineCoveragePercentage
        {
            get { return this._lineCoveragePercentage; }
            set { this._lineCoveragePercentage = value; }
        }

        // Check to see if LineCoveragePercentage property is set
        internal bool IsSetLineCoveragePercentage()
        {
            return this._lineCoveragePercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LinesCovered. 
        /// <para>
        /// The number of lines that are covered by your tests.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? LinesCovered
        {
            get { return this._linesCovered; }
            set { this._linesCovered = value; }
        }

        // Check to see if LinesCovered property is set
        internal bool IsSetLinesCovered()
        {
            return this._linesCovered.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LinesMissed. 
        /// <para>
        /// The number of lines that are not covered by your tests.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? LinesMissed
        {
            get { return this._linesMissed; }
            set { this._linesMissed = value; }
        }

        // Check to see if LinesMissed property is set
        internal bool IsSetLinesMissed()
        {
            return this._linesMissed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReportARN. 
        /// <para>
        /// The ARN of the report.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ReportARN
        {
            get { return this._reportarn; }
            set { this._reportarn = value; }
        }

        // Check to see if ReportARN property is set
        internal bool IsSetReportARN()
        {
            return this._reportarn != null;
        }

    }
}