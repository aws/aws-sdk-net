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
    /// Configuration details for IAM Identity Center Trusted Token Issuer (TTI) authentication.
    /// </summary>
    public partial class DataAccessorIdcTrustedTokenIssuerConfiguration
    {
        private string _idcTrustedTokenIssuerArn;

        /// <summary>
        /// Gets and sets the property IdcTrustedTokenIssuerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM Identity Center Trusted Token Issuer that
        /// will be used for authentication.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1284)]
        public string IdcTrustedTokenIssuerArn
        {
            get { return this._idcTrustedTokenIssuerArn; }
            set { this._idcTrustedTokenIssuerArn = value; }
        }

        // Check to see if IdcTrustedTokenIssuerArn property is set
        internal bool IsSetIdcTrustedTokenIssuerArn()
        {
            return this._idcTrustedTokenIssuerArn != null;
        }

    }
}