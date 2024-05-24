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
    /// Container for the parameters to the UpdateTrustedTokenIssuer operation.
    /// Updates the name of the trusted token issuer, or the path of a source attribute or
    /// destination attribute for a trusted token issuer configuration.
    /// 
    ///  <note> 
    /// <para>
    /// Updating this trusted token issuer configuration might cause users to lose access
    /// to any applications that are configured to use the trusted token issuer.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateTrustedTokenIssuerRequest : AmazonSSOAdminRequest
    {
        private string _name;
        private string _trustedTokenIssuerArn;
        private TrustedTokenIssuerUpdateConfiguration _trustedTokenIssuerConfiguration;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the updated name to be applied to the trusted token issuer configuration.
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
        /// Specifies the ARN of the trusted token issuer configuration that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=1224)]
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
        /// Specifies a structure with settings to apply to the specified trusted token issuer.
        /// The settings that you can provide are determined by the type of the trusted token
        /// issuer that you are updating.
        /// </para>
        /// </summary>
        public TrustedTokenIssuerUpdateConfiguration TrustedTokenIssuerConfiguration
        {
            get { return this._trustedTokenIssuerConfiguration; }
            set { this._trustedTokenIssuerConfiguration = value; }
        }

        // Check to see if TrustedTokenIssuerConfiguration property is set
        internal bool IsSetTrustedTokenIssuerConfiguration()
        {
            return this._trustedTokenIssuerConfiguration != null;
        }

    }
}