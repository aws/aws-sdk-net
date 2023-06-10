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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// A filter that identifies the subset of objects to which the replication rule applies.
    /// A <code>Filter</code> element must specify exactly one <code>Prefix</code>, <code>Tag</code>,
    /// or <code>And</code> child element.
    /// </summary>
    public partial class ReplicationRuleFilter
    {
        private ReplicationRuleAndOperator _and;
        private string _prefix;
        private S3Tag _tag;

        /// <summary>
        /// Gets and sets the property And. 
        /// <para>
        /// A container for specifying rule filters. The filters determine the subset of objects
        /// that the rule applies to. This element is required only if you specify more than one
        /// filter. For example: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify both a <code>Prefix</code> and a <code>Tag</code> filter, wrap these
        /// filters in an <code>And</code> element.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify a filter based on multiple tags, wrap the <code>Tag</code> elements
        /// in an <code>And</code> element.
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
        /// An object key name prefix that identifies the subset of objects that the rule applies
        /// to.
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
        /// </summary>
        public S3Tag Tag
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