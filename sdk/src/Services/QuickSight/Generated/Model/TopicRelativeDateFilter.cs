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
    /// A structure that represents a relative date filter.
    /// </summary>
    public partial class TopicRelativeDateFilter
    {
        private TopicSingularFilterConstant _constant;
        private TopicRelativeDateFilterFunction _relativeDateFilterFunction;
        private TopicTimeGranularity _timeGranularity;

        /// <summary>
        /// Gets and sets the property Constant. 
        /// <para>
        /// The constant used in a relative date filter.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public TopicSingularFilterConstant Constant
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
        /// Gets and sets the property RelativeDateFilterFunction. 
        /// <para>
        /// The function to be used in a relative date filter to determine the range of dates
        /// to include in the results. Valid values for this structure are <c>BEFORE</c>, <c>AFTER</c>,
        /// and <c>BETWEEN</c>.
        /// </para>
        /// </summary>
        public TopicRelativeDateFilterFunction RelativeDateFilterFunction
        {
            get { return this._relativeDateFilterFunction; }
            set { this._relativeDateFilterFunction = value; }
        }

        // Check to see if RelativeDateFilterFunction property is set
        internal bool IsSetRelativeDateFilterFunction()
        {
            return this._relativeDateFilterFunction != null;
        }

        /// <summary>
        /// Gets and sets the property TimeGranularity. 
        /// <para>
        /// The level of time precision that is used to aggregate <c>DateTime</c> values.
        /// </para>
        /// </summary>
        public TopicTimeGranularity TimeGranularity
        {
            get { return this._timeGranularity; }
            set { this._timeGranularity = value; }
        }

        // Check to see if TimeGranularity property is set
        internal bool IsSetTimeGranularity()
        {
            return this._timeGranularity != null;
        }

    }
}