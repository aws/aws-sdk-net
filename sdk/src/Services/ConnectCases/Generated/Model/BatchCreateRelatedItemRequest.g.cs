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

namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Container for the parameters to the BatchCreateRelatedItem operation. Creates a comment
    /// and associates it with multiple cases in a single request. All cases must belong to
    /// the same domain. This operation supports only the Comment related item type. <para>
    /// Each case is processed independently. If some cases fail, the remaining cases still
    /// receive the related item. To determine whether individual items failed, inspect the
    /// <c>failedItems</c> array in the response. </para> <para> The entire request fails,
    /// and no related items are created, in the following cases: </para> <ul> <li> <para>
    /// The specified domain doesn't exist. </para> </li> <li> <para> A reference ID doesn't
    /// match any case in the domain. </para> </li> <li> <para> The request contains duplicate
    /// case IDs. </para> </li> <li> <para> The content isn't comment content. </para> </li>
    /// </ul> <note> <para> This operation uses the same IAM action as <a href="https://docs.aws.amazon.com/cases/latest/APIReference/API_CreateRelatedItem.html">CreateRelatedItem</a>
    /// (<c>cases:CreateRelatedItem</c>). You can use the <c>cases:IsBatchAction</c> condition
    /// key in IAM policies to allow or deny batch operations independently from single-case
    /// operations. </para> </note> <note> <para> If you provide a value for <c>performedBy.userArn</c>,
    /// you must also have <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_DescribeUser.html">DescribeUser</a>
    /// permission on the ARN of the user that you provide. </para> </note> <para> <b>Endpoints</b>:
    /// See <a href="https://docs.aws.amazon.com/general/latest/gr/connect_region.html">Connect
    /// Customer endpoints and quotas</a>. </para>
    /// </summary>
    public partial class BatchCreateRelatedItemRequest : AmazonConnectCasesRequest
    {
        /// <summary>
        /// Gets and sets the property Cases. 
        /// <para>
        /// The list of cases to associate the related item with. All cases must belong to the
        /// same domain.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public List<BatchCreateRelatedItemIdentifier> Cases { get; set; } = AWSConfigs.InitializeCollections ? new List<BatchCreateRelatedItemIdentifier>() : null;

        /// <summary>
        /// Checks to see if the Cases property is set.
        /// </summary>
        internal bool IsSetCases() => this.Cases != null && (this.Cases.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        ///  
        /// <para>
        /// If you retry a request with the same client token, the service returns the original
        /// response instead of processing the request again. If you reuse a client token with
        /// different request parameters, the request fails with a <c>ConflictException</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the related item to be created. The same content is applied to every
        /// case in the request. Only comment content is supported for batch creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RelatedItemInputContent Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The unique identifier of the Cases domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property PerformedBy. 
        /// <para>
        /// The entity that created the related item.
        /// </para>
        /// </summary>
        public UserUnion PerformedBy { get; set; }

        /// <summary>
        /// Checks to see if the PerformedBy property is set.
        /// </summary>
        internal bool IsSetPerformedBy() => this.PerformedBy != null;
    }
}
