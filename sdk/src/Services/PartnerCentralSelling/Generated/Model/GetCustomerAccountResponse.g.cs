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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// This is the response object from the GetCustomerAccount operation.
    /// </summary>
    public partial class GetCustomerAccountResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// The details of the customer that you provided.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CustomerAccountData Account { get; set; }

        /// <summary>
        /// Checks to see if the Account property is set.
        /// </summary>
        internal bool IsSetAccount() => this.Account != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the customer account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AwsEnrichment. 
        /// <para>
        /// Enrichment information that AWS provides about the customer. Present only when <c>EnrichmentStatus</c>
        /// is <c>ENRICHED</c>.
        /// </para>
        /// </summary>
        public AwsEnrichment AwsEnrichment { get; set; }

        /// <summary>
        /// Checks to see if the AwsEnrichment property is set.
        /// </summary>
        internal bool IsSetAwsEnrichment() => this.AwsEnrichment != null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog that the customer account belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date and time when the customer account was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property EnrichmentStatus. 
        /// <para>
        /// The enrichment status of the customer account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EnrichmentStatus EnrichmentStatus { get; set; }

        /// <summary>
        /// Checks to see if the EnrichmentStatus property is set.
        /// </summary>
        internal bool IsSetEnrichmentStatus() => this.EnrichmentStatus != null;

        /// <summary>
        /// Gets and sets the property ExistingCustomerAccountArn. 
        /// <para>
        /// The ARN of the customer account that already maps this customer. Present only when
        /// <c>ReasonCode</c> is <c>DUPLICATE_CUSTOMER_MATCH</c>.
        /// </para>
        /// </summary>
        public string ExistingCustomerAccountArn { get; set; }

        /// <summary>
        /// Checks to see if the ExistingCustomerAccountArn property is set.
        /// </summary>
        internal bool IsSetExistingCustomerAccountArn() => this.ExistingCustomerAccountArn != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the customer account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Issues. 
        /// <para>
        /// The issues found with the customer account. Present only when there is at least one
        /// issue.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Issue> Issues { get; set; } = AWSConfigs.InitializeCollections ? new List<Issue>() : null;

        /// <summary>
        /// Checks to see if the Issues property is set.
        /// </summary>
        internal bool IsSetIssues() => this.Issues != null && (this.Issues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time when the customer account was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A description of the problem and the steps that you can take to resolve it.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property PartnerAccountIdentifier. 
        /// <para>
        /// Your own identifier for the customer account, if you provided one.
        /// </para>
        /// </summary>
        public string PartnerAccountIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the PartnerAccountIdentifier property is set.
        /// </summary>
        internal bool IsSetPartnerAccountIdentifier() => this.PartnerAccountIdentifier != null;

        /// <summary>
        /// Gets and sets the property ReasonCode. 
        /// <para>
        /// The reason that the customer account needs your action. Present only when <c>EnrichmentStatus</c>
        /// is <c>ACTION_REQUIRED</c>.
        /// </para>
        /// </summary>
        public CustomerAccountFailureReason ReasonCode { get; set; }

        /// <summary>
        /// Checks to see if the ReasonCode property is set.
        /// </summary>
        internal bool IsSetReasonCode() => this.ReasonCode != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags on the customer account. This member is absent if the tags can't be retrieved,
        /// which is different from an account that has no tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
