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
    /// Container for the parameters to the UpdateAcmeEndpoint operation.
    /// Updates the configuration of an existing ACME endpoint. You can change the authorization
    /// behavior, contact requirement, or certificate authority settings.
    /// </summary>
    public partial class UpdateAcmeEndpointRequest : AmazonCertificateManagerRequest
    {
        private string _acmeEndpointArn;
        private AcmeAuthorizationBehavior _authorizationBehavior;
        private CertificateAuthority _certificateAuthority;
        private AcmeContact _contact;

        /// <summary>
        /// Gets and sets the property AcmeEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ACME endpoint to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string AcmeEndpointArn
        {
            get { return this._acmeEndpointArn; }
            set { this._acmeEndpointArn = value; }
        }

        // Check to see if AcmeEndpointArn property is set
        internal bool IsSetAcmeEndpointArn()
        {
            return this._acmeEndpointArn != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizationBehavior. 
        /// <para>
        /// The updated authorization behavior.
        /// </para>
        /// </summary>
        public AcmeAuthorizationBehavior AuthorizationBehavior
        {
            get { return this._authorizationBehavior; }
            set { this._authorizationBehavior = value; }
        }

        // Check to see if AuthorizationBehavior property is set
        internal bool IsSetAuthorizationBehavior()
        {
            return this._authorizationBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateAuthority. 
        /// <para>
        /// The updated certificate authority configuration.
        /// </para>
        /// </summary>
        public CertificateAuthority CertificateAuthority
        {
            get { return this._certificateAuthority; }
            set { this._certificateAuthority = value; }
        }

        // Check to see if CertificateAuthority property is set
        internal bool IsSetCertificateAuthority()
        {
            return this._certificateAuthority != null;
        }

        /// <summary>
        /// Gets and sets the property Contact. 
        /// <para>
        /// The updated contact requirement.
        /// </para>
        /// </summary>
        public AcmeContact Contact
        {
            get { return this._contact; }
            set { this._contact = value; }
        }

        // Check to see if Contact property is set
        internal bool IsSetContact()
        {
            return this._contact != null;
        }

    }
}