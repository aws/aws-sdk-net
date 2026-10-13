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

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes the recommendation options for a DB instance.
    /// </summary>
    public partial class RDSDBInstanceRecommendationOption
    {
        /// <summary>
        /// Gets and sets the property DbInstanceClass. 
        /// <para>
        ///  Describes the DB instance class recommendation option for your Amazon Aurora or RDS
        /// database. 
        /// </para>
        /// </summary>
        public string DbInstanceClass { get; set; }

        /// <summary>
        /// Checks to see if the DbInstanceClass property is set.
        /// </summary>
        internal bool IsSetDbInstanceClass() => this.DbInstanceClass != null;

        /// <summary>
        /// Gets and sets the property PerformanceRisk. 
        /// <para>
        ///  The performance risk of the DB instance recommendation option. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4)]
        public double? PerformanceRisk { get; set; }

        /// <summary>
        /// Checks to see if the PerformanceRisk property is set.
        /// </summary>
        internal bool IsSetPerformanceRisk() => this.PerformanceRisk.HasValue;

        /// <summary>
        /// Gets and sets the property ProjectedUtilizationMetrics. 
        /// <para>
        ///  An array of objects that describe the projected utilization metrics of the DB instance
        /// recommendation option. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RDSDBUtilizationMetric> ProjectedUtilizationMetrics { get; set; } = AWSConfigs.InitializeCollections ? new List<RDSDBUtilizationMetric>() : null;

        /// <summary>
        /// Checks to see if the ProjectedUtilizationMetrics property is set.
        /// </summary>
        internal bool IsSetProjectedUtilizationMetrics() => this.ProjectedUtilizationMetrics != null && (this.ProjectedUtilizationMetrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Rank. 
        /// <para>
        ///  The rank identifier of the DB instance recommendation option. 
        /// </para>
        /// </summary>
        public int? Rank { get; set; }

        /// <summary>
        /// Checks to see if the Rank property is set.
        /// </summary>
        internal bool IsSetRank() => this.Rank.HasValue;

        /// <summary>
        /// Gets and sets the property SavingsOpportunity.
        /// </summary>
        public SavingsOpportunity SavingsOpportunity { get; set; }

        /// <summary>
        /// Checks to see if the SavingsOpportunity property is set.
        /// </summary>
        internal bool IsSetSavingsOpportunity() => this.SavingsOpportunity != null;

        /// <summary>
        /// Gets and sets the property SavingsOpportunityAfterDiscounts. 
        /// <para>
        ///  Describes the savings opportunity for Amazon Aurora and RDS database recommendations
        /// or for the recommendation option. 
        /// </para>
        ///  
        /// <para>
        /// Savings opportunity represents the estimated monthly savings after applying Savings
        /// Plans discounts. You can achieve this by implementing a given Compute Optimizer recommendation.
        /// </para>
        /// </summary>
        public RDSInstanceSavingsOpportunityAfterDiscounts SavingsOpportunityAfterDiscounts { get; set; }

        /// <summary>
        /// Checks to see if the SavingsOpportunityAfterDiscounts property is set.
        /// </summary>
        internal bool IsSetSavingsOpportunityAfterDiscounts() => this.SavingsOpportunityAfterDiscounts != null;
    }
}
