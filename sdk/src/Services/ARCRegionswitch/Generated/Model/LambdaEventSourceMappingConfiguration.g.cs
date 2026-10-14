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

namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// Configuration for Amazon Web Services Lambda event source mappings used in a Region
    /// switch plan.
    /// </summary>
    public partial class LambdaEventSourceMappingConfiguration
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to take - whether to <c>enable</c> or <c>disable</c> an event source mapping.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EventSourceMappingAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property RegionEventSourceMappings. 
        /// <para>
        /// Per-region configuration for which Lambda event source mapping to enable or disable
        /// when activating or deactivating a region.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2)]
        public Dictionary<string, EventSourceMapping> RegionEventSourceMappings { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, EventSourceMapping>() : null;

        /// <summary>
        /// Checks to see if the RegionEventSourceMappings property is set.
        /// </summary>
        internal bool IsSetRegionEventSourceMappings() => this.RegionEventSourceMappings != null && (this.RegionEventSourceMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeoutMinutes. 
        /// <para>
        /// The timeout value specified for the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? TimeoutMinutes { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutMinutes property is set.
        /// </summary>
        internal bool IsSetTimeoutMinutes() => this.TimeoutMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property Ungraceful. 
        /// <para>
        /// The settings for ungraceful execution.
        /// </para>
        /// </summary>
        public LambdaEventSourceMappingUngraceful Ungraceful { get; set; }

        /// <summary>
        /// Checks to see if the Ungraceful property is set.
        /// </summary>
        internal bool IsSetUngraceful() => this.Ungraceful != null;
    }
}
