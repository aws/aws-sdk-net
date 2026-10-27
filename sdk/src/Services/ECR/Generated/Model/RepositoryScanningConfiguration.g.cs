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

namespace Amazon.ECR.Model
{
    /// <summary>
    /// The details of the scanning configuration for a repository.
    /// </summary>
    public partial class RepositoryScanningConfiguration
    {
        /// <summary>
        /// Gets and sets the property AppliedScanFilters. 
        /// <para>
        /// The scan filters applied to the repository.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<ScanningRepositoryFilter> AppliedScanFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<ScanningRepositoryFilter>() : null;

        /// <summary>
        /// Checks to see if the AppliedScanFilters property is set.
        /// </summary>
        internal bool IsSetAppliedScanFilters() => this.AppliedScanFilters != null && (this.AppliedScanFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RepositoryArn. 
        /// <para>
        /// The ARN of the repository.
        /// </para>
        /// </summary>
        public string RepositoryArn { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryArn property is set.
        /// </summary>
        internal bool IsSetRepositoryArn() => this.RepositoryArn != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 256)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;

        /// <summary>
        /// Gets and sets the property ScanFrequency. 
        /// <para>
        /// The scan frequency for the repository.
        /// </para>
        /// </summary>
        public ScanFrequency ScanFrequency { get; set; }

        /// <summary>
        /// Checks to see if the ScanFrequency property is set.
        /// </summary>
        internal bool IsSetScanFrequency() => this.ScanFrequency != null;

        /// <summary>
        /// Gets and sets the property ScanOnPush. 
        /// <para>
        /// Whether or not scan on push is configured for the repository.
        /// </para>
        /// </summary>
        public bool? ScanOnPush { get; set; }

        /// <summary>
        /// Checks to see if the ScanOnPush property is set.
        /// </summary>
        internal bool IsSetScanOnPush() => this.ScanOnPush.HasValue;
    }
}
