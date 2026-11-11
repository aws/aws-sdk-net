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
    /// Pair of multicast url and source ip address (optional) that make up a multicast source.
    /// </summary>
    public partial class MulticastSource
    {
        /// <summary>
        /// Gets and sets the property SecondarySourceIp. This represents the ip address of the
        /// device sending the secondary multicast stream.
        /// </summary>
        public string SecondarySourceIp { get; set; }

        /// <summary>
        /// Checks to see if the SecondarySourceIp property is set.
        /// </summary>
        internal bool IsSetSecondarySourceIp() => this.SecondarySourceIp != null;

        /// <summary>
        /// Gets and sets the property SecondaryUrl. This represents the customer's secondary
        /// source URL where the redundant multicast stream (SMPTE 2022-7) is pulled from.
        /// </summary>
        public string SecondaryUrl { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryUrl property is set.
        /// </summary>
        internal bool IsSetSecondaryUrl() => this.SecondaryUrl != null;

        /// <summary>
        /// Gets and sets the property SourceIp. This represents the ip address of the device
        /// sending the multicast stream.
        /// </summary>
        public string SourceIp { get; set; }

        /// <summary>
        /// Checks to see if the SourceIp property is set.
        /// </summary>
        internal bool IsSetSourceIp() => this.SourceIp != null;

        /// <summary>
        /// Gets and sets the property Url. This represents the customer's source URL where multicast
        /// stream is pulled from.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
