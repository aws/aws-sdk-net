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

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// The configuration for an <c>HLS_TAG_PROCESSOR</c> function. Specifies the HLS tags
    /// that trigger evaluation, an optional run condition, and output expressions. Each evaluation
    /// must update, remove, or pass through the matching tag and can also write player session
    /// parameters or temporary values. For more information, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/monetization-functions-types-hls-tag-processor.html">HLS_TAG_PROCESSOR</a>
    /// in the <i>MediaTailor User Guide</i>.
    /// </summary>
    public partial class HlsTagProcessorConfiguration
    {
        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// A map of output bindings that MediaTailor evaluates for each HLS tag that matches
        /// <c>TagFilter</c> and, when specified, passes <c>RunCondition</c>. The required <c>tag</c>
        /// binding must return exactly one tag action: <c>$updateTag</c>, <c>$removeTag</c>,
        /// or <c>$passthroughTag</c>. Optional <c>player_params.&lt;name&gt;</c> bindings write
        /// strings, numbers, or booleans that persist for the player session. Optional <c>temp.&lt;name&gt;</c>
        /// bindings hold any JSON value for the current invocation and are not persisted. For
        /// more information about expression syntax, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/monetization-functions-jsonata.html">JSONata
        /// expression reference</a> in the <i>MediaTailor User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Output { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Output property is set.
        /// </summary>
        internal bool IsSetOutput() => this.Output != null && (this.Output.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RunCondition. JSONata expression that must evaluate to
        /// true for the processor to run.
        /// </summary>
        public string RunCondition { get; set; }

        /// <summary>
        /// Checks to see if the RunCondition property is set.
        /// </summary>
        internal bool IsSetRunCondition() => this.RunCondition != null;

        /// <summary>
        /// Gets and sets the property Runtime. 
        /// <para>
        /// The expression language used to evaluate expressions in the function configuration.
        /// The only supported value is <c>JSONATA</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RuntimeType Runtime { get; set; }

        /// <summary>
        /// Checks to see if the Runtime property is set.
        /// </summary>
        internal bool IsSetRuntime() => this.Runtime != null;

        /// <summary>
        /// Gets and sets the property TagFilter. 
        /// <para>
        /// A list of HLS tag names that trigger function evaluation. Specify <c>["EXT-X-DATERANGE"]</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<string> TagFilter { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TagFilter property is set.
        /// </summary>
        internal bool IsSetTagFilter() => this.TagFilter != null && (this.TagFilter.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
