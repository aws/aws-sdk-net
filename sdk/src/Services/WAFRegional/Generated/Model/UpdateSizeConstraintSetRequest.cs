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
    /// Container for the parameters to the UpdateSizeConstraintSet operation.
    /// <note> 
    /// <para>
    /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
    /// WAF Classic</a> in the developer guide.
    /// </para>
    ///  
    /// <para>
    ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
    /// for regional and global use. 
    /// </para>
    ///  </note> 
    /// <para>
    /// Inserts or deletes <a>SizeConstraint</a> objects (filters) in a <a>SizeConstraintSet</a>.
    /// For each <c>SizeConstraint</c> object, you specify the following values: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Whether to insert or delete the object from the array. If you want to change a <c>SizeConstraintSetUpdate</c>
    /// object, you delete the existing object and add a new one.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The part of a web request that you want AWS WAF to evaluate, such as the length of
    /// a query string or the length of the <c>User-Agent</c> header.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Whether to perform any transformations on the request, such as converting it to lowercase,
    /// before checking its length. Note that transformations of the request body are not
    /// supported because the AWS resource forwards only the first <c>8192</c> bytes of your
    /// request to AWS WAF.
    /// </para>
    ///  
    /// <para>
    /// You can only specify a single type of TextTransformation.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <c>ComparisonOperator</c> used for evaluating the selected part of the request against
    /// the specified <c>Size</c>, such as equals, greater than, less than, and so on.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The length, in bytes, that you want AWS WAF to watch for in selected part of the request.
    /// The length is computed after applying the transformation.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For example, you can add a <c>SizeConstraintSetUpdate</c> object that matches web
    /// requests in which the length of the <c>User-Agent</c> header is greater than 100 bytes.
    /// You can then configure AWS WAF to block those requests.
    /// </para>
    ///  
    /// <para>
    /// To create and configure a <c>SizeConstraintSet</c>, perform the following steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Create a <c>SizeConstraintSet.</c> For more information, see <a>CreateSizeConstraintSet</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
    /// parameter of an <c>UpdateSizeConstraintSet</c> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit an <c>UpdateSizeConstraintSet</c> request to specify the part of the request
    /// that you want AWS WAF to inspect (for example, the header or the URI) and the value
    /// that you want AWS WAF to watch for.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
    /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial class UpdateSizeConstraintSetRequest : AmazonWAFRegionalRequest
    {
        private string _changeToken;
        private string _sizeConstraintSetId;
        private List<SizeConstraintSetUpdate> _updates = AWSConfigs.InitializeCollections ? new List<SizeConstraintSetUpdate>() : null;

        /// <summary>
        /// Gets and sets the property ChangeToken. 
        /// <para>
        /// The value returned by the most recent call to <a>GetChangeToken</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// The <c>SizeConstraintSetId</c> of the <a>SizeConstraintSet</a> that you want to update.
        /// <c>SizeConstraintSetId</c> is returned by <a>CreateSizeConstraintSet</a> and by <a>ListSizeConstraintSets</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// An array of <c>SizeConstraintSetUpdate</c> objects that you want to insert into or
        /// delete from a <a>SizeConstraintSet</a>. For more information, see the applicable data
        /// types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>SizeConstraintSetUpdate</a>: Contains <c>Action</c> and <c>SizeConstraint</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SizeConstraint</a>: Contains <c>FieldToMatch</c>, <c>TextTransformation</c>, <c>ComparisonOperator</c>,
        /// and <c>Size</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>FieldToMatch</a>: Contains <c>Data</c> and <c>Type</c> 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<SizeConstraintSetUpdate> Updates
        {
            get { return this._updates; }
            set { this._updates = value; }
        }

        // Check to see if Updates property is set
        internal bool IsSetUpdates()
        {
            return this._updates != null && (this._updates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}