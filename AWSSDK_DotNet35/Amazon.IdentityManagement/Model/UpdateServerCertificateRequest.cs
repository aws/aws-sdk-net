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
    /// Container for the parameters to the UpdateServerCertificate operation.
    /// Updates the name and/or the path of the specified server certificate.
    /// 
    ///  <important> You should understand the implications of changing a server certificate's
    /// path or name. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/ManagingServerCerts.html">Managing
    /// Server Certificates</a> in the <i>Using IAM</i> guide. </important>
    /// </summary>
    public partial class UpdateServerCertificateRequest : AmazonIdentityManagementServiceRequest
    {
        private string _newPath;
        private string _newServerCertificateName;
        private string _serverCertificateName;


        /// <summary>
        /// Gets and sets the property NewPath. 
        /// <para>
        /// The new path for the server certificate. Include this only if you are updating the
        /// server certificate's path.
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
        /// server certificate's name.
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