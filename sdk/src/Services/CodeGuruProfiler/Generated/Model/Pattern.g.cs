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

namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// A set of rules used to make a recommendation during an analysis.
    /// </summary>
    public partial class Pattern
    {
        /// <summary>
        /// Gets and sets the property CountersToAggregate. 
        /// <para>
        ///  A list of the different counters used to determine if there is a match. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CountersToAggregate { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CountersToAggregate property is set.
        /// </summary>
        internal bool IsSetCountersToAggregate() => this.CountersToAggregate != null && (this.CountersToAggregate.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the recommendation. This explains a potential inefficiency in a
        /// profiled application.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The universally unique identifier (UUID) of this pattern.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for this pattern.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResolutionSteps. 
        /// <para>
        ///  A string that contains the steps recommended to address the potential inefficiency.
        /// 
        /// </para>
        /// </summary>
        public string ResolutionSteps { get; set; }

        /// <summary>
        /// Checks to see if the ResolutionSteps property is set.
        /// </summary>
        internal bool IsSetResolutionSteps() => this.ResolutionSteps != null;

        /// <summary>
        /// Gets and sets the property TargetFrames. 
        /// <para>
        /// A list of frame names that were searched during the analysis that generated a recommendation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<List<string>> TargetFrames { get; set; } = AWSConfigs.InitializeCollections ? new List<List<string>>() : null;

        /// <summary>
        /// Checks to see if the TargetFrames property is set.
        /// </summary>
        internal bool IsSetTargetFrames() => this.TargetFrames != null && (this.TargetFrames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThresholdPercent. 
        /// <para>
        ///  The percentage of time an application spends in one method that triggers a recommendation.
        /// The percentage of time is the same as the percentage of the total gathered sample
        /// counts during analysis. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public double? ThresholdPercent { get; set; }

        /// <summary>
        /// Checks to see if the ThresholdPercent property is set.
        /// </summary>
        internal bool IsSetThresholdPercent() => this.ThresholdPercent.HasValue;
    }
}
