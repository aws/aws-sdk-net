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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteServerCertificate operation.
    /// Deletes the specified server certificate.
    /// 
    ///  
    /// <para>
    /// For more information about working with server certificates, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
    /// with server certificates</a> in the <i>IAM User Guide</i>. This topic also includes
    /// a list of Amazon Web Services services that can use the server certificates that you
    /// manage with IAM.
    /// </para>
    ///  <important> 
    /// <para>
    ///  If you are using a server certificate with Elastic Load Balancing, deleting the certificate
    /// could have implications for your application. If Elastic Load Balancing doesn't detect
    /// the deletion of bound certificates, it may continue to use the certificates. This
    /// could cause Elastic Load Balancing to stop accepting traffic. We recommend that you
    /// remove the reference to the certificate from Elastic Load Balancing before using this
    /// command to delete the certificate. For more information, see <a href="https://docs.aws.amazon.com/ElasticLoadBalancing/latest/APIReference/API_DeleteLoadBalancerListeners.html">DeleteLoadBalancerListeners</a>
    /// in the <i>Elastic Load Balancing API Reference</i>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DeleteServerCertificateRequest : AmazonIdentityManagementServiceRequest
    {
        private string _serverCertificateName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteServerCertificateRequest() { }

        /// <summary>
        /// Instantiates DeleteServerCertificateRequest with the parameterized properties
        /// </summary>
        /// <param name="serverCertificateName">The name of the server certificate you want to delete. This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>) a string of characters consisting of upper and lowercase alphanumeric characters with no spaces. You can also include any of the following characters: _+=,.@-</param>
        public DeleteServerCertificateRequest(string serverCertificateName)
        {
            _serverCertificateName = serverCertificateName;
        }

        /// <summary>
        /// Gets and sets the property ServerCertificateName. 
        /// <para>
        /// The name of the server certificate you want to delete.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of upper and lowercase alphanumeric
        /// characters with no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ServerCertificateName
        {
            get { return this._serverCertificateName; }
            set { this._serverCertificateName = value; }
        }

        // Check to see if ServerCertificateName property is set
        internal bool IsSetServerCertificateName()
        {
            return this._serverCertificateName != null;
        }

    }
}