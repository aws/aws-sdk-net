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
    /// Container for the parameters to the GetSizeConstraintSet operation.
    /// Returns the <a>SizeConstraintSet</a> specified by <code>SizeConstraintSetId</code>.
    /// </summary>
    public partial class GetSizeConstraintSetRequest : AmazonWAFRequest
    {
        private string _sizeConstraintSetId;

        /// <summary>
        /// Gets and sets the property SizeConstraintSetId. 
        /// <para>
        /// The <code>SizeConstraintSetId</code> of the <a>SizeConstraintSet</a> that you want
        /// to get. <code>SizeConstraintSetId</code> is returned by <a>CreateSizeConstraintSet</a>
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