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
    /// Container for the parameters to the DeleteServerCertificate operation.
    /// <para>Deletes the specified server certificate.</para> <para><b>IMPORTANT:</b>If you are using a server certificate with Elastic Load
    /// Balancing, deleting the certificate could have implications for your application. If Elastic Load Balancing doesn't detect the deletion of
    /// bound certificates, it may continue to use the certificates. This could cause Elastic Load Balancing to stop accepting traffic. We recommend
    /// that you remove the reference to the certificate from Elastic Load Balancing before using this command to delete the certificate. For more
    /// information, go to DeleteLoadBalancerListeners in the Elastic Load Balancing API Reference.</para>
    /// </summary>
    public partial class DeleteServerCertificateRequest : AmazonIdentityManagementServiceRequest
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

        // Check to see if ServerCertificateName property is set
        internal bool IsSetServerCertificateName()
        {
            return this.serverCertificateName != null;
        }

    }
}
    
