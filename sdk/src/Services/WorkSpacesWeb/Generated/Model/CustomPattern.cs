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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
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
        private string _keywordRegex;
        private string _patternDescription;
        private string _patternName;
        private string _patternRegex;

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
        [AWSProperty(Sensitive=true, Min=0, Max=300)]
        public string KeywordRegex
        {
            get { return this._keywordRegex; }
            set { this._keywordRegex = value; }
        }

        // Check to see if KeywordRegex property is set
        internal bool IsSetKeywordRegex()
        {
            return this._keywordRegex != null;
        }

        /// <summary>
        /// Gets and sets the property PatternDescription. 
        /// <para>
        /// The pattern description for the customer pattern.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
        public string PatternDescription
        {
            get { return this._patternDescription; }
            set { this._patternDescription = value; }
        }

        // Check to see if PatternDescription property is set
        internal bool IsSetPatternDescription()
        {
            return this._patternDescription != null;
        }

        /// <summary>
        /// Gets and sets the property PatternName. 
        /// <para>
        /// The pattern name for the custom pattern.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=20)]
        public string PatternName
        {
            get { return this._patternName; }
            set { this._patternName = value; }
        }

        // Check to see if PatternName property is set
        internal bool IsSetPatternName()
        {
            return this._patternName != null;
        }

        /// <summary>
        /// Gets and sets the property PatternRegex. 
        /// <para>
        /// The pattern regex for the customer pattern. The format must follow JavaScript regex
        /// format. The pattern must be enclosed between slashes, and can have flags behind the
        /// second slash. For example: “/ab+c/gi”.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=300)]
        public string PatternRegex
        {
            get { return this._patternRegex; }
            set { this._patternRegex = value; }
        }

        // Check to see if PatternRegex property is set
        internal bool IsSetPatternRegex()
        {
            return this._patternRegex != null;
        }

    }
}