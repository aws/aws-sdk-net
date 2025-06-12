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
    /// Container for the parameters to the UpdateConfiguredAudienceModel operation.
    /// Provides the information necessary to update a configured audience model. Updates
    /// that impact audience generation jobs take effect when a new job starts, but do not
    /// impact currently running jobs.
    /// </summary>
    public partial class UpdateConfiguredAudienceModelRequest : AmazonCleanRoomsMLRequest
    {
        private string _audienceModelArn;
        private AudienceSizeConfig _audienceSizeConfig;
        private string _configuredAudienceModelArn;
        private string _description;
        private int? _minMatchingSeedSize;
        private ConfiguredAudienceModelOutputConfig _outputConfig;
        private List<string> _sharedAudienceMetrics = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AudienceModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the new audience model that you want to use.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// The new audience size configuration.
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
        /// Gets and sets the property ConfiguredAudienceModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the configured audience model that you want to update.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The new description of the configured audience model.
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
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The new output configuration.
        /// </para>
        /// </summary>
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
        /// The new value for whether to share audience metrics.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
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

    }
}