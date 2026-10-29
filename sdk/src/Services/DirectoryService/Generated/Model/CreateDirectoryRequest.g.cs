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

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDirectory operation. Creates a Simple AD
    /// directory. For more information, see <a href="https://docs.aws.amazon.com/directoryservice/latest/admin-guide/directory_simple_ad.html">Simple
    /// Active Directory</a> in the <i>Directory Service Admin Guide</i>. <para> Before you
    /// call <c>CreateDirectory</c>, ensure that all of the required permissions have been
    /// explicitly granted through a policy. For details about what permissions are required
    /// to run the <c>CreateDirectory</c> operation, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/UsingWithDS_IAM_ResourcePermissions.html">Directory
    /// Service API Permissions: Actions, Resources, and Conditions Reference</a>. </para>
    /// </summary>
    public partial class CreateDirectoryRequest : AmazonDirectoryServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the directory.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The fully qualified name for the directory, such as <c>corp.example.com</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The network type for your directory. Simple AD supports IPv4 and Dual-stack only.
        /// </para>
        /// </summary>
        public NetworkType NetworkType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkType property is set.
        /// </summary>
        internal bool IsSetNetworkType() => this.NetworkType != null;

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The password for the directory administrator. The directory creation process creates
        /// a directory administrator account with the user name <c>Administrator</c> and this
        /// password.
        /// </para>
        ///  
        /// <para>
        /// If you need to change the password for the administrator account, you can use the
        /// <a>ResetUserPassword</a> API call.
        /// </para>
        ///  
        /// <para>
        /// The regex pattern for this string is made up of the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Length (?=^.{8,64}$) – Must be between 8 and 64 characters
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// AND any 3 of the following password complexity rules required by Active Directory:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Numbers and upper case and lowercase (?=.*\d)(?=.*[A-Z])(?=.*[a-z])
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Numbers and special characters and lower case (?=.*\d)(?=.*[^A-Za-z0-9\s])(?=.*[a-z])
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Special characters and upper case and lower case (?=.*[^A-Za-z0-9\s])(?=.*[A-Z])(?=.*[a-z])
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Numbers and upper case and special characters (?=.*\d)(?=.*[A-Z])(?=.*[^A-Za-z0-9\s])
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For additional information about how Active Directory passwords are enforced, see
        /// <a href="https://docs.microsoft.com/en-us/windows/security/threat-protection/security-policy-settings/password-must-meet-complexity-requirements">Password
        /// must meet complexity requirements</a> on the Microsoft website.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string Password { get; set; }

        /// <summary>
        /// Checks to see if the Password property is set.
        /// </summary>
        internal bool IsSetPassword() => this.Password != null;

        /// <summary>
        /// Gets and sets the property ShortName. 
        /// <para>
        /// The NetBIOS name of the directory, such as <c>CORP</c>.
        /// </para>
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// Checks to see if the ShortName property is set.
        /// </summary>
        internal bool IsSetShortName() => this.ShortName != null;

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size of the directory.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DirectorySize Size { get; set; }

        /// <summary>
        /// Checks to see if the Size property is set.
        /// </summary>
        internal bool IsSetSize() => this.Size != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be assigned to the Simple AD directory.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcSettings. 
        /// <para>
        /// A <a>DirectoryVpcSettings</a> object that contains additional information for the
        /// operation.
        /// </para>
        /// </summary>
        public DirectoryVpcSettings VpcSettings { get; set; }

        /// <summary>
        /// Checks to see if the VpcSettings property is set.
        /// </summary>
        internal bool IsSetVpcSettings() => this.VpcSettings != null;
    }
}
