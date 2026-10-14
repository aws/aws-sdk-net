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
    /// This is the response object from the GetDataQualityRuleset operation.
    /// </summary>
    public partial class GetDataQualityRulesetResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedOn. 
        /// <para>
        /// A timestamp. The time and date that this data quality ruleset was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Checks to see if the CreatedOn property is set.
        /// </summary>
        internal bool IsSetCreatedOn() => this.CreatedOn.HasValue;

        /// <summary>
        /// Gets and sets the property DataQualitySecurityConfiguration. 
        /// <para>
        /// The name of the security configuration created with the data quality encryption option.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DataQualitySecurityConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DataQualitySecurityConfiguration property is set.
        /// </summary>
        internal bool IsSetDataQualitySecurityConfiguration() => this.DataQualitySecurityConfiguration != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the ruleset.
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
        /// A timestamp. The last point in time when this data quality ruleset was modified.
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
        /// The name of the ruleset.
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
        /// Gets and sets the property Ruleset. 
        /// <para>
        /// A Data Quality Definition Language (DQDL) ruleset. For more information, see the Glue
        /// developer guide.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65536)]
        public string Ruleset { get; set; }

        /// <summary>
        /// Checks to see if the Ruleset property is set.
        /// </summary>
        internal bool IsSetRuleset() => this.Ruleset != null;

        /// <summary>
        /// Gets and sets the property TargetTable. 
        /// <para>
        /// The name and database name of the target table.
        /// </para>
        /// </summary>
        public DataQualityTargetTable TargetTable { get; set; }

        /// <summary>
        /// Checks to see if the TargetTable property is set.
        /// </summary>
        internal bool IsSetTargetTable() => this.TargetTable != null;
    }
}
