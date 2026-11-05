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

namespace Amazon.QueryProtocol.Model
{
    /// <summary>
    /// Container for the parameters to the QueryTimestamps operation. This test serializes
    /// timestamps. 1. Timestamps are serialized as RFC 3339 date-time values by default.
    /// 2. A timestampFormat trait on a member changes the format. 3. A timestampFormat trait
    /// on the shape targeted by the member changes the format.
    /// </summary>
    public partial class QueryTimestampsRequest : AmazonQueryProtocolRequest
    {
        /// <summary>
        /// Gets and sets the property EpochMember.
        /// </summary>
        public DateTime? EpochMember { get; set; }

        /// <summary>
        /// Checks to see if the EpochMember property is set.
        /// </summary>
        internal bool IsSetEpochMember() => this.EpochMember.HasValue;

        /// <summary>
        /// Gets and sets the property EpochTarget.
        /// </summary>
        public DateTime? EpochTarget { get; set; }

        /// <summary>
        /// Checks to see if the EpochTarget property is set.
        /// </summary>
        internal bool IsSetEpochTarget() => this.EpochTarget.HasValue;

        /// <summary>
        /// Gets and sets the property NormalFormat.
        /// </summary>
        public DateTime? NormalFormat { get; set; }

        /// <summary>
        /// Checks to see if the NormalFormat property is set.
        /// </summary>
        internal bool IsSetNormalFormat() => this.NormalFormat.HasValue;
    }
}
