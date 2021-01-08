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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFRegional.Model
{
    /// <summary>
    /// This is the response object from the CreateSizeConstraintSet operation.
    /// </summary>
    public partial class CreateSizeConstraintSetResponse : AmazonWebServiceResponse
    {
        private string _changeToken;
        private SizeConstraintSet _sizeConstraintSet;

        /// <summary>
        /// Gets and sets the property ChangeToken. 
        /// <para>
        /// The <code>ChangeToken</code> that you used to submit the <code>CreateSizeConstraintSet</code>
        /// request. You can also use this value to query the status of the request. For more
        /// information, see <a>GetChangeTokenStatus</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property SizeConstraintSet. 
        /// <para>
        /// A <a>SizeConstraintSet</a> that contains no <code>SizeConstraint</code> objects.
        /// </para>
        /// </summary>
        public SizeConstraintSet SizeConstraintSet
        {
            get { return this._sizeConstraintSet; }
            set { this._sizeConstraintSet = value; }
        }

        // Check to see if SizeConstraintSet property is set
        internal bool IsSetSizeConstraintSet()
        {
            return this._sizeConstraintSet != null;
        }

    }
}