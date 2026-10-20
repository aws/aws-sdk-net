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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// An object containing information about the requested path.
    /// </summary>
    public partial class AnalyticsIntentNodeSummary
    {
        /// <summary>
        /// Gets and sets the property IntentCount. 
        /// <para>
        /// The total number of sessions that follow the given path to the given intent.
        /// </para>
        /// </summary>
        public int? IntentCount { get; set; }

        /// <summary>
        /// Checks to see if the IntentCount property is set.
        /// </summary>
        internal bool IsSetIntentCount() => this.IntentCount.HasValue;

        /// <summary>
        /// Gets and sets the property IntentLevel. 
        /// <para>
        /// The number of intents up to and including the requested path.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? IntentLevel { get; set; }

        /// <summary>
        /// Checks to see if the IntentLevel property is set.
        /// </summary>
        internal bool IsSetIntentLevel() => this.IntentLevel.HasValue;

        /// <summary>
        /// Gets and sets the property IntentName. 
        /// <para>
        /// The name of the intent at the end of the requested path.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string IntentName { get; set; }

        /// <summary>
        /// Checks to see if the IntentName property is set.
        /// </summary>
        internal bool IsSetIntentName() => this.IntentName != null;

        /// <summary>
        /// Gets and sets the property IntentPath. 
        /// <para>
        /// The path.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string IntentPath { get; set; }

        /// <summary>
        /// Checks to see if the IntentPath property is set.
        /// </summary>
        internal bool IsSetIntentPath() => this.IntentPath != null;

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// Specifies whether the node is the end of a path (<c>Exit</c>) or not (<c>Inner</c>).
        /// </para>
        /// </summary>
        public AnalyticsNodeType NodeType { get; set; }

        /// <summary>
        /// Checks to see if the NodeType property is set.
        /// </summary>
        internal bool IsSetNodeType() => this.NodeType != null;
    }
}
