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
    /// Container for the parameters to the AssignOpportunity operation.
    /// Enables you to reassign an existing <c>Opportunity</c> to another user within your
    /// Partner Central account. The specified user receives the opportunity, and it appears
    /// on their Partner Central dashboard, allowing them to take necessary actions or proceed
    /// with the opportunity.
    /// 
    ///  
    /// <para>
    /// This is useful for distributing opportunities to the appropriate team members or departments
    /// within your organization, ensuring that each opportunity is handled by the right person.
    /// By default, the opportunity owner is the one who creates it. Currently, there's no
    /// API to enumerate the list of available users.
    /// </para>
    /// </summary>
    public partial class AssignOpportunityRequest : AmazonPartnerCentralSellingRequest
    {
        private AssigneeContact _assignee;
        private string _catalog;
        private string _identifier;

        /// <summary>
        /// Gets and sets the property Assignee. 
        /// <para>
        /// Specifies the user or team member responsible for managing the assigned opportunity.
        /// This field identifies the <i>Assignee</i> based on the partner's internal team structure.
        /// Ensure that the email address is associated with a registered user in your Partner
        /// Central account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssigneeContact Assignee
        {
            get { return this._assignee; }
            set { this._assignee = value; }
        }

        // Check to see if Assignee property is set
        internal bool IsSetAssignee()
        {
            return this._assignee != null;
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog associated with the request. This field takes a string value
        /// from a predefined list: <c>AWS</c> or <c>Sandbox</c>. The catalog determines which
        /// environment the opportunity is assigned in. Use <c>AWS</c> to assign real opportunities
        /// in the Amazon Web Services catalog, and <c>Sandbox</c> for testing in secure, isolated
        /// environments.
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
        /// Gets and sets the property Identifier. 
        /// <para>
        /// Requires the <c>Opportunity</c>'s unique identifier when you want to assign it to
        /// another user. Provide the correct identifier so the intended opportunity is reassigned.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

    }
}