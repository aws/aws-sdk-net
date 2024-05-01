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
    /// The response to a <a>GetXssMatchSet</a> request.
    /// </summary>
    public partial class GetXssMatchSetResponse : AmazonWebServiceResponse
    {
        private XssMatchSet _xssMatchSet;

        /// <summary>
        /// Gets and sets the property XssMatchSet. 
        /// <para>
        /// Information about the <a>XssMatchSet</a> that you specified in the <c>GetXssMatchSet</c>
        /// request. For more information, see the following topics:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>XssMatchSet</a>: Contains <c>Name</c>, <c>XssMatchSetId</c>, and an array of <c>XssMatchTuple</c>
        /// objects
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>XssMatchTuple</a>: Each <c>XssMatchTuple</c> object contains <c>FieldToMatch</c>
        /// and <c>TextTransformation</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>FieldToMatch</a>: Contains <c>Data</c> and <c>Type</c> 
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