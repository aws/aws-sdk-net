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
    /// Contains information about a server certificate without its certificate body, certificate
    /// chain, and private key.
    /// 
    ///  
    /// <para>
    ///  This data type is used as a response element in the <a>UploadServerCertificate</a>
    /// and <a>ListServerCertificates</a> operations. 
    /// </para>
    /// </summary>
    public partial class ServerCertificateMetadata
    {
        private string _arn;
        private DateTime? _expiration;
        private string _path;
        private string _serverCertificateId;
        private string _serverCertificateName;
        private DateTime? _uploadDate;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ServerCertificateMetadata() { }

        /// <summary>
        /// Instantiates ServerCertificateMetadata with the parameterized properties
        /// </summary>
        /// <param name="path"> The path to the server certificate. For more information about paths, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM Identifiers</a> in the <i>Using IAM</i> guide. </param>
        /// <param name="serverCertificateName">The name that identifies the server certificate.</param>
        /// <param name="serverCertificateId"> The stable and unique string identifying the server certificate. For more information about IDs, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM Identifiers</a> in the <i>Using IAM</i> guide. </param>
        /// <param name="arn"> The Amazon Resource Name (ARN) specifying the server certificate. For more information about ARNs and how to use them in policies, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM Identifiers</a> in the <i>Using IAM</i> guide. </param>
        public ServerCertificateMetadata(string path, string serverCertificateName, string serverCertificateId, string arn)
        {
            _path = path;
            _serverCertificateName = serverCertificateName;
            _serverCertificateId = serverCertificateId;
            _arn = arn;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) specifying the server certificate. For more information
        /// about ARNs and how to use them in policies, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>Using IAM</i> guide. 
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Expiration. 
        /// <para>
        /// The date on which the certificate is set to expire.
        /// </para>
        /// </summary>
        public DateTime Expiration
        {
            get { return this._expiration.GetValueOrDefault(); }
            set { this._expiration = value; }
        }

        // Check to see if Expiration property is set
        internal bool IsSetExpiration()
        {
            return this._expiration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        ///  The path to the server certificate. For more information about paths, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>Using IAM</i> guide. 
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property ServerCertificateId. 
        /// <para>
        ///  The stable and unique string identifying the server certificate. For more information
        /// about IDs, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>Using IAM</i> guide. 
        /// </para>
        /// </summary>
        public string ServerCertificateId
        {
            get { return this._serverCertificateId; }
            set { this._serverCertificateId = value; }
        }

        // Check to see if ServerCertificateId property is set
        internal bool IsSetServerCertificateId()
        {
            return this._serverCertificateId != null;
        }

        /// <summary>
        /// Gets and sets the property ServerCertificateName. 
        /// <para>
        /// The name that identifies the server certificate.
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

        /// <summary>
        /// Gets and sets the property UploadDate. 
        /// <para>
        /// The date when the server certificate was uploaded.
        /// </para>
        /// </summary>
        public DateTime UploadDate
        {
            get { return this._uploadDate.GetValueOrDefault(); }
            set { this._uploadDate = value; }
        }

        // Check to see if UploadDate property is set
        internal bool IsSetUploadDate()
        {
            return this._uploadDate.HasValue; 
        }

    }
}