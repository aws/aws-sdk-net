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
    /// Container for the parameters to the RejectEngagementInvitation operation.
    /// This action rejects an <c>EngagementInvitation</c> that AWS shared. Rejecting an invitation
    /// indicates that the partner doesn't want to pursue the opportunity, and all related
    /// data will become inaccessible thereafter.
    /// </summary>
    public partial class RejectEngagementInvitationRequest : AmazonPartnerCentralSellingRequest
    {
        private string _catalog;
        private string _identifier;
        private string _rejectionReason;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// This is the catalog that's associated with the engagement invitation. Acceptable values
        /// are <c>AWS</c> or <c>Sandbox</c>, and these values determine the environment in which
        /// the opportunity is managed.
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
        /// This is the unique identifier of the rejected <c>EngagementInvitation</c>. Providing
        /// the correct identifier helps to ensure that the intended invitation is rejected.
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

        /// <summary>
        /// Gets and sets the property RejectionReason. 
        /// <para>
        /// This describes the reason for rejecting the engagement invitation, which helps AWS
        /// track usage patterns. Acceptable values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Customer problem unclear:</i> The customer's problem isn't understood.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Next steps unclear:</i> The next steps required to proceed aren't understood.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Unable to support:</i> The partner is unable to provide support due to resource
        /// or capability constraints.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Duplicate of partner referral:</i> The opportunity is a duplicate of an existing
        /// referral.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Other:</i> Any reason not covered by other values.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string RejectionReason
        {
            get { return this._rejectionReason; }
            set { this._rejectionReason = value; }
        }

        // Check to see if RejectionReason property is set
        internal bool IsSetRejectionReason()
        {
            return this._rejectionReason != null;
        }

    }
}