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
    /// Container for the parameters to the UpdateLocationFsxWindows operation. Modifies the
    /// following configuration parameters of the Amazon FSx for Windows File Server transfer
    /// location that you're using with DataSync. <para> For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-fsx-location.html">Configuring
    /// DataSync transfers with FSx for Windows File Server</a>. </para>
    /// </summary>
    public partial class UpdateLocationFsxWindowsRequest : AmazonDataSyncRequest
    {
        /// <summary>
        /// Gets and sets the property CmkSecretConfig. 
        /// <para>
        /// Specifies configuration information for a DataSync-managed secret, such as a <c>Password</c>
        /// or set of credentials that DataSync uses to access a specific transfer location, and
        /// a customer-managed KMS key.
        /// </para>
        /// </summary>
        public CmkSecretConfig CmkSecretConfig { get; set; }

        /// <summary>
        /// Checks to see if the CmkSecretConfig property is set.
        /// </summary>
        internal bool IsSetCmkSecretConfig() => this.CmkSecretConfig != null;

        /// <summary>
        /// Gets and sets the property CustomSecretConfig. 
        /// <para>
        /// Specifies configuration information for a customer-managed secret, such as a <c>Password</c>
        /// or set of credentials that DataSync uses to access a specific transfer location, and
        /// a customer-managed Identity and Access Management (IAM) role that provides access
        /// to the secret.
        /// </para>
        /// </summary>
        public CustomSecretConfig CustomSecretConfig { get; set; }

        /// <summary>
        /// Checks to see if the CustomSecretConfig property is set.
        /// </summary>
        internal bool IsSetCustomSecretConfig() => this.CustomSecretConfig != null;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// Specifies the name of the Windows domain that your FSx for Windows File Server file
        /// system belongs to.
        /// </para>
        ///  
        /// <para>
        /// If you have multiple Active Directory domains in your environment, configuring this
        /// parameter makes sure that DataSync connects to the right file system.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 253)]
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property LocationArn. 
        /// <para>
        /// Specifies the ARN of the FSx for Windows File Server transfer location that you're
        /// updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 128)]
        public string LocationArn { get; set; }

        /// <summary>
        /// Checks to see if the LocationArn property is set.
        /// </summary>
        internal bool IsSetLocationArn() => this.LocationArn != null;

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// Specifies the password of the user with the permissions to mount and access the files,
        /// folders, and file metadata in your FSx for Windows File Server file system.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 104)]
        public string Password { get; set; }

        /// <summary>
        /// Checks to see if the Password property is set.
        /// </summary>
        internal bool IsSetPassword() => this.Password != null;

        /// <summary>
        /// Gets and sets the property Subdirectory. 
        /// <para>
        /// Specifies a mount path for your file system using forward slashes. DataSync uses this
        /// subdirectory to read or write data (depending on whether the file system is a source
        /// or destination location).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string Subdirectory { get; set; }

        /// <summary>
        /// Checks to see if the Subdirectory property is set.
        /// </summary>
        internal bool IsSetSubdirectory() => this.Subdirectory != null;

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
        [AWSProperty(Min = 0, Max = 104)]
        public string User { get; set; }

        /// <summary>
        /// Checks to see if the User property is set.
        /// </summary>
        internal bool IsSetUser() => this.User != null;
    }
}
