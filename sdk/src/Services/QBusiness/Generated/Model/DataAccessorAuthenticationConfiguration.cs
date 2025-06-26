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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// A union type that contains the specific authentication configuration based on the
    /// authentication type selected.
    /// </summary>
    public partial class DataAccessorAuthenticationConfiguration
    {
        private DataAccessorIdcTrustedTokenIssuerConfiguration _idcTrustedTokenIssuerConfiguration;

        /// <summary>
        /// Gets and sets the property IdcTrustedTokenIssuerConfiguration. 
        /// <para>
        /// Configuration for IAM Identity Center Trusted Token Issuer (TTI) authentication used
        /// when the authentication type is <c>AWS_IAM_IDC_TTI</c>.
        /// </para>
        /// </summary>
        public DataAccessorIdcTrustedTokenIssuerConfiguration IdcTrustedTokenIssuerConfiguration
        {
            get { return this._idcTrustedTokenIssuerConfiguration; }
            set { this._idcTrustedTokenIssuerConfiguration = value; }
        }

        // Check to see if IdcTrustedTokenIssuerConfiguration property is set
        internal bool IsSetIdcTrustedTokenIssuerConfiguration()
        {
            return this._idcTrustedTokenIssuerConfiguration != null;
        }

    }
}