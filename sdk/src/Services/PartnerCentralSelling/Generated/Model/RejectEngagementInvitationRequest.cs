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
    /// Use this action to reject an <c>EngagementInvitation</c> that has been shared by AWS.
    /// Rejecting the engagement invitation indicates that the partner does not wish to pursue
    /// the opportunity, and all related data will be inaccessible after the rejection.
    /// </summary>
    public partial class RejectEngagementInvitationRequest : AmazonPartnerCentralSellingRequest
    {
        private string _catalog;
        private string _identifier;
        private string _rejectionReason;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog related to the engagement invitation. Accepted values are <c>AWS</c>
        /// and <c>Sandbox</c>, which determine the environment in which the opportunity is managed.
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
        /// Specifies the unique identifier of the <c>EngagementInvitation</c> to be rejected.
        /// Providing the correct identifier ensures that the intended invitation is rejected.
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
        /// Specifies the reason for rejecting the engagement invitation. Providing a reason helps
        /// document the rationale behind the rejection and assists AWS in tracking patterns or
        /// issues. Possible values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Customer problem unclear:</i> The customer's problem is not clearly defined.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Next steps unclear:</i> The next steps required to proceed are not clear.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Unable to support:</i> The partner is unable to provide support due to resource
        /// or capability constraints.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Duplicate of Partner Referral:</i> The opportunity is a duplicate of an existing
        /// referral.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Other:</i> Any other reason not covered by the specified values.
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