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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateFileSystem operation. Associate an Amazon
    /// FSx file system with the FSx File Gateway. After the association process is complete,
    /// the file shares on the Amazon FSx file system are available for access through the
    /// gateway. This operation only supports the FSx File Gateway type.
    /// </summary>
    public partial class AssociateFileSystemRequest : AmazonStorageGatewayRequest
    {
        /// <summary>
        /// Gets and sets the property AuditDestinationARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the storage used for the audit logs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string AuditDestinationARN { get; set; }

        /// <summary>
        /// Checks to see if the AuditDestinationARN property is set.
        /// </summary>
        internal bool IsSetAuditDestinationARN() => this.AuditDestinationARN != null;

        /// <summary>
        /// Gets and sets the property CacheAttributes.
        /// </summary>
        public CacheAttributes CacheAttributes { get; set; }

        /// <summary>
        /// Checks to see if the CacheAttributes property is set.
        /// </summary>
        internal bool IsSetCacheAttributes() => this.CacheAttributes != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique string value that you supply that is used by the FSx File Gateway to ensure
        /// idempotent file system association creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 100)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property EndpointNetworkConfiguration. 
        /// <para>
        /// Specifies the network configuration information for the gateway associated with the
        /// Amazon FSx file system.
        /// </para>
        ///  <note> 
        /// <para>
        /// If multiple file systems are associated with this gateway, this parameter's <c>IpAddresses</c>
        /// field is required.
        /// </para>
        ///  </note>
        /// </summary>
        public EndpointNetworkConfiguration EndpointNetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EndpointNetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetEndpointNetworkConfiguration() => this.EndpointNetworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        [AWSProperty(Required = true, Min = 50, Max = 500)]
        public string GatewayARN { get; set; }

        /// <summary>
        /// Checks to see if the GatewayARN property is set.
        /// </summary>
        internal bool IsSetGatewayARN() => this.GatewayARN != null;

        /// <summary>
        /// Gets and sets the property LocationARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon FSx file system to associate with the
        /// FSx File Gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 8, Max = 512)]
        public string LocationARN { get; set; }

        /// <summary>
        /// Checks to see if the LocationARN property is set.
        /// </summary>
        internal bool IsSetLocationARN() => this.LocationARN != null;

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The password of the user credential.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 1024)]
        public string Password { get; set; }

        /// <summary>
        /// Checks to see if the Password property is set.
        /// </summary>
        internal bool IsSetPassword() => this.Password != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of up to 50 tags that can be assigned to the file system association. Each
        /// tag is a key-value pair.
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
        /// Gets and sets the property UserName. 
        /// <para>
        /// The user name of the user credential that has permission to access the root share
        /// D$ of the Amazon FSx file system. The user account must belong to the Amazon FSx delegated
        /// admin user group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string UserName { get; set; }

        /// <summary>
        /// Checks to see if the UserName property is set.
        /// </summary>
        internal bool IsSetUserName() => this.UserName != null;
    }
}
