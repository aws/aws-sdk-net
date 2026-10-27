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
    /// Used in DescribeNodeSummary, DescribeNodeResult.
    /// </summary>
    public partial class SdiSourceMapping
    {
        /// <summary>
        /// Gets and sets the property CardNumber. A number that uniquely identifies the SDI card
        /// on the node hardware.
        /// </summary>
        public int? CardNumber { get; set; }

        /// <summary>
        /// Checks to see if the CardNumber property is set.
        /// </summary>
        internal bool IsSetCardNumber() => this.CardNumber.HasValue;

        /// <summary>
        /// Gets and sets the property ChannelNumber. A number that uniquely identifies a port
        /// on the SDI card.
        /// </summary>
        public int? ChannelNumber { get; set; }

        /// <summary>
        /// Checks to see if the ChannelNumber property is set.
        /// </summary>
        internal bool IsSetChannelNumber() => this.ChannelNumber.HasValue;

        /// <summary>
        /// Gets and sets the property SdiSource. The ID of the SdiSource to associate with this
        /// port on this card. You can use the ListSdiSources operation to discover all the IDs.
        /// </summary>
        public string SdiSource { get; set; }

        /// <summary>
        /// Checks to see if the SdiSource property is set.
        /// </summary>
        internal bool IsSetSdiSource() => this.SdiSource != null;
    }
}
