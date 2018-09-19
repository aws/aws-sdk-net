/*
 * Copyright 2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.S3.Model.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Filter that identifies subset of objects to which the replication rule applies.
    /// A <code>Filter</code> must specify exactly one <code>Prefix</code>,
    /// <code>Tag</code>, or an <code>And</code> child element.
    /// </summary>
    public class ReplicationRuleFilter
    {
        private string prefix;
        private Tag tag;
        private ReplicationRuleAndOperator and;

        /// <summary>
        /// Object keyname prefix that identifies subset of objects to which the rule applies.
        /// </summary>
        public string Prefix
        {
            get { return this.prefix; }
            set { this.prefix = value; }
        }

        /// <summary>
        /// Checks to see if Prefix property is set.
        /// </summary>
        /// <returns>true if Prefix property is set.</returns>
        internal bool IsSetPrefix()
        {
            return !System.String.IsNullOrEmpty(this.prefix);
        }

        /// <summary>
        /// <p>Container for specifying a tag key and value. </p>
        /// <p>The rule applies only to objects having the tag in its tagset.</p>
        /// </summary>
        public Tag Tag
        {
            get { return this.tag; }
            set { this.tag = value; }
        }

        /// <summary>
        /// Checks to see if Tag property is set.
        /// </summary>
        /// <returns>true if Tag property is set.</returns>
        internal bool IsSetTag()
        {
            return tag != null;
        }

        /// <summary>
        /// <p>Container for specifying rule filters. These filters determine the
        /// subset of objects to which the rule applies. The element is required
        /// only if you specify more than one filter. For example: </p> <ul> <li>
        /// <p>You specify both a <code>Prefix</code> and a <code>Tag</code>
        /// filters. Then you wrap these in an <code>And</code> tag.</p> </li>
        /// <li> <p>You specify filter based on multiple tags. Then you wrap the
        /// <code>Tag</code> elements in an <code>And</code> tag.</p> </li> </ul>
        /// </summary>
        public ReplicationRuleAndOperator And
        {
            get { return this.and; }
            set { this.and = value; }
        }

        /// <summary>
        /// Checks to see if And property is set.
        /// </summary>
        /// <returns>true if And property is set.</returns>
        internal bool IsSetAnd()
        {
            return and != null;
        }
    }
}
