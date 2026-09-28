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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdateConfiguredAudienceModel operation. Provides
    /// the information necessary to update a configured audience model. Updates that impact
    /// audience generation jobs take effect when a new job starts, but do not impact currently
    /// running jobs.
    /// </summary>
    public partial class UpdateConfiguredAudienceModelRequest : AmazonCleanRoomsMLRequest
    {
        /// <summary>
        /// Gets and sets the property AudienceModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the new audience model that you want to use.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string AudienceModelArn { get; set; }

        /// <summary>
        /// Checks to see if the AudienceModelArn property is set.
        /// </summary>
        internal bool IsSetAudienceModelArn() => this.AudienceModelArn != null;

        /// <summary>
        /// Gets and sets the property AudienceSizeConfig. 
        /// <para>
        /// The new audience size configuration.
        /// </para>
        /// </summary>
        public AudienceSizeConfig AudienceSizeConfig { get; set; }

        /// <summary>
        /// Checks to see if the AudienceSizeConfig property is set.
        /// </summary>
        internal bool IsSetAudienceSizeConfig() => this.AudienceSizeConfig != null;

        /// <summary>
        /// Gets and sets the property ConfiguredAudienceModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the configured audience model that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ConfiguredAudienceModelArn { get; set; }

        /// <summary>
        /// Checks to see if the ConfiguredAudienceModelArn property is set.
        /// </summary>
        internal bool IsSetConfiguredAudienceModelArn() => this.ConfiguredAudienceModelArn != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The new description of the configured audience model.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property MinMatchingSeedSize. 
        /// <para>
        /// The minimum number of users from the seed audience that must match with users in the
        /// training data of the audience model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 25, Max = 500000)]
        public int? MinMatchingSeedSize { get; set; }

        /// <summary>
        /// Checks to see if the MinMatchingSeedSize property is set.
        /// </summary>
        internal bool IsSetMinMatchingSeedSize() => this.MinMatchingSeedSize.HasValue;

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The new output configuration.
        /// </para>
        /// </summary>
        public ConfiguredAudienceModelOutputConfig OutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfig property is set.
        /// </summary>
        internal bool IsSetOutputConfig() => this.OutputConfig != null;

        /// <summary>
        /// Gets and sets the property SharedAudienceMetrics. 
        /// <para>
        /// The new value for whether to share audience metrics.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<string> SharedAudienceMetrics { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SharedAudienceMetrics property is set.
        /// </summary>
        internal bool IsSetSharedAudienceMetrics() => this.SharedAudienceMetrics != null && (this.SharedAudienceMetrics.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
