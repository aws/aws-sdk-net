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
    /// A structure that contains configuration information about an Evidently project.
    /// </summary>
    public partial class ProjectSummary
    {
        private long? _activeExperimentCount;
        private long? _activeLaunchCount;
        private string _arn;
        private DateTime? _createdTime;
        private string _description;
        private long? _experimentCount;
        private long? _featureCount;
        private DateTime? _lastUpdatedTime;
        private long? _launchCount;
        private string _name;
        private ProjectStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ActiveExperimentCount. 
        /// <para>
        /// The number of experiments currently in the project.
        /// </para>
        /// </summary>
        public long ActiveExperimentCount
        {
            get { return this._activeExperimentCount.GetValueOrDefault(); }
            set { this._activeExperimentCount = value; }
        }

        // Check to see if ActiveExperimentCount property is set
        internal bool IsSetActiveExperimentCount()
        {
            return this._activeExperimentCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ActiveLaunchCount. 
        /// <para>
        /// The number of ongoing launches currently in the project.
        /// </para>
        /// </summary>
        public long ActiveLaunchCount
        {
            get { return this._activeLaunchCount.GetValueOrDefault(); }
            set { this._activeLaunchCount = value; }
        }

        // Check to see if ActiveLaunchCount property is set
        internal bool IsSetActiveLaunchCount()
        {
            return this._activeLaunchCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The name or ARN of the project.
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
        /// The date and time that the project is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
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
        /// The description of the project.
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
        /// Gets and sets the property ExperimentCount. 
        /// <para>
        /// The number of experiments currently in the project.
        /// </para>
        /// </summary>
        public long ExperimentCount
        {
            get { return this._experimentCount.GetValueOrDefault(); }
            set { this._experimentCount = value; }
        }

        // Check to see if ExperimentCount property is set
        internal bool IsSetExperimentCount()
        {
            return this._experimentCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FeatureCount. 
        /// <para>
        /// The number of features currently in the project.
        /// </para>
        /// </summary>
        public long FeatureCount
        {
            get { return this._featureCount.GetValueOrDefault(); }
            set { this._featureCount = value; }
        }

        // Check to see if FeatureCount property is set
        internal bool IsSetFeatureCount()
        {
            return this._featureCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The date and time that the project was most recently updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LaunchCount. 
        /// <para>
        /// The number of launches currently in the project, including launches that are ongoing,
        /// completed, and not started yet.
        /// </para>
        /// </summary>
        public long LaunchCount
        {
            get { return this._launchCount.GetValueOrDefault(); }
            set { this._launchCount = value; }
        }

        // Check to see if LaunchCount property is set
        internal bool IsSetLaunchCount()
        {
            return this._launchCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the project.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProjectStatus Status
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
        /// The list of tag keys and values associated with this project.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}