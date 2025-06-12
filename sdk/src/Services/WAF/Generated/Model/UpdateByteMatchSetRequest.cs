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
    /// Container for the parameters to the UpdateByteMatchSet operation.
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
    /// Inserts or deletes <a>ByteMatchTuple</a> objects (filters) in a <a>ByteMatchSet</a>.
    /// For each <c>ByteMatchTuple</c> object, you specify the following values: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Whether to insert or delete the object from the array. If you want to change a <c>ByteMatchSetUpdate</c>
    /// object, you delete the existing object and add a new one.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The part of a web request that you want AWS WAF to inspect, such as a query string
    /// or the value of the <c>User-Agent</c> header. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The bytes (typically a string that corresponds with ASCII characters) that you want
    /// AWS WAF to look for. For more information, including how you specify the values for
    /// the AWS WAF API and the AWS CLI or SDKs, see <c>TargetString</c> in the <a>ByteMatchTuple</a>
    /// data type. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Where to look, such as at the beginning or the end of a query string.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Whether to perform any conversions on the request, such as converting it to lowercase,
    /// before inspecting it for the specified string.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For example, you can add a <c>ByteMatchSetUpdate</c> object that matches web requests
    /// in which <c>User-Agent</c> headers contain the string <c>BadBot</c>. You can then
    /// configure AWS WAF to block those requests.
    /// </para>
    ///  
    /// <para>
    /// To create and configure a <c>ByteMatchSet</c>, perform the following steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Create a <c>ByteMatchSet.</c> For more information, see <a>CreateByteMatchSet</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
    /// parameter of an <c>UpdateByteMatchSet</c> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit an <c>UpdateByteMatchSet</c> request to specify the part of the request that
    /// you want AWS WAF to inspect (for example, the header or the URI) and the value that
    /// you want AWS WAF to watch for.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
    /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial class UpdateByteMatchSetRequest : AmazonWAFRequest
    {
        private string _byteMatchSetId;
        private string _changeToken;
        private List<ByteMatchSetUpdate> _updates = AWSConfigs.InitializeCollections ? new List<ByteMatchSetUpdate>() : null;

        /// <summary>
        /// Gets and sets the property ByteMatchSetId. 
        /// <para>
        /// The <c>ByteMatchSetId</c> of the <a>ByteMatchSet</a> that you want to update. <c>ByteMatchSetId</c>
        /// is returned by <a>CreateByteMatchSet</a> and by <a>ListByteMatchSets</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ByteMatchSetId
        {
            get { return this._byteMatchSetId; }
            set { this._byteMatchSetId = value; }
        }

        // Check to see if ByteMatchSetId property is set
        internal bool IsSetByteMatchSetId()
        {
            return this._byteMatchSetId != null;
        }

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
        /// An array of <c>ByteMatchSetUpdate</c> objects that you want to insert into or delete
        /// from a <a>ByteMatchSet</a>. For more information, see the applicable data types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ByteMatchSetUpdate</a>: Contains <c>Action</c> and <c>ByteMatchTuple</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ByteMatchTuple</a>: Contains <c>FieldToMatch</c>, <c>PositionalConstraint</c>,
        /// <c>TargetString</c>, and <c>TextTransformation</c> 
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
        public List<ByteMatchSetUpdate> Updates
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