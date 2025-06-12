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
    /// In a <a>GetByteMatchSet</a> request, <c>ByteMatchSet</c> is a complex type that contains
    /// the <c>ByteMatchSetId</c> and <c>Name</c> of a <c>ByteMatchSet</c>, and the values
    /// that you specified when you updated the <c>ByteMatchSet</c>. 
    /// </para>
    ///  
    /// <para>
    /// A complex type that contains <c>ByteMatchTuple</c> objects, which specify the parts
    /// of web requests that you want AWS WAF to inspect and the values that you want AWS
    /// WAF to search for. If a <c>ByteMatchSet</c> contains more than one <c>ByteMatchTuple</c>
    /// object, a request needs to match the settings in only one <c>ByteMatchTuple</c> to
    /// be considered a match.
    /// </para>
    /// </summary>
    public partial class ByteMatchSet
    {
        private string _byteMatchSetId;
        private List<ByteMatchTuple> _byteMatchTuples = AWSConfigs.InitializeCollections ? new List<ByteMatchTuple>() : null;
        private string _name;

        /// <summary>
        /// Gets and sets the property ByteMatchSetId. 
        /// <para>
        /// The <c>ByteMatchSetId</c> for a <c>ByteMatchSet</c>. You use <c>ByteMatchSetId</c>
        /// to get information about a <c>ByteMatchSet</c> (see <a>GetByteMatchSet</a>), update
        /// a <c>ByteMatchSet</c> (see <a>UpdateByteMatchSet</a>), insert a <c>ByteMatchSet</c>
        /// into a <c>Rule</c> or delete one from a <c>Rule</c> (see <a>UpdateRule</a>), and delete
        /// a <c>ByteMatchSet</c> from AWS WAF (see <a>DeleteByteMatchSet</a>).
        /// </para>
        ///  
        /// <para>
        ///  <c>ByteMatchSetId</c> is returned by <a>CreateByteMatchSet</a> and by <a>ListByteMatchSets</a>.
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
        /// Gets and sets the property ByteMatchTuples. 
        /// <para>
        /// Specifies the bytes (typically a string that corresponds with ASCII characters) that
        /// you want AWS WAF to search for in web requests, the location in requests that you
        /// want AWS WAF to search, and other settings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ByteMatchTuple> ByteMatchTuples
        {
            get { return this._byteMatchTuples; }
            set { this._byteMatchTuples = value; }
        }

        // Check to see if ByteMatchTuples property is set
        internal bool IsSetByteMatchTuples()
        {
            return this._byteMatchTuples != null && (this._byteMatchTuples.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name or description of the <a>ByteMatchSet</a>. You can't change <c>Name</c>
        /// after you create a <c>ByteMatchSet</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}