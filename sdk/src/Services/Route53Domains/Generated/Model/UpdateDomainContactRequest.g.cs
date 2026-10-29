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

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDomainContact operation. This operation
    /// updates the contact information for a particular domain. You must specify information
    /// for at least one contact: registrant, administrator, or technical. <para> If the update
    /// is successful, this method returns an operation ID that you can use to track the progress
    /// and completion of the operation. If the request is not completed successfully, the
    /// domain registrant will be notified by email. </para>
    /// </summary>
    public partial class UpdateDomainContactRequest : AmazonRoute53DomainsRequest
    {
        /// <summary>
        /// Gets and sets the property AdminContact. 
        /// <para>
        /// Provides detailed contact information.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public ContactDetail AdminContact { get; set; }

        /// <summary>
        /// Checks to see if the AdminContact property is set.
        /// </summary>
        internal bool IsSetAdminContact() => this.AdminContact != null;

        /// <summary>
        /// Gets and sets the property BillingContact. 
        /// <para>
        /// Provides detailed contact information.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public ContactDetail BillingContact { get; set; }

        /// <summary>
        /// Checks to see if the BillingContact property is set.
        /// </summary>
        internal bool IsSetBillingContact() => this.BillingContact != null;

        /// <summary>
        /// Gets and sets the property Consent. 
        /// <para>
        ///  The maximum amount that you agree to pay for the owner change. Required if the domain
        /// is not free (consent price is more than USD $0.00).
        /// </para>
        /// </summary>
        public Consent Consent { get; set; }

        /// <summary>
        /// Checks to see if the Consent property is set.
        /// </summary>
        internal bool IsSetConsent() => this.Consent != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain that you want to update contact information for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property RegistrantContact. 
        /// <para>
        /// Provides detailed contact information.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public ContactDetail RegistrantContact { get; set; }

        /// <summary>
        /// Checks to see if the RegistrantContact property is set.
        /// </summary>
        internal bool IsSetRegistrantContact() => this.RegistrantContact != null;

        /// <summary>
        /// Gets and sets the property TechContact. 
        /// <para>
        /// Provides detailed contact information.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public ContactDetail TechContact { get; set; }

        /// <summary>
        /// Checks to see if the TechContact property is set.
        /// </summary>
        internal bool IsSetTechContact() => this.TechContact != null;
    }
}
