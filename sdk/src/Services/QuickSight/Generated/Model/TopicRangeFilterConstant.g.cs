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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A constant value that is used in a range filter to specify the endpoints of the range.
    /// </summary>
    public partial class TopicRangeFilterConstant
    {
        /// <summary>
        /// Gets and sets the property ConstantType. 
        /// <para>
        /// The data type of the constant value that is used in a range filter. Valid values for
        /// this structure are <c>RANGE</c>.
        /// </para>
        /// </summary>
        public ConstantType ConstantType { get; set; }

        /// <summary>
        /// Checks to see if the ConstantType property is set.
        /// </summary>
        internal bool IsSetConstantType() => this.ConstantType != null;

        /// <summary>
        /// Gets and sets the property RangeConstant. 
        /// <para>
        /// The value of the constant that is used to specify the endpoints of a range filter.
        /// </para>
        /// </summary>
        public RangeConstant RangeConstant { get; set; }

        /// <summary>
        /// Checks to see if the RangeConstant property is set.
        /// </summary>
        internal bool IsSetRangeConstant() => this.RangeConstant != null;
    }
}
