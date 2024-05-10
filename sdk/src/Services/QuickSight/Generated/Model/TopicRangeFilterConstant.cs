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
    /// A constant value that is used in a range filter to specify the endpoints of the range.
    /// </summary>
    public partial class TopicRangeFilterConstant
    {
        private ConstantType _constantType;
        private RangeConstant _rangeConstant;

        /// <summary>
        /// Gets and sets the property ConstantType. 
        /// <para>
        /// The data type of the constant value that is used in a range filter. Valid values for
        /// this structure are <c>RANGE</c>.
        /// </para>
        /// </summary>
        public ConstantType ConstantType
        {
            get { return this._constantType; }
            set { this._constantType = value; }
        }

        // Check to see if ConstantType property is set
        internal bool IsSetConstantType()
        {
            return this._constantType != null;
        }

        /// <summary>
        /// Gets and sets the property RangeConstant. 
        /// <para>
        /// The value of the constant that is used to specify the endpoints of a range filter.
        /// </para>
        /// </summary>
        public RangeConstant RangeConstant
        {
            get { return this._rangeConstant; }
            set { this._rangeConstant = value; }
        }

        // Check to see if RangeConstant property is set
        internal bool IsSetRangeConstant()
        {
            return this._rangeConstant != null;
        }

    }
}