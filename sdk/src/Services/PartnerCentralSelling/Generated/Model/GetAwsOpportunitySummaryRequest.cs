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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
    /// Container for the parameters to the GetAwsOpportunitySummary operation.
    /// Retrieves a summary of an AWS Opportunity. This summary includes high-level details
    /// about the opportunity sourced from AWS, such as lifecycle information, customer details,
    /// and involvement type. It is useful for tracking updates on the AWS opportunity corresponding
    /// to an opportunity in the partner's account.
    /// </summary>
    public partial class GetAwsOpportunitySummaryRequest : AmazonPartnerCentralSellingRequest
    {
        private string _catalog;
        private string _relatedOpportunityIdentifier;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog in which the AWS Opportunity is located. Accepted values include
        /// <c>AWS</c> for production opportunities or <c>Sandbox</c> for testing purposes. The
        /// catalog determines which environment the opportunity data is pulled from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property RelatedOpportunityIdentifier. 
        /// <para>
        /// The unique identifier for the related partner opportunity. Use this field to correlate
        /// an AWS opportunity with its corresponding partner opportunity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RelatedOpportunityIdentifier
        {
            get { return this._relatedOpportunityIdentifier; }
            set { this._relatedOpportunityIdentifier = value; }
        }

        // Check to see if RelatedOpportunityIdentifier property is set
        internal bool IsSetRelatedOpportunityIdentifier()
        {
            return this._relatedOpportunityIdentifier != null;
        }

    }
}