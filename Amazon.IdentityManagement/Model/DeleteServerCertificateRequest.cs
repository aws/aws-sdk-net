/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the DeleteServerCertificate operation.
    /// <para>Deletes the specified server certificate.</para>
    /// <para><b>IMPORTANT:</b> You should understand the implications of
    /// deleting a server certificate. If the server certificate is used in
    /// other AWS services, it is recommended that you remove all the
    /// references before using this API to delete the server certificate.
    /// </para>
    /// </summary>
    /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.DeleteServerCertificate"/>
    public class DeleteServerCertificateRequest : AmazonWebServiceRequest
    {
        private string serverCertificateName;

        /// <summary>
        /// The name of the server certificate you want to delete.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 128</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w+=,.@-]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ServerCertificateName
        {
            get { return this.serverCertificateName; }
            set { this.serverCertificateName = value; }
        }

        /// <summary>
        /// Sets the ServerCertificateName property
        /// </summary>
        /// <param name="serverCertificateName">The value to set for the ServerCertificateName property </param>
        /// <returns>this instance</returns>
        public DeleteServerCertificateRequest WithServerCertificateName(string serverCertificateName)
        {
            this.serverCertificateName = serverCertificateName;
            return this;
        }
            
        // Check to see if ServerCertificateName property is set
        internal bool IsSetServerCertificateName()
        {
            return this.serverCertificateName != null;      
        }
    }
}
    
