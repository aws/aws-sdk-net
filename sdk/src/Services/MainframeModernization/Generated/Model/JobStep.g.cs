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

namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// Provides information related to a job step.
    /// </summary>
    public partial class JobStep
    {
        /// <summary>
        /// Gets and sets the property ProcStepName. 
        /// <para>
        /// The name of a procedure step.
        /// </para>
        /// </summary>
        public string ProcStepName { get; set; }

        /// <summary>
        /// Checks to see if the ProcStepName property is set.
        /// </summary>
        internal bool IsSetProcStepName() => this.ProcStepName != null;

        /// <summary>
        /// Gets and sets the property ProcStepNumber. 
        /// <para>
        /// The number of a procedure step.
        /// </para>
        /// </summary>
        public int? ProcStepNumber { get; set; }

        /// <summary>
        /// Checks to see if the ProcStepNumber property is set.
        /// </summary>
        internal bool IsSetProcStepNumber() => this.ProcStepNumber.HasValue;

        /// <summary>
        /// Gets and sets the property StepCheckpoint. 
        /// <para>
        /// A registered step-level checkpoint identifier that can be used for restarting an Amazon
        /// Web Services Blu Age application batch job.
        /// </para>
        /// </summary>
        public int? StepCheckpoint { get; set; }

        /// <summary>
        /// Checks to see if the StepCheckpoint property is set.
        /// </summary>
        internal bool IsSetStepCheckpoint() => this.StepCheckpoint.HasValue;

        /// <summary>
        /// Gets and sets the property StepCheckpointStatus. 
        /// <para>
        /// The step-level checkpoint status for an Amazon Web Services Blu Age application batch
        /// job.
        /// </para>
        /// </summary>
        public string StepCheckpointStatus { get; set; }

        /// <summary>
        /// Checks to see if the StepCheckpointStatus property is set.
        /// </summary>
        internal bool IsSetStepCheckpointStatus() => this.StepCheckpointStatus != null;

        /// <summary>
        /// Gets and sets the property StepCheckpointTime. 
        /// <para>
        /// The step-level checkpoint status for an Amazon Web Services Blu Age application batch
        /// job.
        /// </para>
        /// </summary>
        public DateTime? StepCheckpointTime { get; set; }

        /// <summary>
        /// Checks to see if the StepCheckpointTime property is set.
        /// </summary>
        internal bool IsSetStepCheckpointTime() => this.StepCheckpointTime.HasValue;

        /// <summary>
        /// Gets and sets the property StepCondCode. 
        /// <para>
        /// The condition code of a step.
        /// </para>
        /// </summary>
        public string StepCondCode { get; set; }

        /// <summary>
        /// Checks to see if the StepCondCode property is set.
        /// </summary>
        internal bool IsSetStepCondCode() => this.StepCondCode != null;

        /// <summary>
        /// Gets and sets the property StepName. 
        /// <para>
        /// The name of a step.
        /// </para>
        /// </summary>
        public string StepName { get; set; }

        /// <summary>
        /// Checks to see if the StepName property is set.
        /// </summary>
        internal bool IsSetStepName() => this.StepName != null;

        /// <summary>
        /// Gets and sets the property StepNumber. 
        /// <para>
        /// The number of a step.
        /// </para>
        /// </summary>
        public int? StepNumber { get; set; }

        /// <summary>
        /// Checks to see if the StepNumber property is set.
        /// </summary>
        internal bool IsSetStepNumber() => this.StepNumber.HasValue;

        /// <summary>
        /// Gets and sets the property StepRestartable. 
        /// <para>
        /// Specifies if a step can be restarted or not.
        /// </para>
        /// </summary>
        public bool? StepRestartable { get; set; }

        /// <summary>
        /// Checks to see if the StepRestartable property is set.
        /// </summary>
        internal bool IsSetStepRestartable() => this.StepRestartable.HasValue;
    }
}
