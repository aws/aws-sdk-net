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
    /// A web search result.
    /// </summary>
    public partial class WebSearchResult
    {
        /// <summary>
        /// Gets and sets the property PublishedAt. 
        /// <para>
        /// The time the page was published. This field is absent when the publication time is
        /// not known.
        /// </para>
        /// </summary>
        public DateTime? PublishedAt { get; set; }

        /// <summary>
        /// Checks to see if the PublishedAt property is set.
        /// </summary>
        internal bool IsSetPublishedAt() => this.PublishedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// A text extract from the page.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the page.
        /// </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL of the page.
        /// </para>
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
