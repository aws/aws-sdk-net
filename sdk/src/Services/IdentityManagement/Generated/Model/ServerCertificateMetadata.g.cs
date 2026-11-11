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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Contains information about a server certificate without its certificate body, certificate
    /// chain, and private key.
    /// 
    ///  
    /// <para>
    ///  This data type is used as a response element in the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_UploadServerCertificate.html">UploadServerCertificate</a>
    /// and <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListServerCertificates.html">ListServerCertificates</a>
    /// operations. 
    /// </para>
    /// </summary>
    public partial class ServerCertificateMetadata
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public ServerCertificateMetadata() { }

        /// <summary>
        /// Instantiates ServerCertificateMetadata with the parameterized properties
        /// </summary>
        /// <param name="path"> The path to the server certificate. For more information about paths, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM   identifiers</a> in the <i>IAM User Guide</i>. </param>
        /// <param name="serverCertificateName">The name that identifies the server certificate.</param>
        /// <param name="serverCertificateId"> The stable and unique string identifying the server certificate. For more information   about IDs, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM identifiers</a> in the <i>IAM User Guide</i>. </param>
        /// <param name="arn"> The Amazon Resource Name (ARN) specifying the server certificate. For more information   about ARNs and how to use them in policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM identifiers</a> in the   <i>IAM User Guide</i>. </param>
        public ServerCertificateMetadata(string path, string serverCertificateName, string serverCertificateId, string arn)
        {
            this.Path = path;
            this.ServerCertificateName = serverCertificateName;
            this.ServerCertificateId = serverCertificateId;
            this.Arn = arn;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) specifying the server certificate. For more information
        /// about ARNs and how to use them in policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// identifiers</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Expiration. 
        /// <para>
        /// The date on which the certificate is set to expire.
        /// </para>
        /// </summary>
        public DateTime? Expiration { get; set; }

        /// <summary>
        /// Checks to see if the Expiration property is set.
        /// </summary>
        internal bool IsSetExpiration() => this.Expiration.HasValue;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        ///  The path to the server certificate. For more information about paths, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// identifiers</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property ServerCertificateId. 
        /// <para>
        ///  The stable and unique string identifying the server certificate. For more information
        /// about IDs, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// identifiers</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 16, Max = 128)]
        public string ServerCertificateId { get; set; }

        /// <summary>
        /// Checks to see if the ServerCertificateId property is set.
        /// </summary>
        internal bool IsSetServerCertificateId() => this.ServerCertificateId != null;

        /// <summary>
        /// Gets and sets the property ServerCertificateName. 
        /// <para>
        /// The name that identifies the server certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ServerCertificateName { get; set; }

        /// <summary>
        /// Checks to see if the ServerCertificateName property is set.
        /// </summary>
        internal bool IsSetServerCertificateName() => this.ServerCertificateName != null;

        /// <summary>
        /// Gets and sets the property UploadDate. 
        /// <para>
        /// The date when the server certificate was uploaded.
        /// </para>
        /// </summary>
        public DateTime? UploadDate { get; set; }

        /// <summary>
        /// Checks to see if the UploadDate property is set.
        /// </summary>
        internal bool IsSetUploadDate() => this.UploadDate.HasValue;
    }
}
