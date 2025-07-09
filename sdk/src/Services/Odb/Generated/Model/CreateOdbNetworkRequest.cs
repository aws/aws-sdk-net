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
        private string _customDomainName;
        private string _defaultDnsPrefix;
        private string _displayName;
        private Access _s3Access;
        private string _s3PolicyDocument;
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of resource tags to apply to the ODB network.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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