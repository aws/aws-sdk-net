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

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// This is the response object from the StartExperimentRun operation.
    /// </summary>
    public partial class StartExperimentRunResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The application ID.
        /// </para>
        /// </summary>
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the experiment run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The date and time the experiment run ended, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ExperimentDefinitionId. 
        /// <para>
        /// The experiment definition ID.
        /// </para>
        /// </summary>
        public string ExperimentDefinitionId { get; set; }

        /// <summary>
        /// Checks to see if the ExperimentDefinitionId property is set.
        /// </summary>
        internal bool IsSetExperimentDefinitionId() => this.ExperimentDefinitionId != null;

        /// <summary>
        /// Gets and sets the property ExperimentDefinitionSnapshot. 
        /// <para>
        /// A snapshot of the experiment definition at the time the run was started.
        /// </para>
        /// </summary>
        public ExperimentDefinitionSnapshot ExperimentDefinitionSnapshot { get; set; }

        /// <summary>
        /// Checks to see if the ExperimentDefinitionSnapshot property is set.
        /// </summary>
        internal bool IsSetExperimentDefinitionSnapshot() => this.ExperimentDefinitionSnapshot != null;

        /// <summary>
        /// Gets and sets the property ExposurePercentage. 
        /// <para>
        /// The percentage of the target audience exposed to treatments.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public float? ExposurePercentage { get; set; }

        /// <summary>
        /// Checks to see if the ExposurePercentage property is set.
        /// </summary>
        internal bool IsSetExposurePercentage() => this.ExposurePercentage.HasValue;

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// The result of the experiment run, including the executive summary and launch decision
        /// rationale.
        /// </para>
        /// </summary>
        public ExperimentRunResult Result { get; set; }

        /// <summary>
        /// Checks to see if the Result property is set.
        /// </summary>
        internal bool IsSetResult() => this.Result != null;

        /// <summary>
        /// Gets and sets the property Run. 
        /// <para>
        /// The experiment run number.
        /// </para>
        /// </summary>
        public int? Run { get; set; }

        /// <summary>
        /// Checks to see if the Run property is set.
        /// </summary>
        internal bool IsSetRun() => this.Run.HasValue;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The date and time the experiment run started, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the experiment run. Valid values: <c>RUNNING</c>, <c>DONE</c>.
        /// </para>
        /// </summary>
        public ExperimentRunStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TreatmentOverrides. 
        /// <para>
        /// Treatment assignment overrides that assign specific entity IDs to treatments.
        /// </para>
        /// </summary>
        public TreatmentOverrides TreatmentOverrides { get; set; }

        /// <summary>
        /// Checks to see if the TreatmentOverrides property is set.
        /// </summary>
        internal bool IsSetTreatmentOverrides() => this.TreatmentOverrides != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the experiment run was last updated, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
