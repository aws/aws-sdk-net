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
    /// Provides the sensitivity parameters.
    /// </summary>
    public partial class DifferentialPrivacySensitivityParameters
    {
        /// <summary>
        /// Gets and sets the property AggregationExpression. 
        /// <para>
        /// The aggregation expression that was run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string AggregationExpression { get; set; }

        /// <summary>
        /// Checks to see if the AggregationExpression property is set.
        /// </summary>
        internal bool IsSetAggregationExpression() => this.AggregationExpression != null;

        /// <summary>
        /// Gets and sets the property AggregationType. 
        /// <para>
        /// The type of aggregation function that was run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DifferentialPrivacyAggregationType AggregationType { get; set; }

        /// <summary>
        /// Checks to see if the AggregationType property is set.
        /// </summary>
        internal bool IsSetAggregationType() => this.AggregationType != null;

        /// <summary>
        /// Gets and sets the property MaxColumnValue. 
        /// <para>
        /// The upper bound of the aggregation expression.
        /// </para>
        /// </summary>
        public float? MaxColumnValue { get; set; }

        /// <summary>
        /// Checks to see if the MaxColumnValue property is set.
        /// </summary>
        internal bool IsSetMaxColumnValue() => this.MaxColumnValue.HasValue;

        /// <summary>
        /// Gets and sets the property MinColumnValue. 
        /// <para>
        /// The lower bound of the aggregation expression.
        /// </para>
        /// </summary>
        public float? MinColumnValue { get; set; }

        /// <summary>
        /// Checks to see if the MinColumnValue property is set.
        /// </summary>
        internal bool IsSetMinColumnValue() => this.MinColumnValue.HasValue;

        /// <summary>
        /// Gets and sets the property UserContributionLimit. 
        /// <para>
        /// The maximum number of rows contributed by a user in a SQL query.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? UserContributionLimit { get; set; }

        /// <summary>
        /// Checks to see if the UserContributionLimit property is set.
        /// </summary>
        internal bool IsSetUserContributionLimit() => this.UserContributionLimit.HasValue;
    }
}
