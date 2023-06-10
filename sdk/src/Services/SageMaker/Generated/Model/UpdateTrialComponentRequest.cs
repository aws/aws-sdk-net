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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTrialComponent operation.
    /// Updates one or more properties of a trial component.
    /// </summary>
    public partial class UpdateTrialComponentRequest : AmazonSageMakerRequest
    {
        private string _displayName;
        private DateTime? _endTime;
        private Dictionary<string, TrialComponentArtifact> _inputArtifacts = new Dictionary<string, TrialComponentArtifact>();
        private List<string> _inputArtifactsToRemove = new List<string>();
        private Dictionary<string, TrialComponentArtifact> _outputArtifacts = new Dictionary<string, TrialComponentArtifact>();
        private List<string> _outputArtifactsToRemove = new List<string>();
        private Dictionary<string, TrialComponentParameterValue> _parameters = new Dictionary<string, TrialComponentParameterValue>();
        private List<string> _parametersToRemove = new List<string>();
        private DateTime? _startTime;
        private TrialComponentStatus _status;
        private string _trialComponentName;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the component as displayed. The name doesn't need to be unique. If <code>DisplayName</code>
        /// isn't specified, <code>TrialComponentName</code> is displayed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=120)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// When the component ended.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputArtifacts. 
        /// <para>
        /// Replaces all of the component's input artifacts with the specified artifacts or adds
        /// new input artifacts. Existing input artifacts are replaced if the trial component
        /// is updated with an identical input artifact key.
        /// </para>
        /// </summary>
        [AWSProperty(Max=30)]
        public Dictionary<string, TrialComponentArtifact> InputArtifacts
        {
            get { return this._inputArtifacts; }
            set { this._inputArtifacts = value; }
        }

        // Check to see if InputArtifacts property is set
        internal bool IsSetInputArtifacts()
        {
            return this._inputArtifacts != null && this._inputArtifacts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InputArtifactsToRemove. 
        /// <para>
        /// The input artifacts to remove from the component.
        /// </para>
        /// </summary>
        public List<string> InputArtifactsToRemove
        {
            get { return this._inputArtifactsToRemove; }
            set { this._inputArtifactsToRemove = value; }
        }

        // Check to see if InputArtifactsToRemove property is set
        internal bool IsSetInputArtifactsToRemove()
        {
            return this._inputArtifactsToRemove != null && this._inputArtifactsToRemove.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OutputArtifacts. 
        /// <para>
        /// Replaces all of the component's output artifacts with the specified artifacts or adds
        /// new output artifacts. Existing output artifacts are replaced if the trial component
        /// is updated with an identical output artifact key.
        /// </para>
        /// </summary>
        [AWSProperty(Max=30)]
        public Dictionary<string, TrialComponentArtifact> OutputArtifacts
        {
            get { return this._outputArtifacts; }
            set { this._outputArtifacts = value; }
        }

        // Check to see if OutputArtifacts property is set
        internal bool IsSetOutputArtifacts()
        {
            return this._outputArtifacts != null && this._outputArtifacts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OutputArtifactsToRemove. 
        /// <para>
        /// The output artifacts to remove from the component.
        /// </para>
        /// </summary>
        public List<string> OutputArtifactsToRemove
        {
            get { return this._outputArtifactsToRemove; }
            set { this._outputArtifactsToRemove = value; }
        }

        // Check to see if OutputArtifactsToRemove property is set
        internal bool IsSetOutputArtifactsToRemove()
        {
            return this._outputArtifactsToRemove != null && this._outputArtifactsToRemove.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Replaces all of the component's hyperparameters with the specified hyperparameters
        /// or add new hyperparameters. Existing hyperparameters are replaced if the trial component
        /// is updated with an identical hyperparameter key.
        /// </para>
        /// </summary>
        [AWSProperty(Max=150)]
        public Dictionary<string, TrialComponentParameterValue> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ParametersToRemove. 
        /// <para>
        /// The hyperparameters to remove from the component.
        /// </para>
        /// </summary>
        public List<string> ParametersToRemove
        {
            get { return this._parametersToRemove; }
            set { this._parametersToRemove = value; }
        }

        // Check to see if ParametersToRemove property is set
        internal bool IsSetParametersToRemove()
        {
            return this._parametersToRemove != null && this._parametersToRemove.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// When the component started.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The new status of the component.
        /// </para>
        /// </summary>
        public TrialComponentStatus Status
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
        /// Gets and sets the property TrialComponentName. 
        /// <para>
        /// The name of the component to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=120)]
        public string TrialComponentName
        {
            get { return this._trialComponentName; }
            set { this._trialComponentName = value; }
        }

        // Check to see if TrialComponentName property is set
        internal bool IsSetTrialComponentName()
        {
            return this._trialComponentName != null;
        }

    }
}