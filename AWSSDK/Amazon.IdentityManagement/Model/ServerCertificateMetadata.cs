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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// <para>ServerCertificateMetadata contains information about a server certificate without its certificate body, certificate chain, and private
    /// key.</para> <para>This data type is used as a response element in the action UploadServerCertificate and ListServerCertificates.</para>
    /// </summary>
    public class ServerCertificateMetadata  
    {
        
        private string path;
        private string serverCertificateName;
        private string serverCertificateId;
        private string arn;
        private DateTime? uploadDate;

        /// <summary>
        /// Path to the server certificate. For more information about paths, see <a
        /// href="http://docs.amazonwebservices.com/IAM/latest/UserGuide/index.html?Using_Identifiers.html" target="_blank">Identifiers for IAM
        /// Entities</a> in <i>Using AWS Identity and Access Management</i>.
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
        public string Path
        {
            get { return this.path; }
            set { this.path = value; }
        }

        /// <summary>
        /// Sets the Path property
        /// </summary>
        /// <param name="path">The value to set for the Path property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ServerCertificateMetadata WithPath(string path)
        {
            this.path = path;
            return this;
        }
            

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this.path != null;       
        }

        /// <summary>
        /// The name that identifies the server certificate.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ServerCertificateMetadata WithServerCertificateName(string serverCertificateName)
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
        /// The stable and unique string identifying the server certificate. For more information about IDs, see <a
        /// href="http://docs.amazonwebservices.com/IAM/latest/UserGuide/index.html?Using_Identifiers.html" target="_blank">Identifiers for IAM
        /// Entities</a> in <i>Using AWS Identity and Access Management</i>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>16 - 32</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ServerCertificateId
        {
            get { return this.serverCertificateId; }
            set { this.serverCertificateId = value; }
        }

        /// <summary>
        /// Sets the ServerCertificateId property
        /// </summary>
        /// <param name="serverCertificateId">The value to set for the ServerCertificateId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ServerCertificateMetadata WithServerCertificateId(string serverCertificateId)
        {
            this.serverCertificateId = serverCertificateId;
            return this;
        }
            

        // Check to see if ServerCertificateId property is set
        internal bool IsSetServerCertificateId()
        {
            return this.serverCertificateId != null;       
        }

        /// <summary>
        /// The Amazon Resource Name (ARN) specifying the server certificate. For more information about ARNs and how to use them in policies, see <a
        /// href="http://docs.amazonwebservices.com/IAM/latest/UserGuide/index.html?Using_Identifiers.html" target="_blank">Identifiers for IAM
        /// Entities</a> in <i>Using AWS Identity and Access Management</i>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>20 - 2048</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this.arn; }
            set { this.arn = value; }
        }

        /// <summary>
        /// Sets the Arn property
        /// </summary>
        /// <param name="arn">The value to set for the Arn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ServerCertificateMetadata WithArn(string arn)
        {
            this.arn = arn;
            return this;
        }
            

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this.arn != null;       
        }

        /// <summary>
        /// The date when the server certificate was uploaded.
        ///  
        /// </summary>
        public DateTime UploadDate
        {
            get { return this.uploadDate ?? default(DateTime); }
            set { this.uploadDate = value; }
        }

        /// <summary>
        /// Sets the UploadDate property
        /// </summary>
        /// <param name="uploadDate">The value to set for the UploadDate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ServerCertificateMetadata WithUploadDate(DateTime uploadDate)
        {
            this.uploadDate = uploadDate;
            return this;
        }
            

        // Check to see if UploadDate property is set
        internal bool IsSetUploadDate()
        {
            return this.uploadDate.HasValue;       
        }
    }
}
