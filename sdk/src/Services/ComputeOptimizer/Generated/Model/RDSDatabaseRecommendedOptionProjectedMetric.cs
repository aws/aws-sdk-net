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
        private List<RDSDatabaseProjectedMetric> _projectedMetrics = AWSConfigs.InitializeCollections ? new List<RDSDatabaseProjectedMetric>() : null;
        private int? _rank;
        private string _recommendeddbInstanceClass;

        /// <summary>
        /// Gets and sets the property ProjectedMetrics. 
        /// <para>
        ///  An array of objects that describe the projected metric. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RDSDatabaseProjectedMetric> ProjectedMetrics
        {
            get { return this._projectedMetrics; }
            set { this._projectedMetrics = value; }
        }

        // Check to see if ProjectedMetrics property is set
        internal bool IsSetProjectedMetrics()
        {
            return this._projectedMetrics != null && (this._projectedMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Rank. 
        /// <para>
        ///  The rank identifier of the Amazon Aurora or RDS DB instance recommendation option.
        /// 
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
        /// Gets and sets the property RecommendedDBInstanceClass. 
        /// <para>
        ///  The recommended DB instance class for the Amazon Aurora or RDS database. 
        /// </para>
        /// </summary>
        public string RecommendedDBInstanceClass
        {
            get { return this._recommendeddbInstanceClass; }
            set { this._recommendeddbInstanceClass = value; }
        }

        // Check to see if RecommendedDBInstanceClass property is set
        internal bool IsSetRecommendedDBInstanceClass()
        {
            return this._recommendeddbInstanceClass != null;
        }

    }
}