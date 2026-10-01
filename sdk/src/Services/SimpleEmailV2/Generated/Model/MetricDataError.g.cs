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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An error corresponding to the unsuccessful processing of a single metric data query.
    /// </summary>
    public partial class MetricDataError
    {
        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The query error code. Can be one of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INTERNAL_FAILURE</c> – Amazon SES has failed to process one of the queries.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACCESS_DENIED</c> – You have insufficient access to retrieve metrics based on
        /// the given query.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public QueryErrorCode Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The query identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The error message associated with the current query error.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;
    }
}
