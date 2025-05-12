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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The container for the metadata for the ClarifyCheck step. For more information, see
    /// the topic on <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/build-and-manage-steps.html#step-type-clarify-check">ClarifyCheck
    /// step</a> in the <i>Amazon SageMaker Developer Guide</i>.
    /// </summary>
    public partial class ClarifyCheckStepMetadata
    {
        private string _baselineUsedForDriftCheckConstraints;
        private string _calculatedBaselineConstraints;
        private string _checkJobArn;
        private string _checkType;
        private string _modelPackageGroupName;
        private bool? _registerNewBaseline;
        private bool? _skipCheck;
        private string _violationReport;

        /// <summary>
        /// Gets and sets the property BaselineUsedForDriftCheckConstraints. 
        /// <para>
        /// The Amazon S3 URI of baseline constraints file to be used for the drift check.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string BaselineUsedForDriftCheckConstraints
        {
            get { return this._baselineUsedForDriftCheckConstraints; }
            set { this._baselineUsedForDriftCheckConstraints = value; }
        }

        // Check to see if BaselineUsedForDriftCheckConstraints property is set
        internal bool IsSetBaselineUsedForDriftCheckConstraints()
        {
            return this._baselineUsedForDriftCheckConstraints != null;
        }

        /// <summary>
        /// Gets and sets the property CalculatedBaselineConstraints. 
        /// <para>
        /// The Amazon S3 URI of the newly calculated baseline constraints file.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string CalculatedBaselineConstraints
        {
            get { return this._calculatedBaselineConstraints; }
            set { this._calculatedBaselineConstraints = value; }
        }

        // Check to see if CalculatedBaselineConstraints property is set
        internal bool IsSetCalculatedBaselineConstraints()
        {
            return this._calculatedBaselineConstraints != null;
        }

        /// <summary>
        /// Gets and sets the property CheckJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the check processing job that was run by this step's
        /// execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string CheckJobArn
        {
            get { return this._checkJobArn; }
            set { this._checkJobArn = value; }
        }

        // Check to see if CheckJobArn property is set
        internal bool IsSetCheckJobArn()
        {
            return this._checkJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property CheckType. 
        /// <para>
        /// The type of the Clarify Check step
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string CheckType
        {
            get { return this._checkType; }
            set { this._checkType = value; }
        }

        // Check to see if CheckType property is set
        internal bool IsSetCheckType()
        {
            return this._checkType != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageGroupName. 
        /// <para>
        /// The model package group name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ModelPackageGroupName
        {
            get { return this._modelPackageGroupName; }
            set { this._modelPackageGroupName = value; }
        }

        // Check to see if ModelPackageGroupName property is set
        internal bool IsSetModelPackageGroupName()
        {
            return this._modelPackageGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property RegisterNewBaseline. 
        /// <para>
        /// This flag indicates if a newly calculated baseline can be accessed through step properties
        /// <c>BaselineUsedForDriftCheckConstraints</c> and <c>BaselineUsedForDriftCheckStatistics</c>.
        /// If it is set to <c>False</c>, the previous baseline of the configured check type must
        /// also be available. These can be accessed through the <c>BaselineUsedForDriftCheckConstraints</c>
        /// property. 
        /// </para>
        /// </summary>
        public bool? RegisterNewBaseline
        {
            get { return this._registerNewBaseline; }
            set { this._registerNewBaseline = value; }
        }

        // Check to see if RegisterNewBaseline property is set
        internal bool IsSetRegisterNewBaseline()
        {
            return this._registerNewBaseline.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SkipCheck. 
        /// <para>
        /// This flag indicates if the drift check against the previous baseline will be skipped
        /// or not. If it is set to <c>False</c>, the previous baseline of the configured check
        /// type must be available.
        /// </para>
        /// </summary>
        public bool? SkipCheck
        {
            get { return this._skipCheck; }
            set { this._skipCheck = value; }
        }

        // Check to see if SkipCheck property is set
        internal bool IsSetSkipCheck()
        {
            return this._skipCheck.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ViolationReport. 
        /// <para>
        /// The Amazon S3 URI of the violation report if violations are detected.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ViolationReport
        {
            get { return this._violationReport; }
            set { this._violationReport = value; }
        }

        // Check to see if ViolationReport property is set
        internal bool IsSetViolationReport()
        {
            return this._violationReport != null;
        }

    }
}