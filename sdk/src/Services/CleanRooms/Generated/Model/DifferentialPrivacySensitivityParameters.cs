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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
        private string _aggregationExpression;
        private DifferentialPrivacyAggregationType _aggregationType;
        private float? _maxColumnValue;
        private float? _minColumnValue;
        private int? _userContributionLimit;

        /// <summary>
        /// Gets and sets the property AggregationExpression. 
        /// <para>
        /// The aggregation expression that was run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string AggregationExpression
        {
            get { return this._aggregationExpression; }
            set { this._aggregationExpression = value; }
        }

        // Check to see if AggregationExpression property is set
        internal bool IsSetAggregationExpression()
        {
            return this._aggregationExpression != null;
        }

        /// <summary>
        /// Gets and sets the property AggregationType. 
        /// <para>
        /// The type of aggregation function that was run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DifferentialPrivacyAggregationType AggregationType
        {
            get { return this._aggregationType; }
            set { this._aggregationType = value; }
        }

        // Check to see if AggregationType property is set
        internal bool IsSetAggregationType()
        {
            return this._aggregationType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxColumnValue. 
        /// <para>
        /// The upper bound of the aggregation expression.
        /// </para>
        /// </summary>
        public float? MaxColumnValue
        {
            get { return this._maxColumnValue; }
            set { this._maxColumnValue = value; }
        }

        // Check to see if MaxColumnValue property is set
        internal bool IsSetMaxColumnValue()
        {
            return this._maxColumnValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinColumnValue. 
        /// <para>
        /// The lower bound of the aggregation expression.
        /// </para>
        /// </summary>
        public float? MinColumnValue
        {
            get { return this._minColumnValue; }
            set { this._minColumnValue = value; }
        }

        // Check to see if MinColumnValue property is set
        internal bool IsSetMinColumnValue()
        {
            return this._minColumnValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserContributionLimit. 
        /// <para>
        /// The maximum number of rows contributed by a user in a SQL query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? UserContributionLimit
        {
            get { return this._userContributionLimit; }
            set { this._userContributionLimit = value; }
        }

        // Check to see if UserContributionLimit property is set
        internal bool IsSetUserContributionLimit()
        {
            return this._userContributionLimit.HasValue; 
        }

    }
}