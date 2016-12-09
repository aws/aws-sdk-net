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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFRegional.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteSizeConstraintSet operation.
    /// Permanently deletes a <a>SizeConstraintSet</a>. You can't delete a <code>SizeConstraintSet</code>
    /// if it's still used in any <code>Rules</code> or if it still includes any <a>SizeConstraint</a>
    /// objects (any filters).
    /// 
    ///  
    /// <para>
    /// If you just want to remove a <code>SizeConstraintSet</code> from a <code>Rule</code>,
    /// use <a>UpdateRule</a>.
    /// </para>
    ///  
    /// <para>
    /// To permanently delete a <code>SizeConstraintSet</code>, perform the following steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Update the <code>SizeConstraintSet</code> to remove filters, if any. For more information,
    /// see <a>UpdateSizeConstraintSet</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
    /// parameter of a <code>DeleteSizeConstraintSet</code> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit a <code>DeleteSizeConstraintSet</code> request.
    /// </para>
    ///  </li> </ol>
    /// </summary>
    public partial class DeleteSizeConstraintSetRequest : AmazonWAFRegionalRequest
    {
        private string _changeToken;
        private string _sizeConstraintSetId;

        /// <summary>
        /// Gets and sets the property ChangeToken. 
        /// <para>
        /// The value returned by the most recent call to <a>GetChangeToken</a>.
        /// </para>
        /// </summary>
        public string ChangeToken
        {
            get { return this._changeToken; }
            set { this._changeToken = value; }
        }

        // Check to see if ChangeToken property is set
        internal bool IsSetChangeToken()
        {
            return this._changeToken != null;
        }

        /// <summary>
        /// Gets and sets the property SizeConstraintSetId. 
        /// <para>
        /// The <code>SizeConstraintSetId</code> of the <a>SizeConstraintSet</a> that you want
        /// to delete. <code>SizeConstraintSetId</code> is returned by <a>CreateSizeConstraintSet</a>
        /// and by <a>ListSizeConstraintSets</a>.
        /// </para>
        /// </summary>
        public string SizeConstraintSetId
        {
            get { return this._sizeConstraintSetId; }
            set { this._sizeConstraintSetId = value; }
        }

        // Check to see if SizeConstraintSetId property is set
        internal bool IsSetSizeConstraintSetId()
        {
            return this._sizeConstraintSetId != null;
        }

    }
}