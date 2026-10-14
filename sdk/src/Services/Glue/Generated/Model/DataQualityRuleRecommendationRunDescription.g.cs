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
    /// Describes the result of a data quality rule recommendation run.
    /// </summary>
    public partial class DataQualityRuleRecommendationRunDescription
    {
        /// <summary>
        /// Gets and sets the property CreatedRulesetName. 
        /// <para>
        /// The name of the ruleset that was created by the recommendation run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CreatedRulesetName { get; set; }

        /// <summary>
        /// Checks to see if the CreatedRulesetName property is set.
        /// </summary>
        internal bool IsSetCreatedRulesetName() => this.CreatedRulesetName != null;

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The data source (Glue table) associated with the recommendation run.
        /// </para>
        /// </summary>
        public DataSource DataSource { get; set; }

        /// <summary>
        /// Checks to see if the DataSource property is set.
        /// </summary>
        internal bool IsSetDataSource() => this.DataSource != null;

        /// <summary>
        /// Gets and sets the property RecommendationMode. 
        /// <para>
        /// The mode that Glue Data Quality uses to recommend rules.
        /// </para>
        ///  
        /// <para>
        /// The default is <c>BASIC</c>.
        /// </para>
        /// </summary>
        public RecommendationMode RecommendationMode { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationMode property is set.
        /// </summary>
        internal bool IsSetRecommendationMode() => this.RecommendationMode != null;

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The unique run identifier associated with this run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string RunId { get; set; }

        /// <summary>
        /// Checks to see if the RunId property is set.
        /// </summary>
        internal bool IsSetRunId() => this.RunId != null;

        /// <summary>
        /// Gets and sets the property StartedOn. 
        /// <para>
        /// The date and time when this run started.
        /// </para>
        /// </summary>
        public DateTime? StartedOn { get; set; }

        /// <summary>
        /// Checks to see if the StartedOn property is set.
        /// </summary>
        internal bool IsSetStartedOn() => this.StartedOn.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status for this run.
        /// </para>
        /// </summary>
        public TaskStatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
