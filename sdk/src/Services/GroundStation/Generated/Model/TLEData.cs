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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
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
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Two-line element set (TLE) data.
    /// </summary>
    public partial class TLEData
    {
        private string _tleLine1;
        private string _tleLine2;
        private TimeRange _validTimeRange;

        /// <summary>
        /// Gets and sets the property TleLine1. 
        /// <para>
        /// First line of two-line element set (TLE) data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=69, Max=69)]
        public string TleLine1
        {
            get { return this._tleLine1; }
            set { this._tleLine1 = value; }
        }

        // Check to see if TleLine1 property is set
        internal bool IsSetTleLine1()
        {
            return this._tleLine1 != null;
        }

        /// <summary>
        /// Gets and sets the property TleLine2. 
        /// <para>
        /// Second line of two-line element set (TLE) data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=69, Max=69)]
        public string TleLine2
        {
            get { return this._tleLine2; }
            set { this._tleLine2 = value; }
        }

        // Check to see if TleLine2 property is set
        internal bool IsSetTleLine2()
        {
            return this._tleLine2 != null;
        }

        /// <summary>
        /// Gets and sets the property ValidTimeRange. 
        /// <para>
        /// The valid time range for the TLE. Gaps or overlap are not permitted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TimeRange ValidTimeRange
        {
            get { return this._validTimeRange; }
            set { this._validTimeRange = value; }
        }

        // Check to see if ValidTimeRange property is set
        internal bool IsSetValidTimeRange()
        {
            return this._validTimeRange != null;
        }

    }
}