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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.WAFRegional.Model
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
        /// Information about the <a>SizeConstraintSet</a> that you specified in the <c>GetSizeConstraintSet</c>
        /// request. For more information, see the following topics:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>SizeConstraintSet</a>: Contains <c>SizeConstraintSetId</c>, <c>SizeConstraints</c>,
        /// and <c>Name</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SizeConstraints</c>: Contains an array of <a>SizeConstraint</a> objects. Each
        /// <c>SizeConstraint</c> object contains <a>FieldToMatch</a>, <c>TextTransformation</c>,
        /// <c>ComparisonOperator</c>, and <c>Size</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>FieldToMatch</a>: Contains <c>Data</c> and <c>Type</c> 
        /// </para>
        ///  </li> </ul>
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