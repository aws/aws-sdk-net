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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Represents the percentage of requests over the last 10 seconds that resulted in each
    /// type of status code response. For more information, see <a href="http://www.w3.org/Protocols/rfc2616/rfc2616-sec10.html">Status
    /// Code Definitions</a>.
    /// </summary>
    public partial class StatusCodes
    {
        /// <summary>
        /// Gets and sets the property Status2xx. 
        /// <para>
        /// The percentage of requests over the last 10 seconds that resulted in a 2xx (200, 201,
        /// etc.) status code.
        /// </para>
        /// </summary>
        public int? Status2xx { get; set; }

        /// <summary>
        /// Checks to see if the Status2xx property is set.
        /// </summary>
        internal bool IsSetStatus2xx() => this.Status2xx.HasValue;

        /// <summary>
        /// Gets and sets the property Status3xx. 
        /// <para>
        /// The percentage of requests over the last 10 seconds that resulted in a 3xx (300, 301,
        /// etc.) status code.
        /// </para>
        /// </summary>
        public int? Status3xx { get; set; }

        /// <summary>
        /// Checks to see if the Status3xx property is set.
        /// </summary>
        internal bool IsSetStatus3xx() => this.Status3xx.HasValue;

        /// <summary>
        /// Gets and sets the property Status4xx. 
        /// <para>
        /// The percentage of requests over the last 10 seconds that resulted in a 4xx (400, 401,
        /// etc.) status code.
        /// </para>
        /// </summary>
        public int? Status4xx { get; set; }

        /// <summary>
        /// Checks to see if the Status4xx property is set.
        /// </summary>
        internal bool IsSetStatus4xx() => this.Status4xx.HasValue;

        /// <summary>
        /// Gets and sets the property Status5xx. 
        /// <para>
        /// The percentage of requests over the last 10 seconds that resulted in a 5xx (500, 501,
        /// etc.) status code.
        /// </para>
        /// </summary>
        public int? Status5xx { get; set; }

        /// <summary>
        /// Checks to see if the Status5xx property is set.
        /// </summary>
        internal bool IsSetStatus5xx() => this.Status5xx.HasValue;
    }
}
