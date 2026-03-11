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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// The <c>Filter</c> is used to identify objects that a Lifecycle Rule applies to. A
    /// <c>Filter</c> can have exactly one of <c>Prefix</c>, <c>Tag</c>, <c>ObjectSizeGreaterThan</c>,
    /// <c>ObjectSizeLessThan</c>, or <c>And</c> specified. If the <c>Filter</c> element is
    /// left empty, the Lifecycle Rule applies to all objects in the bucket.
    /// </summary>
    public partial class LifecycleFilter
    {
        private LifecycleRuleAndOperator _and;
        private long? _objectSizeGreaterThan;
        private long? _objectSizeLessThan;
        private string _prefix;
        private Tag _tag;

        /// <summary>
        /// Gets and sets the property And.
        /// </summary>
        public LifecycleRuleAndOperator And
        {
            get { return this._and; }
            set { this._and = value; }
        }

        // Check to see if And property is set
        internal bool IsSetAnd()
        {
            return this._and != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectSizeGreaterThan. 
        /// <para>
        /// Minimum object size to which the rule applies.
        /// </para>
        /// </summary>
        public long? ObjectSizeGreaterThan
        {
            get { return this._objectSizeGreaterThan; }
            set { this._objectSizeGreaterThan = value; }
        }

        // Check to see if ObjectSizeGreaterThan property is set
        internal bool IsSetObjectSizeGreaterThan()
        {
            return this._objectSizeGreaterThan.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ObjectSizeLessThan. 
        /// <para>
        /// Maximum object size to which the rule applies.
        /// </para>
        /// </summary>
        public long? ObjectSizeLessThan
        {
            get { return this._objectSizeLessThan; }
            set { this._objectSizeLessThan = value; }
        }

        // Check to see if ObjectSizeLessThan property is set
        internal bool IsSetObjectSizeLessThan()
        {
            return this._objectSizeLessThan.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// Prefix identifying one or more objects to which the rule applies.
        /// </para>
        ///  <important> 
        /// <para>
        /// Replacement must be made for object keys containing special characters (such as carriage
        /// returns) when using XML requests. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-keys.html#object-key-xml-related-constraints">
        /// XML related object key constraints</a>.
        /// </para>
        ///  </important>
        /// </summary>
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

        /// <summary>
        /// Gets and sets the property Tag. 
        /// <para>
        /// This tag must exist in the object's tag set in order for the rule to apply.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter applies to general purpose buckets only. It is not supported for directory
        /// bucket lifecycle configurations.
        /// </para>
        ///  </note>
        /// </summary>
        public Tag Tag
        {
            get { return this._tag; }
            set { this._tag = value; }
        }

        // Check to see if Tag property is set
        internal bool IsSetTag()
        {
            return this._tag != null;
        }

    }
}