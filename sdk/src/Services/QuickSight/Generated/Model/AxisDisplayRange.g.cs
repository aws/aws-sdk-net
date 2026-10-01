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
    /// The range setup of a numeric axis display range.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class AxisDisplayRange
    {
        /// <summary>
        /// Gets and sets the property DataDriven. 
        /// <para>
        /// The data-driven setup of an axis display range.
        /// </para>
        /// </summary>
        public AxisDisplayDataDrivenRange DataDriven { get; set; }

        /// <summary>
        /// Checks to see if the DataDriven property is set.
        /// </summary>
        internal bool IsSetDataDriven() => this.DataDriven != null;

        /// <summary>
        /// Gets and sets the property MinMax. 
        /// <para>
        /// The minimum and maximum setup of an axis display range.
        /// </para>
        /// </summary>
        public AxisDisplayMinMaxRange MinMax { get; set; }

        /// <summary>
        /// Checks to see if the MinMax property is set.
        /// </summary>
        internal bool IsSetMinMax() => this.MinMax != null;
    }
}
