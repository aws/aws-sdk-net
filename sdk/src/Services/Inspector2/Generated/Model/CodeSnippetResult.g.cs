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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Contains information on a code snippet retrieved by Amazon Inspector from a code vulnerability
    /// finding.
    /// </summary>
    public partial class CodeSnippetResult
    {
        /// <summary>
        /// Gets and sets the property CodeSnippet. 
        /// <para>
        /// Contains information on the retrieved code snippet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<CodeLine> CodeSnippet { get; set; } = AWSConfigs.InitializeCollections ? new List<CodeLine>() : null;

        /// <summary>
        /// Checks to see if the CodeSnippet property is set.
        /// </summary>
        internal bool IsSetCodeSnippet() => this.CodeSnippet != null && (this.CodeSnippet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EndLine. 
        /// <para>
        /// The line number of the last line of a code snippet.
        /// </para>
        /// </summary>
        public int? EndLine { get; set; }

        /// <summary>
        /// Checks to see if the EndLine property is set.
        /// </summary>
        internal bool IsSetEndLine() => this.EndLine.HasValue;

        /// <summary>
        /// Gets and sets the property FindingArn. 
        /// <para>
        /// The ARN of a finding that the code snippet is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string FindingArn { get; set; }

        /// <summary>
        /// Checks to see if the FindingArn property is set.
        /// </summary>
        internal bool IsSetFindingArn() => this.FindingArn != null;

        /// <summary>
        /// Gets and sets the property StartLine. 
        /// <para>
        /// The line number of the first line of a code snippet.
        /// </para>
        /// </summary>
        public int? StartLine { get; set; }

        /// <summary>
        /// Checks to see if the StartLine property is set.
        /// </summary>
        internal bool IsSetStartLine() => this.StartLine.HasValue;

        /// <summary>
        /// Gets and sets the property SuggestedFixes. 
        /// <para>
        /// Details of a suggested code fix.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<SuggestedFix> SuggestedFixes { get; set; } = AWSConfigs.InitializeCollections ? new List<SuggestedFix>() : null;

        /// <summary>
        /// Checks to see if the SuggestedFixes property is set.
        /// </summary>
        internal bool IsSetSuggestedFixes() => this.SuggestedFixes != null && (this.SuggestedFixes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
