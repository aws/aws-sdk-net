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
    /// This is the response object from the JsonTimestamps operation.
    /// </summary>
    public partial class JsonTimestampsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DateTime.
        /// </summary>
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Checks to see if the DateTime property is set.
        /// </summary>
        internal bool IsSetDateTime() => this.DateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DateTimeOnTarget.
        /// </summary>
        public DateTime? DateTimeOnTarget { get; set; }

        /// <summary>
        /// Checks to see if the DateTimeOnTarget property is set.
        /// </summary>
        internal bool IsSetDateTimeOnTarget() => this.DateTimeOnTarget.HasValue;

        /// <summary>
        /// Gets and sets the property EpochSeconds.
        /// </summary>
        public DateTime? EpochSeconds { get; set; }

        /// <summary>
        /// Checks to see if the EpochSeconds property is set.
        /// </summary>
        internal bool IsSetEpochSeconds() => this.EpochSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property EpochSecondsOnTarget.
        /// </summary>
        public DateTime? EpochSecondsOnTarget { get; set; }

        /// <summary>
        /// Checks to see if the EpochSecondsOnTarget property is set.
        /// </summary>
        internal bool IsSetEpochSecondsOnTarget() => this.EpochSecondsOnTarget.HasValue;

        /// <summary>
        /// Gets and sets the property HttpDate.
        /// </summary>
        public DateTime? HttpDate { get; set; }

        /// <summary>
        /// Checks to see if the HttpDate property is set.
        /// </summary>
        internal bool IsSetHttpDate() => this.HttpDate.HasValue;

        /// <summary>
        /// Gets and sets the property HttpDateOnTarget.
        /// </summary>
        public DateTime? HttpDateOnTarget { get; set; }

        /// <summary>
        /// Checks to see if the HttpDateOnTarget property is set.
        /// </summary>
        internal bool IsSetHttpDateOnTarget() => this.HttpDateOnTarget.HasValue;

        /// <summary>
        /// Gets and sets the property Normal.
        /// </summary>
        public DateTime? Normal { get; set; }

        /// <summary>
        /// Checks to see if the Normal property is set.
        /// </summary>
        internal bool IsSetNormal() => this.Normal.HasValue;
    }
}
