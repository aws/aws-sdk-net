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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// An object that describes the details of a number filter.
    /// </summary>
    public partial class NumberFilter
    {
        /// <summary>
        /// Gets and sets the property LowerInclusive. 
        /// <para>
        /// The lowest number to be included in the filter.
        /// </para>
        /// </summary>
        public double? LowerInclusive { get; set; }

        /// <summary>
        /// Checks to see if the LowerInclusive property is set.
        /// </summary>
        internal bool IsSetLowerInclusive() => this.LowerInclusive.HasValue;

        /// <summary>
        /// Gets and sets the property UpperInclusive. 
        /// <para>
        /// The highest number to be included in the filter.
        /// </para>
        /// </summary>
        public double? UpperInclusive { get; set; }

        /// <summary>
        /// Checks to see if the UpperInclusive property is set.
        /// </summary>
        internal bool IsSetUpperInclusive() => this.UpperInclusive.HasValue;
    }
}
