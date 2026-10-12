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
    /// Container for the parameters to the CreateEngagementInvitation operation. This action
    /// creates an invitation from a sender to a single receiver to join an engagement.
    /// </summary>
    public partial class CreateEngagementInvitationRequest : AmazonPartnerCentralSellingRequest
    {
        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        ///  Specifies the catalog related to the engagement. Accepted values are <c>AWS</c> and
        /// <c>Sandbox</c>, which determine the environment in which the engagement is managed.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  Specifies a unique, client-generated UUID to ensure that the request is handled exactly
        /// once. This token helps prevent duplicate invitation creations. 
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property EngagementIdentifier. 
        /// <para>
        ///  The unique identifier of the <c>Engagement</c> associated with the invitation. This
        /// parameter ensures the invitation is created within the correct <c>Engagement</c> context.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EngagementIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EngagementIdentifier property is set.
        /// </summary>
        internal bool IsSetEngagementIdentifier() => this.EngagementIdentifier != null;

        /// <summary>
        /// Gets and sets the property Invitation. 
        /// <para>
        ///  The <c>Invitation</c> object all information necessary to initiate an engagement
        /// invitation to a partner. It contains a personalized message from the sender, the invitation's
        /// receiver, and a payload. The <c>Payload</c> can be the <c>OpportunityInvitation</c>,
        /// which includes detailed structures for sender contacts, partner responsibilities,
        /// customer information, and project details, or <c>LeadInvitation</c>, which includes
        /// structures for customer information and interaction details. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Invitation Invitation { get; set; }

        /// <summary>
        /// Checks to see if the Invitation property is set.
        /// </summary>
        internal bool IsSetInvitation() => this.Invitation != null;
    }
}
