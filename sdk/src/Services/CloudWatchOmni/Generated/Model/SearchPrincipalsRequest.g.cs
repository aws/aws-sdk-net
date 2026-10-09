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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Container for the parameters to the SearchPrincipals operation. Searches Identity
    /// Center for users and groups in a domain. The domain must be configured with Identity
    /// Center. To grant access to a result, pass its principalId to CreateAccessGrant with
    /// a principalType of IDC_USER for a user or IDC_GROUP for a group.
    /// </summary>
    public partial class SearchPrincipalsRequest : AmazonCloudWatchOmniRequest
    {
        /// <summary>
        /// Gets and sets the property DomainId. The ID of the domain to search within.
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. The maximum number of results to return. Defaults
        /// to 10. Valid only when searchQuery is *; other searches reject this parameter and
        /// return at most 10 results.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. A token to retrieve the next page of results.
        /// Valid only when searchQuery is *; other searches do not paginate and reject this parameter.
        /// Tokens expire after 24 hours.
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SearchQuery. A search term to match against user names,
        /// display names, and IDs. Pass * to list all principals. Maximum 128 characters.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string SearchQuery { get; set; }

        /// <summary>
        /// Checks to see if the SearchQuery property is set.
        /// </summary>
        internal bool IsSetSearchQuery() => this.SearchQuery != null;
    }
}
