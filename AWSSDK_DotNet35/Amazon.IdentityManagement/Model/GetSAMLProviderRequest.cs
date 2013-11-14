/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the GetSAMLProvider operation.
    /// <para>Returns the SAML provider metadocument that was uploaded when the provider was created or updated.</para> <para><b>NOTE:</b>This
    /// operation requires Signature Version 4.</para>
    /// </summary>
    public partial class GetSAMLProviderRequest : AmazonIdentityManagementServiceRequest
    {
        private string sAMLProviderArn;


        /// <summary>
        /// The Amazon Resource Name (ARN) of the SAML provider to get information about.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>20 - 2048</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SAMLProviderArn
        {
            get { return this.sAMLProviderArn; }
            set { this.sAMLProviderArn = value; }
        }

        // Check to see if SAMLProviderArn property is set
        internal bool IsSetSAMLProviderArn()
        {
            return this.sAMLProviderArn != null;
        }

    }
}
    
