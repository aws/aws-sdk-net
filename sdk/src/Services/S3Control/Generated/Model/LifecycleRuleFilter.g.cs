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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// The container for the filter of the lifecycle rule.
    /// </summary>
    public partial class LifecycleRuleFilter
    {
        /// <summary>
        /// Gets and sets the property And. 
        /// <para>
        /// The container for the <c>AND</c> condition for the lifecycle rule.
        /// </para>
        /// </summary>
        public LifecycleRuleAndOperator And { get; set; }

        /// <summary>
        /// Checks to see if the And property is set.
        /// </summary>
        internal bool IsSetAnd() => this.And != null;

        /// <summary>
        /// Gets and sets the property ObjectSizeGreaterThan. 
        /// <para>
        /// Minimum object size to which the rule applies.
        /// </para>
        /// </summary>
        public long? ObjectSizeGreaterThan { get; set; }

        /// <summary>
        /// Checks to see if the ObjectSizeGreaterThan property is set.
        /// </summary>
        internal bool IsSetObjectSizeGreaterThan() => this.ObjectSizeGreaterThan.HasValue;

        /// <summary>
        /// Gets and sets the property ObjectSizeLessThan. 
        /// <para>
        /// Maximum object size to which the rule applies.
        /// </para>
        /// </summary>
        public long? ObjectSizeLessThan { get; set; }

        /// <summary>
        /// Checks to see if the ObjectSizeLessThan property is set.
        /// </summary>
        internal bool IsSetObjectSizeLessThan() => this.ObjectSizeLessThan.HasValue;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// Prefix identifying one or more objects to which the rule applies.
        /// </para>
        ///  <important> 
        /// <para>
        /// When you're using XML requests, you must replace special characters (such as carriage
        /// returns) in object keys with their equivalent XML entity codes. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-keys.html#object-key-xml-related-constraints">
        /// XML-related object key constraints</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;

        /// <summary>
        /// Gets and sets the property Tag.
        /// </summary>
        public S3Tag Tag { get; set; }

        /// <summary>
        /// Checks to see if the Tag property is set.
        /// </summary>
        internal bool IsSetTag() => this.Tag != null;
    }
}
