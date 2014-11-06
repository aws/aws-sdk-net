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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that contains the response for the request.
    /// </summary>
    public partial class ListReusableDelegationSetsResult : AmazonWebServiceResponse
    {
        private List<DelegationSet> _delegationSets = new List<DelegationSet>();
        private string _marker;
        private bool? _isTruncated;
        private string _nextMarker;
        private string _maxItems;

        /// <summary>
        /// Gets and sets the property DelegationSets. 
        /// <para>
        /// A complex type that contains information about the reusable delegation sets associated
        /// with the current AWS account.
        /// </para>
        /// </summary>
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
        /// If the request returned more than one page of results, submit another request and
        /// specify the value of <code>NextMarker</code> from the last response in the <code>marker</code>
        /// parameter to get the next page of results.
        /// </para>
        /// </summary>
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
        ///  A flag indicating whether there are more reusable delegation sets to be listed. If
        /// your results were truncated, you can make a follow-up request for the next page of
        /// results by using the <code>Marker</code> element.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>true</code> | <code>false</code>
        /// </para>
        /// </summary>
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
        ///  Indicates where to continue listing reusable delegation sets. If <a>ListReusableDelegationSetsResponse$IsTruncated</a>
        /// is <code>true</code>, make another request to <code>ListReusableDelegationSets</code>
        /// and include the value of the <code>NextMarker</code> element in the <code>Marker</code>
        /// element to get the next page of results.
        /// </para>
        /// </summary>
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
        /// The maximum number of reusable delegation sets to be included in the response body.
        /// If the number of reusable delegation sets associated with this AWS account exceeds
        /// <code>MaxItems</code>, the value of <a>ListReusablDelegationSetsResponse$IsTruncated</a>
        /// in the response is <code>true</code>. Call <code>ListReusableDelegationSets</code>
        /// again and specify the value of <a>ListReusableDelegationSetsResponse$NextMarker</a>
        /// in the <a>ListReusableDelegationSetsRequest$Marker</a> element to get the next page
        /// of results.
        /// </para>
        /// </summary>
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