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
    /// Container for the parameters to the CreateLaunch operation.
    /// Creates a <i>launch</i> of a given feature. Before you create a launch, you must create
    /// the feature to use for the launch.
    /// 
    ///  
    /// <para>
    /// You can use a launch to safely validate new features by serving them to a specified
    /// percentage of your users while you roll out the feature. You can monitor the performance
    /// of the new feature to help you decide when to ramp up traffic to more users. This
    /// helps you reduce risk and identify unintended consequences before you fully launch
    /// the feature.
    /// </para>
    ///  
    /// <para>
    /// Don't use this operation to update an existing launch. Instead, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_UpdateLaunch.html">UpdateLaunch</a>.
    /// 
    /// </para>
    /// </summary>
    public partial class CreateLaunchRequest : AmazonCloudWatchEvidentlyRequest
    {
        private string _description;
        private List<LaunchGroupConfig> _groups = new List<LaunchGroupConfig>();
        private List<MetricMonitorConfig> _metricMonitors = new List<MetricMonitorConfig>();
        private string _name;
        private string _project;
        private string _randomizationSalt;
        private ScheduledSplitsLaunchConfig _scheduledSplitsConfig;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the launch.
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
        /// Gets and sets the property Groups. 
        /// <para>
        /// An array of structures that contains the feature and variations that are to be used
        /// for the launch.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<LaunchGroupConfig> Groups
        {
            get { return this._groups; }
            set { this._groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this._groups != null && this._groups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MetricMonitors. 
        /// <para>
        /// An array of structures that define the metrics that will be used to monitor the launch
        /// performance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<MetricMonitorConfig> MetricMonitors
        {
            get { return this._metricMonitors; }
            set { this._metricMonitors = value; }
        }

        // Check to see if MetricMonitors property is set
        internal bool IsSetMetricMonitors()
        {
            return this._metricMonitors != null && this._metricMonitors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the new launch.
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
        /// Gets and sets the property Project. 
        /// <para>
        /// The name or ARN of the project that you want to create the launch in.
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
        /// When Evidently assigns a particular user session to a launch, it must use a randomization
        /// ID to determine which variation the user session is served. This randomization ID
        /// is a combination of the entity ID and <code>randomizationSalt</code>. If you omit
        /// <code>randomizationSalt</code>, Evidently uses the launch name as the <code>randomizationSalt</code>.
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
        /// Gets and sets the property ScheduledSplitsConfig. 
        /// <para>
        /// An array of structures that define the traffic allocation percentages among the feature
        /// variations during each step of the launch.
        /// </para>
        /// </summary>
        public ScheduledSplitsLaunchConfig ScheduledSplitsConfig
        {
            get { return this._scheduledSplitsConfig; }
            set { this._scheduledSplitsConfig = value; }
        }

        // Check to see if ScheduledSplitsConfig property is set
        internal bool IsSetScheduledSplitsConfig()
        {
            return this._scheduledSplitsConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Assigns one or more tags (key-value pairs) to the launch.
        /// </para>
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
        /// as strings of characters.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a launch.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}