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
    /// A customer account in the results of <c>SearchCustomerAccounts</c>. It carries a reduced
    /// set of fields compared to the full account that is returned by <c>GetCustomerAccount</c>.
    /// </summary>
    public partial class CustomerAccountSummary
    {
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
        /// A summary of the enrichment information that AWS provides about the customer. Present
        /// only when <c>EnrichmentStatus</c> is <c>ENRICHED</c>.
        /// </para>
        /// </summary>
        public AwsEnrichmentSummary AwsEnrichment { get; set; }

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
        /// Gets and sets the property CustomerAccount. 
        /// <para>
        /// A summary of the details of the customer that you provided.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CustomerAccountDetailsSummary CustomerAccount { get; set; }

        /// <summary>
        /// Checks to see if the CustomerAccount property is set.
        /// </summary>
        internal bool IsSetCustomerAccount() => this.CustomerAccount != null;

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
    }
}
