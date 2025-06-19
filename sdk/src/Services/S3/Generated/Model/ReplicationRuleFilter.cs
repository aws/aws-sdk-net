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
    /// A filter that identifies the subset of objects to which the replication rule applies.
    /// A <c>Filter</c> must specify exactly one <c>Prefix</c>, <c>Tag</c>, or an <c>And</c>
    /// child element.
    /// </summary>
    public partial class ReplicationRuleFilter
    {
        private ReplicationRuleAndOperator _and;
        private string _prefix;
        private Tag _tag;

        /// <summary>
        /// Gets and sets the property And. 
        /// <para>
        /// A container for specifying rule filters. The filters determine the subset of objects
        /// to which the rule applies. This element is required only if you specify more than
        /// one filter. For example: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify both a <c>Prefix</c> and a <c>Tag</c> filter, wrap these filters in
        /// an <c>And</c> tag.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify a filter based on multiple tags, wrap the <c>Tag</c> elements in an
        /// <c>And</c> tag.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ReplicationRuleAndOperator And
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
        /// Gets and sets the property Prefix. 
        /// <para>
        /// An object key name prefix that identifies the subset of objects to which the rule
        /// applies.
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
        /// A container for specifying a tag key and value. 
        /// </para>
        ///  
        /// <para>
        /// The rule applies only to objects that have the tag in their tag set.
        /// </para>
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