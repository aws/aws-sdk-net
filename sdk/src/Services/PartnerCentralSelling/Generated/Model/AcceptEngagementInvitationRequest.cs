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
    /// Container for the parameters to the AcceptEngagementInvitation operation.
    /// Use the <c>AcceptEngagementInvitation</c> action to accept an engagement invitation
    /// shared by AWS. Accepting the invitation indicates your willingness to participate
    /// in the engagement, granting you access to all engagement-related data.
    /// </summary>
    public partial class AcceptEngagementInvitationRequest : AmazonPartnerCentralSellingRequest
    {
        private string _catalog;
        private string _identifier;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The <c>CatalogType</c> parameter specifies the catalog associated with the engagement
        /// invitation. Accepted values are <c>AWS</c> and <c>Sandbox</c>, which determine the
        /// environment in which the engagement invitation is managed.
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
        ///  The <c>Identifier</c> parameter in the <c>AcceptEngagementInvitationRequest</c> specifies
        /// the unique identifier of the <c>EngagementInvitation</c> to be accepted. Providing
        /// the correct identifier ensures that the intended invitation is accepted. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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