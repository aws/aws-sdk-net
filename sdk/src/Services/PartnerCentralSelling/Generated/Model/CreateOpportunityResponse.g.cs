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
    /// This is the response object from the CreateOpportunity operation.
    /// </summary>
    public partial class CreateOpportunityResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Read-only, system-generated <c>Opportunity</c> unique identifier. Amazon Web Services
        /// creates this identifier, and it's used for all subsequent opportunity actions, such
        /// as updates, associations, and submissions. It helps to ensure that each opportunity
        /// is accurately tracked and managed.
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
        ///  <c>DateTime</c> when the opportunity was last modified. When the <c>Opportunity</c>
        /// is created, its value is <c>CreatedDate</c>.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property PartnerOpportunityIdentifier. 
        /// <para>
        /// Specifies the opportunity's unique identifier in the partner's CRM system. This value
        /// is essential to track and reconcile because it's included in the outbound payload
        /// sent back to the partner.
        /// </para>
        /// </summary>
        public string PartnerOpportunityIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the PartnerOpportunityIdentifier property is set.
        /// </summary>
        internal bool IsSetPartnerOpportunityIdentifier() => this.PartnerOpportunityIdentifier != null;
    }
}
