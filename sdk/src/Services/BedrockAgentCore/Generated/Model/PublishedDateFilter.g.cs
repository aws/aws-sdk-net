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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// A publication time range for the results. Both bounds are optional, and both are inclusive.
    /// If <c>publishedAfter</c> is later than <c>publishedBefore</c>, the request fails with
    /// a <c>ValidationException</c>.
    /// </summary>
    public partial class PublishedDateFilter
    {
        /// <summary>
        /// Gets and sets the property PublishedAfter. 
        /// <para>
        /// The earliest publication time of the results, inclusive.
        /// </para>
        /// </summary>
        public DateTime? PublishedAfter { get; set; }

        /// <summary>
        /// Checks to see if the PublishedAfter property is set.
        /// </summary>
        internal bool IsSetPublishedAfter() => this.PublishedAfter.HasValue;

        /// <summary>
        /// Gets and sets the property PublishedBefore. 
        /// <para>
        /// The latest publication time of the results, inclusive. A date without a time, such
        /// as one passed to the AWS CLI, means midnight UTC. To include a whole day, use the
        /// last second of that day, for example <c>2026-01-31T23:59:59Z</c>.
        /// </para>
        /// </summary>
        public DateTime? PublishedBefore { get; set; }

        /// <summary>
        /// Checks to see if the PublishedBefore property is set.
        /// </summary>
        internal bool IsSetPublishedBefore() => this.PublishedBefore.HasValue;
    }
}
