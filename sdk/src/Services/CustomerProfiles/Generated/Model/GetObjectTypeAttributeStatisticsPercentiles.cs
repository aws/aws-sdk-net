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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Contains percentile statistics for object type attributes.
    /// </summary>
    public partial class GetObjectTypeAttributeStatisticsPercentiles
    {
        private double? _p25;
        private double? _p5;
        private double? _p50;
        private double? _p75;
        private double? _p95;

        /// <summary>
        /// Gets and sets the property P25. 
        /// <para>
        /// The 25th percentile value of the attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double P25
        {
            get { return this._p25.GetValueOrDefault(); }
            set { this._p25 = value; }
        }

        // Check to see if P25 property is set
        internal bool IsSetP25()
        {
            return this._p25.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property P5. 
        /// <para>
        /// The 5th percentile value of the attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double P5
        {
            get { return this._p5.GetValueOrDefault(); }
            set { this._p5 = value; }
        }

        // Check to see if P5 property is set
        internal bool IsSetP5()
        {
            return this._p5.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property P50. 
        /// <para>
        /// The 50th percentile (median) value of the attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double P50
        {
            get { return this._p50.GetValueOrDefault(); }
            set { this._p50 = value; }
        }

        // Check to see if P50 property is set
        internal bool IsSetP50()
        {
            return this._p50.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property P75. 
        /// <para>
        /// The 75th percentile value of the attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double P75
        {
            get { return this._p75.GetValueOrDefault(); }
            set { this._p75 = value; }
        }

        // Check to see if P75 property is set
        internal bool IsSetP75()
        {
            return this._p75.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property P95. 
        /// <para>
        /// The 95th percentile value of the attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double P95
        {
            get { return this._p95.GetValueOrDefault(); }
            set { this._p95 = value; }
        }

        // Check to see if P95 property is set
        internal bool IsSetP95()
        {
            return this._p95.HasValue; 
        }

    }
}