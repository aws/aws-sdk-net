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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Describes a data quality ruleset returned by <c>GetDataQualityRuleset</c>.
    /// </summary>
    public partial class DataQualityRulesetListDetails
    {
        /// <summary>
        /// Gets and sets the property CreatedOn. 
        /// <para>
        /// The date and time the data quality ruleset was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Checks to see if the CreatedOn property is set.
        /// </summary>
        internal bool IsSetCreatedOn() => this.CreatedOn.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the data quality ruleset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastModifiedOn. 
        /// <para>
        /// The date and time the data quality ruleset was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedOn { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedOn property is set.
        /// </summary>
        internal bool IsSetLastModifiedOn() => this.LastModifiedOn.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data quality ruleset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RecommendationRunId. 
        /// <para>
        /// When a ruleset was created from a recommendation run, this run ID is generated to
        /// link the two together.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string RecommendationRunId { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationRunId property is set.
        /// </summary>
        internal bool IsSetRecommendationRunId() => this.RecommendationRunId != null;

        /// <summary>
        /// Gets and sets the property RuleCount. 
        /// <para>
        /// The number of rules in the ruleset.
        /// </para>
        /// </summary>
        public int? RuleCount { get; set; }

        /// <summary>
        /// Checks to see if the RuleCount property is set.
        /// </summary>
        internal bool IsSetRuleCount() => this.RuleCount.HasValue;

        /// <summary>
        /// Gets and sets the property TargetTable. 
        /// <para>
        /// An object representing an Glue table.
        /// </para>
        /// </summary>
        public DataQualityTargetTable TargetTable { get; set; }

        /// <summary>
        /// Checks to see if the TargetTable property is set.
        /// </summary>
        internal bool IsSetTargetTable() => this.TargetTable != null;
    }
}
