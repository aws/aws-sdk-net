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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The minimum and maximum amount of network bandwidth, in gigabits per second (Gbps).
    /// 
    ///  <note> 
    /// <para>
    /// Setting the minimum bandwidth does not guarantee that your instance will achieve the
    /// minimum bandwidth. Amazon EC2 will identify instance types that support the specified
    /// minimum bandwidth, but the actual bandwidth of your instance might go below the specified
    /// minimum at times. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-network-bandwidth.html#available-instance-bandwidth">Available
    /// instance bandwidth</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class NetworkBandwidthGbps
    {
        private double? _max;
        private double? _min;

        /// <summary>
        /// Gets and sets the property Max. 
        /// <para>
        /// The maximum amount of network bandwidth, in Gbps. If this parameter is not specified,
        /// there is no maximum limit.
        /// </para>
        /// </summary>
        public double Max
        {
            get { return this._max.GetValueOrDefault(); }
            set { this._max = value; }
        }

        // Check to see if Max property is set
        internal bool IsSetMax()
        {
            return this._max.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Min. 
        /// <para>
        /// The minimum amount of network bandwidth, in Gbps. If this parameter is not specified,
        /// there is no minimum limit.
        /// </para>
        /// </summary>
        public double Min
        {
            get { return this._min.GetValueOrDefault(); }
            set { this._min = value; }
        }

        // Check to see if Min property is set
        internal bool IsSetMin()
        {
            return this._min.HasValue; 
        }

    }
}