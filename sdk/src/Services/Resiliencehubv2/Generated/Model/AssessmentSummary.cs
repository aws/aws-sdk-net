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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Contains summary information about a failure mode assessment.
    /// </summary>
    public partial class AssessmentSummary
    {
        private Achievability _achievability;
        private AssessmentCost _assessmentCost;
        private string _assessmentId;
        private AssessmentStatus _assessmentStatus;
        private AssessmentStep _assessmentStep;
        private int? _billableAssessmentUnitCount;
        private DateTime? _endedAt;
        private AssessmentErrorCode _errorCode;
        private string _errorMessage;
        private string _serviceArn;
        private DateTime? _startedAt;
        private int? _totalFindings;

        /// <summary>
        /// Gets and sets the property Achievability. 
        /// <para>
        /// The achievability results from the assessment.
        /// </para>
        /// </summary>
        public Achievability Achievability
        {
            get { return this._achievability; }
            set { this._achievability = value; }
        }

        // Check to see if Achievability property is set
        internal bool IsSetAchievability()
        {
            return this._achievability != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentCost. 
        /// <para>
        /// The cost of the assessment.
        /// </para>
        /// </summary>
        public AssessmentCost AssessmentCost
        {
            get { return this._assessmentCost; }
            set { this._assessmentCost = value; }
        }

        // Check to see if AssessmentCost property is set
        internal bool IsSetAssessmentCost()
        {
            return this._assessmentCost != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentId. 
        /// <para>
        /// The unique identifier of the assessment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string AssessmentId
        {
            get { return this._assessmentId; }
            set { this._assessmentId = value; }
        }

        // Check to see if AssessmentId property is set
        internal bool IsSetAssessmentId()
        {
            return this._assessmentId != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentStatus. 
        /// <para>
        /// The current status of the assessment.
        /// </para>
        /// </summary>
        public AssessmentStatus AssessmentStatus
        {
            get { return this._assessmentStatus; }
            set { this._assessmentStatus = value; }
        }

        // Check to see if AssessmentStatus property is set
        internal bool IsSetAssessmentStatus()
        {
            return this._assessmentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentStep. 
        /// <para>
        /// The current step of the assessment process.
        /// </para>
        /// </summary>
        public AssessmentStep AssessmentStep
        {
            get { return this._assessmentStep; }
            set { this._assessmentStep = value; }
        }

        // Check to see if AssessmentStep property is set
        internal bool IsSetAssessmentStep()
        {
            return this._assessmentStep != null;
        }

        /// <summary>
        /// Gets and sets the property BillableAssessmentUnitCount. 
        /// <para>
        /// The number of billable assessment units consumed by the assessment.
        /// </para>
        /// </summary>
        public int? BillableAssessmentUnitCount
        {
            get { return this._billableAssessmentUnitCount; }
            set { this._billableAssessmentUnitCount = value; }
        }

        // Check to see if BillableAssessmentUnitCount property is set
        internal bool IsSetBillableAssessmentUnitCount()
        {
            return this._billableAssessmentUnitCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The timestamp when the assessment ended.
        /// </para>
        /// </summary>
        public DateTime? EndedAt
        {
            get { return this._endedAt; }
            set { this._endedAt = value; }
        }

        // Check to see if EndedAt property is set
        internal bool IsSetEndedAt()
        {
            return this._endedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code if the assessment failed.
        /// </para>
        /// </summary>
        public AssessmentErrorCode ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A message describing the error if the assessment failed.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceArn.
        /// </summary>
        [AWSProperty(Required=true, Min=31)]
        public string ServiceArn
        {
            get { return this._serviceArn; }
            set { this._serviceArn = value; }
        }

        // Check to see if ServiceArn property is set
        internal bool IsSetServiceArn()
        {
            return this._serviceArn != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp when the assessment started.
        /// </para>
        /// </summary>
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalFindings. 
        /// <para>
        /// The total number of findings generated by the assessment.
        /// </para>
        /// </summary>
        public int? TotalFindings
        {
            get { return this._totalFindings; }
            set { this._totalFindings = value; }
        }

        // Check to see if TotalFindings property is set
        internal bool IsSetTotalFindings()
        {
            return this._totalFindings.HasValue; 
        }

    }
}