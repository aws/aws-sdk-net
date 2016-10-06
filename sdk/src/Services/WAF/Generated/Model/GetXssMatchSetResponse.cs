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
    /// The response to a <a>GetXssMatchSet</a> request.
    /// </summary>
    public partial class GetXssMatchSetResponse : AmazonWebServiceResponse
    {
        private XssMatchSet _xssMatchSet;

        /// <summary>
        /// Gets and sets the property XssMatchSet. 
        /// <para>
        /// Information about the <a>XssMatchSet</a> that you specified in the <code>GetXssMatchSet</code>
        /// request. For more information, see the following topics:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>XssMatchSet</a>: Contains <code>Name</code>, <code>XssMatchSetId</code>, and an
        /// array of <code>XssMatchTuple</code> objects
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>XssMatchTuple</a>: Each <code>XssMatchTuple</code> object contains <code>FieldToMatch</code>
        /// and <code>TextTransformation</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>FieldToMatch</a>: Contains <code>Data</code> and <code>Type</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public XssMatchSet XssMatchSet
        {
            get { return this._xssMatchSet; }
            set { this._xssMatchSet = value; }
        }

        // Check to see if XssMatchSet property is set
        internal bool IsSetXssMatchSet()
        {
            return this._xssMatchSet != null;
        }

    }
}