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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
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
    /// Container for the parameters to the CreateLocationFsxWindows operation.
    /// Creates a transfer <i>location</i> for an Amazon FSx for Windows File Server file
    /// system. DataSync can use this location as a source or destination for transferring
    /// data.
    /// 
    ///  
    /// <para>
    /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-fsx-location.html#create-fsx-location-access">accesses
    /// FSx for Windows File Server file systems</a>.
    /// </para>
    /// </summary>
    public partial class CreateLocationFsxWindowsRequest : AmazonDataSyncRequest
    {
        private CmkSecretConfig _cmkSecretConfig;
        private CustomSecretConfig _customSecretConfig;
        private string _domain;
        private string _fsxFilesystemArn;
        private string _password;
        private List<string> _securityGroupArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _subdirectory;
        private List<TagListEntry> _tags = AWSConfigs.InitializeCollections ? new List<TagListEntry>() : null;
        private string _user;

        /// <summary>
        /// Gets and sets the property CmkSecretConfig. 
        /// <para>
        /// Specifies configuration information for a DataSync-managed secret, which includes
        /// the password that DataSync uses to access a specific FSx Windows storage location,
        /// with a customer-managed KMS key.
        /// </para>
        ///  
        /// <para>
        /// When you include this parameter as part of a <c>CreateLocationFsxWindows</c> request,
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
        /// (without <c>Password</c>) to provide credentials for a <c>CreateLocationFsxWindows</c>
        /// request. Do not provide both parameters for the same request.
        /// </para>
        ///  </note>
        /// </summary>
        public CmkSecretConfig CmkSecretConfig
        {
            get { return this._cmkSecretConfig; }
            set { this._cmkSecretConfig = value; }
        }

        // Check to see if CmkSecretConfig property is set
        internal bool IsSetCmkSecretConfig()
        {
            return this._cmkSecretConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CustomSecretConfig. 
        /// <para>
        /// Specifies configuration information for a customer-managed Secrets Manager secret
        /// where the password for an FSx for Windows File Server storage location is stored in
        /// plain text, in Secrets Manager. This configuration includes the secret ARN, and the
        /// ARN for an IAM role that provides access to the secret. For more information, see
        /// <a href="https://docs.aws.amazon.com/datasync/latest/userguide/location-credentials.html#custom-secret-custom-key">
        /// Using a secret that you manage</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can use either <c>CmkSecretConfig</c> (with <c>Password</c>) or <c>CustomSecretConfig</c>
        /// (without <c>Password</c>) to provide credentials for a <c>CreateLocationFsxWindows</c>
        /// request. Do not provide both parameters for the same request.
        /// </para>
        ///  </note>
        /// </summary>
        public CustomSecretConfig CustomSecretConfig
        {
            get { return this._customSecretConfig; }
            set { this._customSecretConfig = value; }
        }

        // Check to see if CustomSecretConfig property is set
        internal bool IsSetCustomSecretConfig()
        {
            return this._customSecretConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// Specifies the name of the Windows domain that the FSx for Windows File Server file
        /// system belongs to.
        /// </para>
        ///  
        /// <para>
        /// If you have multiple Active Directory domains in your environment, configuring this
        /// parameter makes sure that DataSync connects to the right file system.
        /// </para>
        /// </summary>
        [AWSProperty(Max=253)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property FsxFilesystemArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) for the FSx for Windows File Server file
        /// system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string FsxFilesystemArn
        {
            get { return this._fsxFilesystemArn; }
            set { this._fsxFilesystemArn = value; }
        }

        // Check to see if FsxFilesystemArn property is set
        internal bool IsSetFsxFilesystemArn()
        {
            return this._fsxFilesystemArn != null;
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// Specifies the password of the user with the permissions to mount and access the files,
        /// folders, and file metadata in your FSx for Windows File Server file system.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=104)]
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupArns. 
        /// <para>
        /// Specifies the ARNs of the Amazon EC2 security groups that provide access to your file
        /// system's preferred subnet.
        /// </para>
        ///  
        /// <para>
        /// The security groups that you specify must be able to communicate with your file system's
        /// security groups. For information about configuring security groups for file system
        /// access, see the <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/limit-access-security-groups.html">
        /// <i>Amazon FSx for Windows File Server User Guide</i> </a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you choose a security group that doesn't allow connections from within itself,
        /// do one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Configure the security group to allow it to communicate within itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Choose a different security group that can communicate with the mount target's security
        /// group.
        /// </para>
        ///  </li> </ul> </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<string> SecurityGroupArns
        {
            get { return this._securityGroupArns; }
            set { this._securityGroupArns = value; }
        }

        // Check to see if SecurityGroupArns property is set
        internal bool IsSetSecurityGroupArns()
        {
            return this._securityGroupArns != null && (this._securityGroupArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Subdirectory. 
        /// <para>
        /// Specifies a mount path for your file system using forward slashes. This is where DataSync
        /// reads or writes data (depending on if this is a source or destination location).
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string Subdirectory
        {
            get { return this._subdirectory; }
            set { this._subdirectory = value; }
        }

        // Check to see if Subdirectory property is set
        internal bool IsSetSubdirectory()
        {
            return this._subdirectory != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies labels that help you categorize, filter, and search for your Amazon Web
        /// Services resources. We recommend creating at least a name tag for your location.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<TagListEntry> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// Specifies the user with the permissions to mount and access the files, folders, and
        /// file metadata in your FSx for Windows File Server file system.
        /// </para>
        ///  
        /// <para>
        /// For information about choosing a user with the right level of access for your transfer,
        /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-fsx-location.html#create-fsx-windows-location-permissions">required
        /// permissions</a> for FSx for Windows File Server locations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=104)]
        public string User
        {
            get { return this._user; }
            set { this._user = value; }
        }

        // Check to see if User property is set
        internal bool IsSetUser()
        {
            return this._user != null;
        }

    }
}