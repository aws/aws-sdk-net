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
    /// Lists existing domain associations that conflict with the domain that you specify.
    /// 
    ///  
    /// <para>
    /// You can use this API operation when transferring domains to identify potential domain
    /// conflicts. Domain conflicts must be resolved first before they can be moved.
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
        /// The distribution resource identifier. This can be the distribution or distribution
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