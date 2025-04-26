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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
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
        private string _procStepName;
        private int? _procStepNumber;
        private int? _stepCheckpoint;
        private string _stepCheckpointStatus;
        private DateTime? _stepCheckpointTime;
        private string _stepCondCode;
        private string _stepName;
        private int? _stepNumber;
        private bool? _stepRestartable;

        /// <summary>
        /// Gets and sets the property ProcStepName. 
        /// <para>
        /// The name of a procedure step.
        /// </para>
        /// </summary>
        public string ProcStepName
        {
            get { return this._procStepName; }
            set { this._procStepName = value; }
        }

        // Check to see if ProcStepName property is set
        internal bool IsSetProcStepName()
        {
            return this._procStepName != null;
        }

        /// <summary>
        /// Gets and sets the property ProcStepNumber. 
        /// <para>
        /// The number of a procedure step.
        /// </para>
        /// </summary>
        public int? ProcStepNumber
        {
            get { return this._procStepNumber; }
            set { this._procStepNumber = value; }
        }

        // Check to see if ProcStepNumber property is set
        internal bool IsSetProcStepNumber()
        {
            return this._procStepNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StepCheckpoint. 
        /// <para>
        /// A registered step-level checkpoint identifier that can be used for restarting an Amazon
        /// Web Services Blu Age application batch job.
        /// </para>
        /// </summary>
        public int? StepCheckpoint
        {
            get { return this._stepCheckpoint; }
            set { this._stepCheckpoint = value; }
        }

        // Check to see if StepCheckpoint property is set
        internal bool IsSetStepCheckpoint()
        {
            return this._stepCheckpoint.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StepCheckpointStatus. 
        /// <para>
        /// The step-level checkpoint status for an Amazon Web Services Blu Age application batch
        /// job.
        /// </para>
        /// </summary>
        public string StepCheckpointStatus
        {
            get { return this._stepCheckpointStatus; }
            set { this._stepCheckpointStatus = value; }
        }

        // Check to see if StepCheckpointStatus property is set
        internal bool IsSetStepCheckpointStatus()
        {
            return this._stepCheckpointStatus != null;
        }

        /// <summary>
        /// Gets and sets the property StepCheckpointTime. 
        /// <para>
        /// The step-level checkpoint status for an Amazon Web Services Blu Age application batch
        /// job.
        /// </para>
        /// </summary>
        public DateTime? StepCheckpointTime
        {
            get { return this._stepCheckpointTime; }
            set { this._stepCheckpointTime = value; }
        }

        // Check to see if StepCheckpointTime property is set
        internal bool IsSetStepCheckpointTime()
        {
            return this._stepCheckpointTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StepCondCode. 
        /// <para>
        /// The condition code of a step.
        /// </para>
        /// </summary>
        public string StepCondCode
        {
            get { return this._stepCondCode; }
            set { this._stepCondCode = value; }
        }

        // Check to see if StepCondCode property is set
        internal bool IsSetStepCondCode()
        {
            return this._stepCondCode != null;
        }

        /// <summary>
        /// Gets and sets the property StepName. 
        /// <para>
        /// The name of a step.
        /// </para>
        /// </summary>
        public string StepName
        {
            get { return this._stepName; }
            set { this._stepName = value; }
        }

        // Check to see if StepName property is set
        internal bool IsSetStepName()
        {
            return this._stepName != null;
        }

        /// <summary>
        /// Gets and sets the property StepNumber. 
        /// <para>
        /// The number of a step.
        /// </para>
        /// </summary>
        public int? StepNumber
        {
            get { return this._stepNumber; }
            set { this._stepNumber = value; }
        }

        // Check to see if StepNumber property is set
        internal bool IsSetStepNumber()
        {
            return this._stepNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StepRestartable. 
        /// <para>
        /// Specifies if a step can be restarted or not.
        /// </para>
        /// </summary>
        public bool? StepRestartable
        {
            get { return this._stepRestartable; }
            set { this._stepRestartable = value; }
        }

        // Check to see if StepRestartable property is set
        internal bool IsSetStepRestartable()
        {
            return this._stepRestartable.HasValue; 
        }

    }
}