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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
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
namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Contains summary information about an ACME account.
    /// </summary>
    public partial class AcmeAccountSummary
    {
        private string _accountUrl;
        private string _acmeExternalAccountBindingArn;
        private List<string> _contacts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _createdAt;
        private string _publicKeyThumbprint;
        private AcmeAccountStatus _status;

        /// <summary>
        /// Gets and sets the property AccountUrl. 
        /// <para>
        /// The URL of the ACME account.
        /// </para>
        /// </summary>
        public string AccountUrl
        {
            get { return this._accountUrl; }
            set { this._accountUrl = value; }
        }

        // Check to see if AccountUrl property is set
        internal bool IsSetAccountUrl()
        {
            return this._accountUrl != null;
        }

        /// <summary>
        /// Gets and sets the property AcmeExternalAccountBindingArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the external account binding associated with this
        /// ACME account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string AcmeExternalAccountBindingArn
        {
            get { return this._acmeExternalAccountBindingArn; }
            set { this._acmeExternalAccountBindingArn = value; }
        }

        // Check to see if AcmeExternalAccountBindingArn property is set
        internal bool IsSetAcmeExternalAccountBindingArn()
        {
            return this._acmeExternalAccountBindingArn != null;
        }

        /// <summary>
        /// Gets and sets the property Contacts. 
        /// <para>
        /// The contact information for the ACME account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public List<string> Contacts
        {
            get { return this._contacts; }
            set { this._contacts = value; }
        }

        // Check to see if Contacts property is set
        internal bool IsSetContacts()
        {
            return this._contacts != null && (this._contacts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the ACME account was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PublicKeyThumbprint. 
        /// <para>
        /// The thumbprint of the public key associated with the ACME account.
        /// </para>
        /// </summary>
        public string PublicKeyThumbprint
        {
            get { return this._publicKeyThumbprint; }
            set { this._publicKeyThumbprint = value; }
        }

        // Check to see if PublicKeyThumbprint property is set
        internal bool IsSetPublicKeyThumbprint()
        {
            return this._publicKeyThumbprint != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the ACME account.
        /// </para>
        /// </summary>
        public AcmeAccountStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}