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
    /// Describes the recommendation options for DB storage.
    /// </summary>
    public partial class RDSDBStorageRecommendationOption
    {
        /// <summary>
        /// Gets and sets the property EstimatedMonthlyVolumeIOPsCostVariation. 
        /// <para>
        ///  The projected level of variation in monthly I/O costs for the DB storage recommendation
        /// option. 
        /// </para>
        /// </summary>
        public RDSEstimatedMonthlyVolumeIOPsCostVariation EstimatedMonthlyVolumeIOPsCostVariation { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedMonthlyVolumeIOPsCostVariation property is set.
        /// </summary>
        internal bool IsSetEstimatedMonthlyVolumeIOPsCostVariation() => this.EstimatedMonthlyVolumeIOPsCostVariation != null;

        /// <summary>
        /// Gets and sets the property Rank. 
        /// <para>
        ///  The rank identifier of the DB storage recommendation option. 
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
        public RDSStorageSavingsOpportunityAfterDiscounts SavingsOpportunityAfterDiscounts { get; set; }

        /// <summary>
        /// Checks to see if the SavingsOpportunityAfterDiscounts property is set.
        /// </summary>
        internal bool IsSetSavingsOpportunityAfterDiscounts() => this.SavingsOpportunityAfterDiscounts != null;

        /// <summary>
        /// Gets and sets the property StorageConfiguration. 
        /// <para>
        ///  The recommended storage configuration. 
        /// </para>
        /// </summary>
        public DBStorageConfiguration StorageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the StorageConfiguration property is set.
        /// </summary>
        internal bool IsSetStorageConfiguration() => this.StorageConfiguration != null;
    }
}
