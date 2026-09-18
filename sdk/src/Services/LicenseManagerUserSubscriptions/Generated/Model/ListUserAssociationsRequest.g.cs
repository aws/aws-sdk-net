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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.LicenseManagerUserSubscriptions.Model
{
    /// <summary>
    /// Container for the parameters to the ListUserAssociations operation. Lists user associations
    /// for an identity provider.
    /// </summary>
    public partial class ListUserAssociationsRequest : AmazonLicenseManagerUserSubscriptionsRequest
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// You can use the following filters to streamline results:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Status
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Username
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Domain
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IdentityProvider. 
        /// <para>
        /// An object that specifies details for the identity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IdentityProvider IdentityProvider { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProvider property is set.
        /// </summary>
        internal bool IsSetIdentityProvider() => this.IdentityProvider != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the EC2 instance, which provides user-based subscriptions.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return from a single request.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to specify where to start paginating. This is the nextToken from a previously
        /// truncated response.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
