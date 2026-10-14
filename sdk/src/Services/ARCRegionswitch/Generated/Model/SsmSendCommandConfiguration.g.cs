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
    /// Configuration for an AWS Systems Manager <c>SendCommand</c> execution block in a Region
    /// switch plan. This execution block runs a Systems Manager document on the managed nodes
    /// that you target in each Amazon Web Services Region of the plan.
    /// </summary>
    public partial class SsmSendCommandConfiguration
    {
        /// <summary>
        /// Gets and sets the property RegionDocuments. 
        /// <para>
        /// The Systems Manager document and target configuration for each Amazon Web Services
        /// Region in the plan. Provide an entry for each Amazon Web Services Region that you
        /// want the command to run in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2)]
        public Dictionary<string, SsmDocumentConfig> RegionDocuments { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, SsmDocumentConfig>() : null;

        /// <summary>
        /// Checks to see if the RegionDocuments property is set.
        /// </summary>
        internal bool IsSetRegionDocuments() => this.RegionDocuments != null && (this.RegionDocuments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RetryIntervalMinutes. 
        /// <para>
        /// How often, in minutes, Region switch retries the command if it returns a failure.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public float? RetryIntervalMinutes { get; set; }

        /// <summary>
        /// Checks to see if the RetryIntervalMinutes property is set.
        /// </summary>
        internal bool IsSetRetryIntervalMinutes() => this.RetryIntervalMinutes.HasValue;

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
        /// Specifies the settings that determine how the execution block behaves when the plan
        /// runs ungracefully, such as whether to skip the command.
        /// </para>
        /// </summary>
        public SsmSendCommandUngraceful Ungraceful { get; set; }

        /// <summary>
        /// Checks to see if the Ungraceful property is set.
        /// </summary>
        internal bool IsSetUngraceful() => this.Ungraceful != null;
    }
}
