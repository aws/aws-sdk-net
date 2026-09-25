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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Specifies the minimum number of distinct identities that each query output group must
    /// represent.
    /// </summary>
    public partial class AggregationThreshold
    {
        /// <summary>
        /// Gets and sets the property AllowedAggregateExpressionType. 
        /// <para>
        /// Specifies whether a query can aggregate a transformed column. This applies to the
        /// arguments of both aggregate and window functions. Valid values are:
        /// </para>
        ///  
        /// <para>
        ///  <c>COLUMNS_ONLY</c> – A query can aggregate only a direct column reference, such
        /// as <c>SUM(amount)</c>, or a constant. Clean Rooms rejects a query that transforms
        /// a column and then aggregates it, such as <c>SUM(amount * 2)</c> or <c>SUM(ROUND(amount))</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>ANY_EXPRESSION</c> – A query can aggregate any expression. This includes arithmetic,
        /// such as <c>SUM(price * quantity)</c>; a cast, such as <c>SUM(CAST(amount AS DECIMAL))</c>;
        /// a nested function call, such as <c>SUM(COALESCE(amount, 0))</c>; and a conditional,
        /// such as <c>SUM(CASE WHEN region = 'EU' THEN amount ELSE 0 END)</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AllowedAggregateExpressionType AllowedAggregateExpressionType { get; set; }

        /// <summary>
        /// Checks to see if the AllowedAggregateExpressionType property is set.
        /// </summary>
        internal bool IsSetAllowedAggregateExpressionType() => this.AllowedAggregateExpressionType != null;

        /// <summary>
        /// Gets and sets the property IdentityColumns. 
        /// <para>
        /// The identity column, such as <c>user_id</c>, whose distinct values Clean Rooms counts
        /// to enforce minimum aggregation thresholds. Currently, you can specify only one column,
        /// and its data type must be string, varchar, or char.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<string> IdentityColumns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IdentityColumns property is set.
        /// </summary>
        internal bool IsSetIdentityColumns() => this.IdentityColumns != null && (this.IdentityColumns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MinimumIdentityCount. 
        /// <para>
        /// The minimum number of distinct identities that each query output group must represent.
        /// This threshold applies to all output columns in the table. To override this threshold
        /// for a specific column, use <c>outputColumnThresholds</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 100000)]
        public int? MinimumIdentityCount { get; set; }

        /// <summary>
        /// Checks to see if the MinimumIdentityCount property is set.
        /// </summary>
        internal bool IsSetMinimumIdentityCount() => this.MinimumIdentityCount.HasValue;

        /// <summary>
        /// Gets and sets the property OutputColumnThresholds. 
        /// <para>
        /// The per-column overrides of <c>minimumIdentityCount</c>. An output column without
        /// an override uses <c>minimumIdentityCount</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OutputColumnThreshold> OutputColumnThresholds { get; set; } = AWSConfigs.InitializeCollections ? new List<OutputColumnThreshold>() : null;

        /// <summary>
        /// Checks to see if the OutputColumnThresholds property is set.
        /// </summary>
        internal bool IsSetOutputColumnThresholds() => this.OutputColumnThresholds != null && (this.OutputColumnThresholds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of aggregation that the threshold enforces. Currently, the only supported
        /// value is <c>COUNT_DISTINCT</c>, which counts the distinct values in the identity column.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AggregationThresholdType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
