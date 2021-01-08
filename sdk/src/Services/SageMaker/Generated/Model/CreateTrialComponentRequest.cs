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
    /// Container for the parameters to the CreateTrialComponent operation.
    /// Creates a <i>trial component</i>, which is a stage of a machine learning <i>trial</i>.
    /// A trial is composed of one or more trial components. A trial component can be used
    /// in multiple trials.
    /// 
    ///  
    /// <para>
    /// Trial components include pre-processing jobs, training jobs, and batch transform jobs.
    /// </para>
    ///  
    /// <para>
    /// When you use Amazon SageMaker Studio or the Amazon SageMaker Python SDK, all experiments,
    /// trials, and trial components are automatically tracked, logged, and indexed. When
    /// you use the AWS SDK for Python (Boto), you must use the logging APIs provided by the
    /// SDK.
    /// </para>
    ///  
    /// <para>
    /// You can add tags to a trial component and then use the <a>Search</a> API to search
    /// for the tags.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <code>CreateTrialComponent</code> can only be invoked from within an Amazon SageMaker
    /// managed environment. This includes Amazon SageMaker training jobs, processing jobs,
    /// transform jobs, and Amazon SageMaker notebooks. A call to <code>CreateTrialComponent</code>
    /// from outside one of these environments results in an error.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateTrialComponentRequest : AmazonSageMakerRequest
    {
        private string _displayName;
        private DateTime? _endTime;
        private Dictionary<string, TrialComponentArtifact> _inputArtifacts = new Dictionary<string, TrialComponentArtifact>();
        private MetadataProperties _metadataProperties;
        private Dictionary<string, TrialComponentArtifact> _outputArtifacts = new Dictionary<string, TrialComponentArtifact>();
        private Dictionary<string, TrialComponentParameterValue> _parameters = new Dictionary<string, TrialComponentParameterValue>();
        private DateTime? _startTime;
        private TrialComponentStatus _status;
        private List<Tag> _tags = new List<Tag>();
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
        /// The input artifacts for the component. Examples of input artifacts are datasets, algorithms,
        /// hyperparameters, source code, and instance types.
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
        /// Gets and sets the property MetadataProperties.
        /// </summary>
        public MetadataProperties MetadataProperties
        {
            get { return this._metadataProperties; }
            set { this._metadataProperties = value; }
        }

        // Check to see if MetadataProperties property is set
        internal bool IsSetMetadataProperties()
        {
            return this._metadataProperties != null;
        }

        /// <summary>
        /// Gets and sets the property OutputArtifacts. 
        /// <para>
        /// The output artifacts for the component. Examples of output artifacts are metrics,
        /// snapshots, logs, and images.
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
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The hyperparameters for the component.
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
        /// The status of the component. States include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// InProgress
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Completed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failed
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to associate with the component. You can use <a>Search</a> API to search
        /// on the tags.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TrialComponentName. 
        /// <para>
        /// The name of the component. The name must be unique in your AWS account and is not
        /// case-sensitive.
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