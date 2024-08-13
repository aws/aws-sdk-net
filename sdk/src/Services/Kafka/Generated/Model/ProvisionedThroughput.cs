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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Contains information about provisioned throughput for EBS storage volumes attached
    /// to kafka broker nodes.
    /// </summary>
    public partial class ProvisionedThroughput
    {
        private bool? _enabled;
        private int? _volumeThroughput;

        /// <summary>
        /// Gets and sets the property Enabled.             
        /// <para>
        /// Provisioned throughput is enabled or not.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeThroughput.             
        /// <para>
        /// Throughput value of the EBS volumes for the data drive on each kafka broker node in
        /// MiB per second.
        /// </para>
        /// </summary>
        public int? VolumeThroughput
        {
            get { return this._volumeThroughput; }
            set { this._volumeThroughput = value; }
        }

        // Check to see if VolumeThroughput property is set
        internal bool IsSetVolumeThroughput()
        {
            return this._volumeThroughput.HasValue; 
        }

    }
}