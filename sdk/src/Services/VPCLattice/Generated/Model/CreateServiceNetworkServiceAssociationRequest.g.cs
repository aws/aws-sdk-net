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

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Container for the parameters to the CreateServiceNetworkServiceAssociation operation.
    /// Associates the specified service with the specified service network. For more information,
    /// see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/service-network-associations.html#service-network-service-associations">Manage
    /// service associations</a> in the <i>Amazon VPC Lattice User Guide</i>. <para> You can't
    /// use this operation if the service and service network are already associated or if
    /// there is a disassociation or deletion in progress. If the association fails, you can
    /// retry the operation by deleting the association and recreating it. </para> <para>
    /// You cannot associate a service and service network that are shared with a caller.
    /// The caller must own either the service or the service network. </para> <para> As a
    /// result of this operation, the association is created in the service network account
    /// and the association owner account. </para>
    /// </summary>
    public partial class CreateServiceNetworkServiceAssociationRequest : AmazonVPCLatticeRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you retry a request that completed successfully using the same client
        /// token and parameters, the retry succeeds without performing any actions. If the parameters
        /// aren't identical, the retry fails.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ServiceIdentifier. 
        /// <para>
        /// The ID or ARN of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 17, Max = 2048)]
        public string ServiceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ServiceIdentifier property is set.
        /// </summary>
        internal bool IsSetServiceIdentifier() => this.ServiceIdentifier != null;

        /// <summary>
        /// Gets and sets the property ServiceNetworkIdentifier. 
        /// <para>
        /// The ID or ARN of the service network. You must use an ARN if the resources are in
        /// different accounts.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 2048)]
        public string ServiceNetworkIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNetworkIdentifier property is set.
        /// </summary>
        internal bool IsSetServiceNetworkIdentifier() => this.ServiceNetworkIdentifier != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the association.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
