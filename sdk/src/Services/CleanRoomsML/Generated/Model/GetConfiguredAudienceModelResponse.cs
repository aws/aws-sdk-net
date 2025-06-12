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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// This is the response object from the GetConfiguredAudienceModel operation.
    /// </summary>
    public partial class GetConfiguredAudienceModelResponse : AmazonWebServiceResponse
    {
        private string _audienceModelArn;
        private AudienceSizeConfig _audienceSizeConfig;
        private TagOnCreatePolicy _childResourceTagOnCreatePolicy;
        private string _configuredAudienceModelArn;
        private DateTime? _createTime;
        private string _description;
        private int? _minMatchingSeedSize;
        private string _name;
        private ConfiguredAudienceModelOutputConfig _outputConfig;
        private List<string> _sharedAudienceMetrics = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ConfiguredAudienceModelStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property AudienceModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the audience model used for this configured audience
        /// model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string AudienceModelArn
        {
            get { return this._audienceModelArn; }
            set { this._audienceModelArn = value; }
        }

        // Check to see if AudienceModelArn property is set
        internal bool IsSetAudienceModelArn()
        {
            return this._audienceModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property AudienceSizeConfig. 
        /// <para>
        /// The list of output sizes of audiences that can be created using this configured audience
        /// model. A request to <a>StartAudienceGenerationJob</a> that uses this configured audience
        /// model must have an <c>audienceSize</c> selected from this list. You can use the <c>ABSOLUTE</c>
        /// <a>AudienceSize</a> to configure out audience sizes using the count of identifiers
        /// in the output. You can use the <c>Percentage</c> <a>AudienceSize</a> to configure
        /// sizes in the range 1-100 percent.
        /// </para>
        /// </summary>
        public AudienceSizeConfig AudienceSizeConfig
        {
            get { return this._audienceSizeConfig; }
            set { this._audienceSizeConfig = value; }
        }

        // Check to see if AudienceSizeConfig property is set
        internal bool IsSetAudienceSizeConfig()
        {
            return this._audienceSizeConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ChildResourceTagOnCreatePolicy. 
        /// <para>
        /// Provides the <c>childResourceTagOnCreatePolicy</c> that was used for this configured
        /// audience model.
        /// </para>
        /// </summary>
        public TagOnCreatePolicy ChildResourceTagOnCreatePolicy
        {
            get { return this._childResourceTagOnCreatePolicy; }
            set { this._childResourceTagOnCreatePolicy = value; }
        }

        // Check to see if ChildResourceTagOnCreatePolicy property is set
        internal bool IsSetChildResourceTagOnCreatePolicy()
        {
            return this._childResourceTagOnCreatePolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ConfiguredAudienceModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the configured audience model.
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
        /// The time at which the configured audience model was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreateTime
        {
            get { return this._createTime; }
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
        /// The description of the configured audience model.
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
        /// Gets and sets the property MinMatchingSeedSize. 
        /// <para>
        /// The minimum number of users from the seed audience that must match with users in the
        /// training data of the audience model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=25, Max=500000)]
        public int? MinMatchingSeedSize
        {
            get { return this._minMatchingSeedSize; }
            set { this._minMatchingSeedSize = value; }
        }

        // Check to see if MinMatchingSeedSize property is set
        internal bool IsSetMinMatchingSeedSize()
        {
            return this._minMatchingSeedSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the configured audience model.
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
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The output configuration of the configured audience model
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfiguredAudienceModelOutputConfig OutputConfig
        {
            get { return this._outputConfig; }
            set { this._outputConfig = value; }
        }

        // Check to see if OutputConfig property is set
        internal bool IsSetOutputConfig()
        {
            return this._outputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SharedAudienceMetrics. 
        /// <para>
        /// Whether audience metrics are shared.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> SharedAudienceMetrics
        {
            get { return this._sharedAudienceMetrics; }
            set { this._sharedAudienceMetrics = value; }
        }

        // Check to see if SharedAudienceMetrics property is set
        internal bool IsSetSharedAudienceMetrics()
        {
            return this._sharedAudienceMetrics != null && (this._sharedAudienceMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the configured audience model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfiguredAudienceModelStatus Status
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
        /// The tags that are associated to this configured audience model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// The most recent time at which the configured audience model was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdateTime
        {
            get { return this._updateTime; }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}