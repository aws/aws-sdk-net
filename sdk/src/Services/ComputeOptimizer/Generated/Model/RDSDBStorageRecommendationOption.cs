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
    /// Describes the recommendation options for DB storage.
    /// </summary>
    public partial class RDSDBStorageRecommendationOption
    {
        private RDSEstimatedMonthlyVolumeIOPsCostVariation _estimatedMonthlyVolumeIOPsCostVariation;
        private int? _rank;
        private SavingsOpportunity _savingsOpportunity;
        private RDSStorageSavingsOpportunityAfterDiscounts _savingsOpportunityAfterDiscounts;
        private DBStorageConfiguration _storageConfiguration;

        /// <summary>
        /// Gets and sets the property EstimatedMonthlyVolumeIOPsCostVariation. 
        /// <para>
        ///  The projected level of variation in monthly I/O costs for the DB storage recommendation
        /// option. 
        /// </para>
        /// </summary>
        public RDSEstimatedMonthlyVolumeIOPsCostVariation EstimatedMonthlyVolumeIOPsCostVariation
        {
            get { return this._estimatedMonthlyVolumeIOPsCostVariation; }
            set { this._estimatedMonthlyVolumeIOPsCostVariation = value; }
        }

        // Check to see if EstimatedMonthlyVolumeIOPsCostVariation property is set
        internal bool IsSetEstimatedMonthlyVolumeIOPsCostVariation()
        {
            return this._estimatedMonthlyVolumeIOPsCostVariation != null;
        }

        /// <summary>
        /// Gets and sets the property Rank. 
        /// <para>
        ///  The rank identifier of the DB storage recommendation option. 
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
        ///  Describes the savings opportunity for DB storage recommendations or for the recommendation
        /// option. 
        /// </para>
        ///  
        /// <para>
        ///  Savings opportunity represents the estimated monthly savings after applying Savings
        /// Plans discounts. You can achieve this by implementing a given Compute Optimizer recommendation.
        /// 
        /// </para>
        /// </summary>
        public RDSStorageSavingsOpportunityAfterDiscounts SavingsOpportunityAfterDiscounts
        {
            get { return this._savingsOpportunityAfterDiscounts; }
            set { this._savingsOpportunityAfterDiscounts = value; }
        }

        // Check to see if SavingsOpportunityAfterDiscounts property is set
        internal bool IsSetSavingsOpportunityAfterDiscounts()
        {
            return this._savingsOpportunityAfterDiscounts != null;
        }

        /// <summary>
        /// Gets and sets the property StorageConfiguration. 
        /// <para>
        ///  The recommended storage configuration. 
        /// </para>
        /// </summary>
        public DBStorageConfiguration StorageConfiguration
        {
            get { return this._storageConfiguration; }
            set { this._storageConfiguration = value; }
        }

        // Check to see if StorageConfiguration property is set
        internal bool IsSetStorageConfiguration()
        {
            return this._storageConfiguration != null;
        }

    }
}