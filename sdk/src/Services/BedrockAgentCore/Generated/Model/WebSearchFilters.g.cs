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
    /// The filters to apply to a web search.
    /// </summary>
    public partial class WebSearchFilters
    {
        /// <summary>
        /// Gets and sets the property DomainFilter. 
        /// <para>
        /// The domains to include in or exclude from the results.
        /// </para>
        /// </summary>
        public DomainFilter DomainFilter { get; set; }

        /// <summary>
        /// Checks to see if the DomainFilter property is set.
        /// </summary>
        internal bool IsSetDomainFilter() => this.DomainFilter != null;

        /// <summary>
        /// Gets and sets the property PublishedDateFilter. 
        /// <para>
        /// The publication time range of the results.
        /// </para>
        /// </summary>
        public PublishedDateFilter PublishedDateFilter { get; set; }

        /// <summary>
        /// Checks to see if the PublishedDateFilter property is set.
        /// </summary>
        internal bool IsSetPublishedDateFilter() => this.PublishedDateFilter != null;
    }
}
