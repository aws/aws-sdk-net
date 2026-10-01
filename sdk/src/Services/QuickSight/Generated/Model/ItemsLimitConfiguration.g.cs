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
    /// The limit configuration of the visual display for an axis.
    /// </summary>
    public partial class ItemsLimitConfiguration
    {
        /// <summary>
        /// Gets and sets the property ItemsLimit. 
        /// <para>
        /// The limit on how many items of a field are showed in the chart. For example, the number
        /// of slices that are displayed in a pie chart.
        /// </para>
        /// </summary>
        public long? ItemsLimit { get; set; }

        /// <summary>
        /// Checks to see if the ItemsLimit property is set.
        /// </summary>
        internal bool IsSetItemsLimit() => this.ItemsLimit.HasValue;

        /// <summary>
        /// Gets and sets the property OtherCategories. 
        /// <para>
        /// The <c>Show other</c> of an axis in the chart. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INCLUDE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXCLUDE</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public OtherCategories OtherCategories { get; set; }

        /// <summary>
        /// Checks to see if the OtherCategories property is set.
        /// </summary>
        internal bool IsSetOtherCategories() => this.OtherCategories != null;
    }
}
