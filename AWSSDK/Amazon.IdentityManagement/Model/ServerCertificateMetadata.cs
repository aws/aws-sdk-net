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
    /// ServerCertificateMetadata contains information about a server certificate without
    /// its            certificate body, certificate chain, and private key.
    /// 
    ///         
    /// <para>
    /// This data type is used as a response element in the action <a>UploadServerCertificate</a>
    /// and                <a>ListServerCertificates</a>.
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
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) specifying the server certificate. For more information
        /// about            ARNs and how to use them in policies, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html"
        /// target="_blank">Identifiers for IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }


        /// <summary>
        /// Sets the Arn property
        /// </summary>
        /// <param name="arn">The value to set for the Arn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ServerCertificateMetadata WithArn(string arn)
        {
            this._arn = arn;
            return this;
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


        /// <summary>
        /// Sets the Expiration property
        /// </summary>
        /// <param name="expiration">The value to set for the Expiration property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ServerCertificateMetadata WithExpiration(DateTime expiration)
        {
            this._expiration = expiration;
            return this;
        }

        // Check to see if Expiration property is set
        internal bool IsSetExpiration()
        {
            return this._expiration.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// Path to the server certificate. For more information about paths, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html"
        /// target="_blank">Identifiers for IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }


        /// <summary>
        /// Sets the Path property
        /// </summary>
        /// <param name="path">The value to set for the Path property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ServerCertificateMetadata WithPath(string path)
        {
            this._path = path;
            return this;
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }


        /// <summary>
        /// Gets and sets the property ServerCertificateId. 
        /// <para>
        /// The stable and unique string identifying the server certificate. For more information
        /// about            IDs, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html"
        /// target="_blank">Identifiers for IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        /// </summary>
        public string ServerCertificateId
        {
            get { return this._serverCertificateId; }
            set { this._serverCertificateId = value; }
        }


        /// <summary>
        /// Sets the ServerCertificateId property
        /// </summary>
        /// <param name="serverCertificateId">The value to set for the ServerCertificateId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ServerCertificateMetadata WithServerCertificateId(string serverCertificateId)
        {
            this._serverCertificateId = serverCertificateId;
            return this;
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


        /// <summary>
        /// Sets the ServerCertificateName property
        /// </summary>
        /// <param name="serverCertificateName">The value to set for the ServerCertificateName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ServerCertificateMetadata WithServerCertificateName(string serverCertificateName)
        {
            this._serverCertificateName = serverCertificateName;
            return this;
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


        /// <summary>
        /// Sets the UploadDate property
        /// </summary>
        /// <param name="uploadDate">The value to set for the UploadDate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ServerCertificateMetadata WithUploadDate(DateTime uploadDate)
        {
            this._uploadDate = uploadDate;
            return this;
        }

        // Check to see if UploadDate property is set
        internal bool IsSetUploadDate()
        {
            return this._uploadDate.HasValue; 
        }

    }
}