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

/*
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
    /// Updates the name and/or the path of the specified server certificate stored in IAM.
    /// 
    ///  
    /// <para>
    /// For more information about working with server certificates, including a list of AWS
    /// services that can use the server certificates that you manage with IAM, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
    /// with Server Certificates</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// You should understand the implications of changing a server certificate's path or
    /// name. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs_manage.html#RenamingServerCerts">Renaming
    /// a Server Certificate</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  </important> <note> 
    /// <para>
    /// To change a server certificate name the requester must have appropriate permissions
    /// on both the source object and the target object. For example, to change the name from
    /// "ProductionCert" to "ProdCert", the entity making the request must have permission
    /// on "ProductionCert" and "ProdCert", or must have permission on all (*). For more information
    /// about permissions, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
    /// Management</a> in the <i>IAM User Guide</i>.
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
        /// <param name="serverCertificateName">The name of the server certificate that you want to update. The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for this parameter is a string of characters consisting of upper and lowercase alphanumeric characters with no spaces. You can also include any of the following characters: =,.@-</param>
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
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for this parameter
        /// is a string of characters consisting of either a forward slash (/) by itself or a
        /// string that must begin and end with forward slashes, containing any ASCII character
        /// from the ! (\u0021) thru the DEL character (\u007F), including most punctuation characters,
        /// digits, and upper and lowercased letters.
        /// </para>
        /// </summary>
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
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for this parameter
        /// is a string of characters consisting of upper and lowercase alphanumeric characters
        /// with no spaces. You can also include any of the following characters: =,.@-
        /// </para>
        /// </summary>
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
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for this parameter
        /// is a string of characters consisting of upper and lowercase alphanumeric characters
        /// with no spaces. You can also include any of the following characters: =,.@-
        /// </para>
        /// </summary>
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