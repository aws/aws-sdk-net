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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// A description of a specific Amazon File Cache resource, which is a response object
    /// from the <c>DescribeFileCaches</c> operation.
    /// </summary>
    public partial class FileCache
    {
        /// <summary>
        /// Gets and sets the property CreationTime.
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DNSName. 
        /// <para>
        /// The Domain Name System (DNS) name for the cache.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 16, Max = 275)]
        public string DNSName { get; set; }

        /// <summary>
        /// Checks to see if the DNSName property is set.
        /// </summary>
        internal bool IsSetDNSName() => this.DNSName != null;

        /// <summary>
        /// Gets and sets the property DataRepositoryAssociationIds. 
        /// <para>
        /// A list of IDs of data repository associations that are associated with this cache.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> DataRepositoryAssociationIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DataRepositoryAssociationIds property is set.
        /// </summary>
        internal bool IsSetDataRepositoryAssociationIds() => this.DataRepositoryAssociationIds != null && (this.DataRepositoryAssociationIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FailureDetails. 
        /// <para>
        /// A structure providing details of any failures that occurred.
        /// </para>
        /// </summary>
        public FileCacheFailureDetails FailureDetails { get; set; }

        /// <summary>
        /// Checks to see if the FailureDetails property is set.
        /// </summary>
        internal bool IsSetFailureDetails() => this.FailureDetails != null;

        /// <summary>
        /// Gets and sets the property FileCacheId. 
        /// <para>
        /// The system-generated, unique ID of the cache.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 21)]
        public string FileCacheId { get; set; }

        /// <summary>
        /// Checks to see if the FileCacheId property is set.
        /// </summary>
        internal bool IsSetFileCacheId() => this.FileCacheId != null;

        /// <summary>
        /// Gets and sets the property FileCacheType. 
        /// <para>
        /// The type of cache, which must be <c>LUSTRE</c>.
        /// </para>
        /// </summary>
        public FileCacheType FileCacheType { get; set; }

        /// <summary>
        /// Checks to see if the FileCacheType property is set.
        /// </summary>
        internal bool IsSetFileCacheType() => this.FileCacheType != null;

        /// <summary>
        /// Gets and sets the property FileCacheTypeVersion. 
        /// <para>
        /// The Lustre version of the cache, which must be <c>2.12</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string FileCacheTypeVersion { get; set; }

        /// <summary>
        /// Checks to see if the FileCacheTypeVersion property is set.
        /// </summary>
        internal bool IsSetFileCacheTypeVersion() => this.FileCacheTypeVersion != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// Specifies the ID of the Key Management Service (KMS) key to use for encrypting data
        /// on an Amazon File Cache. If a <c>KmsKeyId</c> isn't specified, the Amazon FSx-managed
        /// KMS key for your account is used. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_Encrypt.html">Encrypt</a>
        /// in the <i>Key Management Service API Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The lifecycle status of the cache. The following are the possible values and what
        /// they mean:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AVAILABLE</c> - The cache is in a healthy state, and is reachable and available
        /// for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATING</c> - The new cache is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> - An existing cache is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> - The cache is undergoing a customer-initiated update.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - An existing cache has experienced an unrecoverable failure. When
        /// creating a new cache, the cache was unable to be created.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FileCacheLifecycle Lifecycle { get; set; }

        /// <summary>
        /// Checks to see if the Lifecycle property is set.
        /// </summary>
        internal bool IsSetLifecycle() => this.Lifecycle != null;

        /// <summary>
        /// Gets and sets the property LustreConfiguration. 
        /// <para>
        /// The configuration for the Amazon File Cache resource.
        /// </para>
        /// </summary>
        public FileCacheLustreConfiguration LustreConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LustreConfiguration property is set.
        /// </summary>
        internal bool IsSetLustreConfiguration() => this.LustreConfiguration != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceIds.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> NetworkInterfaceIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NetworkInterfaceIds property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceIds() => this.NetworkInterfaceIds != null && (this.NetworkInterfaceIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OwnerId.
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property ResourceARN.
        /// </summary>
        [AWSProperty(Min = 8, Max = 512)]
        public string ResourceARN { get; set; }

        /// <summary>
        /// Checks to see if the ResourceARN property is set.
        /// </summary>
        internal bool IsSetResourceARN() => this.ResourceARN != null;

        /// <summary>
        /// Gets and sets the property StorageCapacity. 
        /// <para>
        /// The storage capacity of the cache in gibibytes (GiB).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? StorageCapacity { get; set; }

        /// <summary>
        /// Checks to see if the StorageCapacity property is set.
        /// </summary>
        internal bool IsSetStorageCapacity() => this.StorageCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property SubnetIds.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> SubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubnetIds property is set.
        /// </summary>
        internal bool IsSetSubnetIds() => this.SubnetIds != null && (this.SubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcId.
        /// </summary>
        [AWSProperty(Min = 12, Max = 21)]
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
