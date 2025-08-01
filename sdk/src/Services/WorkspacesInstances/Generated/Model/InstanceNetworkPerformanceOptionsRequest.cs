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
 * Do not modify this file. This file is generated from the workspaces-instances-2022-07-26.normal.json service model.
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
namespace Amazon.WorkspacesInstances.Model
{
    /// <summary>
    /// Configures network performance settings for WorkSpace Instance.
    /// </summary>
    public partial class InstanceNetworkPerformanceOptionsRequest
    {
        private BandwidthWeightingEnum _bandwidthWeighting;

        /// <summary>
        /// Gets and sets the property BandwidthWeighting. 
        /// <para>
        /// Defines bandwidth allocation strategy for network interfaces.
        /// </para>
        /// </summary>
        public BandwidthWeightingEnum BandwidthWeighting
        {
            get { return this._bandwidthWeighting; }
            set { this._bandwidthWeighting = value; }
        }

        // Check to see if BandwidthWeighting property is set
        internal bool IsSetBandwidthWeighting()
        {
            return this._bandwidthWeighting != null;
        }

    }
}