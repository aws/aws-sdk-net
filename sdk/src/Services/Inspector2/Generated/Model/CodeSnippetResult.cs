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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Contains information on a code snippet retrieved by Amazon Inspector from a code vulnerability
    /// finding.
    /// </summary>
    public partial class CodeSnippetResult
    {
        private List<CodeLine> _codeSnippet = AWSConfigs.InitializeCollections ? new List<CodeLine>() : null;
        private int? _endLine;
        private string _findingArn;
        private int? _startLine;
        private List<SuggestedFix> _suggestedFixes = AWSConfigs.InitializeCollections ? new List<SuggestedFix>() : null;

        /// <summary>
        /// Gets and sets the property CodeSnippet. 
        /// <para>
        /// Contains information on the retrieved code snippet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<CodeLine> CodeSnippet
        {
            get { return this._codeSnippet; }
            set { this._codeSnippet = value; }
        }

        // Check to see if CodeSnippet property is set
        internal bool IsSetCodeSnippet()
        {
            return this._codeSnippet != null && (this._codeSnippet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EndLine. 
        /// <para>
        /// The line number of the last line of a code snippet.
        /// </para>
        /// </summary>
        public int? EndLine
        {
            get { return this._endLine; }
            set { this._endLine = value; }
        }

        // Check to see if EndLine property is set
        internal bool IsSetEndLine()
        {
            return this._endLine.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FindingArn. 
        /// <para>
        /// The ARN of a finding that the code snippet is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string FindingArn
        {
            get { return this._findingArn; }
            set { this._findingArn = value; }
        }

        // Check to see if FindingArn property is set
        internal bool IsSetFindingArn()
        {
            return this._findingArn != null;
        }

        /// <summary>
        /// Gets and sets the property StartLine. 
        /// <para>
        /// The line number of the first line of a code snippet.
        /// </para>
        /// </summary>
        public int? StartLine
        {
            get { return this._startLine; }
            set { this._startLine = value; }
        }

        // Check to see if StartLine property is set
        internal bool IsSetStartLine()
        {
            return this._startLine.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SuggestedFixes. 
        /// <para>
        /// Details of a suggested code fix.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<SuggestedFix> SuggestedFixes
        {
            get { return this._suggestedFixes; }
            set { this._suggestedFixes = value; }
        }

        // Check to see if SuggestedFixes property is set
        internal bool IsSetSuggestedFixes()
        {
            return this._suggestedFixes != null && (this._suggestedFixes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}