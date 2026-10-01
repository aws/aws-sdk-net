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
    /// The configuration of filtering the data source content. For example, configuring regular
    /// expression patterns to include or exclude certain content.
    /// </summary>
    public partial class CrawlFilterConfiguration
    {
        /// <summary>
        /// Gets and sets the property PatternObjectFilter. 
        /// <para>
        /// The configuration of filtering certain objects or content types of the data source.
        /// </para>
        /// </summary>
        public PatternObjectFilterConfiguration PatternObjectFilter { get; set; }

        /// <summary>
        /// Checks to see if the PatternObjectFilter property is set.
        /// </summary>
        internal bool IsSetPatternObjectFilter() => this.PatternObjectFilter != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of filtering that you want to apply to certain objects or content of the
        /// data source. For example, the <c>PATTERN</c> type is regular expression patterns you
        /// can apply to filter your content.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CrawlFilterConfigurationType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
