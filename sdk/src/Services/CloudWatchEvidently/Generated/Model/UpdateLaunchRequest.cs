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
    /// Container for the parameters to the UpdateLaunch operation.
    /// Updates a launch of a given feature. 
    /// 
    ///  
    /// <para>
    /// Don't use this operation to update the tags of an existing launch. Instead, use <a
    /// href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_TagResource.html">TagResource</a>.
    /// 
    /// </para>
    /// </summary>
    public partial class UpdateLaunchRequest : AmazonCloudWatchEvidentlyRequest
    {
        private string _description;
        private List<LaunchGroupConfig> _groups = AWSConfigs.InitializeCollections ? new List<LaunchGroupConfig>() : null;
        private string _launch;
        private List<MetricMonitorConfig> _metricMonitors = AWSConfigs.InitializeCollections ? new List<MetricMonitorConfig>() : null;
        private string _project;
        private string _randomizationSalt;
        private ScheduledSplitsLaunchConfig _scheduledSplitsConfig;

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<LaunchGroupConfig> Groups
        {
            get { return this._groups; }
            set { this._groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this._groups != null && (this._groups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Launch. 
        /// <para>
        /// The name of the launch that is to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
        public string Launch
        {
            get { return this._launch; }
            set { this._launch = value; }
        }

        // Check to see if Launch property is set
        internal bool IsSetLaunch()
        {
            return this._launch != null;
        }

        /// <summary>
        /// Gets and sets the property MetricMonitors. 
        /// <para>
        /// An array of structures that define the metrics that will be used to monitor the launch
        /// performance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._metricMonitors != null && (this._metricMonitors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Project. 
        /// <para>
        /// The name or ARN of the project that contains the launch that you want to update.
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
        /// is a combination of the entity ID and <c>randomizationSalt</c>. If you omit <c>randomizationSalt</c>,
        /// Evidently uses the launch name as the <c>randomizationSalt</c>.
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

    }
}