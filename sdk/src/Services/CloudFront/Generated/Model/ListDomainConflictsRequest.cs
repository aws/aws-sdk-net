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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the ListDomainConflicts operation.
    /// <note> 
    /// <para>
    /// We recommend that you use the <c>ListDomainConflicts</c> API operation to check for
    /// domain conflicts, as it supports both standard distributions and distribution tenants.
    /// <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ListConflictingAliases.html">ListConflictingAliases</a>
    /// performs similar checks but only supports standard distributions.
    /// 
    ///  </note> 
    /// <para>
    /// Lists existing domain associations that conflict with the domain that you specify.
    /// </para>
    ///  
    /// <para>
    /// You can use this API operation to identify potential domain conflicts when moving
    /// domains between standard distributions and/or distribution tenants. Domain conflicts
    /// must be resolved first before they can be moved. 
    /// </para>
    ///  
    /// <para>
    /// For example, if you provide <c>www.example.com</c> as input, the returned list can
    /// include <c>www.example.com</c> and the overlapping wildcard alternate domain name
    /// (<c><em>.example.com</c>), if they exist. If you provide <c></em>.example.com</c>
    /// as input, the returned list can include <c>*.example.com</c> and any alternate domain
    /// names covered by that wildcard (for example, <c>www.example.com</c>, <c>test.example.com</c>,
    /// <c>dev.example.com</c>, and so on), if they exist.
    /// </para>
    ///  
    /// <para>
    /// To list conflicting domains, specify the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The domain to search for
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The ID of a standard distribution or distribution tenant in your account that has
    /// an attached TLS certificate, which covers the specified domain
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, including how to set up the standard distribution or distribution
    /// tenant, and the certificate, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/CNAMEs.html#alternate-domain-names-move">Moving
    /// an alternate domain name to a different standard distribution or distribution tenant</a>
    /// in the <i>Amazon CloudFront Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can optionally specify the maximum number of items to receive in the response.
    /// If the total number of items in the list exceeds the maximum that you specify, or
    /// the default maximum, the response is paginated. To get the next page of items, send
    /// a subsequent request that specifies the <c>NextMarker</c> value from the current response
    /// as the <c>Marker</c> value in the subsequent request.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial class ListDomainConflictsRequest : AmazonCloudFrontRequest
    {
        private string _domain;
        private DistributionResourceId _domainControlValidationResource;
        private string _marker;
        private int? _maxItems;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain to check for conflicts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property DomainControlValidationResource. 
        /// <para>
        /// The distribution resource identifier. This can be the standard distribution or distribution
        /// tenant that has a valid certificate, which covers the domain that you specify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DistributionResourceId DomainControlValidationResource
        {
            get { return this._domainControlValidationResource; }
            set { this._domainControlValidationResource = value; }
        }

        // Check to see if DomainControlValidationResource property is set
        internal bool IsSetDomainControlValidationResource()
        {
            return this._domainControlValidationResource != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The marker for the next set of domain conflicts.
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
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of domain conflicts to return.
        /// </para>
        /// </summary>
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

    }
}