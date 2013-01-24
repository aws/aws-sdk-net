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
    /// Container for the parameters to the UpdateServerCertificate operation.
    /// <para>Updates the name and/or the path of the specified server certificate.</para> <para><b>IMPORTANT:</b> You should understand the
    /// implications of changing a server certificate's path or name. For more information, see Managing Server Certificates in Using AWS Identity
    /// and Access Management. </para> <para><b>NOTE:</b>To change a server certificate name the requester must have appropriate permissions on both
    /// the source object and the target object. For example, to change the name from ProductionCert to ProdCert, the entity making the request
    /// must have permission on ProductionCert and ProdCert, or must have permission on all (*). For more information about permissions, see
    /// Permissions and Policies. </para>
    /// </summary>
    /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.UpdateServerCertificate"/>
    public class UpdateServerCertificateRequest : AmazonWebServiceRequest
    {
        private string serverCertificateName;
        private string newPath;
        private string newServerCertificateName;

        /// <summary>
        /// The name of the server certificate that you want to update.
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
        public UpdateServerCertificateRequest WithServerCertificateName(string serverCertificateName)
        {
            this.serverCertificateName = serverCertificateName;
            return this;
        }
            

        // Check to see if ServerCertificateName property is set
        internal bool IsSetServerCertificateName()
        {
            return this.serverCertificateName != null;       
        }

        /// <summary>
        /// The new path for the server certificate. Include this only if you are updating the server certificate's path.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 512</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(\u002F)|(\u002F[\u0021-\u007F]+\u002F)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string NewPath
        {
            get { return this.newPath; }
            set { this.newPath = value; }
        }

        /// <summary>
        /// Sets the NewPath property
        /// </summary>
        /// <param name="newPath">The value to set for the NewPath property </param>
        /// <returns>this instance</returns>
        public UpdateServerCertificateRequest WithNewPath(string newPath)
        {
            this.newPath = newPath;
            return this;
        }
            

        // Check to see if NewPath property is set
        internal bool IsSetNewPath()
        {
            return this.newPath != null;       
        }

        /// <summary>
        /// The new name for the server certificate. Include this only if you are updating the server certificate's name.
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
        public string NewServerCertificateName
        {
            get { return this.newServerCertificateName; }
            set { this.newServerCertificateName = value; }
        }

        /// <summary>
        /// Sets the NewServerCertificateName property
        /// </summary>
        /// <param name="newServerCertificateName">The value to set for the NewServerCertificateName property </param>
        /// <returns>this instance</returns>
        public UpdateServerCertificateRequest WithNewServerCertificateName(string newServerCertificateName)
        {
            this.newServerCertificateName = newServerCertificateName;
            return this;
        }
            

        // Check to see if NewServerCertificateName property is set
        internal bool IsSetNewServerCertificateName()
        {
            return this.newServerCertificateName != null;       
        }
    }
}
    
