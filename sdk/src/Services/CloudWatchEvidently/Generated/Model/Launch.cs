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
    /// This structure contains the configuration details of one Evidently launch.
    /// </summary>
    public partial class Launch
    {
        private string _arn;
        private DateTime? _createdTime;
        private string _description;
        private LaunchExecution _execution;
        private List<LaunchGroup> _groups = AWSConfigs.InitializeCollections ? new List<LaunchGroup>() : null;
        private DateTime? _lastUpdatedTime;
        private List<MetricMonitor> _metricMonitors = AWSConfigs.InitializeCollections ? new List<MetricMonitor>() : null;
        private string _name;
        private string _project;
        private string _randomizationSalt;
        private ScheduledSplitsLaunchDefinition _scheduledSplitsDefinition;
        private LaunchStatus _status;
        private string _statusReason;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private LaunchType _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the launch.
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
        /// The date and time that the launch is created.
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
        /// The description of the launch.
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
        /// A structure that contains information about the start and end times of the launch.
        /// </para>
        /// </summary>
        public LaunchExecution Execution
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
        /// Gets and sets the property Groups. 
        /// <para>
        /// An array of structures that define the feature variations that are being used in the
        /// launch.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LaunchGroup> Groups
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
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The date and time that the launch was most recently updated.
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
        /// Gets and sets the property MetricMonitors. 
        /// <para>
        /// An array of structures that define the metrics that are being used to monitor the
        /// launch performance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<MetricMonitor> MetricMonitors
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the launch.
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
        /// The name or ARN of the project that contains the launch.
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
        /// This value is used when Evidently assigns a particular user session to the launch,
        /// to help create a randomization ID to determine which variation the user session is
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
        /// Gets and sets the property ScheduledSplitsDefinition. 
        /// <para>
        /// An array of structures that define the traffic allocation percentages among the feature
        /// variations during each step of the launch.
        /// </para>
        /// </summary>
        public ScheduledSplitsLaunchDefinition ScheduledSplitsDefinition
        {
            get { return this._scheduledSplitsDefinition; }
            set { this._scheduledSplitsDefinition = value; }
        }

        // Check to see if ScheduledSplitsDefinition property is set
        internal bool IsSetScheduledSplitsDefinition()
        {
            return this._scheduledSplitsDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the launch.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LaunchStatus Status
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
        /// If the launch was stopped, this is the string that was entered by the person who stopped
        /// the launch, to explain why it was stopped.
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
        /// The list of tag keys and values associated with this launch.
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of launch.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LaunchType Type
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