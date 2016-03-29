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
    /// Specifies the <a>ByteMatchSet</a>, <a>IPSet</a>, <a>SqlInjectionMatchSet</a>, <a>XssMatchSet</a>,
    /// and <a>SizeConstraintSet</a> objects that you want to add to a <code>Rule</code> and,
    /// for each object, indicates whether you want to negate the settings, for example, requests
    /// that do NOT originate from the IP address 192.0.2.44.
    /// </summary>
    public partial class Predicate
    {
        private string _dataId;
        private bool? _negated;
        private PredicateType _type;

        /// <summary>
        /// Gets and sets the property DataId. 
        /// <para>
        /// A unique identifier for a predicate in a <code>Rule</code>, such as <code>ByteMatchSetId</code>
        /// or <code>IPSetId</code>. The ID is returned by the corresponding <code>Create</code>
        /// or <code>List</code> command.
        /// </para>
        /// </summary>
        public string DataId
        {
            get { return this._dataId; }
            set { this._dataId = value; }
        }

        // Check to see if DataId property is set
        internal bool IsSetDataId()
        {
            return this._dataId != null;
        }

        /// <summary>
        /// Gets and sets the property Negated. 
        /// <para>
        /// Set <code>Negated</code> to <code>False</code> if you want AWS WAF to allow, block,
        /// or count requests based on the settings in the specified <a>ByteMatchSet</a>, <a>IPSet</a>,
        /// <a>SqlInjectionMatchSet</a>, <a>XssMatchSet</a>, or <a>SizeConstraintSet</a>. For
        /// example, if an <code>IPSet</code> includes the IP address <code>192.0.2.44</code>,
        /// AWS WAF will allow or block requests based on that IP address.
        /// </para>
        ///  
        /// <para>
        /// Set <code>Negated</code> to <code>True</code> if you want AWS WAF to allow or block
        /// a request based on the negation of the settings in the <a>ByteMatchSet</a>, <a>IPSet</a>,
        /// <a>SqlInjectionMatchSet</a>, <a>XssMatchSet</a>, or <a>SizeConstraintSet</a>. For
        /// example, if an <code>IPSet</code> includes the IP address <code>192.0.2.44</code>,
        /// AWS WAF will allow, block, or count requests based on all IP addresses <i>except</i>
        /// <code>192.0.2.44</code>.
        /// </para>
        /// </summary>
        public bool Negated
        {
            get { return this._negated.GetValueOrDefault(); }
            set { this._negated = value; }
        }

        // Check to see if Negated property is set
        internal bool IsSetNegated()
        {
            return this._negated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of predicate in a <code>Rule</code>, such as <code>ByteMatchSet</code> or
        /// <code>IPSet</code>.
        /// </para>
        /// </summary>
        public PredicateType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}