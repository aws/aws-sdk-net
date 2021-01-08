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
    /// An Autopilot job returns recommendations, or candidates. Each candidate has futher
    /// details about the steps involed, and the status.
    /// </summary>
    public partial class AutoMLCandidate
    {
        private string _candidateName;
        private CandidateStatus _candidateStatus;
        private List<AutoMLCandidateStep> _candidateSteps = new List<AutoMLCandidateStep>();
        private DateTime? _creationTime;
        private DateTime? _endTime;
        private string _failureReason;
        private FinalAutoMLJobObjectiveMetric _finalAutoMLJobObjectiveMetric;
        private List<AutoMLContainerDefinition> _inferenceContainers = new List<AutoMLContainerDefinition>();
        private DateTime? _lastModifiedTime;
        private ObjectiveStatus _objectiveStatus;

        /// <summary>
        /// Gets and sets the property CandidateName. 
        /// <para>
        /// The candidate name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string CandidateName
        {
            get { return this._candidateName; }
            set { this._candidateName = value; }
        }

        // Check to see if CandidateName property is set
        internal bool IsSetCandidateName()
        {
            return this._candidateName != null;
        }

        /// <summary>
        /// Gets and sets the property CandidateStatus. 
        /// <para>
        /// The candidate's status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CandidateStatus CandidateStatus
        {
            get { return this._candidateStatus; }
            set { this._candidateStatus = value; }
        }

        // Check to see if CandidateStatus property is set
        internal bool IsSetCandidateStatus()
        {
            return this._candidateStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CandidateSteps. 
        /// <para>
        /// The candidate's steps.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AutoMLCandidateStep> CandidateSteps
        {
            get { return this._candidateSteps; }
            set { this._candidateSteps = value; }
        }

        // Check to see if CandidateSteps property is set
        internal bool IsSetCandidateSteps()
        {
            return this._candidateSteps != null && this._candidateSteps.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time.
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
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The failure reason.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property FinalAutoMLJobObjectiveMetric.
        /// </summary>
        public FinalAutoMLJobObjectiveMetric FinalAutoMLJobObjectiveMetric
        {
            get { return this._finalAutoMLJobObjectiveMetric; }
            set { this._finalAutoMLJobObjectiveMetric = value; }
        }

        // Check to see if FinalAutoMLJobObjectiveMetric property is set
        internal bool IsSetFinalAutoMLJobObjectiveMetric()
        {
            return this._finalAutoMLJobObjectiveMetric != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceContainers. 
        /// <para>
        /// The inference containers.
        /// </para>
        /// </summary>
        [AWSProperty(Max=5)]
        public List<AutoMLContainerDefinition> InferenceContainers
        {
            get { return this._inferenceContainers; }
            set { this._inferenceContainers = value; }
        }

        // Check to see if InferenceContainers property is set
        internal bool IsSetInferenceContainers()
        {
            return this._inferenceContainers != null && this._inferenceContainers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last modified time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ObjectiveStatus. 
        /// <para>
        /// The objective status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ObjectiveStatus ObjectiveStatus
        {
            get { return this._objectiveStatus; }
            set { this._objectiveStatus = value; }
        }

        // Check to see if ObjectiveStatus property is set
        internal bool IsSetObjectiveStatus()
        {
            return this._objectiveStatus != null;
        }

    }
}