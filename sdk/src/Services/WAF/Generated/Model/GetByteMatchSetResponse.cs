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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
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
namespace Amazon.WAF.Model
{
    /// <summary>
    /// This is the response object from the GetByteMatchSet operation.
    /// </summary>
    public partial class GetByteMatchSetResponse : AmazonWebServiceResponse
    {
        private ByteMatchSet _byteMatchSet;

        /// <summary>
        /// Gets and sets the property ByteMatchSet. 
        /// <para>
        /// Information about the <a>ByteMatchSet</a> that you specified in the <c>GetByteMatchSet</c>
        /// request. For more information, see the following topics:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ByteMatchSet</a>: Contains <c>ByteMatchSetId</c>, <c>ByteMatchTuples</c>, and
        /// <c>Name</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ByteMatchTuples</c>: Contains an array of <a>ByteMatchTuple</a> objects. Each
        /// <c>ByteMatchTuple</c> object contains <a>FieldToMatch</a>, <c>PositionalConstraint</c>,
        /// <c>TargetString</c>, and <c>TextTransformation</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>FieldToMatch</a>: Contains <c>Data</c> and <c>Type</c> 
        /// </para>
        ///  </li> </ul>
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