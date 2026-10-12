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

namespace Amazon.PartnerCentralAccount.Model
{
    /// <summary>
    /// Container for the parameters to the StartQualificationsDisassociationTask operation.
    /// Initiates an asynchronous task to disassociate your partner qualifications from a
    /// primary account. You must currently be associated and cannot disassociate if you are
    /// the primary partner. Use <c>GetQualificationsDisassociationTask</c> to monitor task
    /// progress.
    /// </summary>
    public partial class StartQualificationsDisassociationTaskRequest : AmazonPartnerCentralAccountRequest
    {
        /// <summary>
        /// Gets and sets the property AssociatedPartner. 
        /// <para>
        /// The primary partner's profile and account identifier that you are currently associated
        /// with and will disassociate from. You must provide at least one of <c>ProfileId</c>
        /// or <c>AccountId</c>. The specified partner must match your current primary association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public QualificationsAssociationPartner AssociatedPartner { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedPartner property is set.
        /// </summary>
        internal bool IsSetAssociatedPartner() => this.AssociatedPartner != null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog in which to perform the qualifications disassociation. Valid values: <c>AWS</c>,
        /// <c>Sandbox</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// Your partner identifier. You can provide either a partner ID (for example, <c>partner-abc123</c>)
        /// or a partner ARN. You must own this identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;
    }
}
