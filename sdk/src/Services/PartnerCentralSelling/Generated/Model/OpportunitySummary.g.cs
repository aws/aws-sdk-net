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
    /// An object that contains an <c>Opportunity</c>'s subset of fields.
    /// </summary>
    public partial class OpportunitySummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for the opportunity. This globally unique identifier
        /// can be used for IAM policies and cross-service references. 
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog associated with the opportunity, either <c>AWS</c> or <c>Sandbox</c>.
        /// This indicates the environment in which the opportunity is managed.
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
        ///  <c>DateTime</c> when the <c>Opportunity</c> was last created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Customer. 
        /// <para>
        /// An object that contains the <c>Opportunity</c>'s customer details.
        /// </para>
        /// </summary>
        public CustomerSummary Customer { get; set; }

        /// <summary>
        /// Checks to see if the Customer property is set.
        /// </summary>
        internal bool IsSetCustomer() => this.Customer != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Read-only, system-generated <c>Opportunity</c> unique identifier.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        ///  <c>DateTime</c> when the <c>Opportunity</c> was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property LifeCycle. 
        /// <para>
        /// An object that contains the <c>Opportunity</c>'s lifecycle details.
        /// </para>
        /// </summary>
        public LifeCycleSummary LifeCycle { get; set; }

        /// <summary>
        /// Checks to see if the LifeCycle property is set.
        /// </summary>
        internal bool IsSetLifeCycle() => this.LifeCycle != null;

        /// <summary>
        /// Gets and sets the property OpportunityType. 
        /// <para>
        /// Specifies opportunity type as a renewal, new, or expansion.
        /// </para>
        ///  
        /// <para>
        /// Opportunity types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// New Opportunity: Represents a new business opportunity with a potential customer that's
        /// not previously engaged with your solutions or services.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Renewal Opportunity: Represents an opportunity to renew an existing contract or subscription
        /// with a current customer, ensuring continuity of service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Expansion Opportunity: Represents an opportunity to expand the scope of an existing
        /// contract or subscription, either by adding new services or increasing the volume of
        /// existing services for a current customer.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public OpportunityType OpportunityType { get; set; }

        /// <summary>
        /// Checks to see if the OpportunityType property is set.
        /// </summary>
        internal bool IsSetOpportunityType() => this.OpportunityType != null;

        /// <summary>
        /// Gets and sets the property PartnerOpportunityIdentifier. 
        /// <para>
        /// Specifies the <c>Opportunity</c>'s unique identifier in the partner's CRM system.
        /// This value is essential to track and reconcile because it's included in the outbound
        /// payload sent back to the partner. It allows partners to link an opportunity to their
        /// CRM.
        /// </para>
        /// </summary>
        public string PartnerOpportunityIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the PartnerOpportunityIdentifier property is set.
        /// </summary>
        internal bool IsSetPartnerOpportunityIdentifier() => this.PartnerOpportunityIdentifier != null;

        /// <summary>
        /// Gets and sets the property Project. 
        /// <para>
        /// An object that contains the <c>Opportunity</c>'s project details summary.
        /// </para>
        /// </summary>
        public ProjectSummary Project { get; set; }

        /// <summary>
        /// Checks to see if the Project property is set.
        /// </summary>
        internal bool IsSetProject() => this.Project != null;
    }
}
