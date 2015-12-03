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
    /// In an <a>UpdateByteMatchSet</a> request, <code>ByteMatchSetUpdate</code> specifies
    /// whether to insert or delete a <a>ByteMatchTuple</a> and includes the settings for
    /// the <code>ByteMatchTuple</code>.
    /// </summary>
    public partial class ByteMatchSetUpdate
    {
        private ChangeAction _action;
        private ByteMatchTuple _byteMatchTuple;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specifies whether to insert or delete a <a>ByteMatchTuple</a>.
        /// </para>
        /// </summary>
        public ChangeAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property ByteMatchTuple. 
        /// <para>
        /// Information about the part of a web request that you want AWS WAF to inspect and the
        /// value that you want AWS WAF to search for. If you specify <code>DELETE</code> for
        /// the value of <code>Action</code>, the <code>ByteMatchTuple</code> values must exactly
        /// match the values in the <code>ByteMatchTuple</code> that you want to delete from the
        /// <code>ByteMatchSet</code>.
        /// </para>
        /// </summary>
        public ByteMatchTuple ByteMatchTuple
        {
            get { return this._byteMatchTuple; }
            set { this._byteMatchTuple = value; }
        }

        // Check to see if ByteMatchTuple property is set
        internal bool IsSetByteMatchTuple()
        {
            return this._byteMatchTuple != null;
        }

    }
}