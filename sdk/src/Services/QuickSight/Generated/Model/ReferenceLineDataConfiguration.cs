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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The data configuration of the reference line.
    /// </summary>
    public partial class ReferenceLineDataConfiguration
    {
        private AxisBinding _axisBinding;
        private ReferenceLineDynamicDataConfiguration _dynamicConfiguration;
        private ReferenceLineStaticDataConfiguration _staticConfiguration;

        /// <summary>
        /// Gets and sets the property AxisBinding. 
        /// <para>
        /// The axis binding type of the reference line. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PrimaryY
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SecondaryY
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AxisBinding AxisBinding
        {
            get { return this._axisBinding; }
            set { this._axisBinding = value; }
        }

        // Check to see if AxisBinding property is set
        internal bool IsSetAxisBinding()
        {
            return this._axisBinding != null;
        }

        /// <summary>
        /// Gets and sets the property DynamicConfiguration. 
        /// <para>
        /// The dynamic configuration of the reference line data configuration.
        /// </para>
        /// </summary>
        public ReferenceLineDynamicDataConfiguration DynamicConfiguration
        {
            get { return this._dynamicConfiguration; }
            set { this._dynamicConfiguration = value; }
        }

        // Check to see if DynamicConfiguration property is set
        internal bool IsSetDynamicConfiguration()
        {
            return this._dynamicConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property StaticConfiguration. 
        /// <para>
        /// The static data configuration of the reference line data configuration.
        /// </para>
        /// </summary>
        public ReferenceLineStaticDataConfiguration StaticConfiguration
        {
            get { return this._staticConfiguration; }
            set { this._staticConfiguration = value; }
        }

        // Check to see if StaticConfiguration property is set
        internal bool IsSetStaticConfiguration()
        {
            return this._staticConfiguration != null;
        }

    }
}