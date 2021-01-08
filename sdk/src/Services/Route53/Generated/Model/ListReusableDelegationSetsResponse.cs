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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that contains information about the reusable delegation sets that are
    /// associated with the current AWS account.
    /// </summary>
    public partial class ListReusableDelegationSetsResponse : AmazonWebServiceResponse
    {
        private List<DelegationSet> _delegationSets = new List<DelegationSet>();
        private string _marker;
        private bool? _isTruncated;
        private string _nextMarker;
        private string _maxItems;

        /// <summary>
        /// Gets and sets the property DelegationSets. 
        /// <para>
        /// A complex type that contains one <code>DelegationSet</code> element for each reusable
        /// delegation set that was created by the current AWS account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DelegationSet> DelegationSets
        {
            get { return this._delegationSets; }
            set { this._delegationSets = value; }
        }

        // Check to see if DelegationSets property is set
        internal bool IsSetDelegationSets()
        {
            return this._delegationSets != null && this._delegationSets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// For the second and subsequent calls to <code>ListReusableDelegationSets</code>, <code>Marker</code>
        /// is the value that you specified for the <code>marker</code> parameter in the request
        /// that produced the current response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// A flag that indicates whether there are more reusable delegation sets to be listed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool IsTruncated
        {
            get { return this._isTruncated.GetValueOrDefault(); }
            set { this._isTruncated = value; }
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this._isTruncated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// If <code>IsTruncated</code> is <code>true</code>, the value of <code>NextMarker</code>
        /// identifies the next reusable delegation set that Amazon Route 53 will return if you
        /// submit another <code>ListReusableDelegationSets</code> request and specify the value
        /// of <code>NextMarker</code> in the <code>marker</code> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The value that you specified for the <code>maxitems</code> parameter in the call to
        /// <code>ListReusableDelegationSets</code> that produced the current response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MaxItems
        {
            get { return this._maxItems; }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems != null;
        }

    }
}