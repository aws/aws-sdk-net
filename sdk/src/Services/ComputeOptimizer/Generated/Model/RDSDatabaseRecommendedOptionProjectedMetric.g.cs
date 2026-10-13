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
    /// Describes the projected metrics of an Amazon Aurora and RDS database recommendation
    /// option. 
    /// 
    ///  
    /// <para>
    ///  To determine the performance difference between your current Amazon Aurora and RDS
    /// database and the recommended option, compare the metric data of your service against
    /// its projected metric data. 
    /// </para>
    /// </summary>
    public partial class RDSDatabaseRecommendedOptionProjectedMetric
    {
        /// <summary>
        /// Gets and sets the property ProjectedMetrics. 
        /// <para>
        ///  An array of objects that describe the projected metric. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RDSDatabaseProjectedMetric> ProjectedMetrics { get; set; } = AWSConfigs.InitializeCollections ? new List<RDSDatabaseProjectedMetric>() : null;

        /// <summary>
        /// Checks to see if the ProjectedMetrics property is set.
        /// </summary>
        internal bool IsSetProjectedMetrics() => this.ProjectedMetrics != null && (this.ProjectedMetrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Rank. 
        /// <para>
        ///  The rank identifier of the Amazon Aurora or RDS DB instance recommendation option.
        /// 
        /// </para>
        /// </summary>
        public int? Rank { get; set; }

        /// <summary>
        /// Checks to see if the Rank property is set.
        /// </summary>
        internal bool IsSetRank() => this.Rank.HasValue;

        /// <summary>
        /// Gets and sets the property RecommendedDBInstanceClass. 
        /// <para>
        ///  The recommended DB instance class for the Amazon Aurora or RDS database. 
        /// </para>
        /// </summary>
        public string RecommendedDBInstanceClass { get; set; }

        /// <summary>
        /// Checks to see if the RecommendedDBInstanceClass property is set.
        /// </summary>
        internal bool IsSetRecommendedDBInstanceClass() => this.RecommendedDBInstanceClass != null;
    }
}
