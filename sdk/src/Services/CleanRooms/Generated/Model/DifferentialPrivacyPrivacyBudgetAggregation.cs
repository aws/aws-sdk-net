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
    /// Information about the total number of aggregations, as well as the remaining aggregations.
    /// </summary>
    public partial class DifferentialPrivacyPrivacyBudgetAggregation
    {
        private int? _maxCount;
        private int? _remainingCount;
        private DifferentialPrivacyAggregationType _type;

        /// <summary>
        /// Gets and sets the property MaxCount. 
        /// <para>
        /// The maximum number of aggregation functions that you can perform with the given privacy
        /// budget.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? MaxCount
        {
            get { return this._maxCount; }
            set { this._maxCount = value; }
        }

        // Check to see if MaxCount property is set
        internal bool IsSetMaxCount()
        {
            return this._maxCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemainingCount. 
        /// <para>
        /// The remaining number of aggregation functions that can be run with the available privacy
        /// budget.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? RemainingCount
        {
            get { return this._remainingCount; }
            set { this._remainingCount = value; }
        }

        // Check to see if RemainingCount property is set
        internal bool IsSetRemainingCount()
        {
            return this._remainingCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The different types of aggregation functions that you can perform.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DifferentialPrivacyAggregationType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}