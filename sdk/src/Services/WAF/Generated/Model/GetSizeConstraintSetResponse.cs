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
    /// This is the response object from the GetSizeConstraintSet operation.
    /// </summary>
    public partial class GetSizeConstraintSetResponse : AmazonWebServiceResponse
    {
        private SizeConstraintSet _sizeConstraintSet;

        /// <summary>
        /// Gets and sets the property SizeConstraintSet. 
        /// <para>
        /// Information about the <a>SizeConstraintSet</a> that you specified in the <code>GetSizeConstraintSet</code>
        /// request. For more information, see the following topics:
        /// </para>
        ///  <ul> <li><a>SizeConstraintSet</a>: Contains <code>SizeConstraintSetId</code>, <code>SizeConstraints</code>,
        /// and <code>Name</code></li> <li><code>SizeConstraints</code>: Contains an array of
        /// <a>SizeConstraint</a> objects. Each <code>SizeConstraint</code> object contains <a>FieldToMatch</a>,
        /// <code>TextTransformation</code>, <code>ComparisonOperator</code>, and <code>Size</code></li>
        /// <li><a>FieldToMatch</a>: Contains <code>Data</code> and <code>Type</code></li> </ul>
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