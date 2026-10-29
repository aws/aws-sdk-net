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
    /// Container for the parameters to the ConnectDirectory operation. Creates an AD Connector
    /// to connect to a self-managed directory. <para> Before you call <c>ConnectDirectory</c>,
    /// ensure that all of the required permissions have been explicitly granted through a
    /// policy. For details about what permissions are required to run the <c>ConnectDirectory</c>
    /// operation, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/UsingWithDS_IAM_ResourcePermissions.html">Directory
    /// Service API Permissions: Actions, Resources, and Conditions Reference</a>. </para>
    /// </summary>
    public partial class ConnectDirectoryRequest : AmazonDirectoryServiceRequest
    {
        /// <summary>
        /// Gets and sets the property ConnectSettings. 
        /// <para>
        /// A <a>DirectoryConnectSettings</a> object that contains additional information for
        /// the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DirectoryConnectSettings ConnectSettings { get; set; }

        /// <summary>
        /// Checks to see if the ConnectSettings property is set.
        /// </summary>
        internal bool IsSetConnectSettings() => this.ConnectSettings != null;

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
        /// The fully qualified name of your self-managed directory, such as <c>corp.example.com</c>.
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
        /// The network type for your directory. The default value is <c>IPv4</c> or <c>IPv6</c>
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
        /// The password for your self-managed user account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 128)]
        public string Password { get; set; }

        /// <summary>
        /// Checks to see if the Password property is set.
        /// </summary>
        internal bool IsSetPassword() => this.Password != null;

        /// <summary>
        /// Gets and sets the property ShortName. 
        /// <para>
        /// The NetBIOS name of your self-managed directory, such as <c>CORP</c>.
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
        /// The tags to be assigned to AD Connector.
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
    }
}
