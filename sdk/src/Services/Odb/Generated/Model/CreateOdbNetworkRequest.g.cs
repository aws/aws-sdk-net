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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// Container for the parameters to the CreateOdbNetwork operation. Creates an ODB network.
    /// </summary>
    public partial class CreateOdbNetworkRequest : AmazonOdbRequest
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Amazon Web Services Availability Zone (AZ) where the ODB network is located.
        /// </para>
        ///  
        /// <para>
        /// This operation requires that you specify a value for either <c>availabilityZone</c>
        /// or <c>availabilityZoneId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The AZ ID of the AZ where the ODB network is located.
        /// </para>
        ///  
        /// <para>
        /// This operation requires that you specify a value for either <c>availabilityZone</c>
        /// or <c>availabilityZoneId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property BackupSubnetCidr. 
        /// <para>
        /// The CIDR range of the backup subnet for the ODB network.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must not overlap with the CIDR range of the client subnet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must not overlap with the CIDR ranges of the VPCs that are connected to the ODB network.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must not use the following CIDR ranges that are reserved by OCI:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>100.106.0.0/16</c> and <c>100.107.0.0/16</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>169.254.0.0/16</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>224.0.0.0 - 239.255.255.255</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>240.0.0.0 - 255.255.255.255</c> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 43)]
        public string BackupSubnetCidr { get; set; }

        /// <summary>
        /// Checks to see if the BackupSubnetCidr property is set.
        /// </summary>
        internal bool IsSetBackupSubnetCidr() => this.BackupSubnetCidr != null;

        /// <summary>
        /// Gets and sets the property ClientSubnetCidr. 
        /// <para>
        /// The CIDR range of the client subnet for the ODB network.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must not overlap with the CIDR range of the backup subnet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must not overlap with the CIDR ranges of the VPCs that are connected to the ODB network.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must not use the following CIDR ranges that are reserved by OCI:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>100.106.0.0/16</c> and <c>100.107.0.0/16</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>169.254.0.0/16</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>224.0.0.0 - 239.255.255.255</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>240.0.0.0 - 255.255.255.255</c> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 43)]
        public string ClientSubnetCidr { get; set; }

        /// <summary>
        /// Checks to see if the ClientSubnetCidr property is set.
        /// </summary>
        internal bool IsSetClientSubnetCidr() => this.ClientSubnetCidr != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you don't specify a client token, the Amazon Web Services SDK automatically
        /// generates a client token and uses it for the request to ensure idempotency. The client
        /// token is valid for up to 24 hours after it's first used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 8, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CrossRegionS3RestoreSourcesToEnable. 
        /// <para>
        /// The cross-Region Amazon S3 restore sources to enable for the ODB network.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public List<string> CrossRegionS3RestoreSourcesToEnable { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CrossRegionS3RestoreSourcesToEnable property is set.
        /// </summary>
        internal bool IsSetCrossRegionS3RestoreSourcesToEnable() => this.CrossRegionS3RestoreSourcesToEnable != null && (this.CrossRegionS3RestoreSourcesToEnable.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CustomDomainName. 
        /// <para>
        /// The domain name to use for the resources in the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CustomDomainName { get; set; }

        /// <summary>
        /// Checks to see if the CustomDomainName property is set.
        /// </summary>
        internal bool IsSetCustomDomainName() => this.CustomDomainName != null;

        /// <summary>
        /// Gets and sets the property DefaultDnsPrefix. 
        /// <para>
        /// The DNS prefix to the default DNS domain name. The default DNS domain name is oraclevcn.com.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 15)]
        public string DefaultDnsPrefix { get; set; }

        /// <summary>
        /// Checks to see if the DefaultDnsPrefix property is set.
        /// </summary>
        internal bool IsSetDefaultDnsPrefix() => this.DefaultDnsPrefix != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A user-friendly name for the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property KmsAccess. 
        /// <para>
        /// The Amazon Web Services Key Management Service (KMS) access configuration for the
        /// ODB network.
        /// </para>
        /// </summary>
        public Access KmsAccess { get; set; }

        /// <summary>
        /// Checks to see if the KmsAccess property is set.
        /// </summary>
        internal bool IsSetKmsAccess() => this.KmsAccess != null;

        /// <summary>
        /// Gets and sets the property KmsPolicyDocument. 
        /// <para>
        /// The Amazon Web Services Key Management Service (KMS) policy document that defines
        /// permissions for key usage within the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 20480)]
        public string KmsPolicyDocument { get; set; }

        /// <summary>
        /// Checks to see if the KmsPolicyDocument property is set.
        /// </summary>
        internal bool IsSetKmsPolicyDocument() => this.KmsPolicyDocument != null;

        /// <summary>
        /// Gets and sets the property S3Access. 
        /// <para>
        /// Specifies the configuration for Amazon S3 access from the ODB network.
        /// </para>
        /// </summary>
        public Access S3Access { get; set; }

        /// <summary>
        /// Checks to see if the S3Access property is set.
        /// </summary>
        internal bool IsSetS3Access() => this.S3Access != null;

        /// <summary>
        /// Gets and sets the property S3PolicyDocument. 
        /// <para>
        /// Specifies the endpoint policy for Amazon S3 access from the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 20480)]
        public string S3PolicyDocument { get; set; }

        /// <summary>
        /// Checks to see if the S3PolicyDocument property is set.
        /// </summary>
        internal bool IsSetS3PolicyDocument() => this.S3PolicyDocument != null;

        /// <summary>
        /// Gets and sets the property StsAccess. 
        /// <para>
        /// The Amazon Web Services Security Token Service (STS) access configuration for the
        /// ODB network.
        /// </para>
        /// </summary>
        public Access StsAccess { get; set; }

        /// <summary>
        /// Checks to see if the StsAccess property is set.
        /// </summary>
        internal bool IsSetStsAccess() => this.StsAccess != null;

        /// <summary>
        /// Gets and sets the property StsPolicyDocument. 
        /// <para>
        /// The Amazon Web Services Security Token Service (STS) policy document that defines
        /// permissions for token service usage within the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 20480)]
        public string StsPolicyDocument { get; set; }

        /// <summary>
        /// Checks to see if the StsPolicyDocument property is set.
        /// </summary>
        internal bool IsSetStsPolicyDocument() => this.StsPolicyDocument != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of resource tags to apply to the ODB network.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ZeroEtlAccess. 
        /// <para>
        /// Specifies the configuration for Zero-ETL access from the ODB network.
        /// </para>
        /// </summary>
        public Access ZeroEtlAccess { get; set; }

        /// <summary>
        /// Checks to see if the ZeroEtlAccess property is set.
        /// </summary>
        internal bool IsSetZeroEtlAccess() => this.ZeroEtlAccess != null;
    }
}
