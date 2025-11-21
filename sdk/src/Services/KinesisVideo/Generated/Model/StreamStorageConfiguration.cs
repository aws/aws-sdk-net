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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
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
namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// The configuration for stream storage, including the default storage tier for stream
    /// data. This configuration determines how stream data is stored and accessed, with different
    /// tiers offering varying levels of performance and cost optimization.
    /// </summary>
    public partial class StreamStorageConfiguration
    {
        private DefaultStorageTier _defaultStorageTier;

        /// <summary>
        /// Gets and sets the property DefaultStorageTier. 
        /// <para>
        /// The default storage tier for the stream data. This setting determines the storage
        /// class used for stream data, affecting both performance characteristics and storage
        /// costs.
        /// </para>
        ///  
        /// <para>
        /// Available storage tiers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HOT</c> - Optimized for frequent access with the lowest latency and highest performance.
        /// Ideal for real-time applications and frequently accessed data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WARM</c> - Balanced performance and cost for moderately accessed data. Suitable
        /// for data that is accessed regularly but not continuously.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public DefaultStorageTier DefaultStorageTier
        {
            get { return this._defaultStorageTier; }
            set { this._defaultStorageTier = value; }
        }

        // Check to see if DefaultStorageTier property is set
        internal bool IsSetDefaultStorageTier()
        {
            return this._defaultStorageTier != null;
        }

    }
}