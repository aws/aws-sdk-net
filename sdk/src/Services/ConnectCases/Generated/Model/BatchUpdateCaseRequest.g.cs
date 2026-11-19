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
    /// Container for the parameters to the BatchUpdateCase operation. Updates fields on multiple
    /// cases in a single request. All cases must belong to the same domain. Set the title,
    /// status, and customer ID through the top-level <c>title</c>, <c>status</c>, and <c>customerId</c>
    /// parameters, and set other fields through the <c>fields</c> array. <para> Each case
    /// is processed independently. If some cases fail, the remaining cases are still updated.
    /// To determine whether individual cases failed, inspect the <c>failedCases</c> array
    /// in the response. </para> <para> The entire request fails, and no cases are updated,
    /// in the following cases: </para> <ul> <li> <para> The specified domain doesn't exist.
    /// </para> </li> <li> <para> A reference ID doesn't match any case in the domain. </para>
    /// </li> <li> <para> The request contains duplicate case IDs. </para> </li> <li> <para>
    /// The request doesn't specify any update. Provide at least one entry in <c>fields</c>,
    /// or a <c>title</c>, <c>status</c>, or <c>customerId</c>. </para> </li> <li> <para>
    /// A field identifier in <c>fields</c> doesn't resolve to a field in the domain, for
    /// example, an unknown field name. </para> </li> <li> <para> A field name contains a
    /// pipe (<c>|</c>) or comma (<c>,</c>) character. </para> </li> <li> <para> <c>fields</c>
    /// includes <c>title</c>, <c>status</c>, or <c>customerId</c>. </para> </li> </ul> <note>
    /// <para> This operation uses the same IAM action as <a href="https://docs.aws.amazon.com/cases/latest/APIReference/API_UpdateCase.html">UpdateCase</a>
    /// (<c>cases:UpdateCase</c>). You can use the <c>cases:IsBatchAction</c> condition key
    /// in IAM policies to allow or deny batch operations independently from single-case operations.
    /// </para> </note> <note> <para> If you provide a value for <c>performedBy.userArn</c>,
    /// you must also have <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_DescribeUser.html">DescribeUser</a>
    /// permission on the ARN of the user that you provide. </para> </note> <para> <b>Endpoints</b>:
    /// See <a href="https://docs.aws.amazon.com/general/latest/gr/connect_region.html">Connect
    /// Customer endpoints and quotas</a>. </para>
    /// </summary>
    public partial class BatchUpdateCaseRequest : AmazonConnectCasesRequest
    {
        /// <summary>
        /// Gets and sets the property Cases. 
        /// <para>
        /// The list of cases to update. All cases must belong to the same domain.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public List<BatchUpdateCaseIdentifier> Cases { get; set; } = AWSConfigs.InitializeCollections ? new List<BatchUpdateCaseIdentifier>() : null;

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
        /// Gets and sets the property CustomerId. 
        /// <para>
        /// The ARN of the customer profile to associate with all cases in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Checks to see if the CustomerId property is set.
        /// </summary>
        internal bool IsSetCustomerId() => this.CustomerId != null;

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
        /// Gets and sets the property Fields. 
        /// <para>
        /// An array of objects, each with a <c>fieldIdentifier</c> and a <c>value</c>. You can
        /// identify each field by its ID or by its name; identifying a field by name is supported
        /// only in <c>BatchUpdateCase</c>. The same field values are applied to every case in
        /// the request. This field must be present, but can be an empty list when you provide
        /// the top-level <c>title</c>, <c>status</c>, or <c>customerId</c> parameters. Do not
        /// include <c>title</c>, <c>status</c>, or <c>customerId</c> in this list; set those
        /// values only through their top-level parameters. Duplicating them in <c>fields</c>
        /// results in a validation error.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 220)]
        public List<FieldValueInput> Fields { get; set; } = AWSConfigs.InitializeCollections ? new List<FieldValueInput>() : null;

        /// <summary>
        /// Checks to see if the Fields property is set.
        /// </summary>
        internal bool IsSetFields() => this.Fields != null && (this.Fields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PerformedBy. 
        /// <para>
        /// The entity that performed the action.
        /// </para>
        /// </summary>
        public UserUnion PerformedBy { get; set; }

        /// <summary>
        /// Checks to see if the PerformedBy property is set.
        /// </summary>
        internal bool IsSetPerformedBy() => this.PerformedBy != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status to apply to all cases in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title to apply to all cases in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 500)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
