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
    /// A container for specifying a filter that excludes matching objects from the replication
    /// rule. Specify exactly one <c>Prefix</c>, <c>Tag</c>, or <c>Or</c> child element.
    /// </summary>
    public partial class ReplicationRuleNotOperator
    {
        private ReplicationRuleOrOperator _or;
        private string _prefix;
        private Tag _tag;

        /// <summary>
        /// Gets and sets the property Or. 
        /// <para>
        /// A container for specifying prefixes and tags. An object is excluded from the replication
        /// rule if it matches any of the specified filters.
        /// </para>
        /// </summary>
        public ReplicationRuleOrOperator Or
        {
            get { return this._or; }
            set { this._or = value; }
        }

        // Check to see if Or property is set
        internal bool IsSetOr()
        {
            return this._or != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// An object key name prefix that identifies objects to exclude from the replication
        /// rule.
        /// </para>
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
        /// A tag key and value that identify objects to exclude from the replication rule.
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