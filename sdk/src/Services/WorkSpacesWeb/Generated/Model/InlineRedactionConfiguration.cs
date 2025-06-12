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
    /// The configuration for in-session inline redaction.
    /// </summary>
    public partial class InlineRedactionConfiguration
    {
        private int? _globalConfidenceLevel;
        private List<string> _globalEnforcedUrls = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _globalExemptUrls = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<InlineRedactionPattern> _inlineRedactionPatterns = AWSConfigs.InitializeCollections ? new List<InlineRedactionPattern>() : null;

        /// <summary>
        /// Gets and sets the property GlobalConfidenceLevel. 
        /// <para>
        /// The global confidence level for the inline redaction configuration. This indicates
        /// the certainty of data type matches in the redaction process. Confidence level 3 means
        /// high confidence, and requires a formatted text pattern match in order for content
        /// to be redacted. Confidence level 2 means medium confidence, and redaction considers
        /// both formatted and unformatted text, and adds keyword associate to the logic. Confidence
        /// level 1 means low confidence, and redaction is enforced for both formatted pattern
        /// + unformatted pattern without keyword. This is applied to patterns that do not have
        /// a pattern-level confidence level. Defaults to confidence level 2.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public int? GlobalConfidenceLevel
        {
            get { return this._globalConfidenceLevel; }
            set { this._globalConfidenceLevel = value; }
        }

        // Check to see if GlobalConfidenceLevel property is set
        internal bool IsSetGlobalConfidenceLevel()
        {
            return this._globalConfidenceLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GlobalEnforcedUrls. 
        /// <para>
        /// The global enforced URL configuration for the inline redaction configuration. This
        /// is applied to patterns that do not have a pattern-level enforced URL list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> GlobalEnforcedUrls
        {
            get { return this._globalEnforcedUrls; }
            set { this._globalEnforcedUrls = value; }
        }

        // Check to see if GlobalEnforcedUrls property is set
        internal bool IsSetGlobalEnforcedUrls()
        {
            return this._globalEnforcedUrls != null && (this._globalEnforcedUrls.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GlobalExemptUrls. 
        /// <para>
        /// The global exempt URL configuration for the inline redaction configuration. This is
        /// applied to patterns that do not have a pattern-level exempt URL list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> GlobalExemptUrls
        {
            get { return this._globalExemptUrls; }
            set { this._globalExemptUrls = value; }
        }

        // Check to see if GlobalExemptUrls property is set
        internal bool IsSetGlobalExemptUrls()
        {
            return this._globalExemptUrls != null && (this._globalExemptUrls.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InlineRedactionPatterns. 
        /// <para>
        /// The inline redaction patterns to be enabled for the inline redaction configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=150)]
        public List<InlineRedactionPattern> InlineRedactionPatterns
        {
            get { return this._inlineRedactionPatterns; }
            set { this._inlineRedactionPatterns = value; }
        }

        // Check to see if InlineRedactionPatterns property is set
        internal bool IsSetInlineRedactionPatterns()
        {
            return this._inlineRedactionPatterns != null && (this._inlineRedactionPatterns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}