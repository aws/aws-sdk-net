/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAF.Model
{
    /// <summary>
    /// Returned by <a>ListByteMatchSets</a>. Each <code>ByteMatchSetSummary</code> object
    /// includes the <code>Name</code> and <code>ByteMatchSetId</code> for one <a>ByteMatchSet</a>.
    /// </summary>
    public partial class ByteMatchSetSummary
    {
        private string _byteMatchSetId;
        private string _name;

        /// <summary>
        /// Gets and sets the property ByteMatchSetId. 
        /// <para>
        /// The <code>ByteMatchSetId</code> for a <code>ByteMatchSet</code>. You use <code>ByteMatchSetId</code>
        /// to get information about a <code>ByteMatchSet</code>, update a <code>ByteMatchSet</code>,
        /// remove a <code>ByteMatchSet</code> from a <code>Rule</code>, and delete a <code>ByteMatchSet</code>
        /// from AWS WAF.
        /// </para>
        ///  
        /// <para>
        /// <code>ByteMatchSetId</code> is returned by <a>CreateByteMatchSet</a> and by <a>ListByteMatchSets</a>.
        /// </para>
        /// </summary>
        public string ByteMatchSetId
        {
            get { return this._byteMatchSetId; }
            set { this._byteMatchSetId = value; }
        }

        // Check to see if ByteMatchSetId property is set
        internal bool IsSetByteMatchSetId()
        {
            return this._byteMatchSetId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name or description of the <a>ByteMatchSet</a>. You can't change <code>Name</code>
        /// after you create a <code>ByteMatchSet</code>.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}