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
 * Do not modify this file. This file is generated from the ec2-protocol-2020-01-08.normal.json service model.
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
namespace Amazon.EC2Protocol.Model
{
    /// <summary>
    /// Container for the parameters to the QueryTimestamps operation.
    /// This test serializes timestamps.
    /// 
    ///  <ol> <li>Timestamps are serialized as RFC 3339 date-time values by default.</li>
    /// <li>A timestampFormat trait on a member changes the format.</li> <li>A timestampFormat
    /// trait on the shape targeted by the member changes the format.</li> </ol>
    /// </summary>
    public partial class QueryTimestampsRequest : AmazonEC2ProtocolRequest
    {
        private DateTime? _epochMember;
        private DateTime? _epochTarget;
        private DateTime? _normalFormat;

        /// <summary>
        /// Gets and sets the property EpochMember.
        /// </summary>
        public DateTime? EpochMember
        {
            get { return this._epochMember; }
            set { this._epochMember = value; }
        }

        // Check to see if EpochMember property is set
        internal bool IsSetEpochMember()
        {
            return this._epochMember.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EpochTarget.
        /// </summary>
        public DateTime? EpochTarget
        {
            get { return this._epochTarget; }
            set { this._epochTarget = value; }
        }

        // Check to see if EpochTarget property is set
        internal bool IsSetEpochTarget()
        {
            return this._epochTarget.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NormalFormat.
        /// </summary>
        public DateTime? NormalFormat
        {
            get { return this._normalFormat; }
            set { this._normalFormat = value; }
        }

        // Check to see if NormalFormat property is set
        internal bool IsSetNormalFormat()
        {
            return this._normalFormat.HasValue; 
        }

    }
}