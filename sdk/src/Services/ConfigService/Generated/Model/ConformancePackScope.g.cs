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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Defines which resources trigger an evaluation for the Config rules in a conformance
    /// pack. The scope is a tag key, or a combination of a tag key and value, that is applied
    /// to every rule in the conformance pack. Specify a scope to constrain which resources
    /// trigger an evaluation for the rules. Otherwise, evaluations of rules in the conformance
    /// pack are triggered when any resource in your recording group changes in configuration.
    /// </summary>
    public partial class ConformancePackScope
    {
        /// <summary>
        /// Gets and sets the property TagKey. 
        /// <para>
        /// The tag key that applies to only those Amazon Web Services resources that you want
        /// to trigger an evaluation for the rules in the conformance pack. Defines the <a>Scope$TagKey</a>
        /// of all Config rules in the conformance pack. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string TagKey { get; set; }

        /// <summary>
        /// Checks to see if the TagKey property is set.
        /// </summary>
        internal bool IsSetTagKey() => this.TagKey != null;

        /// <summary>
        /// Gets and sets the property TagValue. 
        /// <para>
        /// The tag value that applies to only those Amazon Web Services resources that you want
        /// to trigger an evaluation for the rules in the conformance pack. If you do not specify
        /// a value for <c>TagValue</c>, resources that have the tag key <c>TagKey</c> trigger
        /// an evaluation, regardless of the tag value. Defines the <a>Scope$TagValue</a> of all
        /// Config rules in the conformance pack. 
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
