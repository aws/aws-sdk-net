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
    /// A complex type that contains <c>SizeConstraint</c> objects, which specify the parts
    /// of web requests that you want AWS WAF to inspect the size of. If a <c>SizeConstraintSet</c>
    /// contains more than one <c>SizeConstraint</c> object, a request only needs to match
    /// one constraint to be considered a match.
    /// </para>
    /// </summary>
    public partial class SizeConstraintSet
    {
        private string _name;
        private List<SizeConstraint> _sizeConstraints = AWSConfigs.InitializeCollections ? new List<SizeConstraint>() : null;
        private string _sizeConstraintSetId;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name, if any, of the <c>SizeConstraintSet</c>.
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

        /// <summary>
        /// Gets and sets the property SizeConstraints. 
        /// <para>
        /// Specifies the parts of web requests that you want to inspect the size of.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SizeConstraint> SizeConstraints
        {
            get { return this._sizeConstraints; }
            set { this._sizeConstraints = value; }
        }

        // Check to see if SizeConstraints property is set
        internal bool IsSetSizeConstraints()
        {
            return this._sizeConstraints != null && (this._sizeConstraints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SizeConstraintSetId. 
        /// <para>
        /// A unique identifier for a <c>SizeConstraintSet</c>. You use <c>SizeConstraintSetId</c>
        /// to get information about a <c>SizeConstraintSet</c> (see <a>GetSizeConstraintSet</a>),
        /// update a <c>SizeConstraintSet</c> (see <a>UpdateSizeConstraintSet</a>), insert a <c>SizeConstraintSet</c>
        /// into a <c>Rule</c> or delete one from a <c>Rule</c> (see <a>UpdateRule</a>), and delete
        /// a <c>SizeConstraintSet</c> from AWS WAF (see <a>DeleteSizeConstraintSet</a>).
        /// </para>
        ///  
        /// <para>
        ///  <c>SizeConstraintSetId</c> is returned by <a>CreateSizeConstraintSet</a> and by <a>ListSizeConstraintSets</a>.
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

    }
}