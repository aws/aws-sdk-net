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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// Container for the parameters to the ListExascaleDbStorageVaults operation. Returns
    /// information about the Exascale storage vaults owned by your Amazon Web Services account.
    /// </summary>
    public partial class ListExascaleDbStorageVaultsRequest : AmazonOdbRequest
    {
        /// <summary>
        /// Gets and sets the property CloudExadataInfrastructureId. 
        /// <para>
        /// The unique identifier or Amazon Resource Name (ARN) of an Exadata infrastructure.
        /// If you specify this value, the operation returns only the Exascale storage vaults
        /// on that infrastructure that you own or that are shared with you. The infrastructure
        /// can be one that's shared with you through Amazon Web Services Resource Access Manager
        /// (Amazon Web Services RAM). You can't combine this filter with a <c>vaultType</c> of
        /// <c>EXASCALE_INFRASTRUCTURE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 2048)]
        public string CloudExadataInfrastructureId { get; set; }

        /// <summary>
        /// Checks to see if the CloudExadataInfrastructureId property is set.
        /// </summary>
        internal bool IsSetCloudExadataInfrastructureId() => this.CloudExadataInfrastructureId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned from a previous paginated request. Pagination continues from the
        /// end of the items returned by the previous request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property VaultType. 
        /// <para>
        /// The type of Exascale storage vaults to return. Specify <c>DEDICATED_INFRASTRUCTURE</c>
        /// to return Exascale storage vaults on dedicated Exadata infrastructure, or <c>EXASCALE_INFRASTRUCTURE</c>
        /// to return Exascale storage vaults for Exascale VM clusters. If you don't specify a
        /// value, the operation returns both types. You can't combine <c>EXASCALE_INFRASTRUCTURE</c>
        /// with the <c>cloudExadataInfrastructureId</c> filter.
        /// </para>
        /// </summary>
        public ExascaleDbStorageVaultType VaultType { get; set; }

        /// <summary>
        /// Checks to see if the VaultType property is set.
        /// </summary>
        internal bool IsSetVaultType() => this.VaultType != null;
    }
}
