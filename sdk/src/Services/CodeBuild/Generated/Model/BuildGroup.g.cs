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

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Contains information about a batch build build group. Build groups are used to combine
    /// builds that can run in parallel, while still being able to set dependencies on other
    /// build groups.
    /// </summary>
    public partial class BuildGroup
    {
        /// <summary>
        /// Gets and sets the property CurrentBuildSummary. 
        /// <para>
        /// A <c>BuildSummary</c> object that contains a summary of the current build group.
        /// </para>
        /// </summary>
        public BuildSummary CurrentBuildSummary { get; set; }

        /// <summary>
        /// Checks to see if the CurrentBuildSummary property is set.
        /// </summary>
        internal bool IsSetCurrentBuildSummary() => this.CurrentBuildSummary != null;

        /// <summary>
        /// Gets and sets the property DependsOn. 
        /// <para>
        /// An array of strings that contain the identifiers of the build groups that this build
        /// group depends on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DependsOn { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DependsOn property is set.
        /// </summary>
        internal bool IsSetDependsOn() => this.DependsOn != null && (this.DependsOn.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// Contains the identifier of the build group.
        /// </para>
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property IgnoreFailure. 
        /// <para>
        /// Specifies if failures in this build group can be ignored.
        /// </para>
        /// </summary>
        public bool? IgnoreFailure { get; set; }

        /// <summary>
        /// Checks to see if the IgnoreFailure property is set.
        /// </summary>
        internal bool IsSetIgnoreFailure() => this.IgnoreFailure.HasValue;

        /// <summary>
        /// Gets and sets the property PriorBuildSummaryList. 
        /// <para>
        /// An array of <c>BuildSummary</c> objects that contain summaries of previous build groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BuildSummary> PriorBuildSummaryList { get; set; } = AWSConfigs.InitializeCollections ? new List<BuildSummary>() : null;

        /// <summary>
        /// Checks to see if the PriorBuildSummaryList property is set.
        /// </summary>
        internal bool IsSetPriorBuildSummaryList() => this.PriorBuildSummaryList != null && (this.PriorBuildSummaryList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
