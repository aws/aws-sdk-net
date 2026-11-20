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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAssetOwner operation. Transfers the ownership
    /// of an asset to another project in the same Amazon DataZone domain. The transfer changes
    /// the asset's owning project and moves its published listing, subscriptions, and subscription
    /// grants to the target project. <para> The transfer runs asynchronously, and the operation
    /// returns HTTP status code 202. To follow the transfer, call <c>GetAsset</c> and check
    /// <c>ownershipTransfer.status</c> until it is <c>SUCCEEDED</c> or <c>FAILED</c>. </para>
    /// <para> You need to be an owner of the project that currently owns the asset. You can
    /// transfer an asset from the domain's administration project to any project. You can
    /// also transfer an asset from any project to the administration project. </para> <para>
    /// An asset can have only one ownership transfer in progress at a time. While a transfer
    /// is in progress, requests that change the asset or its listing fail with a <c>ConflictException</c>.
    /// </para>
    /// </summary>
    public partial class UpdateAssetOwnerRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the operation completes no more
        /// than one time. If this token matches a previous request while its transfer is in progress,
        /// the service returns that transfer and doesn't start a new one. This field is automatically
        /// populated if not provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the Amazon DataZone domain that contains the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The ID of the asset whose ownership is transferred.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property TargetProjectIdentifier. 
        /// <para>
        /// The ID of the project that the asset is transferred to. The project must be in the
        /// same domain and must be different from the project that currently owns the asset.
        /// </para>
        ///  
        /// <para>
        /// If the domain's administration project owns the asset, the target can be any project.
        /// Otherwise, the target must be the administration project.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetProjectIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the TargetProjectIdentifier property is set.
        /// </summary>
        internal bool IsSetTargetProjectIdentifier() => this.TargetProjectIdentifier != null;
    }
}
