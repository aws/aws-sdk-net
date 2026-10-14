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

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Specifies the Server Message Block (SMB) protocol configuration that DataSync uses
    /// to access your Amazon FSx for NetApp ONTAP file system's storage virtual machine (SVM).
    /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-ontap-location.html#create-ontap-location-access">Providing
    /// DataSync access to FSx for ONTAP file systems</a>.
    /// </summary>
    public partial class FsxProtocolSmb
    {
        /// <summary>
        /// Gets and sets the property CmkSecretConfig. 
        /// <para>
        /// Specifies configuration information for a DataSync-managed secret, which includes
        /// the password that DataSync uses to access a specific FSx for ONTAP storage location
        /// (using SMB), with a customer-managed KMS key.
        /// </para>
        ///  
        /// <para>
        /// When you include this parameter as part of a <c>CreateLocationFsxOntap</c> request,
        /// you provide only the KMS key ARN. DataSync uses this KMS key together with the <c>Password</c>
        /// you specify for to create a DataSync-managed secret to store the location access credentials.
        /// </para>
        ///  
        /// <para>
        /// Make sure that DataSync has permission to access the KMS key that you specify. For
        /// more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/location-credentials.html#service-secret-custom-key">
        /// Using a service-managed secret encrypted with a custom KMS key</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can use either <c>CmkSecretConfig</c> (with <c>Password</c>) or <c>CustomSecretConfig</c>
        /// (without <c>Password</c>) to provide credentials for a <c>CreateLocationFsxOntap</c>
        /// request. Do not provide both parameters for the same request.
        /// </para>
        ///  </note>
        /// </summary>
        public CmkSecretConfig CmkSecretConfig { get; set; }

        /// <summary>
        /// Checks to see if the CmkSecretConfig property is set.
        /// </summary>
        internal bool IsSetCmkSecretConfig() => this.CmkSecretConfig != null;

        /// <summary>
        /// Gets and sets the property CustomSecretConfig. 
        /// <para>
        /// Specifies configuration information for a customer-managed Secrets Manager secret
        /// where the password for an FSx for ONTAP storage location (using SMB) is stored in
        /// plain text, in Secrets Manager. This configuration includes the secret ARN, and the
        /// ARN for an IAM role that provides access to the secret. For more information, see
        /// <a href="https://docs.aws.amazon.com/datasync/latest/userguide/location-credentials.html#custom-secret-custom-key">
        /// Using a secret that you manage</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can use either <c>CmkSecretConfig</c> (with <c>Password</c>) or <c>CustomSecretConfig</c>
        /// (without <c>Password</c>) to provide credentials for a <c>CreateLocationFsxOntap</c>
        /// request. Do not provide both parameters for the same request.
        /// </para>
        ///  </note>
        /// </summary>
        public CustomSecretConfig CustomSecretConfig { get; set; }

        /// <summary>
        /// Checks to see if the CustomSecretConfig property is set.
        /// </summary>
        internal bool IsSetCustomSecretConfig() => this.CustomSecretConfig != null;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// Specifies the name of the Windows domain that your storage virtual machine (SVM) belongs
        /// to.
        /// </para>
        ///  
        /// <para>
        /// If you have multiple domains in your environment, configuring this setting makes sure
        /// that DataSync connects to the right SVM.
        /// </para>
        ///  
        /// <para>
        /// If you have multiple Active Directory domains in your environment, configuring this
        /// parameter makes sure that DataSync connects to the right SVM.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 253)]
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property ManagedSecretConfig. 
        /// <para>
        /// Describes configuration information for a DataSync-managed secret, such as a <c>Password</c>
        /// that DataSync uses to access a specific storage location. DataSync uses the default
        /// Amazon Web Services-managed KMS key to encrypt this secret in Secrets Manager.
        /// </para>
        ///  <note> 
        /// <para>
        /// Do not provide this for a <c>CreateLocation</c> request. <c>ManagedSecretConfig</c>
        /// is a ReadOnly property and is only be populated in the <c>DescribeLocation</c> response.
        /// </para>
        ///  </note>
        /// </summary>
        public ManagedSecretConfig ManagedSecretConfig { get; set; }

        /// <summary>
        /// Checks to see if the ManagedSecretConfig property is set.
        /// </summary>
        internal bool IsSetManagedSecretConfig() => this.ManagedSecretConfig != null;

        /// <summary>
        /// Gets and sets the property MountOptions.
        /// </summary>
        public SmbMountOptions MountOptions { get; set; }

        /// <summary>
        /// Checks to see if the MountOptions property is set.
        /// </summary>
        internal bool IsSetMountOptions() => this.MountOptions != null;

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// Specifies the password of a user who has permission to access your SVM.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 104)]
        public string Password { get; set; }

        /// <summary>
        /// Checks to see if the Password property is set.
        /// </summary>
        internal bool IsSetPassword() => this.Password != null;

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// Specifies a user that can mount and access the files, folders, and metadata in your
        /// SVM.
        /// </para>
        ///  
        /// <para>
        /// For information about choosing a user with the right level of access for your transfer,
        /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-ontap-location.html#create-ontap-location-smb">Using
        /// the SMB protocol</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 104)]
        public string User { get; set; }

        /// <summary>
        /// Checks to see if the User property is set.
        /// </summary>
        internal bool IsSetUser() => this.User != null;
    }
}
