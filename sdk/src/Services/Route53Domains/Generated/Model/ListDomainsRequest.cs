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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
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
namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Container for the parameters to the ListDomains operation.
    /// This operation returns all the domain names registered with Amazon Route 53 for the
    /// current Amazon Web Services account if no filtering conditions are used.
    /// </summary>
    public partial class ListDomainsRequest : AmazonRoute53DomainsRequest
    {
        private List<FilterCondition> _filterConditions = AWSConfigs.InitializeCollections ? new List<FilterCondition>() : null;
        private string _marker;
        private int? _maxItems;
        private SortCondition _sortCondition;

        /// <summary>
        /// Gets and sets the property FilterConditions. 
        /// <para>
        /// A complex type that contains information about the filters applied during the <c>ListDomains</c>
        /// request. The filter conditions can include domain name and domain expiration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FilterCondition> FilterConditions
        {
            get { return this._filterConditions; }
            set { this._filterConditions = value; }
        }

        // Check to see if FilterConditions property is set
        internal bool IsSetFilterConditions()
        {
            return this._filterConditions != null && (this._filterConditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// For an initial request for a list of domains, omit this element. If the number of
        /// domains that are associated with the current Amazon Web Services account is greater
        /// than the value that you specified for <c>MaxItems</c>, you can use <c>Marker</c> to
        /// return additional domains. Get the value of <c>NextPageMarker</c> from the previous
        /// response, and submit another request that includes the value of <c>NextPageMarker</c>
        /// in the <c>Marker</c> element.
        /// </para>
        ///  
        /// <para>
        /// Constraints: The marker must match the value specified in the previous request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
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
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// Number of domains to be returned.
        /// </para>
        ///  
        /// <para>
        /// Default: 20
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public int? MaxItems
        {
            get { return this._maxItems; }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SortCondition. 
        /// <para>
        /// A complex type that contains information about the requested ordering of domains in
        /// the returned list.
        /// </para>
        /// </summary>
        public SortCondition SortCondition
        {
            get { return this._sortCondition; }
            set { this._sortCondition = value; }
        }

        // Check to see if SortCondition property is set
        internal bool IsSetSortCondition()
        {
            return this._sortCondition != null;
        }

    }
}