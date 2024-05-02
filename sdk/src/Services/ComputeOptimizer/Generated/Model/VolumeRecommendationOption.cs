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
    /// Describes a recommendation option for an Amazon Elastic Block Store (Amazon EBS) instance.
    /// </summary>
    public partial class VolumeRecommendationOption
    {
        private VolumeConfiguration _configuration;
        private double? _performanceRisk;
        private int? _rank;
        private SavingsOpportunity _savingsOpportunity;
        private EBSSavingsOpportunityAfterDiscounts _savingsOpportunityAfterDiscounts;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// An array of objects that describe a volume configuration.
        /// </para>
        /// </summary>
        public VolumeConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property PerformanceRisk. 
        /// <para>
        /// The performance risk of the volume recommendation option.
        /// </para>
        ///  
        /// <para>
        /// Performance risk is the likelihood of the recommended volume type meeting the performance
        /// requirement of your workload.
        /// </para>
        ///  
        /// <para>
        /// The value ranges from <c>0</c> - <c>4</c>, with <c>0</c> meaning that the recommended
        /// resource is predicted to always provide enough hardware capability. The higher the
        /// performance risk is, the more likely you should validate whether the recommendation
        /// will meet the performance requirements of your workload before migrating your resource.
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
        /// Gets and sets the property Rank. 
        /// <para>
        /// The rank of the volume recommendation option.
        /// </para>
        ///  
        /// <para>
        /// The top recommendation option is ranked as <c>1</c>.
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
        /// <para>
        /// An object that describes the savings opportunity for the EBS volume recommendation
        /// option. Savings opportunity includes the estimated monthly savings amount and percentage.
        /// </para>
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
        ///  An object that describes the savings opportunity for the Amazon EBS volume recommendation
        /// option with specific discounts. Savings opportunity includes the estimated monthly
        /// savings and percentage. 
        /// </para>
        /// </summary>
        public EBSSavingsOpportunityAfterDiscounts SavingsOpportunityAfterDiscounts
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