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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// DVB Network Information Table (NIT)
    /// </summary>
    public partial class DvbNitSettings
    {
        /// <summary>
        /// Gets and sets the property NetworkId. The numeric value placed in the Network Information
        /// Table (NIT).
        /// </summary>
        [AWSProperty(Required = true)]
        public int? NetworkId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkId property is set.
        /// </summary>
        internal bool IsSetNetworkId() => this.NetworkId.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkName. The network name text placed in the networkNameDescriptor
        /// inside the Network Information Table. Maximum length is 256 characters.
        /// </summary>
        [AWSProperty(Required = true)]
        public string NetworkName { get; set; }

        /// <summary>
        /// Checks to see if the NetworkName property is set.
        /// </summary>
        internal bool IsSetNetworkName() => this.NetworkName != null;

        /// <summary>
        /// Gets and sets the property RepInterval. The number of milliseconds between instances
        /// of this table in the output transport stream.
        /// </summary>
        public int? RepInterval { get; set; }

        /// <summary>
        /// Checks to see if the RepInterval property is set.
        /// </summary>
        internal bool IsSetRepInterval() => this.RepInterval.HasValue;
    }
}
