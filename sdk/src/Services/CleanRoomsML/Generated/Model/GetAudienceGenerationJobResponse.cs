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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// This is the response object from the GetAudienceGenerationJob operation.
    /// </summary>
    public partial class GetAudienceGenerationJobResponse : AmazonWebServiceResponse
    {
        private string _audienceGenerationJobArn;
        private string _collaborationId;
        private string _configuredAudienceModelArn;
        private DateTime? _createTime;
        private string _description;
        private bool? _includeSeedInOutput;
        private AudienceQualityMetrics _metrics;
        private string _name;
        private AudienceGenerationJobDataSource _seedAudience;
        private string _startedBy;
        private AudienceGenerationJobStatus _status;
        private StatusDetails _statusDetails;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property AudienceGenerationJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the audience generation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string AudienceGenerationJobArn
        {
            get { return this._audienceGenerationJobArn; }
            set { this._audienceGenerationJobArn = value; }
        }

        // Check to see if AudienceGenerationJobArn property is set
        internal bool IsSetAudienceGenerationJobArn()
        {
            return this._audienceGenerationJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property CollaborationId. 
        /// <para>
        /// The identifier of the collaboration that this audience generation job is associated
        /// with.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string CollaborationId
        {
            get { return this._collaborationId; }
            set { this._collaborationId = value; }
        }

        // Check to see if CollaborationId property is set
        internal bool IsSetCollaborationId()
        {
            return this._collaborationId != null;
        }

        /// <summary>
        /// Gets and sets the property ConfiguredAudienceModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the configured audience model used for this audience
        /// generation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ConfiguredAudienceModelArn
        {
            get { return this._configuredAudienceModelArn; }
            set { this._configuredAudienceModelArn = value; }
        }

        // Check to see if ConfiguredAudienceModelArn property is set
        internal bool IsSetConfiguredAudienceModelArn()
        {
            return this._configuredAudienceModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time at which the audience generation job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreateTime
        {
            get { return this._createTime.GetValueOrDefault(); }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the audience generation job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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
        /// Gets and sets the property IncludeSeedInOutput. 
        /// <para>
        /// Configure whether the seed users are included in the output audience. By default,
        /// Clean Rooms ML removes seed users from the output audience. If you specify <c>TRUE</c>,
        /// the seed users will appear first in the output. Clean Rooms ML does not explicitly
        /// reveal whether a user was in the seed, but the recipient of the audience will know
        /// that the first <c>minimumSeedSize</c> count of users are from the seed.
        /// </para>
        /// </summary>
        public bool IncludeSeedInOutput
        {
            get { return this._includeSeedInOutput.GetValueOrDefault(); }
            set { this._includeSeedInOutput = value; }
        }

        // Check to see if IncludeSeedInOutput property is set
        internal bool IsSetIncludeSeedInOutput()
        {
            return this._includeSeedInOutput.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// The relevance scores for different audience sizes and the recall score of the generated
        /// audience. 
        /// </para>
        /// </summary>
        public AudienceQualityMetrics Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the audience generation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// Gets and sets the property SeedAudience. 
        /// <para>
        /// The seed audience that was used for this audience generation job. This field will
        /// be null if the account calling the API is the account that started this audience generation
        /// job. 
        /// </para>
        /// </summary>
        public AudienceGenerationJobDataSource SeedAudience
        {
            get { return this._seedAudience; }
            set { this._seedAudience = value; }
        }

        // Check to see if SeedAudience property is set
        internal bool IsSetSeedAudience()
        {
            return this._seedAudience != null;
        }

        /// <summary>
        /// Gets and sets the property StartedBy. 
        /// <para>
        /// The AWS account that started this audience generation job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string StartedBy
        {
            get { return this._startedBy; }
            set { this._startedBy = value; }
        }

        // Check to see if StartedBy property is set
        internal bool IsSetStartedBy()
        {
            return this._startedBy != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the audience generation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AudienceGenerationJobStatus Status
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
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// Details about the status of the audience generation job.
        /// </para>
        /// </summary>
        public StatusDetails StatusDetails
        {
            get { return this._statusDetails; }
            set { this._statusDetails = value; }
        }

        // Check to see if StatusDetails property is set
        internal bool IsSetStatusDetails()
        {
            return this._statusDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that are associated to this audience generation job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
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
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The most recent time at which the audience generation job was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime UpdateTime
        {
            get { return this._updateTime.GetValueOrDefault(); }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}