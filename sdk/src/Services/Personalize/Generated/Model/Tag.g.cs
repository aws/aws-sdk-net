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

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// The optional metadata that you apply to resources to help you categorize and organize
    /// them. Each tag consists of a key and an optional value, both of which you define.
    /// For more information see <a href="https://docs.aws.amazon.com/personalize/latest/dg/tagging-resources.html">Tagging
    /// Amazon Personalize resources</a>.
    /// </summary>
    public partial class Tag
    {
        /// <summary>
        /// Gets and sets the property TagKey. 
        /// <para>
        /// One part of a key-value pair that makes up a tag. A key is a general label that acts
        /// like a category for more specific tag values.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 128)]
        public string TagKey { get; set; }

        /// <summary>
        /// Checks to see if the TagKey property is set.
        /// </summary>
        internal bool IsSetTagKey() => this.TagKey != null;

        /// <summary>
        /// Gets and sets the property TagValue. 
        /// <para>
        /// The optional part of a key-value pair that makes up a tag. A value acts as a descriptor
        /// within a tag category (key).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 256)]
        public string TagValue { get; set; }

        /// <summary>
        /// Checks to see if the TagValue property is set.
        /// </summary>
        internal bool IsSetTagValue() => this.TagValue != null;
    }
}
