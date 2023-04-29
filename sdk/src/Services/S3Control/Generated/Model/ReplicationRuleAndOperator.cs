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
    /// A container for specifying rule filters. The filters determine the subset of objects
    /// to which the rule applies. This element is required only if you specify more than
    /// one filter. 
    /// 
    ///  
    /// <para>
    /// For example:
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
    public partial class ReplicationRuleAndOperator
    {
        private string _prefix;
        private List<S3Tag> _tags = new List<S3Tag>();

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// An object key name prefix that identifies the subset of objects that the rule applies
        /// to.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of tags that contain key and value pairs.
        /// </para>
        /// </summary>
        public List<S3Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}