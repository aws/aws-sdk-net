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

namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// The pattern configuration for redacting custom data types in session.
    /// </summary>
    public partial class CustomPattern
    {
        /// <summary>
        /// Gets and sets the property KeywordRegex. 
        /// <para>
        /// The keyword regex for the customer pattern. After there is a match to the pattern
        /// regex, the keyword regex is used to search within the proximity of the match. If there
        /// is a keyword match, then the match is confirmed. If no keyword regex is provided,
        /// the pattern regex match will automatically be confirmed. The format must follow JavaScript
        /// regex format. The pattern must be enclosed between slashes, and can have flags behind
        /// the second slash. For example, “/ab+c/gi”
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 300)]
        public string KeywordRegex { get; set; }

        /// <summary>
        /// Checks to see if the KeywordRegex property is set.
        /// </summary>
        internal bool IsSetKeywordRegex() => this.KeywordRegex != null;

        /// <summary>
        /// Gets and sets the property PatternDescription. 
        /// <para>
        /// The pattern description for the customer pattern.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string PatternDescription { get; set; }

        /// <summary>
        /// Checks to see if the PatternDescription property is set.
        /// </summary>
        internal bool IsSetPatternDescription() => this.PatternDescription != null;

        /// <summary>
        /// Gets and sets the property PatternName. 
        /// <para>
        /// The pattern name for the custom pattern.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 20)]
        public string PatternName { get; set; }

        /// <summary>
        /// Checks to see if the PatternName property is set.
        /// </summary>
        internal bool IsSetPatternName() => this.PatternName != null;

        /// <summary>
        /// Gets and sets the property PatternRegex. 
        /// <para>
        /// The pattern regex for the customer pattern. The format must follow JavaScript regex
        /// format. The pattern must be enclosed between slashes, and can have flags behind the
        /// second slash. For example: “/ab+c/gi”.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 300)]
        public string PatternRegex { get; set; }

        /// <summary>
        /// Checks to see if the PatternRegex property is set.
        /// </summary>
        internal bool IsSetPatternRegex() => this.PatternRegex != null;
    }
}
