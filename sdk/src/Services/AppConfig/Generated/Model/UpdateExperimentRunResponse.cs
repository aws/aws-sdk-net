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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
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
namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Describes an experiment run, including its status, exposure settings, and treatment
    /// overrides.
    /// </summary>
    public partial class UpdateExperimentRunResponse : AmazonWebServiceResponse
    {
        private string _applicationId;
        private string _description;
        private DateTime? _endedAt;
        private string _experimentDefinitionId;
        private ExperimentDefinitionSnapshot _experimentDefinitionSnapshot;
        private float? _exposurePercentage;
        private ExperimentRunResult _result;
        private int? _run;
        private DateTime? _startedAt;
        private ExperimentRunStatus _status;
        private TreatmentOverrides _treatmentOverrides;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The application ID.
        /// </para>
        /// </summary>
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the experiment run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The date and time the experiment run ended, in ISO 8601 format.
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
        /// Gets and sets the property ExperimentDefinitionId. 
        /// <para>
        /// The experiment definition ID.
        /// </para>
        /// </summary>
        public string ExperimentDefinitionId
        {
            get { return this._experimentDefinitionId; }
            set { this._experimentDefinitionId = value; }
        }

        // Check to see if ExperimentDefinitionId property is set
        internal bool IsSetExperimentDefinitionId()
        {
            return this._experimentDefinitionId != null;
        }

        /// <summary>
        /// Gets and sets the property ExperimentDefinitionSnapshot. 
        /// <para>
        /// A snapshot of the experiment definition at the time the run was started.
        /// </para>
        /// </summary>
        public ExperimentDefinitionSnapshot ExperimentDefinitionSnapshot
        {
            get { return this._experimentDefinitionSnapshot; }
            set { this._experimentDefinitionSnapshot = value; }
        }

        // Check to see if ExperimentDefinitionSnapshot property is set
        internal bool IsSetExperimentDefinitionSnapshot()
        {
            return this._experimentDefinitionSnapshot != null;
        }

        /// <summary>
        /// Gets and sets the property ExposurePercentage. 
        /// <para>
        /// The percentage of the target audience exposed to treatments.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float? ExposurePercentage
        {
            get { return this._exposurePercentage; }
            set { this._exposurePercentage = value; }
        }

        // Check to see if ExposurePercentage property is set
        internal bool IsSetExposurePercentage()
        {
            return this._exposurePercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// The result of the experiment run, including the executive summary and launch decision
        /// rationale.
        /// </para>
        /// </summary>
        public ExperimentRunResult Result
        {
            get { return this._result; }
            set { this._result = value; }
        }

        // Check to see if Result property is set
        internal bool IsSetResult()
        {
            return this._result != null;
        }

        /// <summary>
        /// Gets and sets the property Run. 
        /// <para>
        /// The experiment run number.
        /// </para>
        /// </summary>
        public int? Run
        {
            get { return this._run; }
            set { this._run = value; }
        }

        // Check to see if Run property is set
        internal bool IsSetRun()
        {
            return this._run.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The date and time the experiment run started, in ISO 8601 format.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the experiment run. Valid values: <c>RUNNING</c>, <c>DONE</c>.
        /// </para>
        /// </summary>
        public ExperimentRunStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TreatmentOverrides. 
        /// <para>
        /// Treatment assignment overrides that assign specific entity IDs to treatments.
        /// </para>
        /// </summary>
        public TreatmentOverrides TreatmentOverrides
        {
            get { return this._treatmentOverrides; }
            set { this._treatmentOverrides = value; }
        }

        // Check to see if TreatmentOverrides property is set
        internal bool IsSetTreatmentOverrides()
        {
            return this._treatmentOverrides != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the experiment run was last updated, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}