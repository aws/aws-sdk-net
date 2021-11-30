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

namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateExperiment operation.
    /// Updates an Evidently experiment. 
    /// 
    ///  
    /// <para>
    /// Don't use this operation to update an experiment's tag. Instead, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_TagResource.html">TagResource</a>.
    /// 
    /// </para>
    /// </summary>
    public partial class UpdateExperimentRequest : AmazonCloudWatchEvidentlyRequest
    {
        private string _description;
        private string _experiment;
        private List<MetricGoalConfig> _metricGoals = new List<MetricGoalConfig>();
        private OnlineAbConfig _onlineAbConfig;
        private string _project;
        private string _randomizationSalt;
        private long? _samplingRate;
        private List<TreatmentConfig> _treatments = new List<TreatmentConfig>();

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description of the experiment.
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
        /// Gets and sets the property Experiment. 
        /// <para>
        /// The name of the experiment to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
        public string Experiment
        {
            get { return this._experiment; }
            set { this._experiment = value; }
        }

        // Check to see if Experiment property is set
        internal bool IsSetExperiment()
        {
            return this._experiment != null;
        }

        /// <summary>
        /// Gets and sets the property MetricGoals. 
        /// <para>
        /// An array of structures that defines the metrics used for the experiment, and whether
        /// a higher or lower value for each metric is the goal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public List<MetricGoalConfig> MetricGoals
        {
            get { return this._metricGoals; }
            set { this._metricGoals = value; }
        }

        // Check to see if MetricGoals property is set
        internal bool IsSetMetricGoals()
        {
            return this._metricGoals != null && this._metricGoals.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OnlineAbConfig. 
        /// <para>
        /// A structure that contains the configuration of which variation o use as the "control"
        /// version. The "control" version is used for comparison with other variations. This
        /// structure also specifies how much experiment traffic is allocated to each variation.
        /// </para>
        /// </summary>
        public OnlineAbConfig OnlineAbConfig
        {
            get { return this._onlineAbConfig; }
            set { this._onlineAbConfig = value; }
        }

        // Check to see if OnlineAbConfig property is set
        internal bool IsSetOnlineAbConfig()
        {
            return this._onlineAbConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Project. 
        /// <para>
        /// The name or ARN of the project that contains the experiment that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
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
        /// When Evidently assigns a particular user session to an experiment, it must use a randomization
        /// ID to determine which variation the user session is served. This randomization ID
        /// is a combination of the entity ID and <code>randomizationSalt</code>. If you omit
        /// <code>randomizationSalt</code>, Evidently uses the experiment name as the <code>randomizationSalt</code>.
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
        /// The portion of the available audience that you want to allocate to this experiment,
        /// in thousandths of a percent. The available audience is the total audience minus the
        /// audience that you have allocated to overrides or current launches of this feature.
        /// </para>
        ///  
        /// <para>
        /// This is represented in thousandths of a percent. For example, specify 20,000 to allocate
        /// 20% of the available audience.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100000)]
        public long SamplingRate
        {
            get { return this._samplingRate.GetValueOrDefault(); }
            set { this._samplingRate = value; }
        }

        // Check to see if SamplingRate property is set
        internal bool IsSetSamplingRate()
        {
            return this._samplingRate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Treatments. 
        /// <para>
        /// An array of structures that define the variations being tested in the experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<TreatmentConfig> Treatments
        {
            get { return this._treatments; }
            set { this._treatments = value; }
        }

        // Check to see if Treatments property is set
        internal bool IsSetTreatments()
        {
            return this._treatments != null && this._treatments.Count > 0; 
        }

    }
}