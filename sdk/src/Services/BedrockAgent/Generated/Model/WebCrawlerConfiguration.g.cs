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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// The configuration of web URLs that you want to crawl. You should be authorized to
    /// crawl the URLs.
    /// </summary>
    public partial class WebCrawlerConfiguration
    {
        /// <summary>
        /// Gets and sets the property CrawlerLimits. 
        /// <para>
        /// The configuration of crawl limits for the web URLs.
        /// </para>
        /// </summary>
        public WebCrawlerLimits CrawlerLimits { get; set; }

        /// <summary>
        /// Checks to see if the CrawlerLimits property is set.
        /// </summary>
        internal bool IsSetCrawlerLimits() => this.CrawlerLimits != null;

        /// <summary>
        /// Gets and sets the property ExclusionFilters. 
        /// <para>
        /// A list of one or more exclusion regular expression patterns to exclude certain URLs.
        /// If you specify an inclusion and exclusion filter/pattern and both match a URL, the
        /// exclusion filter takes precedence and the web content of the URL isn’t crawled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 25)]
        public List<string> ExclusionFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExclusionFilters property is set.
        /// </summary>
        internal bool IsSetExclusionFilters() => this.ExclusionFilters != null && (this.ExclusionFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InclusionFilters. 
        /// <para>
        /// A list of one or more inclusion regular expression patterns to include certain URLs.
        /// If you specify an inclusion and exclusion filter/pattern and both match a URL, the
        /// exclusion filter takes precedence and the web content of the URL isn’t crawled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 25)]
        public List<string> InclusionFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InclusionFilters property is set.
        /// </summary>
        internal bool IsSetInclusionFilters() => this.InclusionFilters != null && (this.InclusionFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The scope of what is crawled for your URLs.
        /// </para>
        ///  
        /// <para>
        /// You can choose to crawl only web pages that belong to the same host or primary domain.
        /// For example, only web pages that contain the seed URL "https://docs.aws.amazon.com/bedrock/latest/userguide/"
        /// and no other domains. You can choose to include sub domains in addition to the host
        /// or primary domain. For example, web pages that contain "aws.amazon.com" can also include
        /// sub domain "docs.aws.amazon.com".
        /// </para>
        /// </summary>
        public WebScopeType Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property UserAgent. 
        /// <para>
        /// Returns the user agent suffix for your web crawler.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 15, Max = 40)]
        public string UserAgent { get; set; }

        /// <summary>
        /// Checks to see if the UserAgent property is set.
        /// </summary>
        internal bool IsSetUserAgent() => this.UserAgent != null;

        /// <summary>
        /// Gets and sets the property UserAgentHeader. 
        /// <para>
        /// A string used for identifying the crawler or bot when it accesses a web server. The
        /// user agent header value consists of the <c>bedrockbot</c>, UUID, and a user agent
        /// suffix for your crawler (if one is provided). By default, it is set to <c>bedrockbot_UUID</c>.
        /// You can optionally append a custom suffix to <c>bedrockbot_UUID</c> to allowlist a
        /// specific user agent permitted to access your source URLs. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 61, Max = 86)]
        public string UserAgentHeader { get; set; }

        /// <summary>
        /// Checks to see if the UserAgentHeader property is set.
        /// </summary>
        internal bool IsSetUserAgentHeader() => this.UserAgentHeader != null;
    }
}
