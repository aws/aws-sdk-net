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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// A structure that contains the configuration settings for a media insights pipeline.
    /// </summary>
    public partial class MediaInsightsPipelineConfiguration
    {
        private DateTime? _createdTimestamp;
        private List<MediaInsightsPipelineConfigurationElement> _elements = new List<MediaInsightsPipelineConfigurationElement>();
        private string _mediaInsightsPipelineConfigurationArn;
        private string _mediaInsightsPipelineConfigurationId;
        private string _mediaInsightsPipelineConfigurationName;
        private RealTimeAlertConfiguration _realTimeAlertConfiguration;
        private string _resourceAccessRoleArn;
        private DateTime? _updatedTimestamp;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time at which the configuration was created.
        /// </para>
        /// </summary>
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Elements. 
        /// <para>
        /// The elements in the configuration.
        /// </para>
        /// </summary>
        public List<MediaInsightsPipelineConfigurationElement> Elements
        {
            get { return this._elements; }
            set { this._elements = value; }
        }

        // Check to see if Elements property is set
        internal bool IsSetElements()
        {
            return this._elements != null && this._elements.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MediaInsightsPipelineConfigurationArn. 
        /// <para>
        /// The ARN of the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string MediaInsightsPipelineConfigurationArn
        {
            get { return this._mediaInsightsPipelineConfigurationArn; }
            set { this._mediaInsightsPipelineConfigurationArn = value; }
        }

        // Check to see if MediaInsightsPipelineConfigurationArn property is set
        internal bool IsSetMediaInsightsPipelineConfigurationArn()
        {
            return this._mediaInsightsPipelineConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property MediaInsightsPipelineConfigurationId. 
        /// <para>
        /// The ID of the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string MediaInsightsPipelineConfigurationId
        {
            get { return this._mediaInsightsPipelineConfigurationId; }
            set { this._mediaInsightsPipelineConfigurationId = value; }
        }

        // Check to see if MediaInsightsPipelineConfigurationId property is set
        internal bool IsSetMediaInsightsPipelineConfigurationId()
        {
            return this._mediaInsightsPipelineConfigurationId != null;
        }

        /// <summary>
        /// Gets and sets the property MediaInsightsPipelineConfigurationName. 
        /// <para>
        /// The name of the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=64)]
        public string MediaInsightsPipelineConfigurationName
        {
            get { return this._mediaInsightsPipelineConfigurationName; }
            set { this._mediaInsightsPipelineConfigurationName = value; }
        }

        // Check to see if MediaInsightsPipelineConfigurationName property is set
        internal bool IsSetMediaInsightsPipelineConfigurationName()
        {
            return this._mediaInsightsPipelineConfigurationName != null;
        }

        /// <summary>
        /// Gets and sets the property RealTimeAlertConfiguration. 
        /// <para>
        /// Lists the rules that trigger a real-time alert.
        /// </para>
        /// </summary>
        public RealTimeAlertConfiguration RealTimeAlertConfiguration
        {
            get { return this._realTimeAlertConfiguration; }
            set { this._realTimeAlertConfiguration = value; }
        }

        // Check to see if RealTimeAlertConfiguration property is set
        internal bool IsSetRealTimeAlertConfiguration()
        {
            return this._realTimeAlertConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceAccessRoleArn. 
        /// <para>
        /// The ARN of the role used by the service to access Amazon Web Services resources.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string ResourceAccessRoleArn
        {
            get { return this._resourceAccessRoleArn; }
            set { this._resourceAccessRoleArn = value; }
        }

        // Check to see if ResourceAccessRoleArn property is set
        internal bool IsSetResourceAccessRoleArn()
        {
            return this._resourceAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        /// The time at which the configuration was last updated.
        /// </para>
        /// </summary>
        public DateTime UpdatedTimestamp
        {
            get { return this._updatedTimestamp.GetValueOrDefault(); }
            set { this._updatedTimestamp = value; }
        }

        // Check to see if UpdatedTimestamp property is set
        internal bool IsSetUpdatedTimestamp()
        {
            return this._updatedTimestamp.HasValue; 
        }

    }
}