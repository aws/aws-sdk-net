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
    /// 
    /// </summary>
    public partial class GetByteMatchSetResponse : AmazonWebServiceResponse
    {
        private ByteMatchSet _byteMatchSet;

        /// <summary>
        /// Gets and sets the property ByteMatchSet. 
        /// <para>
        /// Information about the <a>ByteMatchSet</a> that you specified in the <code>GetByteMatchSet</code>
        /// request. For more information, see the following topics:
        /// </para>
        ///  <ul> <li> <a>ByteMatchSet</a>: Contains <code>ByteMatchSetId</code>, <code>ByteMatchTuples</code>,
        /// and <code>Name</code> </li> <li> <code>ByteMatchTuples</code>: Contains an array of
        /// <a>ByteMatchTuple</a> objects. Each <code>ByteMatchTuple</code> object contains <a>FieldToMatch</a>,
        /// <code>PositionalConstraint</code>, <code>TargetString</code>, and <code>TextTransformation</code>
        /// </li> <li> <a>FieldToMatch</a>: Contains <code>Data</code> and <code>Type</code> </li>
        /// </ul>
        /// </summary>
        public ByteMatchSet ByteMatchSet
        {
            get { return this._byteMatchSet; }
            set { this._byteMatchSet = value; }
        }

        // Check to see if ByteMatchSet property is set
        internal bool IsSetByteMatchSet()
        {
            return this._byteMatchSet != null;
        }

    }
}