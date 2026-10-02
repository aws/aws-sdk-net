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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// A condition on a pull request value.
    /// </summary>
    public partial class TriggerFilter
    {
        /// <summary>
        /// Gets and sets the property MatchMode. 
        /// <para>
        /// Whether the value must match the patterns. The default is <c>INCLUDE</c>.
        /// </para>
        /// </summary>
        public TriggerFilterMatchMode MatchMode { get; set; }

        /// <summary>
        /// Checks to see if the MatchMode property is set.
        /// </summary>
        internal bool IsSetMatchMode() => this.MatchMode != null;

        /// <summary>
        /// Gets and sets the property Patterns. 
        /// <para>
        /// The regular expressions to match against the value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public List<string> Patterns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Patterns property is set.
        /// </summary>
        internal bool IsSetPatterns() => this.Patterns != null && (this.Patterns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The pull request value to match.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TriggerFilterType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
