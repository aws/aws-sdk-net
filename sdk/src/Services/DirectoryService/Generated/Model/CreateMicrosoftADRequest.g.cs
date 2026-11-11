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
    /// Container for the parameters to the CreateMicrosoftAD operation. Creates a Microsoft
    /// AD directory in the Amazon Web Services Cloud. For more information, see <a href="https://docs.aws.amazon.com/directoryservice/latest/admin-guide/directory_microsoft_ad.html">Managed
    /// Microsoft AD</a> in the <i>Directory Service Admin Guide</i>. <para> Before you call
    /// <i>CreateMicrosoftAD</i>, ensure that all of the required permissions have been explicitly
    /// granted through a policy. For details about what permissions are required to run the
    /// <i>CreateMicrosoftAD</i> operation, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/UsingWithDS_IAM_ResourcePermissions.html">Directory
    /// Service API Permissions: Actions, Resources, and Conditions Reference</a>. </para>
    /// </summary>
    public partial class CreateMicrosoftADRequest : AmazonDirectoryServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the directory. This label will appear on the Amazon Web Services
        /// console <c>Directory Details</c> page after the directory is created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Edition. 
        /// <para>
        /// Managed Microsoft AD is available in two editions: <c>Standard</c> and <c>Enterprise</c>.
        /// <c>Enterprise</c> is the default.
        /// </para>
        /// </summary>
        public DirectoryEdition Edition { get; set; }

        /// <summary>
        /// Checks to see if the Edition property is set.
        /// </summary>
        internal bool IsSetEdition() => this.Edition != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The fully qualified domain name for the Managed Microsoft AD directory, such as <c>corp.example.com</c>.
        /// This name will resolve inside your VPC only. It does not need to be publicly resolvable.
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
        ///  The network type for your domain. The default value is <c>IPv4</c> or <c>IPv6</c>
        /// based on the provided subnet capabilities.
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
        /// The password for the default administrative user named <c>Admin</c>.
        /// </para>
        ///  
        /// <para>
        /// If you need to change the password for the administrator account, you can use the
        /// <a>ResetUserPassword</a> API call.
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
        /// The NetBIOS name for your domain, such as <c>CORP</c>. If you don't specify a NetBIOS
        /// name, it will default to the first part of your directory DNS. For example, <c>CORP</c>
        /// for the directory DNS <c>corp.example.com</c>. 
        /// </para>
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// Checks to see if the ShortName property is set.
        /// </summary>
        internal bool IsSetShortName() => this.ShortName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be assigned to the Managed Microsoft AD directory.
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
        /// Contains VPC information for the <a>CreateDirectory</a> or <a>CreateMicrosoftAD</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DirectoryVpcSettings VpcSettings { get; set; }

        /// <summary>
        /// Checks to see if the VpcSettings property is set.
        /// </summary>
        internal bool IsSetVpcSettings() => this.VpcSettings != null;
    }
}
