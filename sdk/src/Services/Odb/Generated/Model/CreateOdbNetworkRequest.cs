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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
    /// Container for the parameters to the CreateOdbNetwork operation.
    /// Creates an ODB network.
    /// </summary>
    public partial class CreateOdbNetworkRequest : AmazonOdbRequest
    {
        private string _availabilityZone;
        private string _availabilityZoneId;
        private string _backupSubnetCidr;
        private string _clientSubnetCidr;
        private string _clientToken;
        private List<string> _crossRegionS3RestoreSourcesToEnable = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _customDomainName;
        private string _defaultDnsPrefix;
        private string _displayName;
        private Access _kmsAccess;
        private string _kmsPolicyDocument;
        private Access _s3Access;
        private string _s3PolicyDocument;
        private Access _stsAccess;
        private string _stsPolicyDocument;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Access _zeroEtlAccess;

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
        [AWSProperty(Min=1, Max=255)]
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

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
        [AWSProperty(Min=1, Max=255)]
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

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
        [AWSProperty(Min=1, Max=43)]
        public string BackupSubnetCidr
        {
            get { return this._backupSubnetCidr; }
            set { this._backupSubnetCidr = value; }
        }

        // Check to see if BackupSubnetCidr property is set
        internal bool IsSetBackupSubnetCidr()
        {
            return this._backupSubnetCidr != null;
        }

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
        [AWSProperty(Required=true, Min=1, Max=43)]
        public string ClientSubnetCidr
        {
            get { return this._clientSubnetCidr; }
            set { this._clientSubnetCidr = value; }
        }

        // Check to see if ClientSubnetCidr property is set
        internal bool IsSetClientSubnetCidr()
        {
            return this._clientSubnetCidr != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you don't specify a client token, the Amazon Web Services SDK automatically
        /// generates a client token and uses it for the request to ensure idempotency. The client
        /// token is valid for up to 24 hours after it's first used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property CrossRegionS3RestoreSourcesToEnable. 
        /// <para>
        /// The cross-Region Amazon S3 restore sources to enable for the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public List<string> CrossRegionS3RestoreSourcesToEnable
        {
            get { return this._crossRegionS3RestoreSourcesToEnable; }
            set { this._crossRegionS3RestoreSourcesToEnable = value; }
        }

        // Check to see if CrossRegionS3RestoreSourcesToEnable property is set
        internal bool IsSetCrossRegionS3RestoreSourcesToEnable()
        {
            return this._crossRegionS3RestoreSourcesToEnable != null && (this._crossRegionS3RestoreSourcesToEnable.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CustomDomainName. 
        /// <para>
        /// The domain name to use for the resources in the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CustomDomainName
        {
            get { return this._customDomainName; }
            set { this._customDomainName = value; }
        }

        // Check to see if CustomDomainName property is set
        internal bool IsSetCustomDomainName()
        {
            return this._customDomainName != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultDnsPrefix. 
        /// <para>
        /// The DNS prefix to the default DNS domain name. The default DNS domain name is oraclevcn.com.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=15)]
        public string DefaultDnsPrefix
        {
            get { return this._defaultDnsPrefix; }
            set { this._defaultDnsPrefix = value; }
        }

        // Check to see if DefaultDnsPrefix property is set
        internal bool IsSetDefaultDnsPrefix()
        {
            return this._defaultDnsPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A user-friendly name for the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property KmsAccess. 
        /// <para>
        /// The Amazon Web Services Key Management Service (KMS) access configuration for the
        /// ODB network.
        /// </para>
        /// </summary>
        public Access KmsAccess
        {
            get { return this._kmsAccess; }
            set { this._kmsAccess = value; }
        }

        // Check to see if KmsAccess property is set
        internal bool IsSetKmsAccess()
        {
            return this._kmsAccess != null;
        }

        /// <summary>
        /// Gets and sets the property KmsPolicyDocument. 
        /// <para>
        /// The KMS policy document that defines permissions for key usage within the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=20480)]
        public string KmsPolicyDocument
        {
            get { return this._kmsPolicyDocument; }
            set { this._kmsPolicyDocument = value; }
        }

        // Check to see if KmsPolicyDocument property is set
        internal bool IsSetKmsPolicyDocument()
        {
            return this._kmsPolicyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property S3Access. 
        /// <para>
        /// Specifies the configuration for Amazon S3 access from the ODB network.
        /// </para>
        /// </summary>
        public Access S3Access
        {
            get { return this._s3Access; }
            set { this._s3Access = value; }
        }

        // Check to see if S3Access property is set
        internal bool IsSetS3Access()
        {
            return this._s3Access != null;
        }

        /// <summary>
        /// Gets and sets the property S3PolicyDocument. 
        /// <para>
        /// Specifies the endpoint policy for Amazon S3 access from the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=20480)]
        public string S3PolicyDocument
        {
            get { return this._s3PolicyDocument; }
            set { this._s3PolicyDocument = value; }
        }

        // Check to see if S3PolicyDocument property is set
        internal bool IsSetS3PolicyDocument()
        {
            return this._s3PolicyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property StsAccess. 
        /// <para>
        /// The Amazon Web Services Security Token Service (STS) access configuration for the
        /// ODB network.
        /// </para>
        /// </summary>
        public Access StsAccess
        {
            get { return this._stsAccess; }
            set { this._stsAccess = value; }
        }

        // Check to see if StsAccess property is set
        internal bool IsSetStsAccess()
        {
            return this._stsAccess != null;
        }

        /// <summary>
        /// Gets and sets the property StsPolicyDocument. 
        /// <para>
        /// The STS policy document that defines permissions for token service usage within the
        /// ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=20480)]
        public string StsPolicyDocument
        {
            get { return this._stsPolicyDocument; }
            set { this._stsPolicyDocument = value; }
        }

        // Check to see if StsPolicyDocument property is set
        internal bool IsSetStsPolicyDocument()
        {
            return this._stsPolicyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of resource tags to apply to the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, string> Tags
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
        /// Gets and sets the property ZeroEtlAccess. 
        /// <para>
        /// Specifies the configuration for Zero-ETL access from the ODB network.
        /// </para>
        /// </summary>
        public Access ZeroEtlAccess
        {
            get { return this._zeroEtlAccess; }
            set { this._zeroEtlAccess = value; }
        }

        // Check to see if ZeroEtlAccess property is set
        internal bool IsSetZeroEtlAccess()
        {
            return this._zeroEtlAccess != null;
        }

    }
}