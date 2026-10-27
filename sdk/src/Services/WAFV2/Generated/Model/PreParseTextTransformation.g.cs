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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// A pre-parse text transformation that normalizes the raw query string before WAF parses
    /// it into individual query arguments. Pre-parse text transformations are only supported
    /// when <c>FieldToMatch</c> is <c>SingleQueryArgument</c> or <c>AllQueryArguments</c>.
    /// </summary>
    public partial class PreParseTextTransformation
    {
        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// Sets the relative processing order for the pre-parse text transformations that you
        /// define. WAF processes all transformations, from lowest priority value to highest,
        /// before inspecting the transformed content. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of pre-parse text transformation to apply to the raw query string.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PreParseTextTransformationType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
