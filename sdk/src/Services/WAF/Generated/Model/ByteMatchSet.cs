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
    /// In a <a>GetByteMatchSet</a> request, <code>ByteMatchSet</code> is a complex type that
    /// contains the <code>ByteMatchSetId</code> and <code>Name</code> of a <code>ByteMatchSet</code>,
    /// and the values that you specified when you updated the <code>ByteMatchSet</code>.
    /// 
    /// 
    ///  
    /// <para>
    /// A complex type that contains <code>ByteMatchTuple</code> objects, which specify the
    /// parts of web requests that you want AWS WAF to inspect and the values that you want
    /// AWS WAF to search for. If a <code>ByteMatchSet</code> contains more than one <code>ByteMatchTuple</code>
    /// object, a request needs to match the settings in only one <code>ByteMatchTuple</code>
    /// to be considered a match.
    /// </para>
    /// </summary>
    public partial class ByteMatchSet
    {
        private string _byteMatchSetId;
        private List<ByteMatchTuple> _byteMatchTuples = new List<ByteMatchTuple>();
        private string _name;

        /// <summary>
        /// Gets and sets the property ByteMatchSetId. 
        /// <para>
        /// The <code>ByteMatchSetId</code> for a <code>ByteMatchSet</code>. You use <code>ByteMatchSetId</code>
        /// to get information about a <code>ByteMatchSet</code> (see <a>GetByteMatchSet</a>),
        /// update a <code>ByteMatchSet</code> (see <a>UpdateByteMatchSet</a>, insert a <code>ByteMatchSet</code>
        /// into a <code>Rule</code> or delete one from a <code>Rule</code> (see <a>UpdateRule</a>),
        /// and delete a <code>ByteMatchSet</code> from AWS WAF (see <a>DeleteByteMatchSet</a>).
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
        /// Gets and sets the property ByteMatchTuples. 
        /// <para>
        /// Specifies the bytes (typically a string that corresponds with ASCII characters) that
        /// you want AWS WAF to search for in web requests, the location in requests that you
        /// want AWS WAF to search, and other settings.
        /// </para>
        /// </summary>
        public List<ByteMatchTuple> ByteMatchTuples
        {
            get { return this._byteMatchTuples; }
            set { this._byteMatchTuples = value; }
        }

        // Check to see if ByteMatchTuples property is set
        internal bool IsSetByteMatchTuples()
        {
            return this._byteMatchTuples != null && this._byteMatchTuples.Count > 0; 
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