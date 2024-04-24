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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
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
namespace Amazon.Shield.Model
{
    /// <summary>
    /// Information about the volume of attacks during the time period, included in an <a>AttackStatisticsDataItem</a>.
    /// If the accompanying <c>AttackCount</c> in the statistics object is zero, this setting
    /// might be empty.
    /// </summary>
    public partial class AttackVolume
    {
        private AttackVolumeStatistics _bitsPerSecond;
        private AttackVolumeStatistics _packetsPerSecond;
        private AttackVolumeStatistics _requestsPerSecond;

        /// <summary>
        /// Gets and sets the property BitsPerSecond. 
        /// <para>
        /// A statistics object that uses bits per second as the unit. This is included for network
        /// level attacks. 
        /// </para>
        /// </summary>
        public AttackVolumeStatistics BitsPerSecond
        {
            get { return this._bitsPerSecond; }
            set { this._bitsPerSecond = value; }
        }

        // Check to see if BitsPerSecond property is set
        internal bool IsSetBitsPerSecond()
        {
            return this._bitsPerSecond != null;
        }

        /// <summary>
        /// Gets and sets the property PacketsPerSecond. 
        /// <para>
        /// A statistics object that uses packets per second as the unit. This is included for
        /// network level attacks. 
        /// </para>
        /// </summary>
        public AttackVolumeStatistics PacketsPerSecond
        {
            get { return this._packetsPerSecond; }
            set { this._packetsPerSecond = value; }
        }

        // Check to see if PacketsPerSecond property is set
        internal bool IsSetPacketsPerSecond()
        {
            return this._packetsPerSecond != null;
        }

        /// <summary>
        /// Gets and sets the property RequestsPerSecond. 
        /// <para>
        /// A statistics object that uses requests per second as the unit. This is included for
        /// application level attacks, and is only available for accounts that are subscribed
        /// to Shield Advanced.
        /// </para>
        /// </summary>
        public AttackVolumeStatistics RequestsPerSecond
        {
            get { return this._requestsPerSecond; }
            set { this._requestsPerSecond = value; }
        }

        // Check to see if RequestsPerSecond property is set
        internal bool IsSetRequestsPerSecond()
        {
            return this._requestsPerSecond != null;
        }

    }
}