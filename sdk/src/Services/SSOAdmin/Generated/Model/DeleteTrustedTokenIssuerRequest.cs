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
    /// Container for the parameters to the DeleteTrustedTokenIssuer operation.
    /// Deletes a trusted token issuer configuration from an instance of IAM Identity Center.
    /// 
    ///  <note> 
    /// <para>
    /// Deleting this trusted token issuer configuration will cause users to lose access to
    /// any applications that are configured to use the trusted token issuer.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteTrustedTokenIssuerRequest : AmazonSSOAdminRequest
    {
        private string _trustedTokenIssuerArn;

        /// <summary>
        /// Gets and sets the property TrustedTokenIssuerArn. 
        /// <para>
        /// Specifies the ARN of the trusted token issuer configuration to delete.
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

    }
}