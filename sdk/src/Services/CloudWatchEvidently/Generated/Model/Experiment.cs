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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
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
namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// A structure containing the configuration details of an experiment.
    /// </summary>
    public partial class Experiment
    {
        private string _arn;
        private DateTime? _createdTime;
        private string _description;
        private ExperimentExecution _execution;
        private DateTime? _lastUpdatedTime;
        private List<MetricGoal> _metricGoals = AWSConfigs.InitializeCollections ? new List<MetricGoal>() : null;
        private string _name;
        private OnlineAbDefinition _onlineAbDefinition;
        private string _project;
        private string _randomizationSalt;
        private long? _samplingRate;
        private ExperimentSchedule _schedule;
        private string _segment;
        private ExperimentStatus _status;
        private string _statusReason;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<Treatment> _treatments = AWSConfigs.InitializeCollections ? new List<Treatment>() : null;
        private ExperimentType _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The date and time that the experiment is first created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=160)]
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
        /// Gets and sets the property Execution. 
        /// <para>
        /// A structure that contains the date and time that the experiment started and ended.
        /// </para>
        /// </summary>
        public ExperimentExecution Execution
        {
            get { return this._execution; }
            set { this._execution = value; }
        }

        // Check to see if Execution property is set
        internal bool IsSetExecution()
        {
            return this._execution != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The date and time that the experiment was most recently updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricGoals. 
        /// <para>
        /// An array of structures that defines the metrics used for the experiment, and whether
        /// a higher or lower value for each metric is the goal.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public List<MetricGoal> MetricGoals
        {
            get { return this._metricGoals; }
            set { this._metricGoals = value; }
        }

        // Check to see if MetricGoals property is set
        internal bool IsSetMetricGoals()
        {
            return this._metricGoals != null && (this._metricGoals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OnlineAbDefinition. 
        /// <para>
        /// A structure that contains the configuration of which variation to use as the "control"
        /// version. The "control" version is used for comparison with other variations. This
        /// structure also specifies how much experiment traffic is allocated to each variation.
        /// </para>
        /// </summary>
        public OnlineAbDefinition OnlineAbDefinition
        {
            get { return this._onlineAbDefinition; }
            set { this._onlineAbDefinition = value; }
        }

        // Check to see if OnlineAbDefinition property is set
        internal bool IsSetOnlineAbDefinition()
        {
            return this._onlineAbDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property Project. 
        /// <para>
        /// The name or ARN of the project that contains this experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Project
        {
            get { return this._project; }
            set { this._project = value; }
        }

        // Check to see if Project property is set
        internal bool IsSetProject()
        {
            return this._project != null;
        }

        /// <summary>
        /// Gets and sets the property RandomizationSalt. 
        /// <para>
        /// This value is used when Evidently assigns a particular user session to the experiment.
        /// It helps create a randomization ID to determine which variation the user session is
        /// served. This randomization ID is a combination of the entity ID and <c>randomizationSalt</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=127)]
        public string RandomizationSalt
        {
            get { return this._randomizationSalt; }
            set { this._randomizationSalt = value; }
        }

        // Check to see if RandomizationSalt property is set
        internal bool IsSetRandomizationSalt()
        {
            return this._randomizationSalt != null;
        }

        /// <summary>
        /// Gets and sets the property SamplingRate. 
        /// <para>
        /// In thousandths of a percent, the amount of the available audience that is allocated
        /// to this experiment. The available audience is the total audience minus the audience
        /// that you have allocated to overrides or current launches of this feature.
        /// </para>
        ///  
        /// <para>
        /// This is represented in thousandths of a percent, so a value of 10,000 is 10% of the
        /// available audience.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100000)]
        public long? SamplingRate
        {
            get { return this._samplingRate; }
            set { this._samplingRate = value; }
        }

        // Check to see if SamplingRate property is set
        internal bool IsSetSamplingRate()
        {
            return this._samplingRate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// A structure that contains the time and date that Evidently completed the analysis
        /// of the experiment.
        /// </para>
        /// </summary>
        public ExperimentSchedule Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

        /// <summary>
        /// Gets and sets the property Segment. 
        /// <para>
        /// The audience segment being used for the experiment, if a segment is being used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Segment
        {
            get { return this._segment; }
            set { this._segment = value; }
        }

        // Check to see if Segment property is set
        internal bool IsSetSegment()
        {
            return this._segment != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExperimentStatus Status
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
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// If the experiment was stopped, this is the string that was entered by the person who
        /// stopped the experiment, to explain why it was stopped.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=160)]
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tag keys and values associated with this experiment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Treatments. 
        /// <para>
        /// An array of structures that describe the configuration of each feature variation used
        /// in the experiment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=2, Max=5)]
        public List<Treatment> Treatments
        {
            get { return this._treatments; }
            set { this._treatments = value; }
        }

        // Check to see if Treatments property is set
        internal bool IsSetTreatments()
        {
            return this._treatments != null && (this._treatments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of this experiment. Currently, this value must be <c>aws.experiment.onlineab</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExperimentType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}