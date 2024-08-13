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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A filter used to restrict data based on a range of dates or times.
    /// </summary>
    public partial class TopicDateRangeFilter
    {
        private TopicRangeFilterConstant _constant;
        private bool? _inclusive;

        /// <summary>
        /// Gets and sets the property Constant. 
        /// <para>
        /// The constant used in a date range filter.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public TopicRangeFilterConstant Constant
        {
            get { return this._constant; }
            set { this._constant = value; }
        }

        // Check to see if Constant property is set
        internal bool IsSetConstant()
        {
            return this._constant != null;
        }

        /// <summary>
        /// Gets and sets the property Inclusive. 
        /// <para>
        /// A Boolean value that indicates whether the date range filter should include the boundary
        /// values. If set to true, the filter includes the start and end dates. If set to false,
        /// the filter excludes them.
        /// </para>
        /// </summary>
        public bool? Inclusive
        {
            get { return this._inclusive; }
            set { this._inclusive = value; }
        }

        // Check to see if Inclusive property is set
        internal bool IsSetInclusive()
        {
            return this._inclusive.HasValue; 
        }

    }
}