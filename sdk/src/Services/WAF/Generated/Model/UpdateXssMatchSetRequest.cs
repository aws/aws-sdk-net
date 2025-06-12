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
    /// Container for the parameters to the UpdateXssMatchSet operation.
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
    /// Inserts or deletes <a>XssMatchTuple</a> objects (filters) in an <a>XssMatchSet</a>.
    /// For each <c>XssMatchTuple</c> object, you specify the following values:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>Action</c>: Whether to insert the object into or delete the object from the array.
    /// To change an <c>XssMatchTuple</c>, you delete the existing object and add a new one.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>FieldToMatch</c>: The part of web requests that you want AWS WAF to inspect and,
    /// if you want AWS WAF to inspect a header or custom query parameter, the name of the
    /// header or parameter.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>TextTransformation</c>: Which text transformation, if any, to perform on the web
    /// request before inspecting the request for cross-site scripting attacks.
    /// </para>
    ///  
    /// <para>
    /// You can only specify a single type of TextTransformation.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You use <c>XssMatchSet</c> objects to specify which CloudFront requests that you want
    /// to allow, block, or count. For example, if you're receiving requests that contain
    /// cross-site scripting attacks in the request body and you want to block the requests,
    /// you can create an <c>XssMatchSet</c> with the applicable settings, and then configure
    /// AWS WAF to block the requests. 
    /// </para>
    ///  
    /// <para>
    /// To create and configure an <c>XssMatchSet</c>, perform the following steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Submit a <a>CreateXssMatchSet</a> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
    /// parameter of an <a>UpdateIPSet</a> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit an <c>UpdateXssMatchSet</c> request to specify the parts of web requests that
    /// you want AWS WAF to inspect for cross-site scripting attacks.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
    /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial class UpdateXssMatchSetRequest : AmazonWAFRequest
    {
        private string _changeToken;
        private List<XssMatchSetUpdate> _updates = AWSConfigs.InitializeCollections ? new List<XssMatchSetUpdate>() : null;
        private string _xssMatchSetId;

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
        /// Gets and sets the property Updates. 
        /// <para>
        /// An array of <c>XssMatchSetUpdate</c> objects that you want to insert into or delete
        /// from an <a>XssMatchSet</a>. For more information, see the applicable data types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>XssMatchSetUpdate</a>: Contains <c>Action</c> and <c>XssMatchTuple</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>XssMatchTuple</a>: Contains <c>FieldToMatch</c> and <c>TextTransformation</c>
        /// 
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
        public List<XssMatchSetUpdate> Updates
        {
            get { return this._updates; }
            set { this._updates = value; }
        }

        // Check to see if Updates property is set
        internal bool IsSetUpdates()
        {
            return this._updates != null && (this._updates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property XssMatchSetId. 
        /// <para>
        /// The <c>XssMatchSetId</c> of the <c>XssMatchSet</c> that you want to update. <c>XssMatchSetId</c>
        /// is returned by <a>CreateXssMatchSet</a> and by <a>ListXssMatchSets</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string XssMatchSetId
        {
            get { return this._xssMatchSetId; }
            set { this._xssMatchSetId = value; }
        }

        // Check to see if XssMatchSetId property is set
        internal bool IsSetXssMatchSetId()
        {
            return this._xssMatchSetId != null;
        }

    }
}