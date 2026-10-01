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

namespace Amazon.RestJsonProtocol.Model
{
    /// <summary>
    /// Container for the parameters to the TimestampFormatHeaders operation. This example
    /// tests how timestamp request and response headers are serialized.
    /// </summary>
    public partial class TimestampFormatHeadersRequest : AmazonRestJsonProtocolRequest
    {
        /// <summary>
        /// Gets and sets the property DefaultFormat.
        /// </summary>
        public DateTime? DefaultFormat { get; set; }

        /// <summary>
        /// Checks to see if the DefaultFormat property is set.
        /// </summary>
        internal bool IsSetDefaultFormat() => this.DefaultFormat.HasValue;

        /// <summary>
        /// Gets and sets the property MemberDateTime.
        /// </summary>
        public DateTime? MemberDateTime { get; set; }

        /// <summary>
        /// Checks to see if the MemberDateTime property is set.
        /// </summary>
        internal bool IsSetMemberDateTime() => this.MemberDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property MemberEpochSeconds.
        /// </summary>
        public DateTime? MemberEpochSeconds { get; set; }

        /// <summary>
        /// Checks to see if the MemberEpochSeconds property is set.
        /// </summary>
        internal bool IsSetMemberEpochSeconds() => this.MemberEpochSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property MemberHttpDate.
        /// </summary>
        public DateTime? MemberHttpDate { get; set; }

        /// <summary>
        /// Checks to see if the MemberHttpDate property is set.
        /// </summary>
        internal bool IsSetMemberHttpDate() => this.MemberHttpDate.HasValue;

        /// <summary>
        /// Gets and sets the property TargetDateTime.
        /// </summary>
        public DateTime? TargetDateTime { get; set; }

        /// <summary>
        /// Checks to see if the TargetDateTime property is set.
        /// </summary>
        internal bool IsSetTargetDateTime() => this.TargetDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property TargetEpochSeconds.
        /// </summary>
        public DateTime? TargetEpochSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TargetEpochSeconds property is set.
        /// </summary>
        internal bool IsSetTargetEpochSeconds() => this.TargetEpochSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property TargetHttpDate.
        /// </summary>
        public DateTime? TargetHttpDate { get; set; }

        /// <summary>
        /// Checks to see if the TargetHttpDate property is set.
        /// </summary>
        internal bool IsSetTargetHttpDate() => this.TargetHttpDate.HasValue;
    }
}
