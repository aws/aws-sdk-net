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

namespace Amazon.Chatbot.Model
{
    /// <summary>
    /// A key-value pair. A tag consists of a tag key and a tag value. Tag keys and tag values
    /// are both required, but tag values can be empty (null) strings.
    /// 
    ///  <important> 
    /// <para>
    /// Do not include confidential or sensitive information in this field. 
    /// </para>
    ///  </important> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/allocation-tag-restrictions.html">User-Defined
    /// Tag Restrictions</a> in the <i>AWS Billing and Cost Management User Guide</i>.
    /// </para>
    /// </summary>
    public partial class Tag
    {
        /// <summary>
        /// Gets and sets the property TagKey. 
        /// <para>
        /// The key of the tag.
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
        /// The value of the tag.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string TagValue { get; set; }

        /// <summary>
        /// Checks to see if the TagValue property is set.
        /// </summary>
        internal bool IsSetTagValue() => this.TagValue != null;
    }
}
