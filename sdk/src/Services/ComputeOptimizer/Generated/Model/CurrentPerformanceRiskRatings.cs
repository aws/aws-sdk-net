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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
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
namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes the performance risk ratings for a given resource type.
    /// 
    ///  
    /// <para>
    /// Resources with a <c>high</c> or <c>medium</c> rating are at risk of not meeting the
    /// performance needs of their workloads, while resources with a <c>low</c> rating are
    /// performing well in their workloads.
    /// </para>
    /// </summary>
    public partial class CurrentPerformanceRiskRatings
    {
        private long? _high;
        private long? _low;
        private long? _medium;
        private long? _veryLow;

        /// <summary>
        /// Gets and sets the property High. 
        /// <para>
        /// A count of the applicable resource types with a high performance risk rating.
        /// </para>
        /// </summary>
        public long? High
        {
            get { return this._high; }
            set { this._high = value; }
        }

        // Check to see if High property is set
        internal bool IsSetHigh()
        {
            return this._high.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Low. 
        /// <para>
        /// A count of the applicable resource types with a low performance risk rating.
        /// </para>
        /// </summary>
        public long? Low
        {
            get { return this._low; }
            set { this._low = value; }
        }

        // Check to see if Low property is set
        internal bool IsSetLow()
        {
            return this._low.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Medium. 
        /// <para>
        /// A count of the applicable resource types with a medium performance risk rating.
        /// </para>
        /// </summary>
        public long? Medium
        {
            get { return this._medium; }
            set { this._medium = value; }
        }

        // Check to see if Medium property is set
        internal bool IsSetMedium()
        {
            return this._medium.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VeryLow. 
        /// <para>
        /// A count of the applicable resource types with a very low performance risk rating.
        /// </para>
        /// </summary>
        public long? VeryLow
        {
            get { return this._veryLow; }
            set { this._veryLow = value; }
        }

        // Check to see if VeryLow property is set
        internal bool IsSetVeryLow()
        {
            return this._veryLow.HasValue; 
        }

    }
}