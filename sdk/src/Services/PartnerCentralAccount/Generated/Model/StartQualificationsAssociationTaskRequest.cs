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
 * Do not modify this file. This file is generated from the partnercentral-account-2025-04-04.normal.json service model.
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
    /// Container for the parameters to the StartQualificationsAssociationTask operation.
    /// Initiates an asynchronous task to associate your partner qualifications with a primary
    /// account. You must be a subsidiary of the primary account with an active subsidiary
    /// connection. Use <c>GetQualificationsAssociationTask</c> to monitor task progress.
    /// </summary>
    public partial class StartQualificationsAssociationTaskRequest : AmazonPartnerCentralAccountRequest
    {
        private string _catalog;
        private string _clientToken;
        private string _identifier;
        private QualificationsAssociationPartner _primaryPartner;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog in which to perform the qualifications association. Valid values: <c>AWS</c>,
        /// <c>Sandbox</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// Your partner identifier. You can provide either a partner ID (for example, <c>partner-abc123</c>)
        /// or a partner ARN. You must own this identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
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
        /// Gets and sets the property PrimaryPartner. 
        /// <para>
        /// The primary (acquiring) partner's profile and account identifier to associate qualifications
        /// with. You must provide at least one of <c>ProfileId</c> or <c>AccountId</c>. You cannot
        /// specify yourself as the primary partner.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public QualificationsAssociationPartner PrimaryPartner
        {
            get { return this._primaryPartner; }
            set { this._primaryPartner = value; }
        }

        // Check to see if PrimaryPartner property is set
        internal bool IsSetPrimaryPartner()
        {
            return this._primaryPartner != null;
        }

    }
}