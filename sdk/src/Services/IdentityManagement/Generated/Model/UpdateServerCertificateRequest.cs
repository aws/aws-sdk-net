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
    /// Container for the parameters to the UpdateServerCertificate operation.
    /// Updates the name and/or the path of the specified server certificate stored in IAM.
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
    /// You should understand the implications of changing a server certificate's path or
    /// name. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs_manage.html#RenamingServerCerts">Renaming
    /// a server certificate</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  </important> <note> 
    /// <para>
    /// The person making the request (the principal), must have permission to change the
    /// server certificate with the old name and the new name. For example, to change the
    /// certificate named <c>ProductionCert</c> to <c>ProdCert</c>, the principal must have
    /// a policy that allows them to update both certificates. If the principal has permission
    /// to update the <c>ProductionCert</c> group, but not the <c>ProdCert</c> certificate,
    /// then the update fails. For more information about permissions, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
    /// management</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateServerCertificateRequest : AmazonIdentityManagementServiceRequest
    {
        private string _newPath;
        private string _newServerCertificateName;
        private string _serverCertificateName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public UpdateServerCertificateRequest() { }

        /// <summary>
        /// Instantiates UpdateServerCertificateRequest with the parameterized properties
        /// </summary>
        /// <param name="serverCertificateName">The name of the server certificate that you want to update. This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>) a string of characters consisting of upper and lowercase alphanumeric characters with no spaces. You can also include any of the following characters: _+=,.@-</param>
        public UpdateServerCertificateRequest(string serverCertificateName)
        {
            _serverCertificateName = serverCertificateName;
        }

        /// <summary>
        /// Gets and sets the property NewPath. 
        /// <para>
        /// The new path for the server certificate. Include this only if you are updating the
        /// server certificate's path.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of either a forward slash (/) by itself
        /// or a string that must begin and end with forward slashes. In addition, it can contain
        /// any ASCII character from the ! (<c>\u0021</c>) through the DEL character (<c>\u007F</c>),
        /// including most punctuation characters, digits, and upper and lowercased letters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string NewPath
        {
            get { return this._newPath; }
            set { this._newPath = value; }
        }

        // Check to see if NewPath property is set
        internal bool IsSetNewPath()
        {
            return this._newPath != null;
        }

        /// <summary>
        /// Gets and sets the property NewServerCertificateName. 
        /// <para>
        /// The new name for the server certificate. Include this only if you are updating the
        /// server certificate's name. The name of the certificate cannot contain any spaces.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of upper and lowercase alphanumeric
        /// characters with no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string NewServerCertificateName
        {
            get { return this._newServerCertificateName; }
            set { this._newServerCertificateName = value; }
        }

        // Check to see if NewServerCertificateName property is set
        internal bool IsSetNewServerCertificateName()
        {
            return this._newServerCertificateName != null;
        }

        /// <summary>
        /// Gets and sets the property ServerCertificateName. 
        /// <para>
        /// The name of the server certificate that you want to update.
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