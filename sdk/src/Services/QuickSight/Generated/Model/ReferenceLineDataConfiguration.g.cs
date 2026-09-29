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
    /// The data configuration of the reference line.
    /// </summary>
    public partial class ReferenceLineDataConfiguration
    {
        /// <summary>
        /// Gets and sets the property AxisBinding. 
        /// <para>
        /// The axis binding type of the reference line. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PrimaryY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SecondaryY</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AxisBinding AxisBinding { get; set; }

        /// <summary>
        /// Checks to see if the AxisBinding property is set.
        /// </summary>
        internal bool IsSetAxisBinding() => this.AxisBinding != null;

        /// <summary>
        /// Gets and sets the property DynamicConfiguration. 
        /// <para>
        /// The dynamic configuration of the reference line data configuration.
        /// </para>
        /// </summary>
        public ReferenceLineDynamicDataConfiguration DynamicConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DynamicConfiguration property is set.
        /// </summary>
        internal bool IsSetDynamicConfiguration() => this.DynamicConfiguration != null;

        /// <summary>
        /// Gets and sets the property SeriesType. 
        /// <para>
        /// The series type of the reference line data configuration. Choose one of the following
        /// options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BAR</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LINE</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ReferenceLineSeriesType SeriesType { get; set; }

        /// <summary>
        /// Checks to see if the SeriesType property is set.
        /// </summary>
        internal bool IsSetSeriesType() => this.SeriesType != null;

        /// <summary>
        /// Gets and sets the property StaticConfiguration. 
        /// <para>
        /// The static data configuration of the reference line data configuration.
        /// </para>
        /// </summary>
        public ReferenceLineStaticDataConfiguration StaticConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the StaticConfiguration property is set.
        /// </summary>
        internal bool IsSetStaticConfiguration() => this.StaticConfiguration != null;
    }
}
