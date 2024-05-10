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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
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
namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// An optional input parameter for the <c>ListSignalingChannels</c> API. When this parameter
    /// is specified while invoking <c>ListSignalingChannels</c>, the API returns only the
    /// channels that satisfy a condition specified in <c>ChannelNameCondition</c>.
    /// </summary>
    public partial class ChannelNameCondition
    {
        private ComparisonOperator _comparisonOperator;
        private string _comparisonValue;

        /// <summary>
        /// Gets and sets the property ComparisonOperator. 
        /// <para>
        /// A comparison operator. Currently, you can only specify the <c>BEGINS_WITH</c> operator,
        /// which finds signaling channels whose names begin with a given prefix.
        /// </para>
        /// </summary>
        public ComparisonOperator ComparisonOperator
        {
            get { return this._comparisonOperator; }
            set { this._comparisonOperator = value; }
        }

        // Check to see if ComparisonOperator property is set
        internal bool IsSetComparisonOperator()
        {
            return this._comparisonOperator != null;
        }

        /// <summary>
        /// Gets and sets the property ComparisonValue. 
        /// <para>
        /// A value to compare.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ComparisonValue
        {
            get { return this._comparisonValue; }
            set { this._comparisonValue = value; }
        }

        // Check to see if ComparisonValue property is set
        internal bool IsSetComparisonValue()
        {
            return this._comparisonValue != null;
        }

    }
}