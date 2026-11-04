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

namespace Amazon.ConnectContactLens.Model
{
    /// <summary>
    /// A tag condition that consists of a tag key, a tag value, and a comparison operator.
    /// </summary>
    public partial class TagCondition
    {
        /// <summary>
        /// Gets and sets the property ComparisonType. 
        /// <para>
        /// The comparison operator for the tag condition. Valid values: <c>EQUALS</c> | <c>NOT_EQUALS</c>.
        /// </para>
        /// </summary>
        public TagComparisonType ComparisonType { get; set; }

        /// <summary>
        /// Checks to see if the ComparisonType property is set.
        /// </summary>
        internal bool IsSetComparisonType() => this.ComparisonType != null;

        /// <summary>
        /// Gets and sets the property TagKey. 
        /// <para>
        /// The tag key in the tag condition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string TagKey { get; set; }

        /// <summary>
        /// Checks to see if the TagKey property is set.
        /// </summary>
        internal bool IsSetTagKey() => this.TagKey != null;

        /// <summary>
        /// Gets and sets the property TagValue. 
        /// <para>
        /// The tag value in the tag condition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string TagValue { get; set; }

        /// <summary>
        /// Checks to see if the TagValue property is set.
        /// </summary>
        internal bool IsSetTagValue() => this.TagValue != null;
    }
}
