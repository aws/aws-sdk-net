/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteSAMLProvider operation.
    /// Deletes a SAML provider.
    /// 
    ///         
    /// <para>
    /// Deleting the provider does not update any roles that reference the SAML provider as
    /// a            principal in their trust policies. Any attempt to assume a role that references
    /// a SAML            provider that has been deleted will fail. 
    /// </para>
    ///         <note>This operation requires <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version            4</a>.</note>
    /// </summary>
    public partial class DeleteSAMLProviderRequest : AmazonIdentityManagementServiceRequest
    {
        private string _sAMLProviderArn;


        /// <summary>
        /// Gets and sets the property SAMLProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SAML provider to delete.
        /// </para>
        /// </summary>
        public string SAMLProviderArn
        {
            get { return this._sAMLProviderArn; }
            set { this._sAMLProviderArn = value; }
        }

        // Check to see if SAMLProviderArn property is set
        internal bool IsSetSAMLProviderArn()
        {
            return this._sAMLProviderArn != null;
        }

    }
}