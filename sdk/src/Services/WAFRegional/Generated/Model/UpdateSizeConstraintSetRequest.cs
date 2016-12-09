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
    /// Container for the parameters to the UpdateSizeConstraintSet operation.
    /// Inserts or deletes <a>SizeConstraint</a> objects (filters) in a <a>SizeConstraintSet</a>.
    /// For each <code>SizeConstraint</code> object, you specify the following values: 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Whether to insert or delete the object from the array. If you want to change a <code>SizeConstraintSetUpdate</code>
    /// object, you delete the existing object and add a new one.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The part of a web request that you want AWS WAF to evaluate, such as the length of
    /// a query string or the length of the <code>User-Agent</code> header.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Whether to perform any transformations on the request, such as converting it to lowercase,
    /// before checking its length. Note that transformations of the request body are not
    /// supported because the AWS resource forwards only the first <code>8192</code> bytes
    /// of your request to AWS WAF.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <code>ComparisonOperator</code> used for evaluating the selected part of the request
    /// against the specified <code>Size</code>, such as equals, greater than, less than,
    /// and so on.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The length, in bytes, that you want AWS WAF to watch for in selected part of the request.
    /// The length is computed after applying the transformation.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For example, you can add a <code>SizeConstraintSetUpdate</code> object that matches
    /// web requests in which the length of the <code>User-Agent</code> header is greater
    /// than 100 bytes. You can then configure AWS WAF to block those requests.
    /// </para>
    ///  
    /// <para>
    /// To create and configure a <code>SizeConstraintSet</code>, perform the following steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Create a <code>SizeConstraintSet.</code> For more information, see <a>CreateSizeConstraintSet</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
    /// parameter of an <code>UpdateSizeConstraintSet</code> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit an <code>UpdateSizeConstraintSet</code> request to specify the part of the
    /// request that you want AWS WAF to inspect (for example, the header or the URI) and
    /// the value that you want AWS WAF to watch for.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
    /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial class UpdateSizeConstraintSetRequest : AmazonWAFRegionalRequest
    {
        private string _changeToken;
        private string _sizeConstraintSetId;
        private List<SizeConstraintSetUpdate> _updates = new List<SizeConstraintSetUpdate>();

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
        /// to update. <code>SizeConstraintSetId</code> is returned by <a>CreateSizeConstraintSet</a>
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

        /// <summary>
        /// Gets and sets the property Updates. 
        /// <para>
        /// An array of <code>SizeConstraintSetUpdate</code> objects that you want to insert into
        /// or delete from a <a>SizeConstraintSet</a>. For more information, see the applicable
        /// data types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>SizeConstraintSetUpdate</a>: Contains <code>Action</code> and <code>SizeConstraint</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SizeConstraint</a>: Contains <code>FieldToMatch</code>, <code>TextTransformation</code>,
        /// <code>ComparisonOperator</code>, and <code>Size</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>FieldToMatch</a>: Contains <code>Data</code> and <code>Type</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<SizeConstraintSetUpdate> Updates
        {
            get { return this._updates; }
            set { this._updates = value; }
        }

        // Check to see if Updates property is set
        internal bool IsSetUpdates()
        {
            return this._updates != null && this._updates.Count > 0; 
        }

    }
}