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
    /// The set of patterns that determine the data types redacted in session.
    /// </summary>
    public partial class InlineRedactionPattern
    {
        private string _builtInPatternId;
        private int? _confidenceLevel;
        private CustomPattern _customPattern;
        private List<string> _enforcedUrls = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _exemptUrls = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private RedactionPlaceHolder _redactionPlaceHolder;

        /// <summary>
        /// Gets and sets the property BuiltInPatternId. 
        /// <para>
        /// The built-in pattern from the list of preconfigured patterns. Either a customPattern
        /// or builtInPatternId is required.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=50)]
        public string BuiltInPatternId
        {
            get { return this._builtInPatternId; }
            set { this._builtInPatternId = value; }
        }

        // Check to see if BuiltInPatternId property is set
        internal bool IsSetBuiltInPatternId()
        {
            return this._builtInPatternId != null;
        }

        /// <summary>
        /// Gets and sets the property ConfidenceLevel. 
        /// <para>
        /// The confidence level for inline redaction pattern. This indicates the certainty of
        /// data type matches in the redaction process. Confidence level 3 means high confidence,
        /// and requires a formatted text pattern match in order for content to be redacted. Confidence
        /// level 2 means medium confidence, and redaction considers both formatted and unformatted
        /// text, and adds keyword associate to the logic. Confidence level 1 means low confidence,
        /// and redaction is enforced for both formatted pattern + unformatted pattern without
        /// keyword. This overrides the global confidence level.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public int? ConfidenceLevel
        {
            get { return this._confidenceLevel; }
            set { this._confidenceLevel = value; }
        }

        // Check to see if ConfidenceLevel property is set
        internal bool IsSetConfidenceLevel()
        {
            return this._confidenceLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomPattern. 
        /// <para>
        /// &gt;The configuration for a custom pattern. Either a customPattern or builtInPatternId
        /// is required.
        /// </para>
        /// </summary>
        public CustomPattern CustomPattern
        {
            get { return this._customPattern; }
            set { this._customPattern = value; }
        }

        // Check to see if CustomPattern property is set
        internal bool IsSetCustomPattern()
        {
            return this._customPattern != null;
        }

        /// <summary>
        /// Gets and sets the property EnforcedUrls. 
        /// <para>
        /// The enforced URL configuration for the inline redaction pattern. This will override
        /// the global enforced URL configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<string> EnforcedUrls
        {
            get { return this._enforcedUrls; }
            set { this._enforcedUrls = value; }
        }

        // Check to see if EnforcedUrls property is set
        internal bool IsSetEnforcedUrls()
        {
            return this._enforcedUrls != null && (this._enforcedUrls.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExemptUrls. 
        /// <para>
        /// The exempt URL configuration for the inline redaction pattern. This will override
        /// the global exempt URL configuration for the inline redaction pattern.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<string> ExemptUrls
        {
            get { return this._exemptUrls; }
            set { this._exemptUrls = value; }
        }

        // Check to see if ExemptUrls property is set
        internal bool IsSetExemptUrls()
        {
            return this._exemptUrls != null && (this._exemptUrls.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RedactionPlaceHolder. 
        /// <para>
        /// The redaction placeholder that will replace the redacted text in session for the inline
        /// redaction pattern.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RedactionPlaceHolder RedactionPlaceHolder
        {
            get { return this._redactionPlaceHolder; }
            set { this._redactionPlaceHolder = value; }
        }

        // Check to see if RedactionPlaceHolder property is set
        internal bool IsSetRedactionPlaceHolder()
        {
            return this._redactionPlaceHolder != null;
        }

    }
}