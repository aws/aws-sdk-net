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
    /// The managed services configuration for the ODB network.
    /// </summary>
    public partial class ManagedServices
    {
        /// <summary>
        /// Gets and sets the property CrossRegionS3RestoreSourcesAccess. 
        /// <para>
        /// The access configuration for the cross-Region Amazon S3 database restore source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CrossRegionS3RestoreSourcesAccess> CrossRegionS3RestoreSourcesAccess { get; set; } = AWSConfigs.InitializeCollections ? new List<CrossRegionS3RestoreSourcesAccess>() : null;

        /// <summary>
        /// Checks to see if the CrossRegionS3RestoreSourcesAccess property is set.
        /// </summary>
        internal bool IsSetCrossRegionS3RestoreSourcesAccess() => this.CrossRegionS3RestoreSourcesAccess != null && (this.CrossRegionS3RestoreSourcesAccess.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KmsAccess. 
        /// <para>
        /// The Amazon Web Services Key Management Service (KMS) access configuration.
        /// </para>
        /// </summary>
        public KmsAccess KmsAccess { get; set; }

        /// <summary>
        /// Checks to see if the KmsAccess property is set.
        /// </summary>
        internal bool IsSetKmsAccess() => this.KmsAccess != null;

        /// <summary>
        /// Gets and sets the property ManagedS3BackupAccess. 
        /// <para>
        /// The managed Amazon S3 backup access configuration.
        /// </para>
        /// </summary>
        public ManagedS3BackupAccess ManagedS3BackupAccess { get; set; }

        /// <summary>
        /// Checks to see if the ManagedS3BackupAccess property is set.
        /// </summary>
        internal bool IsSetManagedS3BackupAccess() => this.ManagedS3BackupAccess != null;

        /// <summary>
        /// Gets and sets the property ManagedServicesIpv4Cidrs. 
        /// <para>
        /// The IPv4 CIDR blocks for the managed services.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public List<string> ManagedServicesIpv4Cidrs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ManagedServicesIpv4Cidrs property is set.
        /// </summary>
        internal bool IsSetManagedServicesIpv4Cidrs() => this.ManagedServicesIpv4Cidrs != null && (this.ManagedServicesIpv4Cidrs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceGatewayArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ResourceGatewayArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceGatewayArn property is set.
        /// </summary>
        internal bool IsSetResourceGatewayArn() => this.ResourceGatewayArn != null;

        /// <summary>
        /// Gets and sets the property S3Access. 
        /// <para>
        /// The Amazon S3 access configuration.
        /// </para>
        /// </summary>
        public S3Access S3Access { get; set; }

        /// <summary>
        /// Checks to see if the S3Access property is set.
        /// </summary>
        internal bool IsSetS3Access() => this.S3Access != null;

        /// <summary>
        /// Gets and sets the property ServiceNetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ServiceNetworkArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNetworkArn property is set.
        /// </summary>
        internal bool IsSetServiceNetworkArn() => this.ServiceNetworkArn != null;

        /// <summary>
        /// Gets and sets the property ServiceNetworkEndpoint. 
        /// <para>
        /// The service network endpoint configuration.
        /// </para>
        /// </summary>
        public ServiceNetworkEndpoint ServiceNetworkEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNetworkEndpoint property is set.
        /// </summary>
        internal bool IsSetServiceNetworkEndpoint() => this.ServiceNetworkEndpoint != null;

        /// <summary>
        /// Gets and sets the property StsAccess. 
        /// <para>
        /// The Amazon Web Services Security Token Service (STS) access configuration.
        /// </para>
        /// </summary>
        public StsAccess StsAccess { get; set; }

        /// <summary>
        /// Checks to see if the StsAccess property is set.
        /// </summary>
        internal bool IsSetStsAccess() => this.StsAccess != null;

        /// <summary>
        /// Gets and sets the property ZeroEtlAccess. 
        /// <para>
        /// The Zero-ETL access configuration.
        /// </para>
        /// </summary>
        public ZeroEtlAccess ZeroEtlAccess { get; set; }

        /// <summary>
        /// Checks to see if the ZeroEtlAccess property is set.
        /// </summary>
        internal bool IsSetZeroEtlAccess() => this.ZeroEtlAccess != null;
    }
}
