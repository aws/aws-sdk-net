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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
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
namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// This is the response object from the DescribeTrustedTokenIssuer operation.
    /// </summary>
    public partial class DescribeTrustedTokenIssuerResponse : AmazonWebServiceResponse
    {
        private string _name;
        private string _trustedTokenIssuerArn;
        private TrustedTokenIssuerConfiguration _trustedTokenIssuerConfiguration;
        private TrustedTokenIssuerType _trustedTokenIssuerType;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the trusted token issuer configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property TrustedTokenIssuerArn. 
        /// <para>
        /// The ARN of the trusted token issuer configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=1224)]
        public string TrustedTokenIssuerArn
        {
            get { return this._trustedTokenIssuerArn; }
            set { this._trustedTokenIssuerArn = value; }
        }

        // Check to see if TrustedTokenIssuerArn property is set
        internal bool IsSetTrustedTokenIssuerArn()
        {
            return this._trustedTokenIssuerArn != null;
        }

        /// <summary>
        /// Gets and sets the property TrustedTokenIssuerConfiguration. 
        /// <para>
        /// A structure the describes the settings that apply of this trusted token issuer.
        /// </para>
        /// </summary>
        public TrustedTokenIssuerConfiguration TrustedTokenIssuerConfiguration
        {
            get { return this._trustedTokenIssuerConfiguration; }
            set { this._trustedTokenIssuerConfiguration = value; }
        }

        // Check to see if TrustedTokenIssuerConfiguration property is set
        internal bool IsSetTrustedTokenIssuerConfiguration()
        {
            return this._trustedTokenIssuerConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TrustedTokenIssuerType. 
        /// <para>
        /// The type of the trusted token issuer.
        /// </para>
        /// </summary>
        public TrustedTokenIssuerType TrustedTokenIssuerType
        {
            get { return this._trustedTokenIssuerType; }
            set { this._trustedTokenIssuerType = value; }
        }

        // Check to see if TrustedTokenIssuerType property is set
        internal bool IsSetTrustedTokenIssuerType()
        {
            return this._trustedTokenIssuerType != null;
        }

    }
}