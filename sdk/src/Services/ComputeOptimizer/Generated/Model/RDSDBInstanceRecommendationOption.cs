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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
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
        private string _dbInstanceClass;
        private double? _performanceRisk;
        private List<RDSDBUtilizationMetric> _projectedUtilizationMetrics = AWSConfigs.InitializeCollections ? new List<RDSDBUtilizationMetric>() : null;
        private int? _rank;
        private SavingsOpportunity _savingsOpportunity;
        private RDSInstanceSavingsOpportunityAfterDiscounts _savingsOpportunityAfterDiscounts;

        /// <summary>
        /// Gets and sets the property DbInstanceClass. 
        /// <para>
        ///  Describes the DB instance class recommendation option for your Amazon Aurora or RDS
        /// database. 
        /// </para>
        /// </summary>
        public string DbInstanceClass
        {
            get { return this._dbInstanceClass; }
            set { this._dbInstanceClass = value; }
        }

        // Check to see if DbInstanceClass property is set
        internal bool IsSetDbInstanceClass()
        {
            return this._dbInstanceClass != null;
        }

        /// <summary>
        /// Gets and sets the property PerformanceRisk. 
        /// <para>
        ///  The performance risk of the DB instance recommendation option. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4)]
        public double? PerformanceRisk
        {
            get { return this._performanceRisk; }
            set { this._performanceRisk = value; }
        }

        // Check to see if PerformanceRisk property is set
        internal bool IsSetPerformanceRisk()
        {
            return this._performanceRisk.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProjectedUtilizationMetrics. 
        /// <para>
        ///  An array of objects that describe the projected utilization metrics of the DB instance
        /// recommendation option. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RDSDBUtilizationMetric> ProjectedUtilizationMetrics
        {
            get { return this._projectedUtilizationMetrics; }
            set { this._projectedUtilizationMetrics = value; }
        }

        // Check to see if ProjectedUtilizationMetrics property is set
        internal bool IsSetProjectedUtilizationMetrics()
        {
            return this._projectedUtilizationMetrics != null && (this._projectedUtilizationMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Rank. 
        /// <para>
        ///  The rank identifier of the DB instance recommendation option. 
        /// </para>
        /// </summary>
        public int? Rank
        {
            get { return this._rank; }
            set { this._rank = value; }
        }

        // Check to see if Rank property is set
        internal bool IsSetRank()
        {
            return this._rank.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SavingsOpportunity.
        /// </summary>
        public SavingsOpportunity SavingsOpportunity
        {
            get { return this._savingsOpportunity; }
            set { this._savingsOpportunity = value; }
        }

        // Check to see if SavingsOpportunity property is set
        internal bool IsSetSavingsOpportunity()
        {
            return this._savingsOpportunity != null;
        }

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
        public RDSInstanceSavingsOpportunityAfterDiscounts SavingsOpportunityAfterDiscounts
        {
            get { return this._savingsOpportunityAfterDiscounts; }
            set { this._savingsOpportunityAfterDiscounts = value; }
        }

        // Check to see if SavingsOpportunityAfterDiscounts property is set
        internal bool IsSetSavingsOpportunityAfterDiscounts()
        {
            return this._savingsOpportunityAfterDiscounts != null;
        }

    }
}