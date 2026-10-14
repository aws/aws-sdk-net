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
    /// Configuration for Amazon Web Services Lambda functions that perform custom actions
    /// during a Region switch.
    /// </summary>
    public partial class CustomActionLambdaConfiguration
    {
        /// <summary>
        /// Gets and sets the property Lambdas. 
        /// <para>
        /// The Amazon Web Services Lambda functions for the execution block.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2)]
        public List<Lambdas> Lambdas { get; set; } = AWSConfigs.InitializeCollections ? new List<Lambdas>() : null;

        /// <summary>
        /// Checks to see if the Lambdas property is set.
        /// </summary>
        internal bool IsSetLambdas() => this.Lambdas != null && (this.Lambdas.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RegionToRun. 
        /// <para>
        /// The Amazon Web Services Region for the function to run in. For recovery workflows
        /// use <c>activatingRegion</c> or <c>deactivatingRegion</c>. For post-recovery workflows,
        /// use <c>activeRegion</c> (the Region with customer traffic) or <c>inactiveRegion</c>
        /// (the Region with no customer traffic).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RegionToRunIn RegionToRun { get; set; }

        /// <summary>
        /// Checks to see if the RegionToRun property is set.
        /// </summary>
        internal bool IsSetRegionToRun() => this.RegionToRun != null;

        /// <summary>
        /// Gets and sets the property RetryIntervalMinutes. 
        /// <para>
        /// The retry interval specified.
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
        /// The settings for ungraceful execution.
        /// </para>
        /// </summary>
        public LambdaUngraceful Ungraceful { get; set; }

        /// <summary>
        /// Checks to see if the Ungraceful property is set.
        /// </summary>
        internal bool IsSetUngraceful() => this.Ungraceful != null;
    }
}
